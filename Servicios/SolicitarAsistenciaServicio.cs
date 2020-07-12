using System;
using System.Collections.Generic;
using AccesoDatos;
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


        public SolicitarAsistenciaServicio()
        {
            _solicitudAsistenciaRepositorio = new SolicitudAsistenciaRepositorio(AccesoADatos.Instance);
            _asistenciaTecnicaRepositorio = new AsistenciaTecnicaRepositorio(AccesoADatos.Instance);
            _estadisticasAsistenciaTecnicaServicio = new EstadisticasAsistenciaTecnicaServicio();
            _turnoServicio = new TurnoServicio();
        }

        public List<Turno> SolicitarTurno(SolicitudAsistenciaTecnica solicitud)
        {
            
            var guardada = _solicitudAsistenciaRepositorio.Guardar(solicitud);

            return _turnoServicio.OfrecerTurno(guardada);
        }

        public void ConfirmarTurno(SolicitudAsistenciaTecnica solicitud)
        {
            var turnos = _turnoServicio.ObtenerTurnosReservador(solicitud);
            _solicitudAsistenciaRepositorio.Actualizar(solicitud);
            _turnoServicio.LiberarNoEscogidos(solicitud, turnos);
            _asistenciaTecnicaRepositorio.Guardar(solicitud.CrearAsistencia());
            _estadisticasAsistenciaTecnicaServicio.ComputarEstadisticas(solicitud);
        }


    }
}