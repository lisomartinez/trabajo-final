
using System;

namespace Entidades
{
    public class EstadisticaFallas : Entidad
    {
        public decimal TasaFallasPromedio { get; set; }
        public decimal TasaFallasPorUsuario { get; set; }
        public decimal CostoPromedioDeReemplazo { get; set; }
        public decimal ComponenteMasFallas { get; set; }
        public decimal CostoMensualAcumulado { get; set; }
        public DateTime Fecha { get; }

        public EstadisticaFallas(Id id) : base(id)
        {
        }

        public EstadisticaFallas Calcular(SolicitudAsistenciaTecnica solicitud)
        {
            throw new System.NotImplementedException();
        }
    }
}