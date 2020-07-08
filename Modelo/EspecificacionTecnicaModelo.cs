using Entidades;

namespace Modelo
{
    public class EspecificacionTecnicaModelo
    {

        public int Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }


        public EspecificacionTecnicaModelo(int codigo, string nombre, string descripcion)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public EspecificacionTecnica ToEntity()
        {
            return new EspecificacionTecnica(
                codigo: new CodigoEspecificacionTecnica(Codigo),
                nombre: Nombre,
                descripcion: Descripcion
            );
        }

        public static EspecificacionTecnicaModelo From(EspecificacionTecnica especificacion)
        {
            return new EspecificacionTecnicaModelo(
                codigo: especificacion.Id.AsInt(),
                nombre: especificacion.Nombre,
                descripcion: especificacion.Descripcion
                );
        }
    }
}