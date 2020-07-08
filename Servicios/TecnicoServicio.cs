using System.Collections.Generic;
using AccesoDatos;
using Entidades;
using Repositorios;

namespace Servicios
{
    public class TecnicoServicio
    {
        private UsuarioRepositorio _repositorio;

        public TecnicoServicio()
        {
            _repositorio = new UsuarioRepositorio(AccesoADatos.Instance);
        }

        public List<Usuario> ObtenerTodos()
        {
            return _repositorio.ObtenerTodos();
        }

        public void CrearTecnico(Usuario tecnico)
        {
            _repositorio.Guardar(tecnico);
        }

        public void Actualizar(Usuario tecnico)
        {
            _repositorio.Actualizar(tecnico);
        }

        public void EliminarTecnico(Usuario tecnico)
        {
            _repositorio.Eliminar(tecnico.Id);
        }

        public void CambiarPassword(Usuario tecnico)
        {
            _repositorio.Actualizar(tecnico);
        }
    }
}