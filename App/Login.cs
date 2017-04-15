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
    public partial class Login : Form
    {
        Inicio previo;
        String tipoRol;
        public Login(Inicio prev_form)
        {
            this.previo = prev_form;
            InitializeComponent();
        }

        public void setTipoRol(String rol)
        {
            this.tipoRol = rol;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = "Login " + tipoRol;
        }

        private void Volver_Inicio(object sender, EventArgs e)
        {
            this.Hide();
            this.previo.Show();
        }

        private void verificarLogueo()
        {

        }

        private void Loguear(object sender, EventArgs e)
        {
            if (textUser.Text == "")
            {
                MessageBox.Show("El campo usuario no debe estar vacío!!");
            } else
            {
                this.verificarLogueo();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.previo.Close();
        }
    }
}
