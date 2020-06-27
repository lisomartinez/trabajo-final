using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace AccesoDatos
{
    public class AccesoADatos
    {
        private SqlConnection _conexion;
        private SqlTransaction _transaction;

        public int Escribir(string consulta, Dictionary<string, object> parametros = null)
        {
            return 0;
        }

        public DataTable Leer(string consulta, Dictionary<string, object> parametros = null)
        {
            return null;
        }
    }
}