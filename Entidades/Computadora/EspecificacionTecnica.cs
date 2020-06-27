namespace Entidades
{
    public class EspecificacionTecnica : Entidad
    {
        public string Nombre { get; }
        public string Descripcion { get; }

        public EspecificacionTecnica(CodigoEspecificacionTecnica codigo) : base(codigo)
        {
        }

        public EspecificacionTecnica(CodigoEspecificacionTecnica codigo, string vistaNombreEspecificacion, string vistaDescripcionEspecificacion) : base(codigo)
        {
            throw new System.NotImplementedException();
        }
    }

    public class CodigoEspecificacionTecnica : Id
    {
        public CodigoEspecificacionTecnica(int value) : base(value)
        {
        }
    }
}