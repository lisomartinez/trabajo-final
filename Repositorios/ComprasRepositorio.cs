using System.Collections.Generic;
using AccesoDatos;
using Entidades;

namespace Repositorios
{
    public class ComprasRepositorio : SqlRepositorio<OrdenDeCompra>
    {
        public ComprasRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override OrdenDeCompra Guardar(OrdenDeCompra entidad)
        {
            throw new System.NotImplementedException();
        }

        public override void Actualizar(OrdenDeCompra entidad)
        {
            throw new System.NotImplementedException();
        }

        public override OrdenDeCompra Obtener(Id id)
        {
            throw new System.NotImplementedException();
        }

        public override List<OrdenDeCompra> ObtenerTodos()
        {
            throw new System.NotImplementedException();
        }

        public override void Eliminar(Id id)
        {
            throw new System.NotImplementedException();
        }
    }
}