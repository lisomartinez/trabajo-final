using System.Collections.Generic;
using AccesoDatos;
using Entidades;

namespace Repositorios
{
    public class TipoProblemaRepositorio : SqlRepositorio<TipoProblema>

    {
        public TipoProblemaRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override TipoProblema Guardar(TipoProblema entidad)
        {
            throw new System.NotImplementedException();
        }

        public override void Actualizar(TipoProblema entidad)
        {
            throw new System.NotImplementedException();
        }

        public override TipoProblema Obtener(Id id)
        {
            throw new System.NotImplementedException();
        }

        public override List<TipoProblema> ObtenerTodos()
        {
            throw new System.NotImplementedException();
        }

        public override void Eliminar(Id id)
        {
            throw new System.NotImplementedException();
        }
    }
}