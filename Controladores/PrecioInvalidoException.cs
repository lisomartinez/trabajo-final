using System;

namespace Controladores
{
    public class PrecioInvalidoException : Exception
    {
        public override string Message => "El precio ingresado es inválido";
    }
}