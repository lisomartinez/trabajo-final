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
        public int NoGuardado => -1;

        public static AccesoADatos Instance => _instance ?? (_instance = new AccesoADatos());

        private string _connectionString =
            "Data Source=DESKTOP-6DRD56B;Initial Catalog=Martinez-Trabajo-Final;Integrated Security=True";
        private SqlConnection _conexion;
        private SqlTransaction _transaction;
        
        public void Abrir()
        {
            _conexion = new SqlConnection(_connectionString);
            _conexion.Open();
            if (!_conexion.State.Equals(ConnectionState.Open)) throw new ErrorAlAbrirSqlConnectionException();
        }

        public void Cerrar()
        {
            _conexion.Close();
            _conexion.Dispose();
            _conexion = null;
            GC.Collect();
        }

        public bool Estado()
        {
            return _conexion.State == ConnectionState.Open;
        }


        public DataTable Leer(string storedProcedureNombre, Dictionary<string, object> parametros = null)
        {
            SqlCommand cmd;
            try
            {
                Abrir();
                _transaction = _conexion.BeginTransaction();
                var tabla = new DataTable();
                cmd = new SqlCommand(storedProcedureNombre, _conexion)
                {
                    CommandType = CommandType.StoredProcedure,
                    Transaction = _transaction
                };
                var da = new SqlDataAdapter(cmd);
                if (parametros != null)
                {
                    parametros.Keys.ToList().ForEach(nombre =>
                    {
                        Debug.Write($"{nombre} {parametros[nombre]}");
                        cmd.Parameters.AddWithValue(nombre, parametros[nombre]);
                    });
                }
                da.Fill(tabla);
                _transaction.Commit();
                Cerrar();
                return tabla;
            }
            catch (Exception e)
            {
                _transaction.Rollback();
                throw;
            }

        }
        public int Escribir(string consulta, Dictionary<string, object> datos = null)
        {
            
            SqlCommand cmd;
            try
            {
                Abrir();
                _transaction = _conexion.BeginTransaction();
                cmd = new SqlCommand(cmdText: consulta, connection: _conexion)
                {
                    CommandType = CommandType.StoredProcedure,
                    Transaction = _transaction
                };
                if (datos != null)
                {
                    datos.Keys.ToList().ForEach(s => cmd.Parameters.AddWithValue(s, datos[s]));
                }

                var id = cmd.ExecuteScalar() as int? ?? -1;
                _transaction.Commit();
                return id;

            }
            catch (Exception ex)
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                Cerrar();
            }

        }

  
    }


}