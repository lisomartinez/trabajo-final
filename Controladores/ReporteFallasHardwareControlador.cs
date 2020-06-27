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

        public ReporteFallasHardwareControlador(IReporteFallasHardwareVista vista,
            EstadisticasAsistenciaTecnicaServicio servicio)
        {
            _vista = vista;
            _servicio = servicio;
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

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
