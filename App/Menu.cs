using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Abm_Cliente;
using System.Data.SqlClient;
using UberFrba.Abm_Rol;
using UberFrba.Viaje;
using UberFrba.Abm_Automovil;
using UberFrba.Rendicion_Viajes;

namespace UberFrba
{
    public partial class Menu : Form
    {
        private Dictionary<String, ToolStripItem> funcionalidades_menu = new Dictionary<String, ToolStripItem>();

        public Menu()
        {
            InitializeComponent();
            init_items();
            mostrar_funcionalidades_rol(Program.user.rol);
        }

        private void init_items()
        {
            funcionalidades_menu.Add("ABM de Rol", rolToolStripMenuItem);
            funcionalidades_menu.Add("Registro de Usuario", altaUsuarioToolStripMenuItem);
            funcionalidades_menu.Add("ABM de Cliente", clienteToolStripMenuItem);
            funcionalidades_menu.Add("ABM de Automóvil", automovilToolStripMenuItem);
            funcionalidades_menu.Add("ABM de Chofer", choferToolStripMenuItem);
            funcionalidades_menu.Add("ABM de Turno", rolToolStripMenuItem);
            funcionalidades_menu.Add("Registro de Viajes", registrarToolStripMenuItem);
            funcionalidades_menu.Add("Rendición de cuenta de Chofer", rendicionChoferToolStripMenuItem);
            funcionalidades_menu.Add("Facturación a Cliente", facturacionToolStripMenuItem);
            funcionalidades_menu.Add("Listado Estadístico", listadoEstadisticoToolStripMenuItem);
        }

        private void mostrar_funcionalidades_rol(String rol_nombre)
        {
            List<String> funcionalidades_user = new List<string>();
            String query = "select func_descripcion, rol_nombre from LJDG.Funcionalidad, LJDG.Rol, LJDG.Funcionalidad_Rol where fxr_funcionalidad=func_id AND fxr_rol=rol_id AND rol_nombre='" + rol_nombre + "' group by func_descripcion, rol_nombre";
            Conexion conn = Conexion.getInstance();
            conn.con.Open();
            SqlCommand command = new SqlCommand(query, conn.con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                funcionalidades_user.Add(reader.GetString(0).ToLower());
            }
            conn.con.Close();
            foreach(var nombre_func in funcionalidades_menu.Keys)
            {
                if (!funcionalidades_user.Contains(nombre_func.ToLower()))
                {
                    funcionalidades_menu[nombre_func].Visible = false;
                }
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Text += " - logueado como '" + Program.user.id + "' <" + Program.user.rol + ">";
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Logueo.Login().Show();
        }


        private void altaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new Abm_Rol.AltaRol().Show();
        }

        private void bajaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new BajaRol().Show();
        }

        private void modificacionToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new EditarRol().Show();
        }

        private void bajaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new BuscarIndividuo(this, "B").Show();
        }

        private void modificacionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new BuscarIndividuo(this, "M").Show();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new AltaModificarCliente(this).Show();
        }

        private void altaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AltaUsuario(this).Show();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistroViaje().Show();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AltaAuto().Show();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BuscarAuto().Show();
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BuscarAuto().Show();
        }

        private void rendicionChoferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RendicionChofer rend_chofer = new RendicionChofer();
            rend_chofer.Show(); 
        }
    }
}

