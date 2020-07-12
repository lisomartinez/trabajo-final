using System.Collections.Generic;
using System.Data;
using System.Linq;
using AccesoDatos;
using Entidades;
using Repositorios;

namespace Servicios
{
    public class EstadoAsistenciaRepositorio : SqlRepositorio<EstadoAsistenciaTecnica>
    {
        private const string CODIGO = "@Id";
        private const string NOMBRE = "@Nombre";
        private const string DESCRIPCION = "@Descripcion";

        private const string ObtenerTodosEstado = "ObtenerTodosEstado";
        private const string ObtenerEstadoPorId = "ObtenerEstadoPorId";
        private const string GuardarEstado = "GuardarEstado";
        private const string ActualizarEstado = "ActualizarEstado";
        private const string EliminarEstadoPorId = "EliminarEstadoPorId";

        public EstadoAsistenciaRepositorio() : base(AccesoADatos.Instance)
        {
        }

        public override EstadoAsistenciaTecnica Guardar(EstadoAsistenciaTecnica entidad)
        {
            var id = _accesoADatos.Escribir(GuardarEstado, Parametros(entidad));
            entidad.Id = new CodigoEstadoAsistencia(id);
            return entidad;
        }

        private Dictionary<string, object> Parametros(EstadoAsistenciaTecnica entidad)
        {
            return new Dictionary<string, object>
            {
                {CODIGO, entidad.Id.AsInt()},
                {NOMBRE, entidad.Nombre},
                {DESCRIPCION, entidad.Descripcion}
            };
        }

        public override void Actualizar(EstadoAsistenciaTecnica entidad)
        {
            _accesoADatos.Escribir(ActualizarEstado, Parametros(entidad));
        }

        public override EstadoAsistenciaTecnica Obtener(Id id)
        {
            return _accesoADatos.Leer(ObtenerEstadoPorId, ParametroId(id))
                .AsEnumerable()
                .Select(ToEstado)
                .ToList()[0];
        }

        private EstadoAsistenciaTecnica ToEstado(DataRow fila)
        {
            return new EstadoAsistenciaTecnica(
                codigo: new CodigoEstadoAsistencia(fila["Id"] as int? ?? 0),
                nombre: fila["Nombre"] as string,
                descripcion: ""
            );
        }

        private Dictionary<string, object> ParametroId(Id id)
        {
            return new Dictionary<string, object>
            {
                {CODIGO, id.AsInt()}
            };
        }

        public override List<EstadoAsistenciaTecnica> ObtenerTodos()
        {
            return _accesoADatos.Leer(ObtenerTodosEstado, null)
                .AsEnumerable()
                .Select(ToEstado)
                .ToList();
        }

        public override void Eliminar(Id id)
        {
            _accesoADatos.Escribir(EliminarEstadoPorId, ParametroId(id));
        }
    }
}