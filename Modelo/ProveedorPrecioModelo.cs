using System.Collections.Generic;
using Entidades;

namespace Modelo
{
    public class ProveedorPrecioModelo
    {
        public ProveedorModelo Proveedor { get; }
        public decimal Precio { get; }

        private ProveedorPrecioModelo(ProveedorModelo proveedor, decimal precio)
        {
            Proveedor = proveedor;
            Precio = precio;
        }

        public static ProveedorPrecioModelo From(KeyValuePair<Proveedor, Precio> entrada)
        {
            return new ProveedorPrecioModelo(ProveedorModelo.From(entrada.Key), entrada.Value.Valor);
        }
    }
}