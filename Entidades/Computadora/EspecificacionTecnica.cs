namespace Entidades
{
    public class EspecificacionTecnica : Entidad
    {
        public string Nombre { get; }
        public string Descripcion { get; }

        public EspecificacionTecnica(CodigoEspecificacionTecnica codigo) : base(codigo)
        {
        }

        public EspecificacionTecnica(CodigoEspecificacionTecnica codigo, string nombre, string descripcion) : base(codigo)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}