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

        int idChofer;
        int idAuto;
        int idCliente;
        int cantKMs;
        int turno;
        decimal precio;
        DateTime fechaHoraInicio;
        DateTime fechaHoraFin;

        BDHandler bdHandler = new BDHandler();

        public RegistroViaje()
        {
            InitializeComponent();
            datetimeHoraInicio.Format=DateTimePickerFormat.Custom;
            datetimeHoraInicio.CustomFormat = "HH:mm";
            datetimeHoraInicio.ShowUpDown= true;
            datetimeHoraFin.Format = DateTimePickerFormat.Custom;
            datetimeHoraFin.CustomFormat = "HH:mm";
            datetimeHoraFin.ShowUpDown = true;
            datetimeFecha.Value = DateTime.Today;
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
            setAuto(id);
        }

        private void setAuto(int _idChofer)
        {
            List<BDParametro> listParametros = new List<BDParametro>();
            listParametros.Add(new BDParametro("@idChofer", _idChofer));
            listParametros.Add(new BDParametro("@idAuto", 0, SqlDbType.Int, 0, ParameterDirection.Output));
            listParametros.Add(new BDParametro("@marca", "", SqlDbType.VarChar, 255, ParameterDirection.Output));
            listParametros.Add(new BDParametro("@modelo", "", SqlDbType.VarChar, 255, ParameterDirection.Output));
            listParametros.Add(new BDParametro("@turno", 0, SqlDbType.Int, 0, ParameterDirection.Output));
            bdHandler.execSP("LJDG.obtener_auto_habilitado_chofer", ref listParametros);
            if (String.IsNullOrEmpty(listParametros[2].valor.ToString()))
            {
                MessageBox.Show("El chofer no posse automóvil habilitado.");
                idChofer = 0;
                idAuto = 0;
                lblIDChoferValor.Text = "";
                lblNombreChoferValor.Text = "";
                lblApellidoChoferValor.Text = "";
                lblIDAutoValor.Text = "";
                lblMarcaAutoValor.Text = "";
                lblModeloAutoValor.Text = "";
                lblIDTurnoAutoValor.Text = "";
                this.Focus();
            }
            else
            {
                idChofer = _idChofer;
                idAuto = int.Parse(listParametros[1].valor.ToString());
                lblIDAutoValor.Text = listParametros[1].valor.ToString();
                lblMarcaAutoValor.Text = listParametros[2].valor.ToString();
                lblModeloAutoValor.Text = listParametros[3].valor.ToString();
                lblIDTurnoAutoValor.Text = listParametros[4].valor.ToString();
            }
        }

        private void lnkCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new BuscarIndividuo(this, "Cliente", 'R').Show();
        }

        public void setCliente(int id, string nombre, string apellido)
        {
            idCliente = id;
            lblIDClienteValor.Text = id.ToString();
            lblNombreClienteValor.Text = nombre;
            lblApellidoClienteValor.Text = apellido;
        }

        private void txtBoxKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46;
        }

        private bool validar()
        {
            if (idChofer == 0)
            {
                MessageBox.Show("Debe ingresar un Chofer con automóvil habilitado.");
                return false;
            }

            if (idCliente == 0)
            {
                MessageBox.Show("Debe ingresar un cliente.");
                return false;
            }

            if (datetimeHoraInicio.Value.Hour > datetimeHoraFin.Value.Hour ||
                datetimeHoraInicio.Value.Hour == datetimeHoraFin.Value.Hour 
                 && datetimeHoraInicio.Value.Minute > datetimeHoraFin.Value.Minute)
            {
                MessageBox.Show("La hora de inicio debe ser menor a la hora de fin.");
                return false;
            }

            if (!int.TryParse(txtBoxKm.Text.ToString(), out cantKMs) || cantKMs < 1)
            {
                MessageBox.Show("Ingrese una cantidad valida de Kilometros.");
                return false;
            }

            /* Validación de los horarios del turno */
            List<BDParametro> lstParamHorarios = new List<BDParametro>();
            lstParamHorarios.Add(new BDParametro("@horaInicio", datetimeHoraInicio.Value.Hour));
            lstParamHorarios.Add(new BDParametro("@horaFin", datetimeHoraFin.Value.Hour));
            lstParamHorarios.Add(new BDParametro("@turnoID", 0, SqlDbType.Int, 0, ParameterDirection.Output));
            lstParamHorarios.Add(new BDParametro("@turnoDescripcion", "", SqlDbType.VarChar, 255, ParameterDirection.Output));
            lstParamHorarios.Add(new BDParametro("@idAuto", idAuto));
            bdHandler.execSP("LJDG.validar_horarios_turno", ref lstParamHorarios);
            lblTurnoValor.Text = lstParamHorarios[3].valor.ToString();
            if (lblIDTurnoAutoValor.Text.ToString() != lstParamHorarios[2].valor.ToString())
            {
                MessageBox.Show("El horario seleccionado no corresponde con el turno del Automóvil.");
                return false;
            }
            turno = int.Parse(lstParamHorarios[2].valor.ToString());

            /* Armo los DateTime completos con fecha y hora*/
            fechaHoraInicio = new DateTime(datetimeFecha.Value.Year,datetimeFecha.Value.Month,datetimeFecha.Value.Day,
                                            datetimeHoraInicio.Value.Hour,datetimeHoraInicio.Value.Minute,0);

            fechaHoraFin = new DateTime(datetimeFecha.Value.Year, datetimeFecha.Value.Month, datetimeFecha.Value.Day,
                                             datetimeHoraFin.Value.Hour, datetimeHoraFin.Value.Minute, 0);

            obtenerPrecio();

            return true;
            //return int.Parse(listParametros[2].valor.ToString()) != 0;
        }

        private void obtenerPrecio()
        {
            List<BDParametro> lstParam = new List<BDParametro>();
            lstParam.Add(new BDParametro("@turno", turno));
            lstParam.Add(new BDParametro("@cantKMs", cantKMs));
            lstParam.Add(new BDParametro("@precio", 0, SqlDbType.Float, 0, ParameterDirection.Output));
            bdHandler.execSP("LJDG.obtener_precio_viaje", ref lstParam);
            precio = Convert.ToDecimal(lstParam[2].valor);
            lblPrecioValor.Text = "$ " + precio.ToString();
        }

        private void registrar()
        {
            List<BDParametro> lstParam = new List<BDParametro>();
            lstParam.Add(new BDParametro("@cantKMs", cantKMs));
            lstParam.Add(new BDParametro("@fechaHoraInicio", fechaHoraInicio));
            lstParam.Add(new BDParametro("@fechaHoraFin", fechaHoraFin));
            lstParam.Add(new BDParametro("@turno", turno));
            lstParam.Add(new BDParametro("@idAuto", idAuto));
            lstParam.Add(new BDParametro("@idChofer", idChofer));
            lstParam.Add(new BDParametro("@idCliente", idCliente));
            lstParam.Add(new BDParametro("@precio", precio));
            lstParam.Add(new BDParametro("@importeRendicion", precio * Program.pcjRend));
            lstParam.Add(new BDParametro("@mensaje", "", SqlDbType.VarChar, 50, ParameterDirection.Output));
            bdHandler.execSP("LJDG.registrar_viaje", ref lstParam);
            MessageBox.Show(lstParam[9].valor.ToString());
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validar())
                registrar();
        }
    }
}
