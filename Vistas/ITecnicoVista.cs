using System;
using System.Collections.Generic;
using Modelo;

namespace Vistas
{
    public interface ITecnicoVista
    {
        void MostrarExcepcion(Exception exception);
        UsuarioModelo TecnicoSeleccionado { get; set; }
        int Legajo { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        string Email { get; set; }
        List<UsuarioModelo> Tecnicos { get; set; }
        void SolicitarIngresoPassword();
    }
}