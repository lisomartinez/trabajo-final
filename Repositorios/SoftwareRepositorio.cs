using System.Collections.Generic;
using AccesoDatos;
using Entidades;

namespace Repositorios
{
    public class SoftwareRepositorio : SqlRepositorio<Software>
    {
        public SoftwareRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override Software Guardar(Software entidad)
        {
            throw new System.NotImplementedException();
        }

        public override void Actualizar(Software entidad)
        {
            throw new System.NotImplementedException();
        }

        public override Software Obtener(Id id)
        {
            throw new System.NotImplementedException();
        }

        public override List<Software> ObtenerTodos()
        {
            throw new System.NotImplementedException();
        }

        public override void Eliminar(Id id)
        {
            throw new System.NotImplementedException();
        }
    }
}