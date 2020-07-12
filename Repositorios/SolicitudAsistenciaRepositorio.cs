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
        private const string NRO_SOLICITUD = "@NumeroSolicitud";
        private const string USUARIO = "@UsuarioLegajo";
        private const string DESCRIPCION = "@Descripcion";
        private const string TIPO_PROBLEMA = "@TipoProblemaId";
        private const string TURNO = "@TurnoId";

        private const string ActualizarSolicitudAsistencia = "ActualizarSolicitudAsistencia";
        private const string GuardarSolicitudAsistencia = "GuardarSolicitudAsistencia";
        private const string ObtenerSolicitudAsistenciaPorId = "ObtenetSolicitudAsistenciaPorId";
        private const string ObtenerTodosSolicitudesAsistencia = "ObtenerTodosSolicitudesAsistencia";
        private const string EliminarSolicitudAsistenciaPorId = "EliminarSolicitudAsistenciaPorId";

        public SolicitudAsistenciaRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override SolicitudAsistenciaTecnica Guardar(SolicitudAsistenciaTecnica entidad)
        {
            var id = _accesoADatos.Escribir(GuardarSolicitudAsistencia, ParametrosSolicitud(entidad));
            entidad.Id = new NumeroSolicitud(id);
            return entidad;
        }

        private Dictionary<string, object> ParametrosSolicitud(SolicitudAsistenciaTecnica entidad)
        {

            var parametros = new Dictionary<string, object>
            {
                {USUARIO, entidad.Usuario.Id.AsInt()},
                {DESCRIPCION, entidad.Descripcion},
                {TIPO_PROBLEMA, entidad.TipoProblema.Id.AsInt()},
            };
            
            if (!entidad.Id.Equals(Id.Empty))
            {
                parametros.Add(NRO_SOLICITUD, entidad.Id.AsInt());
            }

            if (entidad.Turno != null)
            {
                parametros.Add(TURNO, entidad.Turno.Id.AsInt());
            }

            

            return parametros;
        }

        public override void Actualizar(SolicitudAsistenciaTecnica entidad)
        {
            _accesoADatos.Escribir(ActualizarSolicitudAsistencia, ParametrosSolicitud(entidad));
        }

        public override SolicitudAsistenciaTecnica Obtener(Id id)
        {
            return _accesoADatos.Leer(ObtenerSolicitudAsistenciaPorId, ParametroId(id))
                .AsEnumerable()
                .Select(ToSolicitudAsistencia)
                .ToList()[0];
        }

        private SolicitudAsistenciaTecnica ToSolicitudAsistencia(DataRow fila)
        {
            return new SolicitudAsistenciaTecnica(
                id: new NumeroSolicitud(fila["NroSolicitud"] as int? ?? 0),
                usuario: ToUsuario(fila),
                descripcion: fila["Descripcion"] as string,
                tipoProblema: ToTipoProblema(fila),
                turno: ToTurno(fila)
            );
        }

        private Turno ToTurno(DataRow fila)
        {
            return new Turno(
                id: new TurnoId(fila["TurnoId"] as int? ?? 0),
                inicio: fila["InicioT"] as DateTime? ?? DateTime.Now,
                duracion: TimeSpan.Parse(fila["DuracionT"] as string),
                tecnico: ToTecnico(fila)
            );
        }


        private Usuario ToTecnico(DataRow fila)
        {
            return new Usuario(
                legajo: new Legajo(fila["LegajoT"] as int? ?? 0),
                nombre: fila["NombreT"] as string,
                apellido: fila["ApellidoT"] as string,
                rol: Rol.TECNICO,
                categoria: ToJerarquia(fila),
                computadora: ComputadoraSoloId(fila, Rol.TECNICO)
            );
        }

        private Jerarquia ToJerarquia(DataRow fila)
        {
            return new Jerarquia(
                id: new JerarquiId(fila["IdUJ"] as int? ?? 0),
                denominacion: fila["DenominacionUJ"] as string,
                valor: fila["ValorUJ"] as int? ?? 0
            );
        }


        private TipoProblema ToTipoProblema(DataRow fila)
        {
            return new TipoProblema(
                id: new TipoProblemaId(fila["IdTipoP"] as int? ?? 0),
                nombre: fila["NombreTipoP"] as string
            );
        }

        private Usuario ToUsuario(DataRow fila)
        {
            return new Usuario(
                legajo: new Legajo(fila["LegajoU"] as int? ?? 0),
                nombre: fila["NombreU"] as string,
                apellido: fila["ApellidoU"] as string,
                rol: Rol.USUARIO,
                categoria: ToJerarquia(fila),
                computadora: ComputadoraSoloId(fila, Rol.USUARIO)
            );
        }

        private Computadora ComputadoraSoloId(DataRow fila, Rol rol)
        {
            var id = rol == Rol.USUARIO ? "ComputadoraIdU" : "ComputadoraIdT";
            return new Computadora(new ComputadoraId(fila[id] as int? ?? 0));
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
            return _accesoADatos.Leer(ObtenerTodosSolicitudesAsistencia, null)
                .AsEnumerable()
                .Select(ToSolicitudAsistencia)
                .ToList();
        }

        public override void Eliminar(Id id)
        {
            _accesoADatos.Escribir(EliminarSolicitudAsistenciaPorId, ParametroId(id));
        }
    }
}