using System;
using System.Collections.Generic;
using Modelo;

namespace Vistas
{
    public interface IComputadoraVista
    {
        void MostrarExcepcion(Exception exception);
        List<ComputadoraModelo> Computadoras { get; set; }
        ComputadoraModelo ComputadoraSeleccionada { get; set; }
        int Codigo { get; set; }
        string Marca { get; set; }
        string Modelo { get; set; }
        List<ComponenteModelo> Componentes { get; set; }
        List<SoftwareModelo> Software { get; set; }
        ComponenteModelo ComponenteSeleccionado { get; set; }
        SoftwareModelo SoftwareSeleccionado { get; set; }
        void MostrarComponentesForm(ComputadoraModelo vistaComputadoraSeleccionada);
        void MostrarGestionarSoftwareForm(ComputadoraModelo vistaComputadoraSeleccionada);
    }
}