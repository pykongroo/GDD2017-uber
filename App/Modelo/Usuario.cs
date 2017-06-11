using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;

using Helper;

namespace UberFrba.Modelo
{

    public class Usuario
    {

        public string id { get; set; }
        public string password { get; set; }
        public string rol { get; set; }
        public List<String> roles { get; set; }

        public String iniciarSesion()
        {
            List<BDParametro> listParametros = new List<BDParametro>();

            BDHandler handler = new BDHandler();
            listParametros.Add(new BDParametro("@usuario", id));
            listParametros.Add(new BDParametro("@pass", password));
            listParametros.Add(new BDParametro("@mensaje", "", SqlDbType.VarChar, 50, ParameterDirection.Output));
            handler.execSP("LJDG.iniciar_sesion", ref listParametros);
            return listParametros[2].valor.ToString();

        }

        public List<String> obtenerRolesUsuario()
        {
            roles = new List<String>();
            List<BDParametro> listParametros = new List<BDParametro>();

            BDHandler handler = new BDHandler();
            listParametros.Add(new BDParametro("@usuario", id));
            roles = handler.execSelectSP("LJDG.obtener_roles_usuario", listParametros)
                    .AsEnumerable()
                    .Select(r => r[0].ToString()).ToList();
            return roles;

        }

        public static void darDeAlta(String userId, String pass, int rol)
        {
            List<BDParametro> listParametros = new List<BDParametro>();

            BDHandler handler = new BDHandler();
            listParametros.Add(new BDParametro("@userId", userId));
            listParametros.Add(new BDParametro("@pass", pass.Sha256()));
            listParametros.Add(new BDParametro("@rol_id", rol));
            handler.execSP("LJDG.alta_usuario", ref listParametros);
        }
    }
}
