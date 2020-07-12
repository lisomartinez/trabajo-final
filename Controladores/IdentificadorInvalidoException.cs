using System;

namespace Controladores
{
    internal class IdentificadorInvalidoException : Exception
    {
        public override string Message => "El identificador debe ser un número entero";

        public IdentificadorInvalidoException()
        {
        }
    }
}