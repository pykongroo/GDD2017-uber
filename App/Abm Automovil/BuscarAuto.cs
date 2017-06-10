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
        private int idAuto;
        public int idChofer { get; set; }
        private char modo;

        public BuscarAuto(char _modo)
        {
            InitializeComponent();
            this.modo = _modo;
            if (modo == 'M')
                this.Text = "Buscar Automóvil a Modificar";
            else if (modo == 'B')
                this.Text = "Buscar Automóvil a dar de Baja";
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
            BDHandler handler = new BDHandler();
            listParametros.Add(new BDParametro("@marca", cmbMarca.SelectedIndex));
            listParametros.Add(new BDParametro("@modelo", txtBoxModelo.Text.Trim()));
            listParametros.Add(new BDParametro("@patente", txtBoxPatente.Text.Trim()));
            listParametros.Add(new BDParametro("@chofer", idChofer));
            if (modo == 'M')
                dgAuto.DataSource = handler.execSelectSP("LJDG.buscar_auto", listParametros);
            else
                dgAuto.DataSource = handler.execSelectSP("LJDG.buscar_auto_habilitado", listParametros);
            if (dgAuto.RowCount == 0)
                btnSeleccionar.Enabled = false;
            else
                btnSeleccionar.Enabled = true;
        }

        private void lnkChofer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new BuscarIndividuo(this, "Chofer", 'S').Show();
        }

        public void setChofer(int id, string nombre, string apellido)
        {
            idChofer = id;
            lblIDChoferValor.Text = id.ToString();
            lblNombreChoferValor.Text = nombre;
            lblApellidoChoferValor.Text = apellido;
            btnLimpiar.Enabled = true;
            buscar();
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            idAuto = int.Parse(dgAuto.Rows[dgAuto.CurrentCell.RowIndex].Cells["ID"].Value.ToString());
            switch (modo)
            {
                /* Buscar Auto desde Menú Principal ABM Automóvil Modificación */
                case 'M':
                    AltaModiAuto altaModiAuto = new AltaModiAuto('M', idAuto);
                    this.Hide();
                    altaModiAuto.Show();
                    altaModiAuto.lblNombreChoferValor.Text = dgAuto.Rows[dgAuto.CurrentCell.RowIndex].Cells["Nombre"].Value.ToString();
                    altaModiAuto.lblApellidoChoferValor.Text = dgAuto.Rows[dgAuto.CurrentCell.RowIndex].Cells["Apellido"].Value.ToString();
                    break;
                /* Buscar Auto desde Menú Principal ABM Automóvil Baja */
                case 'B':
                    List<BDParametro> listParametros = new List<BDParametro>();
                    listParametros.Add(new BDParametro("@id", idAuto));
                    new BDHandler().execSP("LJDG.baja_auto", ref listParametros);
                    MessageBox.Show("Se ha inhabilitado el Automóvil");
                    this.Hide();
                    break;
            }
        }

    }
}
