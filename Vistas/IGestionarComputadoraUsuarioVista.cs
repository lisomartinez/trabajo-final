﻿using System;
using System.Collections.Generic;
using Modelo;

namespace Vistas
{
    public interface IGestionarComputadoraUsuarioVista
    {
        void MostrarExcepcion(Exception exception);
        List<ComputadoraModelo> Computadoras { get; set; }
        ComputadoraModelo ComputadoraSeleccionada { get; set; }
        int Legajo { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
    }
}