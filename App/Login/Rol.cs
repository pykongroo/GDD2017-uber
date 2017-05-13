using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba
{

    public partial class Rol : Form
    {

        public Rol()
        {
            InitializeComponent();
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

        private void Rol_Load(object sender, EventArgs e)
        {
            List<String> rolesUser = Program.user.obtenerRolesUsuario();
            if (rolesUser.Count > 0)
            {
                cmbRoles.DataSource = rolesUser;
                btnIngresar.Enabled = true;
            }
            else
            {
                MessageBox.Show(Program.user.id + " no tiene roles disponibles");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

    }
}
