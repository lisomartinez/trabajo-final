using System;
using System.Collections.Generic;
using AccesoDatos;
using Entidades;
using Repositorios;

namespace Servicios
{
    public class AsistenciaTecnicaRepositorio : SqlRepositorio<AsistenciaTecnica>
    {
        public AsistenciaTecnicaRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override AsistenciaTecnica Guardar(AsistenciaTecnica entidad)
        {
            throw new NotImplementedException();
        }

        public override void Actualizar(AsistenciaTecnica entidad)
        {
            throw new NotImplementedException();
        }

        public override AsistenciaTecnica Obtener(Id id)
        {
            throw new NotImplementedException();
        }

        public override List<AsistenciaTecnica> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(Id id)
        {
            throw new NotImplementedException();
        }
    }
}