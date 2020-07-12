using System;
using System.Collections.Generic;
using Modelo;

namespace Vistas
{
    public interface IAsistenciaTecnicaVista
    {
        List<AsistenciaTecnicaModelo> AsistenciasTecnicas { get; set; }
        AsistenciaTecnicaModelo AsistenciaSelccionado { get; set; }
        int Codigo { get; set; }
        TipoProblemaModelo TipoProblema { get; set; }
        DateTime Fecha { get; set; }
        UsuarioModelo Usuario { get; set; }
        UsuarioModelo Tecnico { get; set; }
        EstadoAsistenciaTecnicaModelo Estado {get; set; }
        
        int Calificacion { get; set; }


        string Descripcion { get; set; }
        List<TipoProblemaModelo> TiposProblema { get; set; }
        List<EstadoAsistenciaTecnicaModelo> Estados { get; set; }
        void MostrarExcepcion(Exception exception);
        void MostrarGestionarComputadora(UsuarioModelo usuario);
        void MostrarCompletarEncuesta(AsistenciaTecnicaModelo seleccionada);
    }
}