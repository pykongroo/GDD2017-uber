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
            BDHandler handler = new BDHandler();

            miLista = handler.execSelectSP("LJDG.obtener_turnos")
                .AsEnumerable()
                .Select(m => new Turno()
                {
                    ID_Turno = m.Field<int>("ID_Turno")
                    ,
                    Hora_Inicio = m.Field<decimal>("HoraInicio")
                    ,
                    Hora_Finalizacion = m.Field<decimal>("HoraFinalizacion")
                    ,
                    Descripcion = m.Field<string>("Descripcion")
                    ,
                    Valor_Km = m.Field<decimal>("ValorKm")
                    ,
                    Precio_Base = m.Field<decimal>("PrecioBase")
                    ,
                    Habilitado = m.Field<bool>("Habilitado")
                }).ToList();
            //.AsEnumerable()
            //.Select(r => r[0].ToString()).ToList();
            return miLista;
        }

        public static int insertarTurno(string descripcion, decimal horaInicio, decimal horaFin, decimal valorKm, decimal precioBase)
        {
            List<BDParametro> listParametros = new List<BDParametro>();

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

        public static void eliminarTurno(int turnoId)
        {
            List<BDParametro> listParametros = new List<BDParametro>();

            BDHandler handler = new BDHandler();
            listParametros.Add(new BDParametro("@turno_id", turnoId));
            handler.execSP("LJDG.eliminar_turno", ref listParametros);
        }

        public static void editarTurno(int turnoId, string descripcion, decimal horaInicio, decimal horaFin, decimal valorKm, decimal precioBase, int turnoHabilitado)
        {
            List<BDParametro> listParametros = new List<BDParametro>();

            BDHandler handler = new BDHandler();
            listParametros.Add(new BDParametro("@descripcion", descripcion));
            listParametros.Add(new BDParametro("@horaInicio", horaInicio));
            listParametros.Add(new BDParametro("@horaFin", horaFin));
            listParametros.Add(new BDParametro("@valorKm", valorKm));
            listParametros.Add(new BDParametro("@precioBase", precioBase));
            listParametros.Add(new BDParametro("@habilitado", turnoHabilitado));
            listParametros.Add(new BDParametro("@turno_id", turnoId));
            handler.execSP("LJDG.editar_turno", ref listParametros);
        }

        public bool seSolapaCon(decimal nuevaHora_Inicio, decimal nuevaHora_Fin)
        {
            if (nuevaHora_Inicio >= Hora_Inicio && nuevaHora_Inicio < Hora_Finalizacion)
                return true;
            //si la hora de inicio esta entre las 2 horas del turno existente o es igual a la de comienzo
            // ej. turno entre 8 y 16 y mi hora de inicio nueva esta entre 8 y 15, error, si es 16 o 7 OK
            if (nuevaHora_Fin > Hora_Inicio && nuevaHora_Fin <= Hora_Finalizacion)
                return true;
            //si la hora de fin esta entre las 2 horas del turno existente o es igual a la de fin
            // ej. turno entre 8 y 16 y mi hora de fin nueva esta entre 9 y 16, error, si es 17 u 8 OK
            return false;
            //si pasa ambas pruebas esta OK                                                     
        }
    }
}
