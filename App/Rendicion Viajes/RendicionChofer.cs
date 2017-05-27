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

namespace UberFrba.Rendicion_Viajes
{
    public partial class RendicionChofer : Form
    {
        Dictionary<String, String> choferes = new Dictionary<string, string>();
        Dictionary<String, String> turnos = new Dictionary<string, string>();
        public RendicionChofer()
        {
            InitializeComponent();
            init_items();
        }

        public void init_items()
        {
            fechaRendicion_dpicker.setDescription("Fecha Rendicion:");
            cmb_chofer_rendicion.setDescription("Chofer:");
            setChoferes();
            cmb_turno_rendicion.setDescription("Turno:");
            setTurnos();
            importeTotalText.setDescription("Importe Total");
            importeTotalText.inhabilitar();
        }

        private void setChoferes()
        {
            BDHandler bdh = new BDHandler();
            bdh.Conectar();
            SqlConnection conn = bdh.conexionBD;
            String query = "select chof_user, chof_id from LJDG.Chofer where chof_habilitado=1";
            SqlCommand com = new SqlCommand(query, conn);
            var reader = com.ExecuteReader();
            while (reader.Read())
            {
                choferes.Add(reader.GetString(0), reader.GetValue(1).ToString());
                cmb_chofer_rendicion.Add(reader.GetString(0));
            }
            bdh.Desconectar();
        }

        private void setTurnos()
        {
            BDHandler bdh = new BDHandler();
            bdh.Conectar();
            SqlConnection conn = bdh.conexionBD;
            String query = "select turn_descripcion, turn_id from LJDG.Turno where turn_habilitado=1";
            SqlCommand com = new SqlCommand(query, conn);
            var reader = com.ExecuteReader();
            while (reader.Read())
            {
                turnos.Add(reader.GetString(0), reader.GetValue(1).ToString());
                cmb_turno_rendicion.Add(reader.GetString(0));
            }
            bdh.Desconectar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_chofer_rendicion.esValido()&&cmb_turno_rendicion.esValido()) { 
                List<BDParametro> listParametros = new List<BDParametro>();
                try
                {
                    BDHandler handler = new BDHandler();
                    listParametros.Add(new BDParametro("@fecha", fechaRendicion_dpicker.getDate()));
                    listParametros.Add(new BDParametro("@turno", turnos[cmb_turno_rendicion.Text()]));
                    listParametros.Add(new BDParametro("@chofer", choferes[cmb_chofer_rendicion.Text()]));
                    listParametros.Add(new BDParametro("@i_total", 0, SqlDbType.Float, 18, ParameterDirection.Output));
                    listParametros.Add(new BDParametro("@mensaje", "", SqlDbType.VarChar, 50, ParameterDirection.Output));
                    handler.execSP("LJDG.rendiciones_justif", ref listParametros);
                    importeTotalText.setData(listParametros[3].valor.ToString());
                    dgRChofer.DataSource = handler.execSelectSP("LJDG.rendiciones_justif", listParametros);
                    MessageBox.Show(listParametros[4].valor.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw ex;
                }
            } else
            {
                MessageBox.Show("Complete los campos");
            }
        }
    }
}
