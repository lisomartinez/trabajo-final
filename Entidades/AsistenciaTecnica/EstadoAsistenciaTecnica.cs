namespace Entidades
{
    public class EstadoAsistenciaTecnica : Entidad
    {
        public string Nombre { get; }
        public string Descripcion { get; }

        public EstadoAsistenciaTecnica(CodigoEstadoAsistencia codigo, string nombre, string descripcion) : base(codigo)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}