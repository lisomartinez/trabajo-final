using System.Collections.Generic;
using System.Data;
using System.Linq;
using AccesoDatos;
using Entidades;

namespace Repositorios
{
    public class SoftwareRepositorio : SqlRepositorio<Software>
    {
        private const string CODIGO = "@Codigo";
        private const string NOMBRE = "@Nombre";
        private const string VERSION = "@Version";
        private const string DESARROLLADOR = "@Desarrollador";

        public SoftwareRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override Software Guardar(Software entidad)
        {
            var id = _accesoADatos.Escribir("GuardarSoftware", ParametrosSoftware(entidad));
            entidad.Id = new CodigoSoftware(id);
            return entidad;
        }

        private Dictionary<string, object> ParametrosSoftware(Software entidad)
        {
            return new Dictionary<string, object>
            {
                {CODIGO, entidad.Codigo.AsInt()},
                {NOMBRE, entidad.Nombre},
                {VERSION, entidad.Version},
                {DESARROLLADOR, entidad.Desarrollador}
            };
        }

        public override void Actualizar(Software entidad)
        {
            _accesoADatos.Escribir("ActualizarSoftware", ParametrosSoftware(entidad));
        }

        public override Software Obtener(Id id)
        {
            return _accesoADatos.Leer("ObtenerSoftwarePorId", ParametroId(id))
                .AsEnumerable()
                .Select(ToSoftware)
                .ToList()[0];
        }

        private Dictionary<string, object> ParametroId(Id id)
        {
            return new Dictionary<string, object>
            {
                {CODIGO, id.AsInt() }
            };
        }

        private Software ToSoftware(DataRow fila)
        {
            return new Software(
                codigo: new CodigoSoftware(fila["Codigo"] as int? ?? 0),
                nombre: fila["Nombre"] as string,
                version: fila["Version"] as string,
                desarrollador: fila["Desarrollador"] as string
                );
        }

        public override List<Software> ObtenerTodos()
        {
            return _accesoADatos.Leer("ObtenerTodosSoftware", null)
                .AsEnumerable()
                .Select(ToSoftware)
                .ToList();
        }

        public override void Eliminar(Id id)
        {
            _accesoADatos.Escribir("EliminarSoftwarePorId", ParametroId(id));
        }
    }
}