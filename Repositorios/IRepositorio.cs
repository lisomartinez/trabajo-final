using System.Collections.Generic;
using Entidades;

namespace Repositorios
{
    public interface IRepositorio<TEntidad> where TEntidad : Entidad
    {
        TEntidad Guardar(TEntidad entidad);
        void Actualizar(TEntidad entidad);
        TEntidad Obtener(Id id);
        List<TEntidad> ObtenerTodos();
        void Eliminar(Id id);
    }
}