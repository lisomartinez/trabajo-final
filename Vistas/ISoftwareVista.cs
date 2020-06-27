using System;
using System.Collections.Generic;
using Modelo;

namespace Vistas
{
    public interface ISoftwareVista
    {
        void MostrarExcepcion(Exception exception);
        List<SoftwareModelo> Softwares { get; set; }
        SoftwareModelo SoftwareSeleccionado { get; set; }
        int Codigo { get; set; }
        string Nombre { get; set; }
        string Version { get; set; }
        string Desarrollador { get; set; }
    }
}