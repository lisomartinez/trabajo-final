using Entidades;

namespace Modelo
{
    public class TipoProblemaModelo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public TipoProblemaModelo(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public static TipoProblemaModelo From(TipoProblema tp)
        {
            return new TipoProblemaModelo(
                id: tp.Id.AsInt(),
                nombre: tp.Nombre
            );
        }

        public TipoProblema ToEntitty()
        {
            return new TipoProblema(
                id: new TipoProblemaId(Id),
                nombre: Nombre
            );
        }

        public override string ToString()
        {
            return $"{Nombre}";
        }
    }
}