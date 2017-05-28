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

namespace UberFrba.Abm_Automovil
{
    public partial class AltaModiAuto : Form
    {
        private char modo;
        public int idAuto { get; set; }

        public AltaModiAuto(char _modo, int _idAuto)
        {
            InitializeComponent();
            this.modo = _modo;
            if (modo == 'A')
                this.Text = "Alta Automóvil";
            else if (modo == 'M')
            {
                this.Text = "Modificar Automóvil";
                this.idAuto = _idAuto;
                cargarAuto();
            }
            BDHandler handler = new BDHandler();
            cmbMarca.DataSource = handler.execListSP("LJDG.obtener_marcas");
            cmbTurno.DataSource = handler.execListSP("LJDG.obtener_descripcion_turnos");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lnkChofer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new BuscarIndividuo(this, "Chofer", 'S').Show();
        }

        private String guardarAuto()
        {
            BDHandler handler = new BDHandler();
            List<BDParametro> listParametros = new List<BDParametro>();
            listParametros.Add(new BDParametro("@marca", cmbMarca.SelectedIndex + 1));
            listParametros.Add(new BDParametro("@patente", txtBoxPatente.Text));
            listParametros.Add(new BDParametro("@modelo", txtBoxModelo.Text));
            listParametros.Add(new BDParametro("@chofer", int.Parse(lblIDChoferValor.Text.ToString())));
            listParametros.Add(new BDParametro("@turno", cmbTurno.SelectedIndex + 1));
            listParametros.Add(new BDParametro("@habilitado", checkBoxHabilitado.Checked ? 1 : 0));
            listParametros.Add(new BDParametro("@mensaje", "", SqlDbType.VarChar, 50, ParameterDirection.Output));
            if (modo == 'A')
                handler.execSP("LJDG.alta_auto", ref listParametros);
            else if (modo == 'M')
            {
                listParametros.Insert(0, new BDParametro("@id", idAuto));
                handler.execSP("LJDG.modi_auto", ref listParametros);
            }
            return listParametros[listParametros.Count - 1].valor.ToString();
        }

        private void cargarAuto()
        {
            List<BDParametro> listParametros = new List<BDParametro>();
            listParametros.Add(new BDParametro("@id", idAuto));
            listParametros.Add(new BDParametro("@marca", 0, SqlDbType.Int, 0, ParameterDirection.Output));
            listParametros.Add(new BDParametro("@patente", "", SqlDbType.VarChar, 10, ParameterDirection.Output));
            listParametros.Add(new BDParametro("@modelo", "", SqlDbType.VarChar, 255, ParameterDirection.Output));
            listParametros.Add(new BDParametro("@chofer", 0, SqlDbType.Int, 0, ParameterDirection.Output));
            listParametros.Add(new BDParametro("@turno", 0, SqlDbType.Int, 0, ParameterDirection.Output));
            listParametros.Add(new BDParametro("@habilitado", 0, SqlDbType.Bit, 0, ParameterDirection.Output));
            listParametros.Add(new BDParametro("@mensaje", "", SqlDbType.VarChar, 50, ParameterDirection.Output));
            new BDHandler().execSP("LJDG.obtener_auto", ref listParametros);
            cmbMarca.SelectedValue = Convert.ToInt32(listParametros[1].valor.ToString());
            txtBoxPatente.Text = listParametros[2].valor.ToString();
            txtBoxModelo.Text = listParametros[3].valor.ToString();
            lblIDChoferValor.Text = listParametros[4].valor.ToString();
            cmbTurno.SelectedValue = Convert.ToInt32(listParametros[5].valor);
            checkBoxHabilitado.Checked = Convert.ToInt32(listParametros[6].valor) == 1;
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(guardarAuto());
            this.Hide();
        }
    }
}
