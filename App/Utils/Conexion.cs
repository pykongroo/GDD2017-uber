using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba
{
    class Conexion
    {
        private static Conexion instance;
        public SqlConnection con;
        private Conexion()
        {
            String dtSrc = "localhost\\SQLSERVER2012";
            String iniCtlg = "GD1C2017";
            String user = "gd";
            String pass = "gd2017";
            String str_cfg = "Data Source=" + dtSrc + ";Initial Catalog=" + iniCtlg + ";User ID=" + user + ";Password=" + pass;
            this.con = new SqlConnection(str_cfg);
        }

        public static Conexion getInstance()
        {
            if (instance == null)
            {
                instance = new Conexion();
            }
            return instance;
        }

    }
}
