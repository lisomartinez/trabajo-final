using System.Collections.Generic;
using Entidades;
using Repositorios;

namespace Servicios
{
    public class TurnoServicio
    {
        private AgendaServicio _agendaServicio;
        private ColaTurnosServicio _colaTurnosServicio;

        public TurnoServicio()
        {
            _agendaServicio = new AgendaServicio();
            _colaTurnosServicio = new ColaTurnosServicio();
        }

        public List<Turno> OfrecerTurno(SolicitudAsistenciaTecnica solicitud)
        {

            var turnosDisponibles = _agendaServicio.TurnosDisponibles();
            var mejoresTurnos = _colaTurnosServicio.BuscarMejoresTurnos(turnosDisponibles, solicitud);
            return _agendaServicio.Reservar(solicitud, mejoresTurnos);
        }

        public List<Turno> ObtenerTurnosReservador(SolicitudAsistenciaTecnica solicitud)
        {
            return _agendaServicio.ObtenerTurnosReservados(solicitud);
        }

        public void LiberarNoEscogidos(SolicitudAsistenciaTecnica solicitud, List<Turno> turnos)
        {
            _agendaServicio.LiberarNoEscogidos(solicitud, turnos);
        }
    }
}