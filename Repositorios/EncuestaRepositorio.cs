using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using AccesoDatos;
using Entidades;

namespace Repositorios
{
    public class EncuestaRepositorio : SqlRepositorio<Encuesta>
    {
        private const string CODIGO = "@Codigo";
        private const string FECHA = "@Fecha";
        private const string VIGENTE = "@Vigente";

        public EncuestaRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override Encuesta Guardar(Encuesta entidad)
        {
            var id = _accesoADatos.Escribir("GuardarEncuesta", Parametros(entidad));
            entidad.Id = new CodigoEncuesta(id);
            return entidad;
        }

        private Dictionary<string, object> Parametros(Encuesta entidad)
        {
            return new Dictionary<string, object>
            {
                {CODIGO, entidad.Id.AsInt()},
                {FECHA, entidad.FechaCreacion},
                {VIGENTE, entidad.Vigente}
            };
        }

        public override void Actualizar(Encuesta entidad)
        {
            _accesoADatos.Escribir("ActualizarEncuesta", Parametros(entidad));
        }

        public override Encuesta Obtener(Id id)
        {
            return _accesoADatos.Leer("ObtenerEncuestaPorId", ParametroId(id))
                .AsEnumerable()
                .Select(ToEncuesta)
                .ToList()[0];
        }

        private Encuesta ToEncuesta(DataRow fila)
        {
            return new Encuesta(
                codigoEncuesta: new CodigoEncuesta(fila["codigo"] as int? ?? 0),
                fechaCreacion: DateTime.Parse(fila["fecha"] as string),
                vigente: fila["vigente"] as bool? ?? false,
                preguntas: new List<Pregunta>()
                );
        }

        private Dictionary<string, object> ParametroId(Id id)
        {
            return new Dictionary<string, object>
            {
                {CODIGO, id.AsInt()},

            };
        }

        public override List<Encuesta> ObtenerTodos()
        {
            return _accesoADatos.Leer("ObtenerTodosEncuesta", null)
                .AsEnumerable()
                .Select(ToEncuesta)
                .ToList();
        }

        public override void Eliminar(Id id)
        {
            _accesoADatos.Escribir("EliminarEncuestaPorId", ParametroId(id));
        }

        public Encuesta ObtenerMasReciente()
        {
            return _accesoADatos.Leer("ObtenerEncuestaMasReciente", null)
                .AsEnumerable()
                .Select(ToEncuesta)
                .ToList()[0];
        }
    }
}