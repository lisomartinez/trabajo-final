using System.Collections.Generic;
using System.Linq;

namespace Entidades
{
    public class ColaTurnos : Entidad
    {
        private List<EntradaCola> _cola;
        public ColaTurnos(ColaTurnoId id, List<EntradaCola> entradas) : base(id)
        {
            _cola = entradas;
        }

        public List<EntradaCola> Entradas => _cola;

        public void Agregar(EntradaCola entradaColas)
        {
            _cola.Add(entradaColas);
        }

        public void Repriorizar()
        {
            for (int i = 0; i < _cola.Count; i += 1)
            {
                for (int j = 3; j < _cola.Count; j += 1)
                {
                    if (_cola[i].Prioridad < _cola[j].Prioridad && _cola[i].Turno.Inicio.CompareTo(_cola[j].Turno.Inicio) < 0)
                    {
                        var temp = _cola[i].Turno;
                        _cola[i].Turno = _cola[j].Turno;
                        _cola[j].Turno = temp;
                    }       
                }
            }
        }

        public List<Turno> ExtraerTurnos(SolicitudAsistenciaTecnica solicitud)
        {
            var turnos = _cola.Where(e => e.Solicitud.Id.Equals(solicitud.Id))
                .Select(e => e.Turno)
                .ToList();
            _cola = Entradas.Where(e => !e.Solicitud.Id.Equals(solicitud.Id)).ToList();
            return turnos;
        }
    }
}