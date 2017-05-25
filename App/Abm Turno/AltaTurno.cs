using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Modelo;


namespace UberFrba.Abm_Turno
{
    public partial class AltaTurno : Form
    {
        public AltaTurno()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AltaTurno_Load(object sender, EventArgs e)
        {
            // MessageBox.Show(typeof(NumericUpDown).ToString);
        }

        private bool validacion()
        {
            if (numHoraInicio.Value >= numHoraFin.Value)
            {
                MessageBox.Show("El horario de finalización debe ser mayor al de inicio");
                return false;
            }
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Por favor complete la descripción");
                return false;
            }
            if (numValorKM.Value == Convert.ToDecimal(0))
            {
                MessageBox.Show("El valor del Km no puede ser 0");
                return false;
            }
            if (numPrecioBase.Value == Convert.ToDecimal(0))
            {
                MessageBox.Show("El valor del precio base no puede ser 0");
                return false;
            }
            return true;

        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            var camposOk = validacion();
            if (camposOk)
            {
               
                Turno.insertarTurno(txtDescripcion.Text, numHoraInicio.Value, numHoraFin.Value, numValorKM.Value, numPrecioBase.Value);
                MessageBox.Show("El turno ha sido creado correctamente");
                this.Hide();
            }

        }
    }
}
