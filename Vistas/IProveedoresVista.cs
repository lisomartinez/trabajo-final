using System;
using System.Collections.Generic;
using Modelo;

namespace Vistas
{
    public interface IProveedoresVista
    {
        void MostrarExcepcion(Exception exception);
        List<ProveedorModelo> Proveedores { get; set; }
        ProveedorModelo ProveedorSeleccionado { get; set; }
        int Cuit { get; set; }
        string RazonSocial { get; set; }
        string Direccion { get; set; }
        string Email { get; set; }
        string Telefono { get; set; }
        void MostrarListaPreciosForm(ProveedorModelo proveedor);
    }
}