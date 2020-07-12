using System;
using System.Collections.Generic;
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
        private TipoProblemaServicio _tipoProblemaServicio;
        private Dictionary<TipoProblemaId, EstadisticaTecnico> _estadisticaTecnico;

        public ReporteAsistenciaTecnicaControlador(IReporteAsistenciaTecnicaVista vista)
        {
            _vista = vista;
            _estadisticasServicio = new EstadisticasAsistenciaTecnicaServicio();
            _tecnicoServicio = new TecnicoServicio();
            _tipoProblemaServicio = new TipoProblemaServicio();
        }

        public void MostrarEstadisticasGenerales()
        {
            try
            {
                var estadisticas = _estadisticasServicio.ObtenerEstadisticasGenerales();
                _vista.TiempoMedioDuracion = estadisticas.TiempoDuracion;
                _vista.TiempoMedioDeInicio = estadisticas.TiempoInicio;
                _vista.TiempoMedioInicioFinalizacion = estadisticas.TiempoFinalizacion;
                _vista.CalificacionPromedio = estadisticas.Calificacion;
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
                _vista.Tecnicos = _tecnicoServicio.ObtenerTodos().Select(TecnicoModelo.From).ToList();
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
                var estadistica = ObtenerEstadisticaTecnico();
                MostrarMediasTecnico(estadistica);
                MostrarDesviacionTecnicoRespectoDeGeneral(estadistica);
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        private EstadisticaTecnico ObtenerEstadisticaTecnico()
        {
            var seleccionado = _vista.TecnicoSeleccionado;
            var problemaSeleccionado = _vista.TipoProblemaSeleccionado;
            _estadisticaTecnico =
                _estadisticasServicio.ObtenerEstadisticasDeTecnico(new TipoProblemaId(problemaSeleccionado.Id),
                    new Legajo(seleccionado.Id));
            return _estadisticaTecnico[new TipoProblemaId(problemaSeleccionado.Id)];
        }

        private void MostrarMediasTecnico(EstadisticaTecnico estadistica)
        {
            _vista.TiempoMedioDuracionTecnico = estadistica.TiempoMedioDuracion;
            _vista.TiempoMedioDeInicioTecnico = estadistica.TiempoMedioDeInicio;
            _vista.TiempoMedioInicioFinalizacionTecnico = estadistica.TiempoMedioInicioFinalizacion;
            _vista.CalificacionPromedioTecnico = estadistica.CalificacionPromedioTipoProblema;
        }

        private void MostrarDesviacionTecnicoRespectoDeGeneral(EstadisticaTecnico estadisticaTecnico)
        {
            _vista.DesviacionDuracionTecnico = estadisticaTecnico.TiempoMedioDuracion - _vista.TiempoMedioDuracion;
            _vista.DesviacionInicioTecnico = estadisticaTecnico.TiempoMedioDeInicio - _vista.TiempoMedioDeInicio;
            _vista.DesviacionInicioFinalizacion =
                estadisticaTecnico.TiempoMedioInicioFinalizacion - _vista.TiempoMedioInicioFinalizacion;
            _vista.DesviacionCalificacionPromedioTecnico =
                estadisticaTecnico.CalificacionPromedioTipoProblema - _vista.CalificacionPromedio;
        }

        public void MostrarTipoProblemas()
        {
            _vista.TipoProblemas = _tipoProblemaServicio.ObtenerTodos().Select(TipoProblemaModelo.From).ToList();
        }
    }
}