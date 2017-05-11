using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace UberFrba
{
    public class BDHandler
    {
        /* Levanta la configuración desde App.config */
        public SqlConnection conexionBD = new SqlConnection(ConfigurationManager.AppSettings["BDConfig"]);

        /****** Ejecuta un SP y devuelve un Listado del tipo DataTable ******/
        /* Recibe el nombre del SP y la lista de Parametros */
        public DataTable Listado(String nameStoredProcedure, List<BDParametro> listParametros)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter;
            try {
                Conectar();
                dataAdapter = new SqlDataAdapter(nameStoredProcedure, conexionBD);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (listParametros != null)
                    for (int i = 0; i < listParametros.Count; i++)
                        dataAdapter.SelectCommand.Parameters.AddWithValue(listParametros[i].nombre, listParametros[i].valor);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex) {
                throw ex;
            }
            Desconectar();
            return dataTable;
        }

        /* Recibe el nombre del SP y la lista de Parametros */
        public void execStoredProcedure(String nameStoredProcedure, ref List<BDParametro> listParametros) {
            SqlCommand comando;
            try {
                Conectar();
                comando = new SqlCommand(nameStoredProcedure, conexionBD);
                comando.CommandType = CommandType.StoredProcedure;
                if (listParametros != null) {
                    for (int i = 0; i < listParametros.Count; i++) {
                        if (listParametros[i].direccion == ParameterDirection.Input)
                            comando.Parameters.AddWithValue(listParametros[i].nombre, listParametros[i].valor);
                        if (listParametros[i].direccion == ParameterDirection.Output)
                            comando.Parameters
                                .Add(listParametros[i].nombre, listParametros[i].tipoDato, listParametros[i].tamanio)
                                .Direction = ParameterDirection.Output;
                    }
                    comando.ExecuteNonQuery();
                    for (int i = 0; i < listParametros.Count; i++)
                        if (comando.Parameters[i].Direction == ParameterDirection.Output)
                            listParametros[i].valor = comando.Parameters[i].Value;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
            Desconectar();
        }
        
        public void Conectar()
        {
            if (conexionBD.State == ConnectionState.Closed)
                conexionBD.Open();
        }

        public void Desconectar()
        {
            if (conexionBD.State == ConnectionState.Open)
                conexionBD.Close();
        }
    }
}
