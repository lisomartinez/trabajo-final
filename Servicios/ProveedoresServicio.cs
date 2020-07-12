using System.Collections.Generic;
using AccesoDatos;
using Entidades;
using Repositorios;

namespace Servicios
{
    public class ProveedoresServicio
    {
        private ProveedoresRepositorio _repositorio;

        public ProveedoresServicio()
        {
            _repositorio = new ProveedoresRepositorio(AccesoADatos.Instance);
        }

        public List<Proveedor> ObtenerProveedores()
        {
            return _repositorio.ObtenerTodos();
        }

        public void AltaProveedor(Proveedor proveedor)
        {
            _repositorio.Guardar(proveedor);
        }

        public void ModificarProveedor(Proveedor proveedor)
        {
            _repositorio.Actualizar(proveedor);
        }

        public void BajaProveedor(CUIT seleccionado)
        {
            _repositorio.Eliminar(seleccionado);
        }

        public void ActualizarPrecio(Proveedor proveedor, NumeroDeSerie numeroDeSerie, Precio precio)
        {
            _repositorio.ActualizarPrecio(proveedor, numeroDeSerie, precio);
        }

        public void AgregarComponenteAListaDePrecios(Proveedor proveedor, NumeroDeSerie numeroDeSerie, Precio precio)
        {
            _repositorio.AgregarComponenteAListaDePrecios(proveedor, numeroDeSerie, precio);
        }

        public void EliminarComponenteDeListaDePrecios(Proveedor proveedor, NumeroDeSerie numeroDeSerie)
        {
            _repositorio.EliminarComponenteDeListaDePrecios(proveedor, numeroDeSerie);
        }

        public Dictionary<Componente, Precio> ObtenerListaPrecios(Proveedor proveedor)
        {
            return _repositorio.ObtenerListaPrecios(proveedor.CUIT);
        }
    }
}