using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Modelo;

namespace UberFrba.Abm_Cliente
{
    public partial class BuscarIndividuo : CustomForm
    {
        Form prev_form;
        private String tipoIndividuo;
        private char modo;

        /* Recibe el Formulario anterior
         * Tipo de Individuo = "Chofer" / "Cliente"
         * Modo de uso = 'B' Baja / 'M' Modificación / 'S' Busqueda de Chofer */
        public BuscarIndividuo(Form prev_form, String _tipoIndividuo, char _modo) : base(prev_form)
        {
            InitializeComponent();
            this.prev_form = prev_form;
            this.tipoIndividuo = _tipoIndividuo;
            this.modo = _modo;
            this.Text += " " + _tipoIndividuo;
            buscar();
        }

        private void buscar() {
            List<BDParametro> listParametros = new List<BDParametro>();
            try
            {
                long dni;
                long.TryParse(txtDNI.Text, out dni);
                BDHandler handler = new BDHandler();
                listParametros.Add(new BDParametro("@nombre", txtNombre.Text.Trim()));
                listParametros.Add(new BDParametro("@apellido", txtApellido.Text.Trim()));
                listParametros.Add(new BDParametro("@dni", dni));
                if (tipoIndividuo == "Chofer")
                    if (modo == 'M')
                        dgIndividuo.DataSource = handler.execSelectSP("LJDG.buscar_chofer", listParametros);
                    else
                        dgIndividuo.DataSource = handler.execSelectSP("LJDG.buscar_chofer_habilitado", listParametros);
                else if (tipoIndividuo == "Cliente")
                    if (modo == 'M')
                        dgIndividuo.DataSource = handler.execSelectSP("LJDG.buscar_cliente", listParametros);
                    else
                        dgIndividuo.DataSource = handler.execSelectSP("LJDG.buscar_cliente_habilitado", listParametros);
                if (dgIndividuo.RowCount == 0)
                    btnSeleccionar.Enabled = false;
                else
                    btnSeleccionar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos.");
                throw ex;
            }
        }
        
        private void dataGridCliente_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String clienteId = dgIndividuo.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (modo == 'B')
            {
                MessageBox.Show("Se da de baja");
                Usuario.darDeBaja(clienteId);
            } else if (modo == 'M')
            {
                AltaModificarCliente amCliente = new AltaModificarCliente(this, clienteId);
                amCliente.Show();
                this.Hide();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        /* Solo deja ingresar digitos, backspace o delete */
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.prev_form.Show();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(dgIndividuo.Rows[dgIndividuo.CurrentCell.RowIndex].Cells["ID"].Value.ToString(), out id);            
            if (tipoIndividuo == "Chofer")
            {
                switch (modo)
                {
                    /* Buscar Chofer desde AltaAuto */
                    case 'S':
                        ((Abm_Automovil.AltaAuto)prev_form).lblIDChoferValor.Text = id.ToString();
                        ((Abm_Automovil.AltaAuto)prev_form).lblNombreChoferValor.Text = dgIndividuo.Rows[dgIndividuo.CurrentCell.RowIndex].Cells["Nombre"].Value.ToString();
                        ((Abm_Automovil.AltaAuto)prev_form).lblApellidoChoferValor.Text = dgIndividuo.Rows[dgIndividuo.CurrentCell.RowIndex].Cells["Apellido"].Value.ToString();
                        ((Abm_Automovil.AltaAuto)prev_form).btnGuardar.Enabled = true;
                        this.Hide();
                        break;
                    /* Buscar Chofer desde BuscarAuto */
                    case 'V':
                        ((Abm_Automovil.BuscarAuto)prev_form).idChofer = id;
                        ((Abm_Automovil.BuscarAuto)prev_form).buscar();
                        this.Hide();
                        break;
                }
            }
            else if (tipoIndividuo == "Cliente")
            {
                switch (modo)
                {
                    /* Buscar Chofer desde Baja Cliente */
                    case 'B':
                        List<BDParametro> listParametros = new List<BDParametro>();
                        listParametros.Add(new BDParametro("@id", id));
                        new BDHandler().execSP("LJDG.baja_cliente", ref listParametros);
                        this.Hide();
                        break;
                    /* Buscar Chofer desde Modificación Cliente */
                    case 'M':
                        ((Abm_Automovil.BuscarAuto)prev_form).idChofer = id;
                        ((Abm_Automovil.BuscarAuto)prev_form).buscar();
                        this.Hide();
                        break;
                }

            }
        }

    }
}
