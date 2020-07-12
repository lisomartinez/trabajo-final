using System;
using Entidades;

namespace Modelo
{
    public class TurnoModelo
    {
        public int Id { get; }
        public TimeSpan Duracion { get; set; }
        public UsuarioModelo Tecnico { get; set; }
        public DateTime Inicio { get; set; }


        public TurnoModelo(int id, DateTime inicio, TimeSpan duracion, UsuarioModelo tecnico)
        {
            Id = id;
            Duracion = duracion;
            Tecnico = tecnico;
            Inicio = inicio;
        }

        public static TurnoModelo From(Turno turno)
        {
            return new TurnoModelo(
                id: turno.TurnoId.AsInt(),
                inicio: turno.Inicio,
                duracion: turno.Duracion,
                tecnico: UsuarioModelo.From(turno.Tecnico)
            );
        }

        public Turno ToEntity()
        {
            return new Turno(
                id: new TurnoId(Id),
                inicio: Inicio,
                duracion: Duracion,
                tecnico: Tecnico.ToEntity()
            );
        }
    }
}