using System;
using System.Collections.Generic;
using Modelo;

namespace Vistas
{
    public interface IOrdenDeCompraVista
    {
        void MostrarExcepcion(Exception exception);
        List<ProveedorPrecioModelo> Proveedores { get; set; }
        ProveedorModelo ProveedorSeleccionado { get; set; }
        decimal Precio { get; set; }
    }
}