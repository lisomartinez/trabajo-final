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

        public ComponentePrecioModelo(int numeroSerie, string marca, string modelo, decimal precio)
        {
            NumeroSerie = numeroSerie;
            Marca = marca;
            Modelo = modelo;
            Precio = precio;
        }

        public static ComponentePrecioModelo From(KeyValuePair<Componente, Precio> componentePrecio)
        {
            var componente = componentePrecio.Key;
            var precio = componentePrecio.Value;
            return new ComponentePrecioModelo(
                numeroSerie: componente.NumeroDeSerie.AsInt(),
                marca: componente.Marca,
                modelo: componente.Modelo,
                precio: precio.Valor
            );
        }
    }
}