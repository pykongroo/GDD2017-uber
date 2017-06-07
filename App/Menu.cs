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
using UberFrba.Abm_Turno;
using UberFrba.Buscador;
using UberFrba.Abm_Chofer;

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
            funcionalidades_menu.Add("ABM de Rol", menuABMRol);
            funcionalidades_menu.Add("Registro de Usuario", menuAltaUsuario);
            funcionalidades_menu.Add("ABM de Cliente", menuABMCliente);
            funcionalidades_menu.Add("ABM de Automóvil", menuABMAuto);
            funcionalidades_menu.Add("ABM de Chofer", menuABMChofer);
            funcionalidades_menu.Add("ABM de Turno", menuABMTurno);
            funcionalidades_menu.Add("Registro de Viajes", menuRegistrarViaje);
            funcionalidades_menu.Add("Rendición de cuenta de Chofer", menuRendicion);
            funcionalidades_menu.Add("Facturación a Cliente", menuFacturacion);
            funcionalidades_menu.Add("Listado Estadístico", menuEstadisticas);
        }

        private void mostrar_funcionalidades_rol(String rol_nombre)
        {
            List<String> funcionalidades_user = new List<string>();
            String query = "select func_descripcion, rol_nombre from LJDG.Funcionalidad, LJDG.Rol, LJDG.Funcionalidad_Rol where fxr_funcionalidad=func_id AND fxr_rol=rol_id AND rol_nombre='" + rol_nombre + "' group by func_descripcion, rol_nombre";
            BDHandler bdh = new BDHandler();
            bdh.Conectar();
            SqlConnection conn = bdh.conexionBD;
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                funcionalidades_user.Add(reader.GetString(0).ToLower());
            }
            bdh.Desconectar();
            foreach (var nombre_func in funcionalidades_menu.Keys)
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


        private void menuABMAltaRol_Click(object sender, EventArgs e)
        {
            new AltaRol().Show();
        }

        private void menuABMBajaRol_Click(object sender, EventArgs e)
        {
            new BajaRol().Show();
        }

        private void menuABMModiRol_Click(object sender, EventArgs e)
        {
            new EditarRol().Show();
        }

        private void menuABMBajaCliente_Click(object sender, EventArgs e)
        {
            new BuscarIndividuo(this, "Cliente", 'B').Show();
        }

        private void menuABMModiCliente_Click(object sender, EventArgs e)
        {
            new BuscarIndividuo(this, "Cliente", 'M').Show();
        }

        private void menuABMAltaCliente_Click(object sender, EventArgs e)
        {
            new AltaModificarCliente(this).Show();
        }

        private void altaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AltaUsuario(this).Show();
        }

        private void menuRegistrarViaje_Click(object sender, EventArgs e)
        {
            new RegistroViaje().Show();
        }

        private void menuABMAltaAuto_Click(object sender, EventArgs e)
        {
            new AltaModiAuto('A').Show();
        }

        private void menuABMBajaAuto_Click(object sender, EventArgs e)
        {
            new BuscarAuto('B').Show();
        }

        private void menuABMModiAuto_Click(object sender, EventArgs e)
        {
            new BuscarAuto('M').Show();
        }

        private void rendicionChoferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RendicionChofer rend_chofer = new RendicionChofer();
            rend_chofer.Show();
        }

        private void menuABMTAltaTurno_Click(object sender, EventArgs e)
        {
            new AltaTurno().Show();
        }

        private void menuABMBajaTurno_Click(object sender, EventArgs e)
        {
            new BajaTurno().Show();
        }

        private void menuABMModiTurno_Click(object sender, EventArgs e)
        {
            new EditarTurno().Show();
        }

        private void menuABMAltaChofer_Click(object sender, EventArgs e)
        {
            new AltaModiChofer('A').Show();
        }

        private void menuABMBajaChofer_Click(object sender, EventArgs e)
        {
            new BuscarIndividuo(this, "Chofer", 'B').Show();
        }

        private void menuABMModiChofer_Click(object sender, EventArgs e)
        {
            new BuscarIndividuo(this, "Chofer", 'M').Show();
        }

        private void menuEstadisticas_Click(object sender, EventArgs e)
        {
            new Estadisticas.Estadisticas().Show();
        }
    }
}

