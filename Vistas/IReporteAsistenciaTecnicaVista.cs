using System;
using System.Collections.Generic;
using Modelo;

namespace Vistas
{
    public interface IReporteAsistenciaTecnicaVista
    {
        void MostrarExcepcion(Exception exception);
        decimal TiempoMedioDuracion { get; set; }
        decimal TiempoMedioDeInicio { get; set; }
        decimal TiempoMedioInicioFinalizacion { get; set; }
        List<TecnicoModelo> Tecnicos { get; set; }
        TecnicoModelo TecnicoSeleccionado { get; set; }
        decimal CalificacionPromedio { get; set; }
        decimal TiempoMedioDuracionTecnico { get; set; }
        decimal TiempoMedioDeInicioTecnico { get; set; }
        decimal TiempoMedioInicioFinalizacionTecnico { get; set; }
        decimal DesviacionDuracionTecnico { get; set; }
        decimal DesviacionInicioTecnico { get; set; }
        decimal DesviacionInicioFinalizacion { get; set; }
        List<TipoProblemaModelo> TipoProblemas { get; set; }
        TipoProblemaModelo TipoProblemaSeleccionado { get; set; }
        decimal CalificacionPromedioTecnico { get; set; }
        decimal DesviacionCalificacionPromedioTecnico { get; set; }
        decimal CalificacionPromedioTecnicoTotal { get; set; }
        decimal DesviacionCalificacionPromedioTecnicoTotal { get; set; }
    }
}