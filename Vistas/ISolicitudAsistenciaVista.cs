using System;
using System.Collections.Generic;
using Modelo;

namespace Vistas
{
    public interface ISolicitudAsistenciaVista
    {
        List<TipoProblemaModelo> TiposDeProblemas { get; set; }
        string Descripcion { get; set; }
        List<TurnoModelo> Turnos { get; set; }
        TipoProblemaModelo TipoProblemaSeleccionado { get; set; }
        TurnoModelo TurnoSeleccionado { get; set; }
        void MostrarExcepcion(Exception exception);
        void IniciarTimer();
        decimal Seconds { get; set; }
        bool ConfirmarHabilitado { get; set; }
        void MostrarMensaje(string msj);
    }
}