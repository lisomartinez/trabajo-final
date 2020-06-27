using System;
using System.Collections.Generic;
using AccesoDatos;
using Entidades;
using Repositorios;

namespace Servicios
{
    public class SolicitudAsistenciaRepositorio : SqlRepositorio<SolicitudAsistenciaTecnica>
    {
        public SolicitudAsistenciaRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override SolicitudAsistenciaTecnica Guardar(SolicitudAsistenciaTecnica entidad)
        {
            throw new NotImplementedException();
        }

        public override void Actualizar(SolicitudAsistenciaTecnica entidad)
        {
            throw new NotImplementedException();
        }

        public override SolicitudAsistenciaTecnica Obtener(Id id)
        {
            throw new NotImplementedException();
        }

        public override List<SolicitudAsistenciaTecnica> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(Id id)
        {
            throw new NotImplementedException();
        }
    }
}