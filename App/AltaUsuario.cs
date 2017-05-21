using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Modelo;

namespace UberFrba
{
    public partial class AltaUsuario : CustomForm
    {
        private Dictionary<String, int> roles;
        public AltaUsuario(Form prev):base(prev)
        {
            InitializeComponent();
            username.setDescription("Usuario:");
            cmb_roles.setDescription("Rol:");
            setearRoles();
        }

        private void setearRoles()
        {
            Conexion conn = Conexion.getInstance();
            conn.con.Open();
            String query = "select * from LJDG.Rol";
            SqlCommand command = new SqlCommand(query, conn.con);
            var reader = command.ExecuteReader();
            roles = new Dictionary<string, int>();
            while (reader.Read())
            {
                roles.Add(reader.GetString(1), (int) reader.GetValue(0));
                cmb_roles.Add(reader.GetString(1));
            }
            conn.con.Close();
        }

        public bool yaExiste(String username)
        {
            Conexion conn = Conexion.getInstance();
            String query = "select * from LJDG.Usuario where user_id='" + username + "'";
            conn.con.Open();
            var reader = (new SqlCommand(query, conn.con)).ExecuteReader();
            bool existe = reader.Read();
            conn.con.Close();
            return existe;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (username.esValido() && passwordInput.esValido() && cmb_roles.esValido())
            {
                if (yaExiste(username.Text()))
                {
                    MessageBox.Show("el nombre de usuario ya existe");
                } else
                {
                    Usuario.darDeAlta(username.Text(), passwordInput.Text(), roles[cmb_roles.Text()]);
                    MessageBox.Show("Usuario agregado correctamente");
                    this.Hide();
                    previo.Show();
                }
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
        
    }
}
