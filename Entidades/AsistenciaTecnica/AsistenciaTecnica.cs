using System;
using System.Security.Policy;

namespace Entidades
{
    //TODO: add Turno to AsistenciaTecnica????
    public class AsistenciaTecnica : Entidad
    {
        public CodigoAsistencia Codigo => Id as CodigoAsistencia;
        public DateTime Fecha { get; }
        public Usuario Tecnico { get; }
        public Usuario Usuario { get; }
        public TipoProblema TipoProblema { get; }

        public string DescripcionProblema { get; }
        public EstadoAsistenciaTecnica Estado { get; set; }
        public int Calificacion { get; set; }

        public AsistenciaTecnica(CodigoAsistencia id) : base(id)
        {
        }

        public AsistenciaTecnica(CodigoAsistencia codigo, DateTime fecha, Usuario tecnico, Usuario usuario, TipoProblema tipoProblema, string descripcionProblema, EstadoAsistenciaTecnica estado, int calificacion) : base(codigo)
        {
            Fecha = fecha;
            Tecnico = tecnico;
            Usuario = usuario;
            TipoProblema = tipoProblema;
            DescripcionProblema = descripcionProblema;
            Estado = estado;
            Calificacion = calificacion;
        }

        public AsistenciaTecnica(CodigoAsistencia codigo, DateTime turno, Usuario usuario, Usuario tecnico, TipoProblema tipoProblema, string descripcion) : base(codigo)
        {
            Fecha = turno;
            Tecnico = tecnico;
            Usuario = usuario;
            TipoProblema = tipoProblema;
            DescripcionProblema = descripcion;
            Calificacion = -1;
        }

        public void ReemplazarComponente(Componente anterior, Componente componenteNuevo)
        {
            Usuario.Computadora.Reemplazar(anterior, componenteNuevo);
        }
    }
}