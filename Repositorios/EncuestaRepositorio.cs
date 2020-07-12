using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using AccesoDatos;
using Entidades;

namespace Repositorios
{
    public class EncuestaRepositorio : SqlRepositorio<Encuesta>
    {
        private const string CODIGO = "@Codigo";
        private const string FECHA = "@Fecha";
        private const string VIGENTE = "@Vigente";
        private const string GuardarEncuesta = "GuardarEncuesta";
        private const string ActualizarEncuesta = "ActualizarEncuesta";
        private const string ObtenerEncuestaPorId = "ObtenerEncuestaPorId";
        private const string ObtenerTodosEncuesta = "ObtenerTodosEncuesta";
        private const string EliminarEncuestaPorId = "EliminarEncuestaPorId";
        private const string ObtenerEncuestaMasReciente = "ObtenerEncuestaMasReciente";
        private const string ObtenerPreguntas = "ObtenerPreguntasDeEncuesta";

        public EncuestaRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override Encuesta Guardar(Encuesta entidad)
        {
            var id = _accesoADatos.Escribir(GuardarEncuesta, Parametros(entidad));
            _accesoADatos.Escribir(GuardarPreguntas(entidad.Id.AsInt(), entidad.Preguntas));
            entidad.Id = new CodigoEncuesta(id);
            return entidad;
        }

        private string GuardarPreguntas(int id, List<Pregunta> preguntas)
        {
            var query = new StringBuilder();
            query.Append($"DELETE FROM Pregunta WHERE EncuestaCodigo {id}");
            query.Append(
                "INERT INTO Pregunta(Numero, EncuestaCodigo, Texto, PesoRelativo, PuntajeMinimo, PuntajeMaximo) ");
            preguntas.ForEach(p =>
            {
                query.Append(
                    $"VALUES({p.Numero}, {id}, {p.Texto}, {p.PesoRelativo}, {p.PuntajeMinimo}, {p.PuntajeMaximo}) ");
            });
            query.Append(";");
            return query.ToString();
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
            _accesoADatos.Escribir(ActualizarEncuesta, Parametros(entidad));
            _accesoADatos.Escribir(GuardarPreguntas(entidad.Id.AsInt(), entidad.Preguntas));
        }

        public override Encuesta Obtener(Id id)
        {
            return _accesoADatos.Leer(ObtenerEncuestaPorId, ParametroId(id))
                .AsEnumerable()
                .Select(ToEncuesta)
                .ToList()[0];
        }

        private Encuesta ToEncuesta(DataRow fila)
        {
            return new Encuesta(
                new CodigoEncuesta(fila["Codigo"] as int? ?? 0),
                fila["FechaCreacion"] as DateTime? ?? new DateTime(),
                fila["Vigente"] as bool? ?? false,
                new List<Pregunta>()
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
            return _accesoADatos.Leer(ObtenerTodosEncuesta, null)
                .AsEnumerable()
                .Select(ToEncuesta)
                .ToList();
        }

        public override void Eliminar(Id id)
        {
            _accesoADatos.Escribir(EliminarEncuestaPorId, ParametroId(id));
        }

        //TODO: Should Most recent Survey be determined by date or validity?
        public Encuesta ObtenerMasReciente()
        {
            return _accesoADatos.Leer(ObtenerEncuestaMasReciente, null)
                .AsEnumerable()
                .Select(ToEncuesta)
                .ToList()[0];
        }

        public List<Pregunta> ObtenerPreguntasDeEncuesta(Encuesta encuesta)
        {
            return _accesoADatos.Leer(ObtenerPreguntas, ParametroId(encuesta.Id))
                .AsEnumerable()
                .Select(ToPregunta)
                .ToList();
        }

        private Pregunta ToPregunta(DataRow fila)
        {
            return new Pregunta(
                fila["Numero"] as int? ?? 0,
                fila["Texto"] as string,
                fila["PesoRelativo"] as decimal? ?? 0,
                fila["PuntajeMaximo"] as decimal? ?? 0,
                fila["PuntajeMinimo"] as decimal? ?? 0
            );
        }
    }
}