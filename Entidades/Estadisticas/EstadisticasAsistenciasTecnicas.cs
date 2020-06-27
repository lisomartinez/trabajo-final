namespace Entidades
{
    public class EstadisticasAsistenciasTecnicas
    {
        public int TiempoMedioDuracion { get; set; }
        public int TiempoMedioDeInicio { get; set; }
        public int TiempoMedioInicioFinalizacion { get; set; }
        public decimal CalificacionPromedio { get; set; }

        public EstadisticasAsistenciasTecnicas(int tiempoMedioDuracion, int tiempoMedioDeInicio, int tiempoMedioInicioFinalizacion, decimal calificacionPromedio)
        {
            TiempoMedioDuracion = tiempoMedioDuracion;
            TiempoMedioDeInicio = tiempoMedioDeInicio;
            TiempoMedioInicioFinalizacion = tiempoMedioInicioFinalizacion;
            CalificacionPromedio = calificacionPromedio;
        }
    }
}