using System;

namespace Vistas
{
    public interface ILoginVista
    {
        void MostrarExcepcion(Exception exception);
        string Usuario { get; set; }
        string Password { get; set; }
    }
}