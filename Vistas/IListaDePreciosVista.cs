using System;
using System.Collections.Generic;
using Modelo;

namespace Vistas
{
    public interface IListaDePreciosVista
    {
        List<ComponentePrecioModelo> ListaPrecios { get; set; }
        ComponentePrecioModelo ComponenteSeleccionado { get; set; }
        int NumeroSerie { get; set; }
        string Marca { get; set; }
        string Modelo { get; set; }
        decimal Precio { get; set; }
        void MostrarExcepcion(Exception exception);
    }
}