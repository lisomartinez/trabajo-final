using System.Collections.Generic;
using System.Data;
using System.Linq;
using AccesoDatos;
using Entidades;

namespace Repositorios
{
    public class ComprasRepositorio : SqlRepositorio<OrdenDeCompra>
    {
        private const string CODIGO = "@Codigo";
        private const string PRECIO = "@Precio";
        private const string ASISTENCIA = "@Asistencia";
        private const string COMPONENTE = "@Componente";
        private const string PROVEEDOR = "@Proveedor";

        public ComprasRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override OrdenDeCompra Guardar(OrdenDeCompra entidad)
        {
            var id = _accesoADatos.Escribir("GuardarOrdenCompra", Parametros(entidad));
            entidad.Id = new CodigoOrdenDeCompra(id);
            return entidad;
        }

        private Dictionary<string, object> Parametros(OrdenDeCompra entidad)
        {
            return new Dictionary<string, object>
            {
                { CODIGO, entidad.Id.AsInt() },
                { PRECIO, entidad.Precio }
            };
        }

        public override void Actualizar(OrdenDeCompra entidad)
        {
            _accesoADatos.Escribir("ActualizarOrdenCompra", Parametros(entidad));
        }

        public override OrdenDeCompra Obtener(Id id)
        {
           return _accesoADatos.Leer("ObtenerOrdenCompraPorId", ParametroId(id))
                .AsEnumerable()
                .Select(ToOrdenCompra)
                .ToList()[0];
        }

        private OrdenDeCompra ToOrdenCompra(DataRow fila)
        {
            return new OrdenDeCompra(
                codigo: new CodigoOrdenDeCompra(fila["codigo"] as int? ?? 0),
                proveedor: null,
                asistenciaTecnica: null,
                componente: null,
                precio: null
                );
        }

        private Dictionary<string, object> ParametroId(Id id)
        {
            return new Dictionary<string, object>
            {
                { CODIGO, id.AsInt() }
            };
        }

        public override List<OrdenDeCompra> ObtenerTodos()
        {
            return _accesoADatos.Leer("ObtenerTodosOrdenCompra", null)
                .AsEnumerable()
                .Select(ToOrdenCompra)
                .ToList();
        }

        public override void Eliminar(Id id)
        {
            _accesoADatos.Escribir("EliminarOrdenCompraPorId", ParametroId(id));
        }
    }
}