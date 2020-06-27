using System;
using System.Collections.Generic;
using AccesoDatos;
using Entidades;
using Repositorios;

namespace Servicios
{
    public class ComputadoraRepositorio : SqlRepositorio<Computadora>
    {
        public ComputadoraRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override Computadora Guardar(Computadora entidad)
        {
            throw new NotImplementedException();
        }

        public override void Actualizar(Computadora entidad)
        {
            throw new NotImplementedException();
        }

        public override Computadora Obtener(Id id)
        {
            throw new NotImplementedException();
        }

        public override List<Computadora> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(Id id)
        {
            throw new NotImplementedException();
        }
    }
}