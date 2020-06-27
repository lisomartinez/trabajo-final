using System;

namespace Entidades
{
    public class Turno : Entidad
    {
        
        public TimeSpan Duracion { get; set; }
        public Usuario Tecnico { get; set; }

        public Turno(Id id) : base(id)
        {
        }
    }
}