using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace UberFrba
{
    public class BDParametro
    {
        public String nombre { get; set; }
        public Object valor { get; set; }
        public SqlDbType tipoDato { get; set; }
        public int tamanio { get; set; }
        public ParameterDirection direccion { get; set; }

        /* Constructor para parametros de entrada */
        public BDParametro(String _nombre, Object _valor) {
            nombre = _nombre;
            valor = _valor;
            direccion = ParameterDirection.Input;
        }

        /* Constructor para parametros de salida */
        public BDParametro(String _nombre, Object _valor,
                SqlDbType _tipoDato, int _tamanio, ParameterDirection _direccion)
        {
            nombre = _nombre;
            valor = _valor;
            tipoDato = _tipoDato;
            tamanio = _tamanio;
            direccion = _direccion;
        }

    }
}
