using System;
using System.Collections.Generic;
using Modelo;

namespace Vistas
{
    public interface IEstadoAsistenciaVista
    {
        void MostrarException(Exception exception);
        List<EstadoAsistenciaTecnicaModelo> Estados { get; set; }
        EstadoAsistenciaTecnicaModelo EstadoSeleccionado { get; set; }
        string Nombre { get; set; }
        string Descripcion { get; set; }
        int Codigo { get; set; }
    }
}