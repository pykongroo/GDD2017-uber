using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Estadisticas
{
    public partial class Estadisticas : Form
    {
        private int anio;
        
        public Estadisticas()
        {
            InitializeComponent();
            List<String> trimestres = new List<String>();
            trimestres.Add("Primero");
            trimestres.Add("Segundo");
            trimestres.Add("Tercero");
            trimestres.Add("Cuarto");
            cmbTrimestre.DataSource = trimestres;
            List<String> estadisticas = new List<String>();
            estadisticas.Add("Chóferes con mayor recaudación");
            estadisticas.Add("Choferes con el viaje más largo realizado");
            estadisticas.Add("Clientes con mayor consumo");
            estadisticas.Add("Cliente que utilizo más veces el mismo automóvil en sus viajes");
            cmbEstadistica.DataSource = estadisticas;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        public void buscar()
        {
            if (!int.TryParse(txtAnio.Text.Trim(), out anio))
                return;
            List<BDParametro> listParametros = new List<BDParametro>();
            BDHandler handler = new BDHandler();
            listParametros.Add(new BDParametro("@anio", anio));
            listParametros.Add(new BDParametro("@trimestre", cmbTrimestre.SelectedIndex + 1));
            switch (cmbEstadistica.SelectedIndex)
            {
                case 0:
                    dgEstadistica.DataSource = handler.execSelectSP("LJDG.choferes_mayor_recaudacion", listParametros);
                    break;
                case 1:
                    dgEstadistica.DataSource = handler.execSelectSP("LJDG.choferes_viaje_mas_largo", listParametros);
                    break;
                case 2:
                    dgEstadistica.DataSource = handler.execSelectSP("LJDG.clientes_mayor_consumo", listParametros);
                    break;
                case 3:
                    dgEstadistica.DataSource = handler.execSelectSP("LJDG.cliente_auto", listParametros);
                    break;
            }
        }

        private void cmbTrimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void cmbEstadistica_SelectedIndexChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void txtAnio_Leave(object sender, EventArgs e)
        {
            buscar();
        }
    }
}
