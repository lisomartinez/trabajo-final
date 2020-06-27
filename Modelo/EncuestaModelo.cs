using System;
using System.Collections.Generic;
using Entidades;

namespace Vistas
{
    public class EncuestaModelo
    {
        public static EncuestaModelo From(Encuesta encuesta)
        {
            throw new System.NotImplementedException();
        }

        public int Codigo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Vigente { get; set; }
        public List<PreguntaModelo> Preguntas { get; set; }

        public void AgregarPregunta(PreguntaModelo pregunta)
        {
            Preguntas.Add(pregunta);
        }

        public Encuesta ToEntity()
        {
            throw new NotImplementedException();
        }
    }
}