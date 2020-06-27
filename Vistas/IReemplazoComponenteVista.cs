using System;
using System.Collections.Generic;
using Modelo;

namespace Vistas
{
    public interface IReemplazoComponenteVista
    {
        int Codigo { get; set; }
        string Marca { get; set; }
        string Modelo { get; set; }
        List<ComponenteModelo> Componentes { get; set; }
        ComponenteModelo ComponenteSeleccionado { get; set; }
        void MostrarOrdenDeCompraForm(ComponenteModelo componenteSeleccionado);
        void MostrarExcepcion(Exception exception);
    }
}