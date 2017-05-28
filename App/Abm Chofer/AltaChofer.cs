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

namespace UberFrba.Abm_Chofer
{
    public partial class AltaChofer : Form
    {
        public AltaChofer()
        {
            InitializeComponent();
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
            dateTimePickerFechaNac.Enabled = true;

            btnNuevo.Enabled = true;
        }

        public bool validarCampo(string text, bool esNumerico, bool esObligatorio)
        {
            return (!esObligatorio && text == "")
                 || (esObligatorio && text != "" && (esNumerico && text.All(char.IsDigit) || !esNumerico));
        }

        private bool validacion()
        {
            bool valido = true;
            if (!(validarCampo(txtBoxNombre.Text, false, true) && validarCampo(txtBoxApellido.Text, false, true)
                 && validarCampo(txtBoxDNI.Text, true, true) && validarCampo(txtBoxDireccion.Text, false, true)
                 && validarCampo(txtBoxMail.Text, false, true) && validarCampo(txtBoxTelefono.Text, true, true)
                 && validarCampo(txtBoxUsername.Text, false, true)))
            {
                valido = false;
            }
            if (radioNuevoUser.Checked && !validarCampo(txtBoxPassword.Text, false, true))
            {
                valido = false;
            }
            if (!valido)
                MessageBox.Show("Complete todos los campos correctamente");
            return valido;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (validacion())
            {
                if (altaChofer())
                    limpiar();
            }
        }

        private void limpiar()
        {
            txtBoxUsername.Clear();
            txtBoxPassword.Clear();
            txtBoxNombre.Clear();
            txtBoxApellido.Clear();
            txtBoxDNI.Clear();
            txtBoxDireccion.Clear();
            txtBoxTelefono.Clear();
            txtBoxMail.Clear();
            dateTimePickerFechaNac.Value = DateTime.Today;
        }

        private bool altaChofer()
        {
            BDHandler handler = new BDHandler();
            List<BDParametro> listParametros = new List<BDParametro>();
            listParametros.Add(new BDParametro("@username", txtBoxUsername.Text));
            listParametros.Add(new BDParametro("@nombre", txtBoxNombre.Text));
            listParametros.Add(new BDParametro("@apellido", txtBoxApellido.Text));
            listParametros.Add(new BDParametro("@DNI", int.Parse(txtBoxDNI.Text)));
            listParametros.Add(new BDParametro("@direccion", txtBoxDireccion.Text));
            listParametros.Add(new BDParametro("@telefono", int.Parse(txtBoxTelefono.Text)));
            listParametros.Add(new BDParametro("@mail", txtBoxMail.Text));
            listParametros.Add(new BDParametro("@fecha_nac", dateTimePickerFechaNac.Value));
            listParametros.Add(new BDParametro("@mensaje", "", SqlDbType.VarChar, 50, ParameterDirection.Output));
            if (radioNuevoUser.Checked)
            {
                listParametros.Insert(1, new BDParametro("@password", txtBoxPassword.Text.Sha256()));
                handler.execSP("LJDG.alta_chofer_usuario_nuevo", ref listParametros);
            }
            else if (radioUserExistente.Checked)
                handler.execSP("LJDG.alta_chofer_usuario_existente", ref listParametros);
            else return false;

            string mensaje = listParametros[listParametros.Count - 1].valor.ToString();
            MessageBox.Show(mensaje);
            if (mensaje == "Alta Exitosa")
                return true;
            else return false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void AltaChofer_Load(object sender, EventArgs e)
        {
            dateTimePickerFechaNac.Value = DateTime.Today;
        }

    }
}
