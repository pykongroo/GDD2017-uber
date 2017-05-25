using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;

namespace UberFrba.Modelo
{
    class Turno
    {
        private int _ID_Turno;
        private string _Descripcion;
        private decimal _Hora_Inicio;
        private decimal _Hora_Finalizacion;
        private decimal _Valor_Km;
        private decimal _Precio_Base;
        private bool _Habilitado;


        public int ID_Turno
        {
            get { return _ID_Turno; }
            set { _ID_Turno = value; }
        }
        public decimal Hora_Inicio
        {
            get { return _Hora_Inicio; }
            set { _Hora_Inicio = value; }
        }
        public decimal Hora_Finalizacion
        {
            get { return _Hora_Finalizacion; }
            set { _Hora_Finalizacion = value; }
        }

        public decimal Valor_Km
        {
            get { return _Valor_Km; }
            set { _Valor_Km = value; }
        }

        public decimal Precio_Base
        {
            get { return _Precio_Base; }
            set { _Precio_Base = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public bool Habilitado
        {
            get { return _Habilitado; }
            set { _Habilitado = value; }
        }

        public static List<Turno> obtenerTurnos()
        {
            var miLista = new List<Turno>();
            List<BDParametro> listParametros = new List<BDParametro>();
            try
            {
                BDHandler handler = new BDHandler();

                miLista = handler.execSelectSP("LJDG.obtener_turnos")
                    .AsEnumerable()
                    .Select(m => new Turno()
                    {
                        ID_Turno = m.Field<int>("ID_Turno")
                        , Hora_Inicio = m.Field<decimal>("HoraInicio")
                        , Hora_Finalizacion = m.Field<decimal>("HoraFinalizacion")
                        , Descripcion = m.Field<string>("Descripcion")
                        , Valor_Km = m.Field<decimal>("ValorKm")
                        , Precio_Base = m.Field<decimal>("PrecioBase")
                        , Habilitado = m.Field<bool>("Habilitado") 
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

        public static int insertarTurno(string descripcion, decimal horaInicio, decimal horaFin, decimal valorKm, decimal precioBase)
        {
            List<BDParametro> listParametros = new List<BDParametro>();
            try
            {
                BDHandler handler = new BDHandler();
                listParametros.Add(new BDParametro("@descripcion", descripcion));
                listParametros.Add(new BDParametro("@horaInicio", (int)horaInicio));
                listParametros.Add(new BDParametro("@horaFin", (int)horaFin));
                listParametros.Add(new BDParametro("@valorKm", valorKm));
                listParametros.Add(new BDParametro("@precioBase", precioBase));
                listParametros.Add(new BDParametro("@ID", "", SqlDbType.Int, 50, ParameterDirection.Output));
                handler.execSP("LJDG.crear_turno", ref listParametros);

                return Convert.ToInt32(listParametros[1].valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
        }

        public static void eliminarTurno(int turnoId)
        {
            List<BDParametro> listParametros = new List<BDParametro>();
            try
            {
                BDHandler handler = new BDHandler();
                listParametros.Add(new BDParametro("@turno_id", turnoId));
                handler.execSP("LJDG.eliminar_turno", ref listParametros);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
        }

        public static void editarTurno(int turnoId, string descripcion, int horaInicio, int horaFin, decimal valorKm, decimal precioBase, bool turnoHabilitado)
        {
            List<BDParametro> listParametros = new List<BDParametro>();
            try
            {
                BDHandler handler = new BDHandler();
                listParametros.Add(new BDParametro("@turnoId", turnoId));
                listParametros.Add(new BDParametro("@descripcion", descripcion));
                listParametros.Add(new BDParametro("@horaInicio", horaInicio));
                listParametros.Add(new BDParametro("@horaFin", horaFin));
                listParametros.Add(new BDParametro("@valorKm", valorKm));
                listParametros.Add(new BDParametro("@precioBase", precioBase));
                listParametros.Add(new BDParametro("@turnoHabilitado", turnoHabilitado));
                handler.execSP("LJDG.editar_turno", ref listParametros);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
        }
    }
}
