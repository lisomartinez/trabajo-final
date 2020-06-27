using System;
using Entidades;
using Repositorios;

namespace Servicios
{
    public class EstadisticasAsistenciaTecnicaServicio
    {
        private EstadisticasAsistenciasTecnicasRepositorio _estadisticasAsistenciasTecnicas;
        private EstadisticasTecnicosRepositorio _estadisticasTecnicoRepositorio;
        private EstadisticaFallasRepositorio _estadisticaFallasRepositorio;


        public void ComputarEstadisticas(SolicitudAsistenciaTecnica solicitud)
        {
            var valoresActuales = _estadisticaFallasRepositorio.ObtenerValorActual();
            var nuevosValores = valoresActuales.Calcular(solicitud);
            _estadisticaFallasRepositorio.Guardar(nuevosValores);
        }

        public EstadisticasAsistenciasTecnicas ObtenerEstadisticasGenerales()
        {
            throw new NotImplementedException();
        }

        public EstadisticaTecnico ObtenerEstadisticasDeTecnico(Usuario toEntity)
        {
            throw new NotImplementedException();
        }


        public void ComputarEstadisticasActualizacionEstado(AsistenciaTecnica asistenciaTecnica)
        {
            throw new NotImplementedException();
        }
    }
}