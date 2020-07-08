using System;
using System.Collections.Generic;
using Modelo;

namespace Vistas
{
    public interface IComponenteVista
    {
        void MostrarExcepcion(Exception exception);
        List<ComponenteModelo> Componentes { get; set; }
        ComponenteModelo ComponenteSeleccionado { get; set; }
        int NumeroSerie { get; set; }
        string Marca { get; set; }
        string Modelo { get; set; }
        List<EspecificacionTecnicaModelo> EspecificacionesTecnicas { get; set; }
        int CodigoEspecificacionTecnica { get; set; }
        string NombreEspecificacion { get; set; }
        string DescripcionEspecificacion { get; set; }
        EspecificacionTecnicaModelo EspecificacionTecnicaSeleccionada { get; set; }
    }
}