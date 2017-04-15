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

namespace UberFrba
{
    public partial class Login : Form
    {
        Inicio previo;
        String tipoRol;
        List<Dictionary<String, Object>> usuarios;
        public Login(Inicio prev_form)
        {
            this.previo = prev_form;
            usuarios = getUsuarios();
            InitializeComponent();
        }

        public void setTipoRol(String rol)
        {
            this.tipoRol = rol;
            this.Text = "Login " + tipoRol;
        }

        private void Volver_Inicio(object sender, EventArgs e)
        {
            this.Hide();
            this.previo.Show();
        }

        private List<Dictionary<string, Object>> getUsuarios()
        {
            List<Dictionary<string, Object>> usuarios = new List<Dictionary<string, object>>();
            Dictionary<string, Object> user1 = new Dictionary<string, Object>();
            List<string> roles1 = new List<string>();
            roles1.Add("Administrador");
            user1.Add("username", "admin");
            user1.Add("password", "w23e".Sha256());
            user1.Add("roles", roles1);
            user1.Add("fallos", 0);
            usuarios.Add(user1);

            Dictionary<string, Object> user2 = new Dictionary<string, Object>();
            List<string> roles2 = new List<string>();
            roles2.Add("Cliente");
            roles2.Add("Administrador");
            user2.Add("username", "user");
            user2.Add("password", "pass".Sha256());
            user2.Add("roles", roles2);
            user2.Add("fallos", 0);
            usuarios.Add(user2);

            Dictionary<string, Object> user3 = new Dictionary<string, Object>();
            List<string> roles3 = new List<string>();
            roles3.Add("Chofer");
            user3.Add("username", "chofer1");
            user3.Add("password", "".Sha256());
            user3.Add("roles", roles3);
            user3.Add("fallos", 0);
            usuarios.Add(user3);
            return usuarios;
        }

        private void verificarLogueo()
        {
            // algoritmo temporal hasta lograr utilizar la DB
            Boolean nomatch = true;
            foreach (Dictionary<string, Object> user in usuarios)
            {
                if ((String)user["username"] == textUser.Text)
                {
                    Console.WriteLine(user["username"].ToString());
                    Console.WriteLine(user["password"].ToString());
                    Console.WriteLine(user["fallos"].ToString());
                    nomatch = false;
                    int fallos = (int)user["fallos"];
                    if (fallos == 3)
                    {
                        MessageBox.Show("Usuario inhabilitado");
                        break;
                    }
                    if ((string)user["password"] == textPass.Text.Sha256())
                    {
                        user["fallos"] = 0;
                        List<string> roles = (List<string>) user["roles"];
                        if (roles.Contains(tipoRol)){
                            MessageBox.Show("Logueo exitoso");
                        } else
                        {
                            MessageBox.Show("Rol no permitido!!");
                        }
                        //break;
                    } else
                    {
                        fallos++;
                        user["fallos"] = fallos;
                        MessageBox.Show("Contraseña incorrecta");
                        if (fallos == 3)
                        {
                            MessageBox.Show(
                                "Maximos intentos permitidos superados\n"+
                                "Su usuario será inhabilitado!!");
                        }
                        //break;
                    }
                    break;
                }
            }
            if (nomatch)
            {
                MessageBox.Show("Usuario inexistente");
            }
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
