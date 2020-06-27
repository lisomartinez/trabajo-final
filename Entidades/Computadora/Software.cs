using System.Collections.Generic;

namespace Entidades
{
    public class Software : Entidad
    {
        private SoftwareRepositorio _repositorio;
        public Software(Id id) : base(id)
        {
        }

        public Software(CodigoSoftware id, string vistaNombre, string vistaVersion, string vistaDesarrollador) : base(id)
        {
            throw new System.NotImplementedException();
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