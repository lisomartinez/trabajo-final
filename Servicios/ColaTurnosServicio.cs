using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;

namespace Servicios
{
    public class ColaTurnosServicio
    {
        private ColaTurnosRepositorio _cola;

        public ColaTurnosServicio()
        {
            _cola = new ColaTurnosRepositorio();
        }

        public List<Turno> BuscarMejoresTurnos(List<Turno> turnosDisponibles, SolicitudAsistenciaTecnica solicitud)
        {
            var entradas = _cola.ObtenerEntradas();
            var cola = new ColaTurnos(new ColaTurnoId(1), entradas);
            turnosDisponibles.Select(t => new EntradaCola(t, solicitud))
                .ToList()
                .ForEach(e => cola.Agregar(e));
            cola.Repriorizar();
            var turnos = cola.ExtraerTurnos(solicitud);
            _cola.GuardarCola(cola);
            return turnos;
        }
    }
}