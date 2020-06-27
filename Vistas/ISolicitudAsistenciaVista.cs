using System;
using System.Collections.Generic;
using Controladores;
using Modelo;

namespace Vistas
{
    public interface ISolicitudAsistenciaVista
    {
        List<TipoProblemaModelo> TiposDeProblemas { get; set; }
        string Descripcion { get; set; }
        List<TurnoModelo> Turnos { get; set; }
        TipoProblemaModelo TipoProblemaSeleccionado { get; set; }
        TurnoModelo TurnoSeleccionado();
        void MostrarExcepcion(Exception exception);
    }
}