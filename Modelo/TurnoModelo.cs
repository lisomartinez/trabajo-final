using System;
using Entidades;

namespace Modelo
{
    public class TurnoModelo
    {
        public int Id { get; }
        public TimeSpan Duracion { get; set; }
        public UsuarioModelo Tecnico { get; set; }

        public TurnoModelo(int id, TimeSpan duracion, UsuarioModelo tecnico)
        {
            Id = id;
            Duracion = duracion;
            Tecnico = tecnico;
        }

        public static TurnoModelo From(Turno turno)
        {
            return new TurnoModelo(
                id: turno.TurnoId.AsInt(),
                duracion: turno.Duracion,
                tecnico: UsuarioModelo.From(turno.Tecnico)
            );
        }

        public Turno ToEntity()
        {
            return new Turno(
                id: new TurnoId(Id),
                duracion: Duracion,
                tecnico: Tecnico.ToEntity()
            );
        }
    }
}