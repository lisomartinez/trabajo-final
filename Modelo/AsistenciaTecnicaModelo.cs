using System;
using Controladores;
using Entidades;

namespace Modelo
{
    public class AsistenciaTecnicaModelo
    {
        public int Codigo { get; set; }
        public TipoProblemaModelo TipoProblema { get; set; }
        public string Descripcion { get; set; }
        public EstadoAsistenciaTecnicaModelo Estado { get; set; }
        public DateTime Fecha { get; set; }
        public UsuarioModelo Usuario { get; set; }
        public UsuarioModelo Tecnico { get; set; }
        public int Calificacion { get; set; }


        public AsistenciaTecnicaModelo(int codigo, TipoProblemaModelo tipoProblema, string descripcion, EstadoAsistenciaTecnicaModelo estado, DateTime fecha, UsuarioModelo usuario, UsuarioModelo tecnico, int calificacion)
        {
            Codigo = codigo;
            TipoProblema = tipoProblema;
            Descripcion = descripcion;
            Estado = estado;
            Fecha = fecha;
            Usuario = usuario;
            Tecnico = tecnico;
            Calificacion = calificacion;
        }

        public static AsistenciaTecnicaModelo From(AsistenciaTecnica at)
        {
            return new AsistenciaTecnicaModelo(
                 codigo: at.Codigo.AsInt(),
                 tipoProblema: TipoProblemaModelo.From(at.TipoProblema),
                 descripcion: at.DescripcionProblema,
                 estado: EstadoAsistenciaTecnicaModelo.From(at.Estado),
                 fecha: at.Fecha,
                 usuario: UsuarioModelo.From(at.Usuario),
                 tecnico: UsuarioModelo.From(at.Tecnico),
                 calificacion: at.Calificacion
                );
        }

        public AsistenciaTecnica ToEntity()
        {
            return new AsistenciaTecnica(
                codigo: new CodigoAsistencia(Codigo),
                tipoProblema: TipoProblema.ToEntitty(),
                descripcionProblema: Descripcion,
                estado: Estado.ToEntity(),
                fecha: Fecha,
                usuario: Usuario.ToEntity(),
                tecnico: Tecnico.ToEntity(),
                calificacion: Calificacion
            );
        }
    }
}