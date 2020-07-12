using System;

namespace Entidades
{
    public class Turno : Entidad
    {
        public TurnoId TurnoId => Id as TurnoId;
        public TimeSpan Duracion { get; set; }
        public Usuario Tecnico { get; set; }
        public DateTime Inicio { get; set; }


        public Turno(TurnoId id, DateTime inicio, TimeSpan duracion, Usuario tecnico) : base(id)
        {
            Inicio = inicio;
            Duracion = duracion;
            Tecnico = tecnico;
        }
    }
}