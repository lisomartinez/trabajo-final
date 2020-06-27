using System.Collections.Generic;
using AccesoDatos;
using Entidades;
using Repositorios;

namespace Servicios
{
    public class ProveedoresRepositorio : SqlRepositorio<Proveedor>

    {
        public ProveedoresRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override Proveedor Guardar(Proveedor entidad)
        {
            throw new System.NotImplementedException();
        }

        public override void Actualizar(Proveedor entidad)
        {
            throw new System.NotImplementedException();
        }

        public override Proveedor Obtener(Id id)
        {
            throw new System.NotImplementedException();
        }

        public override List<Proveedor> ObtenerTodos()
        {
            throw new System.NotImplementedException();
        }

        public override void Eliminar(Id id)
        {
            throw new System.NotImplementedException();
        }
    }
}