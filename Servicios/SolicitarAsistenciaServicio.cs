using System;
using System.Collections.Generic;
using Entidades;
using Repositorios;

namespace Servicios
{
    public class SolicitarAsistenciaServicio
    {
        private readonly SolicitudAsistenciaRepositorio _solicitudAsistenciaRepositorio;
        private readonly AsistenciaTecnicaRepositorio _asistenciaTecnicaRepositorio;
        private readonly EstadisticasAsistenciaTecnicaServicio _estadisticasAsistenciaTecnicaServicio;
        private readonly TurnoServicio _turnoServicio;

        public SolicitarAsistenciaServicio(SolicitudAsistenciaRepositorio solicitudAsistenciaRepositorio, AsistenciaTecnicaRepositorio asistenciaTecnicaRepositorio, EstadisticasAsistenciaTecnicaServicio estadisticasAsistenciaTecnicaServicio, TurnoServicio turnoServicio)
        {
            _solicitudAsistenciaRepositorio = solicitudAsistenciaRepositorio;
            _asistenciaTecnicaRepositorio = asistenciaTecnicaRepositorio;
            _estadisticasAsistenciaTecnicaServicio = estadisticasAsistenciaTecnicaServicio;
            _turnoServicio = turnoServicio;
        }

        public List<Turno> SolicitarTurno(SolicitudAsistenciaTecnica solicitud)
        {
            _estadisticasAsistenciaTecnicaServicio.ComputarEstadisticas(solicitud);
            _solicitudAsistenciaRepositorio.Guardar(solicitud);

            return _turnoServicio.OfrecerTurno(solicitud);
        }

        public void ConfirmarTurno(SolicitudAsistenciaTecnica solicitud)
        {
            _turnoServicio.ObtenerTurnosReservador(solicitud);
            _solicitudAsistenciaRepositorio.Actualizar(solicitud);
            _turnoServicio.LiberarNoEscogidos(solicitud);
            _asistenciaTecnicaRepositorio.Guardar(solicitud.CrearAsistencia());
        }


    }
}