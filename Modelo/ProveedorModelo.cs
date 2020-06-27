using System;
using System.Collections.Generic;
using Entidades;

namespace Controladores
{
    public class ProveedorModelo
    {
        public int CUIT;
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public static ProveedorModelo From(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }

        public Proveedor ToEntity()
        {
            throw new NotImplementedException();
        }

        public Dictionary<Componente,Precio> ListaDePrecios(Proveedor toEntity)
        {
            throw new NotImplementedException();
        }
    }
}