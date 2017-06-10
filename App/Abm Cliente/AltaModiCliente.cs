using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helper;

namespace UberFrba.Abm_Cliente
{
    public partial class AltaModiCliente : Form
    {
        private char modo;
        public int idCliente { get; set; }

        public AltaModiCliente(char _modo, int _idCliente = 0)
        {
            InitializeComponent();
            this.modo = _modo;
            if (modo == 'A')
            {
                this.Text = "Alta Cliente";
                radioNuevoUser.Enabled = true;
                radioUserExistente.Enabled = true;
                dateTimePickerFechaNac.Value = DateTime.Today;
            }

            else if (modo == 'M')
            {
                this.Text = "Modificar Cliente";
                this.idCliente = _idCliente;
                cargarCliente();
            }
        }

        private void radioNuevoUser_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNuevoUser.Checked)
            {
                txtBoxUsername.Enabled = true;
                txtBoxPassword.Enabled = true;

                radioUserExistente.Checked = false;

                habilitarNuevo();
            }
        }

        private void radioUserExistente_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUserExistente.Checked)
            {
                txtBoxUsername.Enabled = true;
                txtBoxPassword.Enabled = false;
                txtBoxPassword.Clear();

                radioNuevoUser.Checked = false;
                habilitarNuevo();
            }

        }

        private void habilitarNuevo()
        {
            txtBoxNombre.Enabled = true;
            txtBoxApellido.Enabled = true;
            txtBoxDNI.Enabled = true;
            txtBoxTelefono.Enabled = true;
            txtBoxMail.Enabled = true;
            txtBoxDireccion.Enabled = true;
            txtBoxCP.Enabled = true;
            dateTimePickerFechaNac.Enabled = true;

            btnGuardar.Enabled = true;
        }

        public bool validarCampo(string text, bool esNumerico, bool esObligatorio)
        {
            return (!esObligatorio && text == "")
                 || (text != "" && (esNumerico && text.All(char.IsDigit) || !esNumerico));
        }

        private bool validarCliente()
        {
            bool valido = true;
            if (!(validarCampo(txtBoxNombre.Text, false, true) && validarCampo(txtBoxApellido.Text, false, true)
                 && validarCampo(txtBoxDNI.Text, true, true) && validarCampo(txtBoxDireccion.Text, false, true)
                 && validarCampo(txtBoxCP.Text,false,true)
                 && validarCampo(txtBoxMail.Text, false, false) && validarCampo(txtBoxTelefono.Text, true, true)
                 ))
                valido = false;

            if (!valido)
                MessageBox.Show("Complete los campos del cliente correctamente");
            return valido;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCliente())
            {
                if (modo == 'A')
                {
                    if (validarUser())
                    {
                        if (guardarCliente())
                            limpiar();
                    }
                }
                else if (modo == 'M')
                {
                    if (guardarCliente())
                        this.Hide();
                }
            }
        }

        private bool validarUser()
        {
            bool valido = true;
            if (!validarCampo(txtBoxUsername.Text, false, true))
                valido = false;
            if (radioNuevoUser.Checked && !validarCampo(txtBoxPassword.Text, false, true))
                valido = false;
            if (!valido)
                MessageBox.Show("Complete los campos del usuario correctamente");
            return valido;
        }

        private void limpiar()
        {
            txtBoxUsername.Clear();
            txtBoxPassword.Clear();
            txtBoxNombre.Clear();
            txtBoxApellido.Clear();
            txtBoxDNI.Clear();
            txtBoxDireccion.Clear();
            txtBoxCP.Clear();
            txtBoxTelefono.Clear();
            txtBoxMail.Clear();
            dateTimePickerFechaNac.Value = DateTime.Today;
        }

        private bool guardarCliente()
        {
            BDHandler handler = new BDHandler();
            List<BDParametro> listParametros = new List<BDParametro>();
            listParametros.Add(new BDParametro("@username", txtBoxUsername.Text));
            listParametros.Add(new BDParametro("@nombre", txtBoxNombre.Text));
            listParametros.Add(new BDParametro("@apellido", txtBoxApellido.Text));
            listParametros.Add(new BDParametro("@DNI", int.Parse(txtBoxDNI.Text)));
            listParametros.Add(new BDParametro("@direccion", txtBoxDireccion.Text));
            listParametros.Add(new BDParametro("@cp", txtBoxCP.Text));
            listParametros.Add(new BDParametro("@telefono", int.Parse(txtBoxTelefono.Text)));
            listParametros.Add(new BDParametro("@mail", txtBoxMail.Text));
            listParametros.Add(new BDParametro("@fecha_nac", dateTimePickerFechaNac.Value));
            listParametros.Add(new BDParametro("@mensaje", "", SqlDbType.VarChar, 200, ParameterDirection.Output));
            if (modo == 'A')
            {
                if (radioNuevoUser.Checked)
                {
                    listParametros.Insert(1, new BDParametro("@password", txtBoxPassword.Text.Sha256()));
                    handler.execSP("LJDG.alta_cliente_usuario_nuevo", ref listParametros);
                }
                else if (radioUserExistente.Checked)
                    handler.execSP("LJDG.alta_cliente_usuario_existente", ref listParametros);
                else return false;
            }
            else if (modo == 'M')
            {
                listParametros.RemoveAt(0);
                listParametros.Insert(0, new BDParametro("@id", idCliente));
                listParametros.Insert(9, new BDParametro("@habilitado", radioHabilitar.Checked ? 1 : 0));
                handler.execSP("LJDG.modi_cliente", ref listParametros);
            }
            string mensaje = listParametros[listParametros.Count - 1].valor.ToString();
            MessageBox.Show(mensaje);
            if (mensaje.Contains("Exitosamente"))
                return true;
            else return false;
        }

        private void cargarCliente()
        {
            List<BDParametro> listParametros = new List<BDParametro>();
            listParametros.Add(new BDParametro("@id", idCliente));
            listParametros.Add(new BDParametro("@nombre", "", SqlDbType.VarChar, 255, ParameterDirection.Output));
            listParametros.Add(new BDParametro("@apellido", "", SqlDbType.VarChar, 255, ParameterDirection.Output));
            listParametros.Add(new BDParametro("@DNI", 0, SqlDbType.Decimal, 18, ParameterDirection.Output));
            listParametros.Add(new BDParametro("@direccion", "", SqlDbType.VarChar, 255, ParameterDirection.Output));
            listParametros.Add(new BDParametro("@cp", "", SqlDbType.VarChar, 10, ParameterDirection.Output));
            listParametros.Add(new BDParametro("@telefono", 0, SqlDbType.Decimal, 18, ParameterDirection.Output));
            listParametros.Add(new BDParametro("@mail", "", SqlDbType.VarChar, 50, ParameterDirection.Output));
            listParametros.Add(new BDParametro("@fecha_nac", 0, SqlDbType.DateTime, 0, ParameterDirection.Output));
            listParametros.Add(new BDParametro("@habilitado", 0, SqlDbType.Bit, 0, ParameterDirection.Output));
            new BDHandler().execSP("LJDG.obtener_cliente", ref listParametros);
            txtBoxNombre.Text = listParametros[1].valor.ToString();
            txtBoxApellido.Text = listParametros[2].valor.ToString();
            txtBoxDNI.Text = listParametros[3].valor.ToString();
            txtBoxDireccion.Text = listParametros[4].valor.ToString();
            txtBoxCP.Text = listParametros[5].valor.ToString();
            txtBoxTelefono.Text = listParametros[6].valor.ToString();
            txtBoxMail.Text = listParametros[7].valor.ToString();
            dateTimePickerFechaNac.Value = Convert.ToDateTime(listParametros[8].valor);
            radioHabilitar.Checked = Convert.ToBoolean(listParametros[9].valor);
            if (!radioHabilitar.Checked)
            {
                radioHabilitar.Visible = true;
                labelHabilitar.Visible = true;
            }
            this.habilitarNuevo();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void txtBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

    }
}
