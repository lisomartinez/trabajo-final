using System.Collections.Generic;
using Entidades;

namespace Servicios
{
    public class TurnoServicio
    {
        private Agenda _agenda;
        private ColaTurnos _colaTurnos;

        public TurnoServicio()
        {
            _agenda = new Agenda();
            _colaTurnos = new ColaTurnos();
        }

        public List<Turno> OfrecerTurno(SolicitudAsistenciaTecnica solicitud)
        {

            var turnosDisponibles = _agenda.TurnosDisponibles();
            var mejoresTurnos = _colaTurnos.BuscarMejoresTurnos(turnosDisponibles, solicitud);
            _colaTurnos.Actualizar(mejoresTurnos);
            _agenda.Reservar(mejoresTurnos);
            return new List<Turno>();
        }

        public List<Turno> ObtenerTurnosReservador(SolicitudAsistenciaTecnica solicitud)
        {
            return _agenda.ObtenerTurnosReservador(solicitud);
        }

        public void LiberarNoEscogidos(SolicitudAsistenciaTecnica solicitud)
        {
            _agenda.LiberarNoEscogidos(solicitud);
        }
    }
}