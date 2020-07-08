using System.Collections.Generic;
using AccesoDatos;
using Entidades;
using Repositorios;

namespace Servicios
{
    public class ComprasServicio
    {
        private ComprasRepositorio _repositorio;

        public ComprasServicio()
        {
            _repositorio = new ComprasRepositorio(AccesoADatos.Instance);
        }

        public List<Proveedor> ObtenerProveedoresVendiendoComponente(Componente componente)
        {
            throw new System.NotImplementedException();
        }

        public void GenerarOrdenDeCompra(Componente componente)
        {
            throw new System.NotImplementedException();
        }
    }
}