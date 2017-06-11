using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Modelo;

namespace UberFrba.Rendicion_Viajes
{
    public partial class Rendicion : Form
    {

        private int idChofer;
        private int idTurno;
        private decimal montoTotal;

        public Rendicion()
        {
            InitializeComponent();
        }

        public void setChofer(int id, string nombre, string apellido)
        {
            idChofer = id;
            lblIDChoferValor.Text = id.ToString();
            lblNombreChoferValor.Text = nombre;
            lblApellidoChoferValor.Text = apellido;
            buscar();
        }

        private void lnkCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Buscador.BuscarIndividuo(this, "Chofer", 'R').Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void buscar()
        {
            List<BDParametro> listParametros = new List<BDParametro>();
            listParametros.Add(new BDParametro("@fecha", datetimeFecha.Value));
            listParametros.Add(new BDParametro("@idTurno", idTurno));
            listParametros.Add(new BDParametro("@idChofer", idChofer));
            listParametros.Add(new BDParametro("@pcj", Program.pcjRend));
            dgViajes.DataSource = new BDHandler().execSelectSP("LJDG.viajes_chofer", listParametros);
            montoTotal = 0;
            foreach (DataGridViewRow r in dgViajes.Rows)
                montoTotal += Convert.ToDecimal(r.Cells[7].Value);
            lblMontoTotalValor.Text = "$ " + montoTotal.ToString();
        }

        private bool validar()
        {

            if (idChofer == 0)
            {
                MessageBox.Show("Debe ingresar un chofer.");
                return false;
            }
            if (idTurno == 0)
            {
                MessageBox.Show("Debe ingresar un turno.");
                return false;
            }
            return true;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                string mensaje = registrarRendicion();
                MessageBox.Show(mensaje);
                if(mensaje.Contains("Exitosamente"))
                    this.Hide();
            }
        }

        private string registrarRendicion()
        {
            List<BDParametro> listParametros = new List<BDParametro>();
            BDHandler handler = new BDHandler();
            listParametros.Add(new BDParametro("@rend_chofer", idChofer));
            listParametros.Add(new BDParametro("@rend_turno", idTurno));
            listParametros.Add(new BDParametro("@rend_fecha", datetimeFecha.Value));
            listParametros.Add(new BDParametro("@rend_total", montoTotal));
            listParametros.Add(new BDParametro("@pcj", Program.pcjRend));
            listParametros.Add(new BDParametro("@mensaje", "", SqlDbType.VarChar, 200, ParameterDirection.Output));
            handler.execSP("LJDG.crear_rendicion", ref listParametros);
            return listParametros[listParametros.Count - 1].valor.ToString();
        }
   
        private void datetimeFecha_ValueChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void Rendicion_Load(object sender, EventArgs e)
        {
            lblPcjValor.Text = Program.pcjRend.ToString();
            datetimeFecha.Value = DateTime.Today;
            cmbTurno.DataSource = Turno.obtenerTurnos();
            cmbTurno.DisplayMember = "Descripcion";
            var turnoSeleccionado = (Turno)cmbTurno.SelectedItem;
            idTurno = turnoSeleccionado.ID_Turno;
            dgViajes.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgViajes.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        }

        private void cmbTurno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var turnoSeleccionado = (Turno)cmbTurno.SelectedItem;
            idTurno = turnoSeleccionado.ID_Turno;
            buscar();
        }

    }
}
