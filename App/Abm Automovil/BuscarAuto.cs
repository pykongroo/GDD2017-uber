using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Automovil
{
    public partial class BuscarAuto : Form
    {
        public int idChofer { get; set; }

        public BuscarAuto()
        {
            InitializeComponent();
            BDHandler handler = new BDHandler();
            cmbMarca.DataSource = handler.execListSP("LJDG.obtener_marcas");
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
                listParametros.Add(new BDParametro("@marca", cmbMarca.SelectedIndex + 1));
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
            new Abm_Cliente.BuscarIndividuo(this, "Chofer", 'V').Show();
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

    }
}
