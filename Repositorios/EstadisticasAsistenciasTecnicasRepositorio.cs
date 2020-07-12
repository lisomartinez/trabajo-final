using System.Collections.Generic;
using System.Data;
using System.Linq;
using AccesoDatos;
using Entidades;

namespace Repositorios
{
    public class EstadisticasAsistenciasTecnicasRepositorio : SqlRepositorio<EstadisticasAsistenciasTecnicas>
    {
        public EstadisticasAsistenciasTecnicasRepositorio(AccesoADatos instance) : base(AccesoADatos.Instance)
        {
        }

        public override EstadisticasAsistenciasTecnicas Guardar(EstadisticasAsistenciasTecnicas entidad)
        {
             _accesoADatos.Escribir("GuardarEstadisticasAsistenciaTecnica", Parametro(entidad));
             return entidad;
        }

        private Dictionary<string, object> Parametro(EstadisticasAsistenciasTecnicas entidad)
        {
            return new Dictionary<string, object>
            {
                {"@Id", 1},
                {"@Inicio", entidad.TiempoInicio},
                {"@Duracion", entidad.TiempoDuracion},
                {"@Finalizacion", entidad.TiempoFinalizacion},
                {"@Calificacion", entidad.Calificacion},
                {"@Cantidad", entidad.Cantidad}
            };
        }

        public override void Actualizar(EstadisticasAsistenciasTecnicas entidad)
        {
            _accesoADatos.Escribir("GuardarEstadisticasAsistenciaTecnica", Parametro(entidad));
        }

        public override EstadisticasAsistenciasTecnicas Obtener(Id id)
        {
            throw new System.NotImplementedException();
        }

        public override List<EstadisticasAsistenciasTecnicas> ObtenerTodos()
        {
            return _accesoADatos.Leer("ObtenerTodosEstadisticaAsistencia", null)
                .AsEnumerable()
                .Select(ToEstadistica)
                .ToList();
        }

        public override void Eliminar(Id id)
        {
            throw new System.NotImplementedException();
        }

        public EstadisticasAsistenciasTecnicas ObtenerUltima()
        {
            return _accesoADatos.Leer("ObtenerEstadisticaAsistenciaMasReciente", null)
                .AsEnumerable()
                .Select(ToEstadistica)
                .ToList()[0];
        }

        private EstadisticasAsistenciasTecnicas ToEstadistica(DataRow fila)
        {
            return new EstadisticasAsistenciasTecnicas(
                id: new EstadisticasAsistenciaId(fila["Id"] as int? ?? 0),
                tiempoInicio: fila["Inicio"] as decimal? ?? 0,
                tiempoDuracion: fila["Duracion"] as decimal? ?? 0,
                tiempoFinalizacion: fila["Finalizacion"] as decimal? ?? 0,
                calificacion: fila["Calificacion"] as decimal? ?? 0,
                cantidad: fila["Cantidad"] as int? ?? 0
            );
        }
    }
}