using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;

namespace UberFrba.Modelo
{
    class Rol
    {
        private int _ID_Rol;
        private string _Nombre;
        private bool _Habilitado;


        public int ID_Rol
        {
            get { return _ID_Rol; }
            set { _ID_Rol = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public bool Habilitado
        {
            get { return _Habilitado; }
            set { _Habilitado = value; }
        }

        public List<Rol> obtenerRoles()
        {
            var miLista = new List<Rol>();
            List<BDParametro> listParametros = new List<BDParametro>();
            try
            {
                BDHandler handler = new BDHandler();

                miLista = handler.execSelect("LJDG.obtener_roles")
                    .AsEnumerable()
                    .Select(m => new Rol()
                    {
                        ID_Rol = m.Field<int>("ID_Rol"),
                        Nombre = m.Field<string>("Nombre"),
                        Habilitado = m.Field<bool>("Habilitado"),
                    }).ToList();
                //.AsEnumerable()
                //.Select(r => r[0].ToString()).ToList();
                return miLista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
        }

        public int insertarRol(string nombreRol)
        {
            List<BDParametro> listParametros = new List<BDParametro>();
            try
            {
                BDHandler handler = new BDHandler();
                listParametros.Add(new BDParametro("@nombre", nombreRol));
                listParametros.Add(new BDParametro("@ID", "", SqlDbType.Int, 50, ParameterDirection.Output));
                handler.execStoredProcedure("LJDG.crear_rol", ref listParametros);

                return Convert.ToInt32(listParametros[1].valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
        }

        public void eliminarRol(int rolId)
        {
            List<BDParametro> listParametros = new List<BDParametro>();
            try
            {
                BDHandler handler = new BDHandler();
                listParametros.Add(new BDParametro("@rol_id", rolId));
                handler.execStoredProcedure("LJDG.eliminar_rol", ref listParametros);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
        }

        public void editarRol(int rolId, string rolNombre, int rolHabilitado)
        {
            List<BDParametro> listParametros = new List<BDParametro>();
            try
            {
                BDHandler handler = new BDHandler();
                listParametros.Add(new BDParametro("@rol_id", rolId));
                listParametros.Add(new BDParametro("@rol_nombre", rolNombre));
                listParametros.Add(new BDParametro("@rol_habilitado", rolHabilitado));
                handler.execStoredProcedure("LJDG.editar_rol", ref listParametros);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
        }

    }
}
