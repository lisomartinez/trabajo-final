using System.Collections.Generic;
using Entidades;
using Repositorios;

namespace Servicios
{
    public class SoftwareServicio
    {
        private SoftwareRepositorio _repositorio;

        public SoftwareServicio(SoftwareRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void AgregarSoftware(Software software)
        {
            throw new System.NotImplementedException();
        }

        public void ModificarSoftware(Software software)
        {
            throw new System.NotImplementedException();
        }

        public void EliminarSoftware(Software software)
        {
            throw new System.NotImplementedException();
        }

        public List<Software> ObtenerTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}