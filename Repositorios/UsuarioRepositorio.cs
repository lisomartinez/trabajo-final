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
        private const string EMAIL = "@EMAIL";
        private const string COMPUTADORA = "@COMPUTADORA";
        private const string ROL = "@ROL";


        public UsuarioRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override Usuario Guardar(Usuario entidad)
        {
            var consulta = "GuardarUsuario";
            Dictionary<string, object> parametros = CrearParametrosGuardar(entidad);
            var id = _accesoADatos.Escribir(consulta, parametros);
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
            var consulta = "ActualizarUsuario";
            Dictionary<string, object> parametros = CrearParametrosGuardar(entidad);
            _accesoADatos.Escribir(consulta, parametros);
        }

        public override Usuario Obtener(Id id)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object> {{LEGAJO, id.AsInt()}};
            return _accesoADatos.Leer("ObtenerUsuarioPorId", parametros)
                .AsEnumerable()
                .Select(ToUsuario)
                .ToList()[0];
        }

        private Usuario ToUsuario(DataRow fila)
        {
            

            return new Usuario(
                legajo: new Legajo(fila["legajo"] as int? ?? 0),
                nombre: fila["nombre"] as string,
                apellido: fila["apellido"] as string,
                email: fila["email"] as string,
                password: fila["password"] as string,
                rol: ObtenerRol(fila["rol"] as string),
                computadora: ObtenerComputadora(fila["computadoraId"] as string)
            );
        }

        private Computadora ObtenerComputadora(string s)
        {
            throw new NotImplementedException();
        }

        private Rol ObtenerRol(string s)
        {
            throw new NotImplementedException();
        }


        public override List<Usuario> ObtenerTodos()
        {
            return _accesoADatos.Leer("ObtenerTodosUsuario", null)
                .AsEnumerable()
                .Select(ToUsuario)
                .ToList();

        }

        public override void Eliminar(Id id)
        {
            var consulta = "EliminarUsuarioPorId";
            Dictionary<string, object> parametros = new Dictionary<string, object> { { LEGAJO, id.AsInt() } };
            _accesoADatos.Escribir(consulta, parametros);
        }
    }
}