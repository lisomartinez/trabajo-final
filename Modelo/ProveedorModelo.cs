using System;
using System.Collections.Generic;
using Entidades;

namespace Modelo
{
    public class ProveedorModelo
    {
        public int CUIT;
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }


        public ProveedorModelo(int cuit, string razonSocial, string direccion, string email, string telefono)
        {
            CUIT = cuit;
            RazonSocial = razonSocial;
            Direccion = direccion;
            Email = email;
            Telefono = telefono;
        }

        public static ProveedorModelo From(Proveedor proveedor)
        {
            return new ProveedorModelo(
                cuit: proveedor.CUIT.AsInt(),
                razonSocial: proveedor.RazonSoncial,
                direccion: proveedor.Direccion,
                email: proveedor.Email,
                telefono: proveedor.Telefono
                );
        }

        public Proveedor ToEntity()
        {
            return new Proveedor(
                cuit: new CUIT(CUIT),
                razonSoncial: RazonSocial,
                direccion: Direccion,
                email: Email,
                telefono: Telefono
                );
        }


    }
}