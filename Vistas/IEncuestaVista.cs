using System;
using System.Collections.Generic;
using Modelo;

namespace Vistas
{
    public interface IEncuestaVista
    {
        void MostrarExcepcion(Exception exception);
        List<EncuestaModelo> Encuestas { get; set; }
        EncuestaModelo EncuestaSeleccionada { get; set; }
        int Codigo { get; set; }
        DateTime FechaCreacion { get; set; }
        bool Vigente { get; set; }
        List<PreguntaModelo> Preguntas { get; set; }
        PreguntaModelo PreguntaSeleccionada { get; set; }
        int PreguntaNumero { get; set; }
        string PreguntaTexto { get; set; }
        decimal PesoRelativo { get; set; }
        decimal PuntajeMaximo { get; set; }
        decimal PuntajeMinimo { get; set; }
    }
}