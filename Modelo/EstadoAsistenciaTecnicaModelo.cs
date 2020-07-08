using System;
using Entidades;

namespace Modelo
{
    public class EstadoAsistenciaTecnicaModelo
    {
        public int Codigo { get; }
        public string Nombre { get; }
        public string Descripcion { get; }

        public EstadoAsistenciaTecnicaModelo(int codigo, string nombre, string descripcion)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public EstadoAsistenciaTecnica ToEntity()
        {
            return new EstadoAsistenciaTecnica(
                codigo: new CodigoEstadoAsistencia(Codigo),
                nombre: Nombre,
                descripcion: Descripcion
                );
        }

        public static EstadoAsistenciaTecnicaModelo From(EstadoAsistenciaTecnica estado)
        {
            return new EstadoAsistenciaTecnicaModelo(
                codigo: estado.Id.AsInt(),
                nombre: estado.Nombre,
                descripcion: estado.Descripcion
                );
        }
    }
}