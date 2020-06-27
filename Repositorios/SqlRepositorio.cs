using Entidades;
using System.Collections.Generic;
using AccesoDatos;

namespace Repositorios
{
    public abstract class SqlRepositorio<TEntidad> : IRepositorio<TEntidad> where TEntidad : Entidad
    {
        protected AccesoADatos _accesoADatos { get; }

        protected SqlRepositorio(AccesoADatos accesoADatos)
        {
            _accesoADatos = accesoADatos;
        }

        public abstract TEntidad Guardar(TEntidad entidad);
        public abstract void Actualizar(TEntidad entidad);
        public abstract TEntidad Obtener(Id id);
        public abstract List<TEntidad> ObtenerTodos();
        public abstract void Eliminar(Id id);
    }
}