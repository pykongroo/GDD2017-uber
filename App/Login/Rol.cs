using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba {
    
    public partial class Rol : Form {

        public Rol() {
            InitializeComponent();
            cmbRoles.DataSource = Program.user.obtenerRolesUsuario() ;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (cmbRoles.SelectedItem != null)
            {
                Program.user.rol = cmbRoles.SelectedItem.ToString();
                Menu menuPrincipal = new Menu();
                this.Hide();
                menuPrincipal.Show();
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
