using System;
using System.Collections.Generic;
using Controladores;
using Modelo;

namespace Vistas
{
    public interface IOrdenDeCompraVista
    {
        void MostrarExcepcion(Exception exception);
        List<ProveedorModelo> Proveedores { get; set; }
    }
}