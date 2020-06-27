using System;

namespace Entidades
{
    public class EstadisticaTecnico
    {
        public int TiempoMedioDuracion { get; set; }
        public int TiempoMedioDeInicio { get; set; }
        public int TiempoMedioInicioFinalizacion { get; set; }

        public DateTime Fecha { get; set; }

        public EstadisticaTecnico(int tiempoMedioDuracion, int tiempoMedioDeInicio, int tiempoMedioInicioFinalizacion)
        {
            TiempoMedioDuracion = tiempoMedioDuracion;
            TiempoMedioDeInicio = tiempoMedioDeInicio;
            TiempoMedioInicioFinalizacion = tiempoMedioInicioFinalizacion;
        }
    }
}