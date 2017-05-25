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
    public partial class BajaTurno : Form
    {
        public BajaTurno()
        {
            InitializeComponent();
        }

        private void BajaTurno_Load(object sender, EventArgs e)
        {
            var misTurnos = Turno.obtenerTurnos().FindAll(r => r.Habilitado);
            cmbTurnos.DataSource = misTurnos;
            cmbTurnos.DisplayMember = "Descripcion";
        }

        private void BajaTurno_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            //new Menu().Show();
        }


        private void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            Turno selectedItem = (Turno)cmbTurnos.SelectedItem;
            var confirmResult = MessageBox.Show("¿Esta seguro que desea inhabilitar el turno seleccionado?",
                                     "Dar de baja <" + selectedItem.Descripcion + ">?",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // BAJA LOGICA DEL TURNO
                Turno.eliminarTurno(selectedItem.ID_Turno);
                MessageBox.Show("El Turno " + selectedItem.Descripcion + " ha sido dado de baja");
                this.Hide();
                //Menu menuPrincipal = new Menu();
                //menuPrincipal.Show();
            }
            else
            {
                //NADA
            }
        }
    }
}
