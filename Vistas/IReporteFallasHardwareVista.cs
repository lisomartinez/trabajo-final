namespace Vistas
{
    public interface IReporteFallasHardwareVista
    {
        decimal CostoPromedioDeReemplazo { get; set; }
        decimal TasaFallasPromedio { get; set; }
        decimal TasaFallasPorUsuario { get; set; }
        decimal ComponenteMasFallas { get; set; }
    }
}