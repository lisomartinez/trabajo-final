namespace Entidades
{
    public class TipoProblema : Entidad
    {
        public TipoProblemaId TipoProblemaId { get; set; }

        public string Nombre { get; }

        public TipoProblema(TipoProblemaId id, string nombre) : base(id)
        {
            Nombre = nombre;
        }
    }
}