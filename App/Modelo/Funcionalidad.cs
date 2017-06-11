using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
namespace UberFrba.Modelo
{
    class Funcionalidad
    {
        private int _ID_Funcionalidad;
        private string _Descripcion;

        public int ID_Funcionalidad
        {
            get { return _ID_Funcionalidad; }
            set { _ID_Funcionalidad = value; }
        }
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public static List<Funcionalidad> obtenerFuncionalidades()
        {
            var miLista = new List<Funcionalidad>();
            List<BDParametro> listParametros = new List<BDParametro>();
            BDHandler handler = new BDHandler();

            miLista = handler.execSelectSP("LJDG.obtener_funcionalidades")
                .AsEnumerable()
                .Select(m => new Funcionalidad()
                {
                    ID_Funcionalidad = m.Field<int>("ID_Funcionalidad"),
                    Descripcion = m.Field<string>("Descripcion"),
                }).ToList();
            //.AsEnumerable()
            //.Select(r => r[0].ToString()).ToList();
            return miLista;
        }

        public static List<Funcionalidad> obtenerFuncxRol(int idRol)
        {
            var miLista = new List<Funcionalidad>();
            List<BDParametro> listParametros = new List<BDParametro>();

            BDHandler handler = new BDHandler();
            listParametros.Add(new BDParametro("@rol_id", idRol));
            miLista = handler.execSelectSP("LJDG.obtener_funcionalidadesxrol", listParametros)
               .AsEnumerable()
               .Select(m => new Funcionalidad()
               {
                   ID_Funcionalidad = m.Field<int>("ID_Funcionalidad"),
                   Descripcion = m.Field<string>("Descripcion")
               }).ToList();
            //.AsEnumerable()
            //.Select(r => r[0].ToString()).ToList();
            return miLista;
        }

        public static void insertarFuncxRol(int idRol, int idFuncionalidad)
        {
            List<BDParametro> listParametros = new List<BDParametro>();

            BDHandler handler = new BDHandler();
            listParametros.Add(new BDParametro("@rol_id", idRol));
            listParametros.Add(new BDParametro("@func_id", idFuncionalidad));
            handler.execSP("LJDG.crear_funcxrol", ref listParametros);
        }
    }

}
