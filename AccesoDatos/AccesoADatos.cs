using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AccesoADatos
    {
        private static AccesoADatos _instance = null;

        public static AccesoADatos Instance => _instance ?? (_instance = new AccesoADatos());

        private SqlConnection _conexion;
        private SqlTransaction _transaction;

        public int Escribir(string consulta, Dictionary<string, object> parametros = null)
        {
            return 0;
        }

        public DataTable Leer(string consulta, Dictionary<string, object> parametros = null)
        {
            return new DataTable(" ");
        }
    }
}