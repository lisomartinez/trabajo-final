using System.Collections.Generic;
using Entidades;

namespace Modelo
{
    public class ComponentePrecioModelo
    {
        public int NumeroSerie { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public static ComponentePrecioModelo From(KeyValuePair<Componente, Precio> componentePrecio)
        {
            throw new System.NotImplementedException();
        }
    }
}