using System;

namespace Vistas
{
    public interface ILoginVista
    {
        void MostrarExcepcion(Exception exception);
        string Legajo { get; set; }
        string Password { get; set; }
    }
}