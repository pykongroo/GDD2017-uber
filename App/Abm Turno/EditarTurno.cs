using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Modelo;
using UberFrba.Utils;

namespace UberFrba.Abm_Turno
{
    public partial class EditarTurno : Form
    {
        Turno selectedItemTurno;
        public EditarTurno()
        {
            InitializeComponent();
        }

        private void EditarTurno_Load(object sender, EventArgs e)
        {
            var misTurnos = Turno.obtenerTurnos();
            cmbTurnos.DataSource = misTurnos;
            cmbTurnos.DisplayMember = "Descripcion";
        }

        private void cmbTurnos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedItemTurno = (Turno)cmbTurnos.SelectedItem;
            txtDescripcion.Enabled = true;
            btnModificarTurno.Enabled = true;
            numHoraFin.Enabled = true;
            numHoraInicio.Enabled = true;
            numPrecioBase.Enabled = true;
            numValorKM.Enabled = true;
            numHoraInicio.Value = selectedItemTurno.Hora_Inicio;
            numPrecioBase.Value = selectedItemTurno.Precio_Base;
            numValorKM.Value = selectedItemTurno.Valor_Km;
            numHoraFin.Value = selectedItemTurno.Hora_Finalizacion;
            txtDescripcion.Text = selectedItemTurno.Descripcion;
            if (!selectedItemTurno.Habilitado)
            {
                lblDeshabilitado.Visible = true;
                radioHabilitar.Visible = true;
                radioHabilitar.Checked = false;
            }
            else
            {
                lblDeshabilitado.Visible = false;
                radioHabilitar.Visible = false;
                radioHabilitar.Checked = true;
            }
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


        private void btnModificarTurno_Click(object sender, EventArgs e)
        {
            int habilitar = 0;
            if (validacion())
            {
                if (radioHabilitar.Checked)
                {
                    habilitar = 1;
                }
                Turno.editarTurno(selectedItemTurno.ID_Turno, txtDescripcion.Text, numHoraInicio.Value, numHoraFin.Value, numValorKM.Value, numPrecioBase.Value, habilitar);
                MessageBox.Show("Turno modificado");
                radioHabilitar.Visible = false;
                lblDeshabilitado.Visible = false;
                this.Hide();
                //Menu menuPrincipal = new Menu();
                //menuPrincipal.Show();
            }
            
        }

        private void cmbTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditarTurno_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            //new Menu().Show();
        }
    }
}
