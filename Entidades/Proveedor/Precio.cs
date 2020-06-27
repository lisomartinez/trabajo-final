using System.Collections.Generic;

namespace Entidades
{
    public class Precio
    {
        public decimal Valor { get; }

        public Precio(decimal seleccionadoPrecio)
        {
            Valor = seleccionadoPrecio;
        }
    }
}