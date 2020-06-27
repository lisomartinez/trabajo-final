namespace Entidades
{
    public class EstadoAsistenciaTecnica
    {
        public int Codigo { get; }
        public string Nombre { get; }
        public string Descripcion { get; }

        public EstadoAsistenciaTecnica(int codigo, string nombre, string descripcion)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}