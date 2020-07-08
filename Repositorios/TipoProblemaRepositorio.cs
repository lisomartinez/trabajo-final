using System.Collections.Generic;
using System.Data;
using System.Linq;
using AccesoDatos;
using Entidades;

namespace Repositorios
{
    public class TipoProblemaRepositorio : SqlRepositorio<TipoProblema>
    {
        public const string ID = "@Id";
        public const string NOMBRE = "@Nombre";

        public TipoProblemaRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override TipoProblema Guardar(TipoProblema entidad)
        {
            var id = _accesoADatos.Escribir("GuardarTipoProblema", ParametroDesde(entidad));
            entidad.Id = new TipoProblemaId(id);
            return entidad;
        }

        private static Dictionary<string, object> ParametroDesde(TipoProblema entidad)
        {
            return new Dictionary<string, object>
            {
                {ID, entidad.Id.AsInt()},
                {NOMBRE, entidad.Nombre}
            };
        }

        public override void Actualizar(TipoProblema entidad)
        {
            _accesoADatos.Escribir("ActualizarTipoProblema", ParametroDesde(entidad));

        }

        public override TipoProblema Obtener(Id id)
        {
            return _accesoADatos.Leer("ObtenerTipoProblemaPorId", ParametroId(id))
                .AsEnumerable()
                .Select(ToTipoProblema)
                .ToList()[0];
        }

        private TipoProblema ToTipoProblema(DataRow fila)
        {
            return new TipoProblema(
                id: new TipoProblemaId( fila["id"] as int? ?? 0),
                nombre: fila["nombre"] as string
                );
        }

        private Dictionary<string, object> ParametroId(Id id)
        {
            return new Dictionary<string, object>
            {
                {ID, id.AsInt() }
            };
        }

        public override List<TipoProblema> ObtenerTodos()
        {
            return _accesoADatos.Leer("ObtenerTodosTipoProblema", null)
                .AsEnumerable()
                .Select(ToTipoProblema)
                .ToList();
        }

        public override void Eliminar(Id id)
        {
            _accesoADatos.Escribir("EliminarTipoProblemaPorId", ParametroId(id));
        }
    }
}