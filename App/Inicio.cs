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
    public partial class Inicio : Form
    {
        Login login_form;
        public Inicio()
        {
            //login_form = new Login(this);
            InitializeComponent();
        }

        private List<String> getRoles()
        {
            List<String> roles = new List<string>();
            roles.Add("Administrador");
            roles.Add("Cliente");
            roles.Add("Chofer");
            return roles;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<String> roles = getRoles();
            foreach (String rol in roles)
            {
                cmb_roles.Items.Add(rol);
            }
        }

        private void Loguear_Rol(object sender, EventArgs e)
        {
            login_form = new Login(this);
            String rolSeleccionado = cmb_roles.Text;
            if (rolSeleccionado == "")
            {
                MessageBox.Show("Debe elegir un rol!!");
            } else
            {
                login_form.setTipoRol(rolSeleccionado);
                this.Hide();
                login_form.Show();
                //switch (rolSeleccionado)
                //{
                //    case "Administrador":
                //        MessageBox.Show("ADM");
                //        break;
                //    case "Cliente":
                //        MessageBox.Show("CLI");
                //        break;
                //    case "Chofer":
                //        MessageBox.Show("CHF");
                //        break;
                //}
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaUsuario altaUser = new AltaUsuario(this);
            this.Hide();
            altaUser.Show();
        }

        private void cmb_roles_KeyUp(object sender, KeyEventArgs e)
        {
            cmb_roles.Text = "";
        }
    }
}
