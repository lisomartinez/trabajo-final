using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Modelo;

namespace Vistas
{
    public interface IAgregarComponenteAListaDePrecios
    {
        List<ComponenteModelo> Componentes { get; set; }
        ComponenteModelo ComponenteSeleccionado { get; set; }
        decimal Precio { get; set; }
        void MostrarExcepcion(Exception exception);

        int NumeroDeSerie { get; set; }
        string Marca { get; set; }
        string Modelo { get; set; }
    }
}