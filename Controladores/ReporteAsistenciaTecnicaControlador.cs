using System;
using System.Linq;
using Entidades;
using Modelo;
using Servicios;
using Vistas;

namespace Controladores
{
    public class ReporteAsistenciaTecnicaControlador
    {
        private IReporteAsistenciaTecnicaVista _vista;
        private EstadisticasAsistenciaTecnicaServicio _estadisticasServicio;
        private TecnicoServicio _tecnicoServicio;

        public void MostrarEstadisticasGenerales()
        {
            try
            {
                var estadisticas = _estadisticasServicio.ObtenerEstadisticasGenerales();
                _vista.TiempoMedioDuracion = estadisticas.TiempoMedioDuracion;
                _vista.TiempoMedioDeInicio = estadisticas.TiempoMedioDeInicio;
                _vista.TiempoMedioInicioFinalizacion = estadisticas.TiempoMedioInicioFinalizacion;
                _vista.CalificacionPromedio = estadisticas.CalificacionPromedio;
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void MostrarTecnicos()
        {
            try
            {
                _vista.Tecnicos = _tecnicoServicio.ObtenerTodos().Select(UsuarioModelo.From).ToList();
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }


        public void MostrarEstadisticasDeTecnico()
        {
            try
            {
                var seleccionado = _vista.TecnicoSeleccionado;
                var estadisticaTecnico = _estadisticasServicio.ObtenerEstadisticasDeTecnico(seleccionado.ToEntity());
                _vista.TiempoMedioDuracionTecnico = estadisticaTecnico.TiempoMedioDuracion;
                _vista.TiempoMedioDeInicioTecnico = estadisticaTecnico.TiempoMedioDeInicio;
                _vista.TiempoMedioInicioFinalizacionTecnico = estadisticaTecnico.TiempoMedioInicioFinalizacion;
                MostrarDesviacionTecnicoRespectoDeGeneral(estadisticaTecnico);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void MostrarDesviacionTecnicoRespectoDeGeneral(EstadisticaTecnico estadisticaTecnico)
        {
            _vista.DesviacionDuracionTecnico = estadisticaTecnico.TiempoMedioDuracion - _vista.TiempoMedioDuracion;
            _vista.DesviacionInicioTecnico = estadisticaTecnico.TiempoMedioDeInicio - _vista.TiempoMedioDeInicio;
            _vista.DesviacionInicioFinalizacion =
                estadisticaTecnico.TiempoMedioInicioFinalizacion - _vista.TiempoMedioInicioFinalizacion;
        }
    }
}