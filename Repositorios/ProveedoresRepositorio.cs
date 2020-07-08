using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using AccesoDatos;
using Entidades;

namespace Repositorios
{
    public class ProveedoresRepositorio : SqlRepositorio<Proveedor>
    {
        private const string CUIT = "@Cuit";
        private const string RAZON_SOCIAL = "@RazonSocial";
        private const string DiRECCION = "@Direccion";
        private const string EMAIL = "@Email";
        private const string TELEFONO = "@Telefono";


        public ProveedoresRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override Proveedor Guardar(Proveedor entidad)
        {
            var id = _accesoADatos.Escribir("GuardarProveedor", ParametrosProveedor(entidad));
            entidad.Id = new CUIT(id);
            return entidad;
        }

        private Dictionary<string, object> ParametrosProveedor(Proveedor entidad)
        {
            return new Dictionary<string, object>
            {
                {CUIT, entidad.CUIT.AsInt()},
                {RAZON_SOCIAL, entidad.RazonSoncial},
                {DiRECCION, entidad.Direccion},
                {EMAIL, entidad.Email},
                {TELEFONO, entidad.Telefono}
            };
        }

        public override void Actualizar(Proveedor entidad)
        {
            _accesoADatos.Escribir("ActualizarProveedor", ParametrosProveedor(entidad));
        }

        public override Proveedor Obtener(Id id)
        {
            return _accesoADatos.Leer("ObtenerProveedorPorId", ParametroId(id))
                .AsEnumerable()
                .Select(ToProveedor)
                .ToList()[0];
        }

        private Proveedor ToProveedor(DataRow fila)
        {
            return new Proveedor(
                cuit: new CUIT(fila["cuit"] as int? ?? 0),
                razonSoncial: fila["razonSocial"] as string,
                direccion: fila["direccion"] as string,
                email: fila["email"] as string,
                telefono: fila["telefono"] as string
            );
        }

        private Dictionary<string, object> ParametroId(Id id)
        {
            return new Dictionary<string, object>
            {
                {CUIT, id.AsInt()}
            };
        }

        public override List<Proveedor> ObtenerTodos()
        {
            return _accesoADatos.Leer("ObtenerTodosProveedor", null)
                .AsEnumerable()
                .Select(ToProveedor)
                .ToList();
        }

        public override void Eliminar(Id id)
        {
            _accesoADatos.Escribir("EliminarProveedorPorId", ParametroId(id));
        }
    }
}