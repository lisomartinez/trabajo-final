using System;

namespace Entidades
{
    public class EntradaCola : Entidad
    {
        public Turno Turno { get; set; }
        public SolicitudAsistenciaTecnica Solicitud { get; set; }

        public EntradaCola(ColaTurnoId id,  Turno turno, SolicitudAsistenciaTecnica solicitud) : base(id)
        {
            Turno = turno;
            Solicitud = solicitud;
        }
        public EntradaCola(Turno turno, SolicitudAsistenciaTecnica solicitud) : base(Entidades.Id.Empty)
        {
            Turno = turno;
            Solicitud = solicitud;
        }


        public int Prioridad => DateTime.Now.Subtract(Turno.Inicio).Minutes;
        public int Jerarquia => Solicitud.Usuario.Categoria.Valor;
    }
}