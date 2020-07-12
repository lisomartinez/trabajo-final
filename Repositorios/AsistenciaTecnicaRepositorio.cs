using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using AccesoDatos;
using Entidades;

namespace Repositorios
{
    public class AsistenciaTecnicaRepositorio : SqlRepositorio<AsistenciaTecnica>
    {
        private const string CODIGO = "@Codigo";
        private const string FECHA = "@Fecha";
        private const string TECNICO = "@Tecnico";
        private const string USUARIO = "@Usuario";
        private const string TIPO_PROBLEMA = "@TipoProblema";
        private const string DESCRIPCION = "@Descripcion";
        private const string CALIFICACION = "@Calificacion";
        private const string ESTADO = "@Estado";
        private const string LEGAJO = "@LEGAJO";

        private const string ObtenerTodosAsistencia = "ObtenerTodosAsistencia";
        private const string EliminarAsistenciaPorId = "EliminarAsistenciaPorId";
        private const string ObtenerAsistenciaPorId = "ObtenerAsistenciaPorId";
        private const string ActualizarAsistencia = "ActualizarAsistencia";
        private const string GuardarAsistenciaTecnica = "GuardarAsistenciaTecnica";
        private const string ObtenerPorLegajoUsuario = "ObtenerAsistenciaPorUsuario";
        private const string ObtenerPorLegajoTecnico = "ObtenerAsistenciaPorTecnico";

        public AsistenciaTecnicaRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override AsistenciaTecnica Guardar(AsistenciaTecnica entidad)
        {
            var id = _accesoADatos.Escribir(GuardarAsistenciaTecnica, Parametros(entidad));
            // entidad.Id = new CodigoAsistencia(id);
            return entidad;
        }

        private Dictionary<string, object> Parametros(AsistenciaTecnica entidad)
        {
            var parametros = new Dictionary<string, object>
            {
                {CODIGO, entidad.Codigo.AsInt()},
                {FECHA, entidad.Fecha},
                {TECNICO, entidad.Tecnico.Id.AsInt()},
                {USUARIO, entidad.Usuario.Id.AsInt()},
                {TIPO_PROBLEMA, entidad.TipoProblema.Id.AsInt()},
                {DESCRIPCION, entidad.DescripcionProblema}
            };

            if (entidad.Estado != null)
            {
                parametros.Add(ESTADO, entidad.Estado);
            }

            if (entidad.Calificacion != -1)
            {
                parametros.Add(CALIFICACION, entidad.Calificacion);
            }

            return parametros;
        }

        public override void Actualizar(AsistenciaTecnica entidad)
        {
            _accesoADatos.Escribir(ActualizarAsistencia, Parametros(entidad));
        }

        public override AsistenciaTecnica Obtener(Id id)
        {
            return _accesoADatos.Leer(ObtenerAsistenciaPorId, ParametroId(id))
                .AsEnumerable()
                .Select(ToAsistencia)
                .ToList()[0];
        }

        //TODO: handle null calification.
        private AsistenciaTecnica ToAsistencia(DataRow fila)
        {
            return new AsistenciaTecnica(
                codigo: new CodigoAsistencia(fila["Codigo"] as int? ?? 0),
                fecha: fila["Fecha"] as DateTime? ?? new DateTime(),
                tecnico: ToTecnico(fila),
                usuario: ToUsuario(fila),
                tipoProblema: ToTipoProblema(fila),
                descripcionProblema: fila["Descripcion"] as string,
                estado: ToEstado(fila),
                calificacion: fila["Calificacion"] as int? ?? 0
            );
        }

        private EstadoAsistenciaTecnica ToEstado(DataRow fila)
        {
            return new EstadoAsistenciaTecnica(
                codigo: new CodigoEstadoAsistencia(fila["IdEst"] as int? ?? 0),
                nombre: fila["NombreEst"] as string,
                descripcion: ""
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
                categoria: ToJerarquiaUsuario(fila),
                rol: Rol.USUARIO,
                computadora: ComputadoraSoloId(fila, Rol.USUARIO)
            );
        }

        private Jerarquia ToJerarquiaUsuario(DataRow fila)
        {
            return new Jerarquia(
                id: new JerarquiId(fila["IdUJ"] as int? ?? 0),
                denominacion: fila["DenominacionUJ"] as string,
                valor: fila["ValorUJ"] as int? ?? 0
            );
        }

        private static Computadora ComputadoraSoloId(DataRow fila, Rol rol)
        {
            var id = rol == Rol.USUARIO ? "ComputadoraIdU" : "ComputadoraIdT";
            return new Computadora(
                new ComputadoraId(fila[id] as int? ?? 0),
                fila["MarcaU"] as string,
                fila["ModeloU"] as string,
                new List<Componente>(),
                new List<Software>()
            );
        }


        private Usuario ToTecnico(DataRow fila)
        {
            return new Usuario(
                legajo: new Legajo(fila["LegajoT"] as int? ?? 0),
                nombre: fila["NombreT"] as string,
                apellido: fila["ApellidoT"] as string,
                categoria: ToJerarquiaTecnico(fila),
                rol: Rol.TECNICO,
                computadora: ComputadoraSoloId(fila, Rol.TECNICO)
            );
        }

        private Jerarquia ToJerarquiaTecnico(DataRow fila)
        {
            return new Jerarquia(
                id: new JerarquiId(fila["IdTJ"] as int? ?? 0),
                denominacion: fila["DenominacionTJ"] as string,
                valor: fila["ValorTJ"] as int? ?? 0
            );
        }

        private Dictionary<string, object> ParametroId(Id id)
        {
            return new Dictionary<string, object>
            {
                {CODIGO, id.AsInt()},
            };
        }

        public override List<AsistenciaTecnica> ObtenerTodos()
        {
            return _accesoADatos.Leer(ObtenerTodosAsistencia, null)
                .AsEnumerable()
                .Select(ToAsistencia)
                .ToList();
        }

        public override void Eliminar(Id id)
        {
            _accesoADatos.Escribir(EliminarAsistenciaPorId, ParametroId(id));
        }

        public List<AsistenciaTecnica> ObtenerPorLegajo(Legajo legajo)
        {
            return _accesoADatos.Leer(ObtenerPorLegajoUsuario, ParametroLegajo(legajo))
                .AsEnumerable()
                .Select(ToAsistencia)
                .ToList();
        }

        private Dictionary<string, object> ParametroLegajo(Legajo legajo)
        {
            return new Dictionary<string, object>
            {
                {LEGAJO, legajo.AsInt()}
            };
        }

        public List<AsistenciaTecnica> ObtenerPorTecnico(Legajo legajo)
        {
            return _accesoADatos.Leer(ObtenerPorLegajoTecnico, ParametroLegajo(legajo))
                .AsEnumerable()
                .Select(ToAsistencia)
                .ToList();
        }
    }
}