using System;
using System.Collections.Generic;

namespace Vistas
{
    public interface IGestionarComputadoraUsuarioVista
    {
        void MostrarExcepcion(Exception exception);
        List<ComputadoraModelo> Computadoras { get; set; }
        ComputadoraModelo ComputadoraSeleccionada { get; set; }
    }
}