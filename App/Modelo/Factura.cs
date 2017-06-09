using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
namespace UberFrba.Modelo
{
    class Factura
    {
        private int _fact_nro;
        private DateTime _fact_fecha_inicio;
        private DateTime _fact_fecha_fin;
        private DateTime _fact_fecha;
        private int _fact_cliente;
        private decimal _fact_total;

        public int fact_nro
        {
            get { return _fact_nro; }
            set { _fact_nro = value; }
        }

        public int fact_cliente
        {
            get { return _fact_cliente; }
            set { _fact_cliente = value; }
        }

        public decimal fact_total
        {
            get { return _fact_total; }
            set { _fact_total = value; }
        }

        public DateTime fact_fecha
        {
            get { return _fact_fecha; }
            set { _fact_fecha = value; }
        }

        public DateTime fact_fecha_inicio
        {
            get { return _fact_fecha_inicio; }
            set { _fact_fecha_inicio = value; }
        }

        public DateTime fact_fecha_fin
        {
            get { return _fact_fecha_fin; }
            set { _fact_fecha_fin = value; }
        }

        public static void insertarFactura(int fact_cliente, decimal fact_total, DateTime fact_fecha, DateTime fact_fecha_inicio, DateTime fact_fecha_fin)
        {
            List<BDParametro> listParametros = new List<BDParametro>();

            BDHandler handler = new BDHandler();
            listParametros.Add(new BDParametro("@fact_cliente", fact_cliente));
            listParametros.Add(new BDParametro("@fact_total", fact_total));
            listParametros.Add(new BDParametro("@fact_fecha", fact_fecha));
            listParametros.Add(new BDParametro("@fact_fecha_inicio", fact_fecha_inicio));
            listParametros.Add(new BDParametro("@fact_fecha_fin", fact_fecha_fin));
            handler.execSP("LJDG.crear_factura", ref listParametros);

        }
    }

}
