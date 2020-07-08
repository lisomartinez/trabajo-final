using System.Collections.Generic;
using AccesoDatos;
using Entidades;
using Repositorios;

namespace Servicios
{
    public class SoftwareServicio
    {
        private SoftwareRepositorio _repositorio;

        public SoftwareServicio()
        {
            _repositorio = new SoftwareRepositorio(AccesoADatos.Instance);
        }


        public void AgregarSoftware(Software software)
        {
            _repositorio.Guardar(software);
        }

        public void ModificarSoftware(Software software)
        {
            _repositorio.Actualizar(software);
        }

        public void EliminarSoftware(Software software)
        {
            _repositorio.Eliminar(software.Id);
        }

        public List<Software> ObtenerTodos()
        {
           return _repositorio.ObtenerTodos();
        }
    }
}