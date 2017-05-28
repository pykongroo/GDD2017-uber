using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Text;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba
{
    public class BDHandler
    {
        /* Levanta la configuración desde App.config */
        public SqlConnection conexionBD = new SqlConnection(ConfigurationManager.AppSettings["BDConfig"]);

        /****** Ejecuta un SP y devuelve un Listado del tipo DataTable ******/
        /* Recibe el nombre del SP y la lista de Parametros */
        public DataTable execSelectSP(String nameStoredProcedure, List<BDParametro> listParametros = null)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter;
            try
            {
                Conectar();
                dataAdapter = new SqlDataAdapter(nameStoredProcedure, conexionBD);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (listParametros != null)
                    foreach (BDParametro parametro in listParametros)
                        dataAdapter.SelectCommand.Parameters.AddWithValue(parametro.nombre, parametro.valor);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                //throw e;
            }
            Desconectar();
            return dataTable;
        }

        /* Recibe el nombre del SP y la lista de Parametros */
        public void execSP(String nameStoredProcedure, ref List<BDParametro> listParametros)
        {
            try
            {
                Conectar();
                SqlCommand comando = new SqlCommand(nameStoredProcedure, conexionBD);
                comando.CommandType = CommandType.StoredProcedure;
                if (listParametros != null)
                    foreach (BDParametro parametro in listParametros)
                    {
                        if (parametro.direccion == ParameterDirection.Input)
                            comando.Parameters.AddWithValue(parametro.nombre, parametro.valor);
                        if (parametro.direccion == ParameterDirection.Output)
                            comando.Parameters
                                .Add(parametro.nombre, parametro.tipoDato, parametro.tamanio)
                                .Direction = ParameterDirection.Output;
                    }
                comando.ExecuteNonQuery();
                if (listParametros != null)
                    for (int i = 0; i < listParametros.Count; i++)
                        if (comando.Parameters[i].Direction == ParameterDirection.Output)
                            listParametros[i].valor = comando.Parameters[i].Value;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                //throw e;
            }
            Desconectar();
        }

        /* Devuelve un Lista con la primera columna del Select */
        public List<String> execListSP(String nameStoredProcedure)
        {
            return execSelectSP(nameStoredProcedure)
                .AsEnumerable()
                .Select(r => r[0].ToString()).ToList();
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
