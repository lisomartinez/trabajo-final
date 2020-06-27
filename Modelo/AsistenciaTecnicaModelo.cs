using System;
using Controladores;
using Entidades;

namespace Modelo
{
    public class AsistenciaTecnicaModelo
    {
        public static AsistenciaTecnicaModelo From(AsistenciaTecnica at)
        {
            throw new NotImplementedException();
        }

        public AsistenciaTecnica ToEntity()
        {
            throw new NotImplementedException();
        }

        public int Codigo { get; set; }
        public TipoProblemaModelo TipoProblema { get; set; }
        public string Descripcion { get; set; }
        public EstadoAsistenciaTecnicaModelo Estado { get; set; }
        public DateTime Fecha { get; set; }
        public UsuarioModelo Usuario { get; set; }
        public UsuarioModelo Tecnico { get; set; }
        public int Calificacion { get; set; }
    }
}