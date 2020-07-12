using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;
using Repositorios;

namespace Servicios
{
    internal class AgendaServicio
    {
        private TurnoRepositorio _repositorio;
        private TecnicoServicio _tecnicoServicio;
        public AgendaServicio()
        {
            _repositorio = new TurnoRepositorio();
            _tecnicoServicio = new TecnicoServicio();
        }

        //TODO: Handle assistant duration by stats.
        public List<Turno> TurnosDisponibles()
        {
            var duracion = new TimeSpan(1, 0, 0);
            var turnosHoy = _repositorio.ObtenerTurnosDesdeFecha(DateTime.Today);
            var proximo = 15.0;
            var enElFuturo = turnosHoy.Where(t => t.Inicio.Add(t.Duracion).CompareTo(DateTime.Now) > 0)
                .Select(t =>
                {
                    t.Id = new TurnoId(-1);
                    t.Inicio = t.Inicio.Add(t.Duracion).AddMinutes(proximo);
                    t.Duracion = duracion;
                    proximo += 60.0;
                    return t;
                })
                .ToList();
            var tecnicos = _tecnicoServicio.ObtenerTodos();
            proximo = 15;
            var turnosDeTecnicosDisponibles = tecnicos.Where(tec => enElFuturo.Count(t => t.Tecnico.Id.Equals(tec.Id)) == 0)
                .Select(tec =>
                {
                    var t = new Turno(new TurnoId(-1), DateTime.Now.AddMinutes(proximo), duracion, tec);
                    proximo += 60.0;
                    return t;
                }).ToList();

            var turnos = turnosDeTecnicosDisponibles.Concat(enElFuturo)
                .OrderBy(t => t.Inicio)
                .ToList();
            return turnos;
        }

        public List<Turno> Reservar(SolicitudAsistenciaTecnica solicitud, List<Turno> mejoresTurnos)
        {
            return mejoresTurnos.Select(t => _repositorio.GuardarConReserva(solicitud, t)).ToList();
        }

        public List<Turno> ObtenerTurnosReservados(SolicitudAsistenciaTecnica solicitud)
        {
            return _repositorio.ObtenerPorSolicitud(solicitud);
        }

        public void LiberarNoEscogidos(SolicitudAsistenciaTecnica solicitud, List<Turno> turnos)
        {
            _repositorio.EliminarReserva(solicitud);
            turnos.Where(t => !t.TurnoId.Equals(solicitud.Turno.Id))
                .ToList()
                .ForEach(t => _repositorio.Eliminar(t.Id));
            
        }
    }
}