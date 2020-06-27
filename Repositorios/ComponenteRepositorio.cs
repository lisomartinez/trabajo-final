using System;
using System.Collections.Generic;
using AccesoDatos;
using Entidades;

namespace Repositorios
{
    public class ComponenteRepositorio : SqlRepositorio<Componente>
    {
        public ComponenteRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override Componente Guardar(Componente entidad)
        {
            throw new NotImplementedException();
        }

        public override void Actualizar(Componente entidad)
        {
            throw new NotImplementedException();
        }

        public override Componente Obtener(Id id)
        {
            throw new NotImplementedException();
        }

        public override List<Componente> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(Id id)
        {
            throw new NotImplementedException();
        }
    }
}