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

namespace UberFrba.Buscador
{
    public partial class BuscarIndividuo : Form
    {
        Form formPadre;
        private String tipoIndividuo;
        private char modo;

        /* Recibe el Formulario anterior
         * Tipo de Individuo = "Chofer" / "Cliente"
         * Modo de uso = 'B' Baja / 'M' Modificación / 'S' Busqueda de Chofer */
        public BuscarIndividuo(Form _formPadre, String _tipoIndividuo, char _modo)
        {
            InitializeComponent();
            this.formPadre = _formPadre;
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
            this.formPadre.Show();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgIndividuo.Rows[dgIndividuo.CurrentCell.RowIndex].Cells["ID"].Value.ToString());
            string nombre = dgIndividuo.Rows[dgIndividuo.CurrentCell.RowIndex].Cells["Nombre"].Value.ToString();
            string apellido = dgIndividuo.Rows[dgIndividuo.CurrentCell.RowIndex].Cells["Apellido"].Value.ToString();
            
            if (tipoIndividuo == "Chofer")
            {
                switch (modo)
                {
                    /* Buscar Chofer desde AltaModiAuto*/
                    case 'S':
                        ((Abm_Automovil.AltaModiAuto)formPadre).setChofer(id, nombre, apellido);
                        break;
                    /* Buscar Chofer desde RegistroViaje*/
                    case 'R':
                        ((Viaje.RegistroViaje)formPadre).setChofer(id, nombre, apellido);
                        break;
                    /* Buscar Chofer desde BuscarAuto */
                    case 'V':
                        ((Abm_Automovil.BuscarAuto)formPadre).setChofer(id, nombre, apellido);
                        break;
                }
            }
            else if (tipoIndividuo == "Cliente")
            {
                switch (modo)
                {
                    /* Buscar Cliente desde Baja Cliente */
                    case 'B':
                        List<BDParametro> listParametros = new List<BDParametro>();
                        listParametros.Add(new BDParametro("@id", id));
                        new BDHandler().execSP("LJDG.baja_cliente", ref listParametros);
                        break;
                    /* Buscar Cliente desde RegistroViaje*/
                    case 'R':
                        ((Viaje.RegistroViaje)formPadre).setCliente(id, nombre, apellido);
                        break;
                }
            }
            this.Hide();
        }

    }
}
