using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using AccesoDatos;
using Entidades;


namespace Repositorios
{
    public class UsuarioRepositorio : SqlRepositorio<Usuario>
    {
        private const string LEGAJO = "@Legajo";
        private const string NOMBRE = "@Nombre";
        private const string APELLIDO = "@Apellido";
        private const string PASSWORD = "@Password";
        private const string EMAIL = "@Email";
        private const string COMPUTADORA = "@ComputadoraId";
        private const string ROL = "@Rol";
        private const string GuardarUsuario = "GuardarUsuario";
        private const string ActualizarUsuario = "ActualizarUsuario";
        private const string ObtenerUsuarioPorId = "ObtenerUsuarioPorId";
        private const string ObtenerTodosUsuario = "ObtenerTodosUsuario";
        private const string EliminarUsuarioPorId = "EliminarUsuarioPorId";


        public UsuarioRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override Usuario Guardar(Usuario entidad)
        {
            var id = _accesoADatos.Escribir(GuardarUsuario, CrearParametrosGuardar(entidad));
            entidad.Id = new Legajo(id);
            return entidad;
        }

        private Dictionary<string, object> CrearParametrosGuardar(Usuario entidad)
        {
            return new Dictionary<string, object>
            {
                {LEGAJO, entidad.Id.AsInt()},
                {NOMBRE, entidad.Nombre},
                {APELLIDO, entidad.Apellido},
                {PASSWORD, entidad.Password},
                {EMAIL, entidad.Email},
                {ROL, entidad.Rol},
                {COMPUTADORA, entidad.Computadora.Id.AsInt()}
            };
        }

        public override void Actualizar(Usuario entidad)
        {
            _accesoADatos.Escribir(ActualizarUsuario, CrearParametrosGuardar(entidad));
        }

        public override Usuario Obtener(Id id)
        {
            return _accesoADatos.Leer(ObtenerUsuarioPorId, new Dictionary<string, object> {{LEGAJO, id.AsInt()}})
                .AsEnumerable()
                .Select(ToUsuario)
                .ToList()[0];
        }

        private Usuario ToUsuario(DataRow fila)
        {
            return new Usuario(
                legajo: new Legajo(fila["Legajo"] as int? ?? 0),
                nombre: fila["Nombre"] as string,
                apellido: fila["Apellido"] as string,
                email: fila["Email"] as string,
                password: fila["Password"] as string,
                rol: ToRol(fila["Rol"] as string),
                categoria: ToJerarquiaUsuario(fila),
                computadora: ToComputadora(fila)
            );
        }

        private Jerarquia ToJerarquiaUsuario(DataRow fila)
        {
            var value = fila["IdUJ"] as int? ?? 0;
            return new Jerarquia(
                id: new JerarquiId(value),
                denominacion: fila["DenominacionUJ"] as string,
                valor: fila["ValorUJ"] as int? ?? 0
            );
        }

        private Computadora ToComputadora(DataRow fila)
        {
            return new Computadora(
                id: new ComputadoraId(fila["Id"] as int? ?? 0),
                marca: fila["Marca"] as string,
                modelo: fila["Modelo"] as string,
                componentes: new List<Componente>(),
                software: new List<Software>()
            );
        }

        private Rol ToRol(string rol)
        {
            switch (rol)
            {
                case "TECNICO":
                    return Rol.TECNICO;
                case "USUARIO":
                    return Rol.USUARIO;
                default:
                    return Rol.JEFE;
            }
        }


        public override List<Usuario> ObtenerTodos()
        {
            return _accesoADatos.Leer(ObtenerTodosUsuario, null)
                .AsEnumerable()
                .Select(ToUsuario)
                .ToList();
        }

        public override void Eliminar(Id id)
        {
            _accesoADatos.Escribir(EliminarUsuarioPorId, new Dictionary<string, object> {{LEGAJO, id.AsInt()}});
        }
    }
}