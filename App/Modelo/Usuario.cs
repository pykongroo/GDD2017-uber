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
                listParametros.Add(new BDParametro("@mensaje", "", SqlDbType.VarChar, 50, ParameterDirection.Output));
                handler.execStoredProcedure("LJDG.IniciarSesion", ref listParametros);
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
                roles = handler.execSelect("LJDG.ObtenerRolesUsuario", listParametros)
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
