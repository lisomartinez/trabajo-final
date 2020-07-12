using System;
using System.Collections.Generic;
using Modelo;

namespace Vistas
{
    public interface ICompletarEncuestaVista
    {
        void MostrarException(Exception exception);
        void IngresoRespuesta(PreguntaModelo preguntaModelo);
        int Calificacion { get; set; }
        List<PreguntaModelo> Preguntas
        { get; set; }

        PreguntaModelo PreguntaSeleccionada { get; set; }
        string PreguntaTexto { get; set; }
        int PreguntaNro { get; set; }
        int Respuesta { get; set; }
        bool Completada { get; set; }
    }
}