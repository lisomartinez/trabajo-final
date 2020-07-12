using System.Collections.Generic;

namespace Entidades
{
    public class Proveedor : Entidad
    {
        public CUIT CUIT => Id as CUIT;
        public string RazonSoncial { get; }
        public string Direccion { get; }
        public string Email { get; }
        public string Telefono { get; }

        public Dictionary<NumeroDeSerie, Componente> Componentes { get; }

        public Proveedor(CUIT id) : base(id)
        {
        }

        public Proveedor(CUIT cuit, string razonSoncial, string direccion, string email, string telefono,
            Dictionary<NumeroDeSerie, Componente> componentes) : base(cuit)
        {
            RazonSoncial = razonSoncial;
            Direccion = direccion;
            Email = email;
            Telefono = telefono;
            Componentes = componentes;
        }

        public Proveedor(CUIT cuit, string razonSoncial, string direccion, string email, string telefono) : base(cuit)
        {
            RazonSoncial = razonSoncial;
            Direccion = direccion;
            Email = email;
            Telefono = telefono;
        }
    }
}