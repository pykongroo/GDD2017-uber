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


namespace UberFrba.Abm_Rol
{
    public partial class BajaRol : Form
    {
        public BajaRol()
        {
            InitializeComponent();
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            Rol selectedItem = (Rol)cmbRoles.SelectedItem;
            var confirmResult = MessageBox.Show("¿Esta seguro que desea inhabilitar el rol seleccionado?",
                                     "Dar de baja <" + selectedItem.Nombre + ">?",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // BAJA LOGICA DEL ROL y BORRADO DE LA TABLA ROL USUARIO.
                Rol.eliminarRol(selectedItem.ID_Rol);
                MessageBox.Show("El Rol " + selectedItem.Nombre + " ha sido dado de baja");  
                this.Hide();
                //Menu menuPrincipal = new Menu();
                //menuPrincipal.Show();
            }
            else
            {
                //NADA
            }
        }

        private void BajaRolForm_Load(object sender, EventArgs e)
        {
            var misRoles =  Rol.obtenerRoles().FindAll(r => r.Habilitado) ;
            cmbRoles.DataSource = misRoles;
            cmbRoles.DisplayMember = "Nombre";
        }

        private void BajaRol_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            //new Menu().Show();
        }
    }
}
