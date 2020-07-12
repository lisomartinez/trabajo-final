using Entidades;

namespace Modelo
{
    public class TecnicoModelo
    {
        public int Id { get; }
        public string Nombre { get; }
        public string Apellido { get; }

        private TecnicoModelo(int id, string nombre, string apellido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
        }

        public static TecnicoModelo From(Usuario tecnico)
        {
            return new TecnicoModelo(tecnico.Id.AsInt(), tecnico.Nombre, tecnico.Apellido);
        }
    }
}