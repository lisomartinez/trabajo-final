using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Encuesta : Entidad
    {
        // public CodigoEncuesta CodigoEncuesta { get; }
        public DateTime FechaCreacion { get; set; }
        public bool Vigente { get; set; }
        public List<Pregunta> Preguntas { get; set; }

        public Encuesta(CodigoEncuesta codigoEncuesta) : base(codigoEncuesta)
        {
 
        }

        public Encuesta(CodigoEncuesta codigoEncuesta, DateTime fechaCreacion, bool vigente, List<Pregunta> preguntas) : base(codigoEncuesta)
        { 
            FechaCreacion = fechaCreacion;
            Vigente = vigente;
            Preguntas = preguntas;
        }
    }
}