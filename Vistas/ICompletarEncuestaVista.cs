using System;

namespace Vistas
{
    public interface ICompletarEncuestaVista
    {
        void MostrarException(Exception exception);
        void IngresoRespuesta(PreguntaModelo preguntaModelo);
        int Calificacion { get; set; }
    }
}