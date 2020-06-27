using System;
using System.Collections.Generic;
using Entidades;
using Modelo;

namespace Vistas
{
    public interface IReporteAsistenciaTecnicaVista
    {
        void MostrarExcepcion(Exception exception);
        int TiempoMedioDuracion { get; set; }
        int TiempoMedioDeInicio { get; set; }
        int TiempoMedioInicioFinalizacion { get; set; }
        List<UsuarioModelo> Tecnicos { get; set; }
        UsuarioModelo TecnicoSeleccionado { get; set; }
        decimal CalificacionPromedio { get; set; }
        int TiempoMedioDuracionTecnico { get; set; }
        int TiempoMedioDeInicioTecnico { get; set; }
        int TiempoMedioInicioFinalizacionTecnico { get; set; }
        int DesviacionDuracionTecnico { get; set; }
        int DesviacionInicioTecnico { get; set; }
        int DesviacionInicioFinalizacion { get; set; }
    }
}