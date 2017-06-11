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
    public partial class AltaUsuario : Form
    {
        private Dictionary<String, int> roles;

        public AltaUsuario()
        {
            InitializeComponent();
            username.setDescription("Usuario:");
            cmb_roles.setDescription("Rol:");
            setearRoles();
        }

        private void setearRoles()
        {
            BDHandler bdh = new BDHandler();
            bdh.Conectar();
            SqlConnection conn = bdh.conexionBD;
            String query = "select * from LJDG.Rol where rol_habilitado = 1";
            SqlCommand command = new SqlCommand(query, conn);
            var reader = command.ExecuteReader();
            roles = new Dictionary<string, int>();
            while (reader.Read())
            {
                roles.Add(reader.GetString(1), (int)reader.GetValue(0));
                cmb_roles.Add(reader.GetString(1));
            }
            bdh.Desconectar();
        }

        public bool yaExiste(String username)
        {
            BDHandler bdh = new BDHandler();
            bdh.Conectar();
            SqlConnection conn = bdh.conexionBD;
            String query = "select * from LJDG.Usuario where user_id='" + username + "'";
            var reader = (new SqlCommand(query, conn)).ExecuteReader();
            bool existe = reader.Read();
            bdh.Desconectar();
            return existe;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (username.esValido() && passwordInput.esValido() && cmb_roles.esValido())
            {
                if (yaExiste(username.Text()))
                {
                    MessageBox.Show("El nombre de usuario ya existe");
                }
                else
                {
                    Usuario.darDeAlta(username.Text(), passwordInput.Text(), roles[cmb_roles.Text()]);
                    MessageBox.Show("Usuario agregado correctamente");
                    this.Hide();
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
        }

    }
}
