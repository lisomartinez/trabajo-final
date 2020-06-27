namespace Entidades
{
    public class TipoProblema : Entidad
    {
        public TipoProblemaId Id { get; }

        public string Nombre { get; }

        public TipoProblema(TipoProblemaId id, string nombre) : base(id)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}