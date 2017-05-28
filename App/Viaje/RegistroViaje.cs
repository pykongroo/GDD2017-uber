using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Buscador;

namespace UberFrba.Viaje
{
    public partial class RegistroViaje : Form
    {
        public RegistroViaje()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lnkChofer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new BuscarIndividuo(this, "Chofer", 'R').Show();
        }

        public void setChofer(int id, string nombre, string apellido)
        {
            lblIDChoferValor.Text = id.ToString();
            lblNombreChoferValor.Text = nombre;
            lblApellidoChoferValor.Text = apellido;
        }

        public void setCliente(int id, string nombre, string apellido)
        {
            lblIDClienteValor.Text = id.ToString();
            lblNombreClienteValor.Text = nombre;
            lblApellidoClienteValor.Text = apellido;
        }

        private void lnkCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new BuscarIndividuo(this, "Cliente", 'R').Show();
        }
    }
}
