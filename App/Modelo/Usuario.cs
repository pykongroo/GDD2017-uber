using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;

namespace UberFrba.Modelo {

    public class Usuario {

        public string id { get; set; }
        public string password { get; set; }
        public string rol { get; set; }
        public List<String> roles { get; set; }

        public String iniciarSesion() {
            List<BDParametro> listParametros = new List<BDParametro>();
            try {
                BDHandler handler = new BDHandler();
                listParametros.Add(new BDParametro("@usuario", id));
                listParametros.Add(new BDParametro("@pass", password));
                listParametros.Add(new BDParametro("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 200));
                handler.execStoredProcedure("LJDG.iniciar_sesion", ref listParametros);
                return listParametros[2].valor.ToString();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
        }

        public List<String> obtenerRolesUsuario() {
            roles = new List<String>();
            List<BDParametro> listParametros = new List<BDParametro>();
            try {
                BDHandler handler = new BDHandler();
                listParametros.Add(new BDParametro("@usuario", id));
                roles = handler.Listado("LJDG.obtener_roles_usuario", listParametros)
                        .AsEnumerable()
                        .Select(r => r[0].ToString()).ToList();
                return roles;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
        }
    }
}
