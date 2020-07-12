using System;
using System.Collections.Generic;
using AccesoDatos;
using Entidades;
using Repositorios;

namespace Servicios
{
    public class EstadisticasAsistenciaTecnicaServicio
    {
        private EstadisticasAsistenciasTecnicasRepositorio _estadisticasAsistenciasTecnicas;
        private EstadisticasTecnicosRepositorio _estadisticasTecnicoRepositorio;
        private EstadisticaFallasRepositorio _estadisticaFallasRepositorio;
        
        public EstadisticasAsistenciaTecnicaServicio()
        {
            _estadisticasAsistenciasTecnicas = new EstadisticasAsistenciasTecnicasRepositorio(AccesoADatos.Instance);
            _estadisticasTecnicoRepositorio = new EstadisticasTecnicosRepositorio(AccesoADatos.Instance);
        }

        public void ComputarEstadisticas(SolicitudAsistenciaTecnica solicitud)
        {
            if (solicitud.TipoProblema.Nombre != "Falla Hardware")
            {

            }

            var valoresActuales= _estadisticasAsistenciasTecnicas.ObtenerUltima();
            var nuevosValores = valoresActuales.Calcular(solicitud);
            _estadisticasAsistenciasTecnicas.Actualizar(nuevosValores);
        }

        public EstadisticasAsistenciasTecnicas ObtenerEstadisticasGenerales()
        {
            return _estadisticasAsistenciasTecnicas.ObtenerUltima();
        }

        public Dictionary<TipoProblemaId, EstadisticaTecnico> ObtenerEstadisticasDeTecnico(
            TipoProblemaId tipoProblemaId, Legajo legajo)
        {
            return _estadisticasTecnicoRepositorio.ObtenerPorTipoProblemaId(legajo);
        }


        public void ComputarEstadisticasActualizacionEstado(AsistenciaTecnica asistenciaTecnica)
        {
        }

        public EstadisticaFallas ObtenerEstadisticasFallas()
        {
            throw new NotImplementedException();
        }
    }
}