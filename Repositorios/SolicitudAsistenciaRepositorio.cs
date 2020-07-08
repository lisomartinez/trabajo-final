using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using AccesoDatos;
using Entidades;

namespace Repositorios
{
    public class SolicitudAsistenciaRepositorio : SqlRepositorio<SolicitudAsistenciaTecnica>
    {
        private const string NRO_SOLICITUD = "@NroSolicitud";
        private const string USUARIO = "@Usuario";
        private const string DESCRIPCION = "@DESCRIPCION";
        private const string TIPO_PROBLEMA = "@TipoProblema";
        private const string TURNO = "@Turno";

        public SolicitudAsistenciaRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override SolicitudAsistenciaTecnica Guardar(SolicitudAsistenciaTecnica entidad)
        {
            var id = _accesoADatos.Escribir("GuardarSolicitudAsistencia", ParametrosSolicitud(entidad));
            entidad.Id = new NumeroSolicitud(id);
            return entidad;
        }

        private Dictionary<string, object> ParametrosSolicitud(SolicitudAsistenciaTecnica entidad)
        {
            return new Dictionary<string, object>
            {
                {NRO_SOLICITUD, entidad.Id.AsInt()},
                {USUARIO, entidad.Usuario.Id.AsInt()},
                {DESCRIPCION, entidad.Descripcion},
                {TIPO_PROBLEMA, entidad.TipoProblema.Id.AsInt()},
                {TURNO, entidad.Turno.Id.AsInt()}
            };
        }

        public override void Actualizar(SolicitudAsistenciaTecnica entidad)
        {
            _accesoADatos.Escribir("ActualizarSolicitudAsistencia", ParametrosSolicitud(entidad));
        }

        public override SolicitudAsistenciaTecnica Obtener(Id id)
        {
            return _accesoADatos.Leer("ObtenetSolicitudAsistenciaPorId", ParametroId(id))
                .AsEnumerable()
                .Select(ToSolicitudAsistencia)
                .ToList()[0];
        }

        private SolicitudAsistenciaTecnica ToSolicitudAsistencia(DataRow fila)
        {
            return new SolicitudAsistenciaTecnica(
                id: new NumeroSolicitud(fila["nroSolicitud"] as int? ?? 0),
                usuario: ObtenerUsuario(fila["usuario"] as int? ?? 0),
                descripcion: fila["descripcion"] as string,
                tipoProblema: ObtenerTipoProblema(fila["tipoProblema"] as int? ?? 0)
            );
        }

        private TipoProblema ObtenerTipoProblema(int i)
        {
            throw new NotImplementedException();
        }

        private Usuario ObtenerUsuario(int i)
        {
            throw new NotImplementedException();
        }

        private Dictionary<string, object> ParametroId(Id id)
        {
            return new Dictionary<string, object>
            {
                {NRO_SOLICITUD, id.AsInt()}
            };
        }

        public override List<SolicitudAsistenciaTecnica> ObtenerTodos()
        {
            return _accesoADatos.Leer("ObtenerTodosSolicitudesAsistencia", null)
                .AsEnumerable()
                .Select(ToSolicitudAsistencia)
                .ToList();
        }

        public override void Eliminar(Id id)
        {
            _accesoADatos.Escribir("EliminarSolicitudAsistenciaPorId", ParametroId(id));
        }
    }
}