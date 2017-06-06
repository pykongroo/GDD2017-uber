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
        public Estadisticas()
        {
            InitializeComponent();
            List<String> trimestres = new List<String>();
            trimestres.Add("Primero");
            trimestres.Add("Segundo");
            trimestres.Add("Tercero");
            trimestres.Add("Quarto");
            cmbTrimestre.DataSource = trimestres;
            List<String> estadisticas = new List<String>();
            estadisticas.Add("Chóferes con mayor recaudación");
            estadisticas.Add("Choferes con el viaje más largo realizado");
            estadisticas.Add("Clientes con mayor consumo");
            estadisticas.Add("Cliente que utilizo más veces el mismo automóvil en los viajes que ha realizado");
            cmbEstadistica.DataSource = estadisticas;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46;
        }
    }
}
