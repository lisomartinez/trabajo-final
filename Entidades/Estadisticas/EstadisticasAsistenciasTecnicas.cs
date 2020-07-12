using System;

namespace Entidades
{
    public class EstadisticasAsistenciasTecnicas : Entidad
    {
        public decimal TiempoInicio { get; set; }
        public decimal TiempoDuracion { get; set; }
        public decimal TiempoFinalizacion { get; set; }
        public decimal Calificacion { get; set; }
        public int Cantidad { get; set; }

        public EstadisticasAsistenciasTecnicas(EstadisticasAsistenciaId id, decimal tiempoInicio,
            decimal tiempoDuracion, decimal tiempoFinalizacion, decimal calificacion, int cantidad) : base(id)
        {
            TiempoInicio = tiempoInicio;
            TiempoDuracion = tiempoDuracion;
            TiempoFinalizacion = tiempoFinalizacion;
            Calificacion = calificacion;
            Cantidad = cantidad;
        }

        public EstadisticasAsistenciasTecnicas Calcular(SolicitudAsistenciaTecnica solicitud)
        {
            return new EstadisticasAsistenciasTecnicas(
                Id as EstadisticasAsistenciaId,
                TiempoInicio + Convert.ToDecimal(solicitud.Turno.Inicio.Subtract(DateTime.Now).TotalMinutes),
                TiempoDuracion + Convert.ToDecimal(solicitud.Turno.Duracion.TotalMinutes),
                TiempoFinalizacion + Convert.ToDecimal(DateTime.Now.Subtract(solicitud.Turno.Inicio).TotalMinutes) +
                Convert.ToDecimal(solicitud.Turno.Duracion.TotalMinutes),
                Calificacion,
                Cantidad + 1
            );
        }
    }
}