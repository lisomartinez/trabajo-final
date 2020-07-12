namespace Entidades
{
    public class OrdenDeCompra : Entidad
    {
        public CodigoOrdenDeCompra Codigo { get; }
        public AsistenciaTecnica AsistenciaTecnica { get; }
        public Componente Componente { get; }

        public Proveedor Proveedor;

        public Precio Precio { get; }

        public OrdenDeCompra(CodigoOrdenDeCompra codigo, Proveedor proveedor, AsistenciaTecnica asistenciaTecnica, Componente componente, Precio precio) : base(codigo)
        {
            Proveedor = proveedor;
            AsistenciaTecnica = asistenciaTecnica;
            Componente = componente;
            Precio = precio;
        }

        public OrdenDeCompra(Proveedor proveedor, AsistenciaTecnica asistencia, Componente componente, Precio precio) : base(Id.Empty)
        {
            Proveedor = proveedor;
            AsistenciaTecnica = asistencia;
            Componente = componente;
            Precio = precio;
        }
    }
}