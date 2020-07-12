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
                cuit: new CUIT(fila["Cuit"] as int? ?? 0),
                razonSoncial: fila["RazonSocial"] as string,
                direccion: fila["Direccion"] as string,
                email: fila["Email"] as string,
                telefono: fila["Telefono"] as string
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

        public Dictionary<Proveedor, Precio> ObtenerPorComponente(NumeroDeSerie nroSerie)
        {
            return _accesoADatos.Leer("ObtenerPorComponente", ParametroNroSerie(nroSerie))
                .AsEnumerable()
                .Select(ToProveedorPrecio)
                .ToDictionary(k => k.Key, v => v.Value);

        }

        private KeyValuePair<Proveedor, Precio> ToProveedorPrecio(DataRow fila)
        {
            return new KeyValuePair<Proveedor, Precio>(ToProveedor(fila), ToPrecio(fila));
        }

        private Precio ToPrecio(DataRow fila)
        {
            return new Precio(fila["Precio"] as decimal? ?? 0);
        }

        private Dictionary<string, object> ParametroNroSerie(NumeroDeSerie nroSerie)
        {
            return new Dictionary<string, object>
            {
                {"@NumeroDeSerie", nroSerie.AsInt() }
            };
        }

        public void ActualizarPrecio(Proveedor proveedor, NumeroDeSerie numeroDeSerie, Precio precio)
        {
            _accesoADatos.Escribir("ActualizarListaDePrecios",
                ParametrosAgregarComponente(proveedor, numeroDeSerie, precio));
        }

        public void AgregarComponenteAListaDePrecios(Proveedor proveedor, NumeroDeSerie numeroDeSerie, Precio precio)
        {
            _accesoADatos.Escribir("AgregarComponenteAListaDePrecios",
                ParametrosAgregarComponente(proveedor, numeroDeSerie, precio));
        }

        private Dictionary<string, object> ParametrosAgregarComponente(Proveedor proveedor, NumeroDeSerie numeroDeSerie, Precio precio)
        {
            return new Dictionary<string, object>
            {
                {"@Cuit", proveedor.CUIT.AsInt() },
                {"@NumeroDeSerie", numeroDeSerie.AsInt() },
                {"@Precio", precio.Valor }
            };
        }


        public void EliminarComponenteDeListaDePrecios(Proveedor proveedor, NumeroDeSerie numeroDeSerie)
        {
            throw new System.NotImplementedException();
        }

        public Dictionary<Componente, Precio> ObtenerListaPrecios(CUIT cuit)
        {
            return _accesoADatos.Leer("ObtenerListaPrecios", ParametroId(cuit))
                .AsEnumerable()
                .Select(ToComponentProveedor)
                .ToDictionary(cp => cp.Key, cp => cp.Value);
        }

        private KeyValuePair<Componente, Precio> ToComponentProveedor(DataRow fila)
        {
            return new KeyValuePair<Componente, Precio>(ToComponente(fila), ToPrecio(fila));
        }

        private Componente ToComponente(DataRow fila)
        {
            return new Componente(
                numeroDeSerie: new NumeroDeSerie(fila["NumeroDeSerie"] as int? ?? 0),
                marca: fila["Marca"] as string,
                modelo: fila["Modelo"] as string,
                especificacionTecnicas: new List<EspecificacionTecnica>()
            );
        }
    }
}