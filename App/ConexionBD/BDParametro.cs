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
        public ParameterDirection direccion { get; set; }
        public int tamanio { get; set; }

        /* Constructor para parametros de entrada */
        public BDParametro(String _nombre, Object _valor) {
            nombre = _nombre;
            valor = _valor;
            direccion = ParameterDirection.Input;
        }

        /* Constructor para parametros de salida */
        public BDParametro(String _nombre, Object _valor,
                SqlDbType _tipoDato, ParameterDirection _direccion, int _tamanio) {
            nombre = _nombre;
            valor = _valor;
            tipoDato = _tipoDato;
            direccion = _direccion;
            tamanio = _tamanio;
        }

    }
}
