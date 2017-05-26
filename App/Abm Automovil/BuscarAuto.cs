using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Buscador;

namespace UberFrba.Abm_Automovil
{
    public partial class BuscarAuto : Form
    {
        public int idChofer { get; set; }

        public BuscarAuto()
        {
            InitializeComponent();
            List<String> marcas = new List<String>();
            marcas.Add("Todas");
            marcas.AddRange(new BDHandler().execListSP("LJDG.obtener_marcas"));
            cmbMarca.DataSource = marcas;
            buscar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void buscar()
        {
            List<BDParametro> listParametros = new List<BDParametro>();
            try
            {
                BDHandler handler = new BDHandler();
                listParametros.Add(new BDParametro("@marca", cmbMarca.SelectedIndex));
                listParametros.Add(new BDParametro("@modelo", txtBoxModelo.Text.Trim()));
                listParametros.Add(new BDParametro("@patente", txtBoxPatente.Text.Trim()));
                listParametros.Add(new BDParametro("@chofer", idChofer));
                dgAuto.DataSource = handler.execSelectSP("LJDG.buscar_auto", listParametros);
                if (dgAuto.RowCount == 0)
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

        private void lnkChofer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new BuscarIndividuo(this, "Chofer", 'V').Show();
        }

        private void txtBoxPatente_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void txtBoxModelo_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            idChofer = 0;
            lblIDChoferValor.Text = "";
            lblNombreChoferValor.Text = "";
            lblApellidoChoferValor.Text = "";
            buscar();
        }

    }
}
