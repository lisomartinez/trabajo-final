using System;
using System.Collections.Generic;
using AccesoDatos;
using Entidades;
using Repositorios;

namespace Servicios
{
    public class UsuarioServicio
    {
        private UsuarioRepositorio _repositorio;

        public UsuarioServicio()
        {
            _repositorio = new UsuarioRepositorio(AccesoADatos.Instance);
        }

        public List<Usuario> ObtenerTodos()
        {
            try
            {
                return _repositorio.ObtenerTodos();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void CrearUsuario(Usuario usuario)
        {
            try
            {
                _repositorio.Guardar(usuario);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Actualizar(Usuario usuario)
        {
            try
            {
                _repositorio.Actualizar(usuario);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void EliminarUsuario(Usuario usuario)
        {
            try
            {
                _repositorio.Eliminar(usuario.Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void CambiarPassword(Usuario usuario)
        {
            try
            {
                _repositorio.Actualizar(usuario);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void GestionarComputadora(Usuario usuario)
        {
            try
            {
                _repositorio.Actualizar(usuario);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Usuario Logearse(string usuario, string password)
        {
            try
            {
                var usuarioGuardado = _repositorio.Obtener(new Id(int.Parse(usuario)));
                if (usuarioGuardado == null) return null;
                if (usuarioGuardado.Password != password) return null;
                return usuarioGuardado;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}