using System;

namespace Vistas
{
    public interface IReporteFallasHardwareVista
    {
        decimal CostoPromedioDeReemplazo { get; set; }
        decimal TasaFallasPromedio { get; set; }
        decimal TasaFallasPorUsuario { get; set; }
        decimal ComponenteMasFallas { get; set; }
        decimal CostoMensual { get; set; }
        void MostrarExcepcion(Exception exception);
    }
}