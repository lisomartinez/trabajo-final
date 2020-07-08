using System;

namespace Entidades
{
    public class Turno : Entidad
    {
        public TurnoId TurnoId => new TurnoId(TurnoId.AsInt());
        public TimeSpan Duracion { get; set; }
        public Usuario Tecnico { get; set; }


        public Turno(TurnoId id, TimeSpan duracion, Usuario tecnico) : base(id)
        {
            Duracion = duracion;
            Tecnico = tecnico;
        }
    }
}