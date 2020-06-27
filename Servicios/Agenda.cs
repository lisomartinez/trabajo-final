using System;
using System.Collections.Generic;
using Entidades;

namespace Servicios
{
    internal class Agenda
    {
        private TurnoRepositorio _turnoRepositorio;

        public List<Turno> TurnosDisponibles()
        {
            throw new NotImplementedException();
        }

        public void Reservar(List<Turno> mejoresTurnos)
        {
            throw new NotImplementedException();
        }

        public List<Turno> ObtenerTurnosReservador(SolicitudAsistenciaTecnica solicitud)
        {
            throw new NotImplementedException();
        }

        public void LiberarNoEscogidos(SolicitudAsistenciaTecnica solicitud)
        {
            throw new NotImplementedException();
        }
    }
}