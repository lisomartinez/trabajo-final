using System;
using System.Collections.Generic;
using AccesoDatos;
using Entidades;

namespace Repositorios
{
    public class TurnoRepositorio : SqlRepositorio<Turno>
    {
        public TurnoRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override Turno Guardar(Turno entidad)
        {
            throw new NotImplementedException();
        }

        public override void Actualizar(Turno entidad)
        {
            throw new NotImplementedException();
        }

        public override Turno Obtener(Id id)
        {
            throw new NotImplementedException();
        }

        public override List<Turno> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(Id id)
        {
            throw new NotImplementedException();
        }
    }
}