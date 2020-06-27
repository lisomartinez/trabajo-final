using System;
using System.Collections.Generic;
using AccesoDatos;
using Entidades;

namespace Repositorios
{
    public class EstadisticaFallasRepositorio : SqlRepositorio<EstadisticaFallas>
    {
        public EstadisticaFallasRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override EstadisticaFallas Guardar(EstadisticaFallas entidad)
        {
            throw new NotImplementedException();
        }

        public override void Actualizar(EstadisticaFallas entidad)
        {
            throw new NotImplementedException();
        }

        public override EstadisticaFallas Obtener(Id id)
        {
            throw new NotImplementedException();
        }

        public override List<EstadisticaFallas> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(Id id)
        {
            throw new NotImplementedException();
        }

        public EstadisticaFallas ObtenerValorActual()
        {
            throw new NotImplementedException();
        }
    }
}