using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;

namespace Modelo
{
    public class EncuestaModelo
    {
        public int Codigo { get; set; }

        public DateTime FechaCreacion { get; set; }

        public bool Vigente { get; set; }

        public List<PreguntaModelo> Preguntas { get; set; }

        public EncuestaModelo(int codigo, DateTime fechaCreacion, bool vigente, List<PreguntaModelo> preguntas)
        {
            Codigo = codigo;
            FechaCreacion = fechaCreacion;
            Vigente = vigente;
            Preguntas = preguntas;
        }

        public void AgregarPregunta(PreguntaModelo pregunta)
        {
            Preguntas.Add(pregunta);
        }

        public Encuesta ToEntity()
        {
            return new Encuesta(
                codigoEncuesta: new CodigoEncuesta(Codigo),
                fechaCreacion: FechaCreacion,
                vigente: Vigente,
                preguntas: Preguntas.Select(p => p.ToEntity()).ToList());
        }

        public static EncuestaModelo From(Encuesta encuesta)
        {
            return new EncuestaModelo(
                codigo: encuesta.Id.AsInt(),
                fechaCreacion: encuesta.FechaCreacion,
                vigente: encuesta.Vigente,
                preguntas: encuesta.Preguntas.Select(PreguntaModelo.From).ToList()
            );
        }
    }
}