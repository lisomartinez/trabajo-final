using System;
using System.Linq;
using Entidades;
using Modelo;
using Vistas;
using Servicios;
namespace Controladores
{
    public class UsuarioControlador
    {
        private IUsuarioVista _vista;
        private UsuarioServicio _servicio;

        public UsuarioControlador(IUsuarioVista vista)
        {
            _vista = vista;
            _servicio = new UsuarioServicio();
        }

        public void MostrarUsuarios()
        {
            try
            {
                _vista.Usuarios = _servicio.ObtenerTodos().Select(UsuarioModelo.From).ToList();
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void MostrarUsuario()
        {
            try
            {
                var seleccionado = _vista.UsuarioSeleccionado;
                _vista.Legajo = seleccionado.Legajo;
                _vista.Nombre = seleccionado.Nombre;
                _vista.Apellido = seleccionado.Apellido;
                _vista.Email = seleccionado.Email;
                // _vista.Rol = seleccionado.Rol;
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }


        public void CrearUsuario()
        {
            try
            {
                ValidarCampos();
                // var Usuario = new Usuario(new Legajo(_vista.Legajo), _vista.Nombre, _vista.Apellido, _vista.Email, _vista.Rol.ToEntity());
                // _servicio.CrearUsuario(Usuario);
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        private void ValidarCampos()
        {
            throw new NotImplementedException();
        }

        public void ModificarUsuario()
        {
            try
            {
                ValidarCampos();
                var seleccionado = _vista.UsuarioSeleccionado;
                seleccionado.Nombre = _vista.Nombre;
                seleccionado.Apellido = _vista.Apellido;
                seleccionado.Email = _vista.Email;
                // seleccionado.Rol = _vista.Rol;
                _servicio.Actualizar(seleccionado.ToEntity());
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void EliminarUsuario()
        {
            try
            {
                var usuario = _vista.UsuarioSeleccionado.ToEntity();
                _servicio.EliminarUsuario(usuario);
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void CambiarPassword()
        {
            try
            {
                var seleccionado = _vista.UsuarioSeleccionado;
                _vista.SolicitarIngresoPassword();
                // seleccionado.Password =   _vista.Password;
                _servicio.CambiarPassword(seleccionado.ToEntity());
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void GestionarComputadora()
        {
            try
            {
                _vista.MostrarGestionarComputadoraForm(_vista.UsuarioSeleccionado);
                _servicio.GestionarComputadora(_vista.UsuarioSeleccionado.ToEntity());
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }
    }
}