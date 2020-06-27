using System.Collections.Generic;
using AccesoDatos;
using Entidades;

namespace Repositorios
{
    public class EncuestaRepositorio : SqlRepositorio<Encuesta>
    {
        public EncuestaRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override Encuesta Guardar(Encuesta entidad)
        {
            throw new System.NotImplementedException();
        }

        public override void Actualizar(Encuesta entidad)
        {
            throw new System.NotImplementedException();
        }

        public override Encuesta Obtener(Id id)
        {
            throw new System.NotImplementedException();
        }

        public override List<Encuesta> ObtenerTodos()
        {
            throw new System.NotImplementedException();
        }

        public override void Eliminar(Id id)
        {
            throw new System.NotImplementedException();
        }
    }
}