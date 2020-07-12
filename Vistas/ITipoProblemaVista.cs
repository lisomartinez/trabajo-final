using System;
using System.Collections.Generic;
using Modelo;

namespace Vistas
{
    public interface ITipoProblemaVista
    {
        List<TipoProblemaModelo> TiposProblemas { get; set; }
        TipoProblemaModelo TipoProblemaSeleccionado { get; set; }
        int Id { get; set; }
        string Nombre { get; set; }
        void MostrarException(Exception exception);
    }
}