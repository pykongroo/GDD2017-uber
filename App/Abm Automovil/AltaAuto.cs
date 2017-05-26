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
    public partial class AltaAuto : Form
    {
        public int idAuto { get; set; }

        public AltaAuto()
        {
            InitializeComponent();
            BDHandler handler = new BDHandler();
            cmbMarca.DataSource = handler.execListSP("LJDG.obtener_marcas");
            cmbTurno.DataSource = handler.execListSP("LJDG.obtener_descripcion_turnos");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lnkChofer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Abm_Cliente.BuscarIndividuo(this, "Chofer", 'S').Show();
        }

        private void nuevoAuto()
        {
            
        }

        private String guardarAuto()
        {            
            List<BDParametro> listParametros = new List<BDParametro>();            
            listParametros.Add(new BDParametro("@marca",      cmbMarca.SelectedIndex + 1));
            listParametros.Add(new BDParametro("@patente",    txtBoxPatente.Text));
            listParametros.Add(new BDParametro("@modelo",     txtBoxModelo.Text));
            listParametros.Add(new BDParametro("@chofer",     int.Parse(lblIDChoferValor.Text.ToString())));
            listParametros.Add(new BDParametro("@turno",      cmbTurno.SelectedIndex + 1));
            listParametros.Add(new BDParametro("@habilitado", checkBoxHabilitado.Checked ? 1 : 0));
            listParametros.Add(new BDParametro("@mensaje", "", SqlDbType.VarChar, 50, ParameterDirection.Output));
            new BDHandler().execSP("LJDG.alta_auto", ref listParametros);
            return listParametros[6].valor.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(guardarAuto());
        }
    }
}
