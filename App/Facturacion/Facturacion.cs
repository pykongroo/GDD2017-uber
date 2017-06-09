using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Facturacion
{
    public partial class Facturacion : Form
    {

        int idCliente;
        double montoTotal;

        public Facturacion()
        {
            InitializeComponent();
        }
        
        public void setCliente(int id, string nombre, string apellido)
        {
            idCliente = id;
            lblIDClienteValor.Text = id.ToString();
            lblNombreClienteValor.Text = nombre;
            lblApellidoClienteValor.Text = apellido;
            buscar();
        }

        private void lnkCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Buscador.BuscarIndividuo(this, "Cliente", 'F').Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void buscar()
        {
            List<BDParametro> listParametros = new List<BDParametro>();
            listParametros.Add(new BDParametro("@fechaInicio", datetimeFechaInicio.Value));
            listParametros.Add(new BDParametro("@fechaFin", datetimeFechaFin.Value));
            listParametros.Add(new BDParametro("@idCliente", idCliente));
            dgViajes.DataSource = new BDHandler().execSelectSP("LJDG.viajes_cliente", listParametros);
            montoTotal = 0;
            foreach (DataGridViewRow r in dgViajes.Rows)
                montoTotal += Convert.ToDouble(r.Cells[6].Value);            
            lblMontoTotalValor.Text = "$ " + montoTotal.ToString();
        }

        private bool validar()
        {

            if (idCliente == 0)
            {
                MessageBox.Show("Debe ingresar un cliente.");
                return false;
            }

            if (datetimeFechaInicio.Value.Date > datetimeFechaFin.Value.Date)
            {
                MessageBox.Show("La fecha de inicio debe ser menor a la fecha de fin.");
                return false;
            }
            
            return true;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            validar();
        }

        private void datetimeFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void datetimeFechaFin_ValueChanged(object sender, EventArgs e)
        {
            buscar();
        }

    }
}
