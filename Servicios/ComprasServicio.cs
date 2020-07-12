using System.Collections.Generic;
using AccesoDatos;
using Entidades;
using Repositorios;

namespace Servicios
{
    public class ComprasServicio
    {
        private ComprasRepositorio _repositorio;
        private ProveedoresRepositorio _proveedoresRepositorio;

        public ComprasServicio()
        {
            _repositorio = new ComprasRepositorio(AccesoADatos.Instance);
        }

        public Dictionary<Proveedor, Precio> ObtenerProveedoresVendiendoComponente(Componente componente)
        {
            return _proveedoresRepositorio.ObtenerPorComponente(componente.NumeroDeSerie);
        }

        public void GenerarOrdenDeCompra(OrdenDeCompra ordenDeCompra)
        {
            _repositorio.Guardar(ordenDeCompra);
        }
    }
}