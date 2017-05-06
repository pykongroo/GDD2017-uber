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
    public partial class AltaUsuario : CustomForm
    {
        bool usernameOk;
        bool passwordOk;
        bool rolOk;
        public AltaUsuario(Form prev):base(prev)
        {
            InitializeComponent();
            setearRoles();
        }

        private void setearRoles()
        {
            //se deben obtener de la DB
            comboBoxRoles.Items.Add("Admin");
            comboBoxRoles.Items.Add("Cliente");
            comboBoxRoles.Items.Add("Chofer");
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                //MessageBox.Show("El username no debe estar vacio");
                usernameOk = false;
            } else
            {
                usernameOk = true;
            }
            if (usernameOk)
            {
                labelStatUser.BackColor = Color.Green;
            } else
            {
                labelStatUser.BackColor = Color.Red;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("La contraseña no debe estar vacía!!");
                passwordOk = false;
            } else
            {
                if (textBoxPassword.Text == textBoxPasswordConfirm.Text)
                {
                    passwordOk = true;
                } else
                {
                    if (textBoxPasswordConfirm.Text != "")
                    {
                        MessageBox.Show("Las contraseñas no coinciden");
                    }
                    passwordOk = false;
                }
            }
            if (passwordOk)
            {
                labelStatPass.BackColor = Color.Green;
            }
            else
            {
                labelStatPass.BackColor = Color.Red;
            }
        }

        private void textBoxPasswordConfirm_Leave(object sender, EventArgs e)
        {
            if (textBoxPasswordConfirm.Text == "")
            {
                MessageBox.Show("La contraseña no debe estar vacía!!");
                passwordOk = false;
            }
            else
            {
                if (textBoxPassword.Text == textBoxPasswordConfirm.Text)
                {
                    passwordOk = true;
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    passwordOk = false;
                }
            }
            if (passwordOk)
            {
                labelStatPass.BackColor = Color.Green;
            }
            else
            {
                labelStatPass.BackColor = Color.Red;
            }
        }

        private void comboBoxRoles_Leave(object sender, EventArgs e)
        {
            if (comboBoxRoles.Text == "")
            {
                rolOk = false;
            } else
            {
                rolOk = true;
            }
            if (rolOk)
            {
                labelStatRol.BackColor = Color.Green;
            }
            else
            {
                labelStatRol.BackColor = Color.Red;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (usernameOk && passwordOk && rolOk)
            {
                MessageBox.Show("Registro exitoso");
                //codigo de alta en DB y captura de error en DB
                //se debe validar existencia de usuario
                //la contraseña debe ser almacenada usando SHA256de la DB
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.previo.Show();
        }

        private void comboBoxRoles_KeyUp(object sender, KeyEventArgs e)
        {
            comboBoxRoles.Text = "";
        }
    }
}
