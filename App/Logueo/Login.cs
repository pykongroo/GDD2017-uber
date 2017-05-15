using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helper;

namespace UberFrba.Logueo {
    
    public partial class Login : Form {
              
        public Login() {
            InitializeComponent();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            if (textUser.Text.Trim() != "") {
                if (textPass.Text.Trim() != "") {
                    String mensaje;
                    Program.user.id = textUser.Text;
                    Program.user.password = textPass.Text.Sha256();
                    mensaje = Program.user.iniciarSesion();
                    if (mensaje == "OK") {
                        SeleccionRol menuRoles = new SeleccionRol();
                        this.Hide();
                        menuRoles.Show();
                        return;
                    }
                    MessageBox.Show(mensaje);
                    textPass.Clear();
                    textPass.Focus();
                }
                else {
                    MessageBox.Show("Ingrese su Contraseña.");
                    textPass.Focus();
                }
            }
            else {
                MessageBox.Show("Ingrese su Nombre de Usuario.");
                textUser.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {
            if (textUser.Text != "")
                textPass.Enabled = true;
            else {
                textPass.Enabled = false;
                textUser.Clear();
            }
        }

        private void textPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
