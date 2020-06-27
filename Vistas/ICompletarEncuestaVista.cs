using System;
using Modelo;

namespace Vistas
{
    public interface ICompletarEncuestaVista
    {
        void MostrarException(Exception exception);
        void IngresoRespuesta(PreguntaModelo preguntaModelo);
        int Calificacion { get; set; }
    }
}