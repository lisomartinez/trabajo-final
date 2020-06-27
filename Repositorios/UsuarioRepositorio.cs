using System;
using System.Collections.Generic;
using AccesoDatos;
using Entidades;
using Repositorios;

namespace Servicios
{
    public class UsuarioRepositorio : SqlRepositorio<Usuario>
    {
        public UsuarioRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override Usuario Guardar(Usuario entidad)
        {
            throw new NotImplementedException();
        }

        public override void Actualizar(Usuario entidad)
        {
            throw new NotImplementedException();
        }

        public override Usuario Obtener(Id id)
        {
            throw new NotImplementedException();
        }

        public override List<Usuario> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(Id id)
        {
            throw new NotImplementedException();
        }
    }
}