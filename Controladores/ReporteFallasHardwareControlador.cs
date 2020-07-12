using System;
using Entidades;
using Servicios;
using Vistas;

namespace Controladores
{
    public class ReporteFallasHardwareControlador
    {
        private IReporteFallasHardwareVista _vista;
        private EstadisticasAsistenciaTecnicaServicio _servicio;


        public ReporteFallasHardwareControlador(IReporteFallasHardwareVista vista)
        {
            _vista = vista;
            _servicio = new EstadisticasAsistenciaTecnicaServicio();
        }

        public void MostrarEstadisticas()
        {
            try
            {
                var estadisticas = _servicio.ObtenerEstadisticasFallas();
                _vista.CostoPromedioDeReemplazo = estadisticas.CostoPromedioDeReemplazo;
                _vista.TasaFallasPromedio = estadisticas.TasaFallasPromedio;
                _vista.TasaFallasPorUsuario = estadisticas.TasaFallasPorUsuario;
                _vista.ComponenteMasFallas = estadisticas.ComponenteMasFallas;
                _vista.CostoMensual = estadisticas.CostoMensualAcumulado;

            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }
    }
}
