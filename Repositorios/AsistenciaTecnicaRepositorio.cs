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
        public AsistenciaTecnicaRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override AsistenciaTecnica Guardar(AsistenciaTecnica entidad)
        {
            var id = _accesoADatos.Escribir("GuardarAsistenciaTecnica", Parametros(entidad));
            entidad.Id =  new CodigoAsistencia(id);
            return entidad;
        }

        private Dictionary<string, object> Parametros(AsistenciaTecnica entidad)
        {
            return new Dictionary<string, object>
            {
                { CODIGO, entidad.Codigo.AsInt()},
                {FECHA, entidad.Fecha },
                {TECNICO, entidad.Id.AsInt() },
                {USUARIO, entidad.Usuario.Id.AsInt() },
                {TIPO_PROBLEMA,  entidad.TipoProblema.Id.AsInt()},
                {DESCRIPCION, entidad.DescripcionProblema },
                {CALIFICACION, entidad.Calificacion }
            };
        }

        public override void Actualizar(AsistenciaTecnica entidad)
        {
            _accesoADatos.Escribir("ActualizarAsistencia", Parametros(entidad));
        }

        public override AsistenciaTecnica Obtener(Id id)
        {
            return _accesoADatos.Leer("ObtenerAsistenciaPorId", ParametroId(id))
                .AsEnumerable()
                .Select(ToAsistencia)
                .ToList()[0];
        }

        private AsistenciaTecnica ToAsistencia(DataRow fila)
        {
            return new AsistenciaTecnica(
                codigo: new CodigoAsistencia(fila["codigo"] as int? ?? 0),
                fecha: DateTime.Parse(fila["fecha"] as string),
                tecnico: null,
                usuario: null,
                tipoProblema: null,
                descripcionProblema: fila["descripcion"] as string,
                estado: null,
                calificacion: fila["calificacion"] as int? ?? 0
            );

        }

        private Dictionary<string, object> ParametroId(Id id)
        {
            return new Dictionary<string, object>
            {
                { CODIGO, id.AsInt()},
            };
        }

        public override List<AsistenciaTecnica> ObtenerTodos()
        {
            return _accesoADatos.Leer("ObtenerTodosAsistencia", null)
                .AsEnumerable()
                .Select(ToAsistencia)
                .ToList();
        }

        public override void Eliminar(Id id)
        {
            _accesoADatos.Escribir("EliminarAsistenciaPorId", ParametroId(id));
        }
    }
}