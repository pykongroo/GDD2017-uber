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
using UberFrba.Viaje;
using UberFrba.Logueo;

namespace UberFrba
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
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
            new Login().Show();
        }


        private void altaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            new Abm_Rol.AltaRol().Show();
        }

        private void bajaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            new Abm_Rol.BajaRol().Show();
        }

        private void modificacionToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            new Abm_Rol.EditarRol().Show();
        }

        private void bajaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BajaModificarCliente bmCliente = new BajaModificarCliente(this, "B");
            bmCliente.Show();
            //this.Hide();
        }

        private void modificacionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BajaModificarCliente bmCliente = new BajaModificarCliente(this, "M");
            bmCliente.Show();
            //this.Hide();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AltaModificarCliente amCliente = new AltaModificarCliente(this);
            amCliente.Show();
            //this.Hide();

        }

        private void altaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaUsuario altaUser = new AltaUsuario(this);
            this.Hide();
            altaUser.Show();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistroViaje().Show();
        }
    }
}

