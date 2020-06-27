using System;
using System.Collections.Generic;
using Controladores;

namespace Vistas
{
    public interface IOrdenDeCompraVista
    {
        void MostrarExcepcion(Exception exception);
        List<ProveedorModelo> Proveedores { get; set; }
    }
}