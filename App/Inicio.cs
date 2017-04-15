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
            login_form = new Login(this);
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            cmb_roles.Items.Add("Administrador");
            cmb_roles.Items.Add("Cliente");
            cmb_roles.Items.Add("Chofer");
        }

        private void Loguear_Rol(object sender, EventArgs e)
        {
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
    }
}
