using System;
using System.Linq;
using Modelo;
using Servicios;
using Vistas;

namespace Controladores
{
    public class OrdenDeCompraControlador
    {
        private IOrdenDeCompraVista _vista;
        private ComprasServicio _servicio;
        private ComponenteModelo _componenteModelo;

        public void MostrarProveedorVendiendoComponente()
        {
            try
            {
                _vista.Proveedores = _servicio.ObtenerProveedoresVendiendoComponente(_componenteModelo.ToEntity())
                    .Select(ProveedorModelo.From).ToList();
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void GenerarOrdenDeCompra()
        {
            try
            {
                _servicio.GenerarOrdenDeCompra(_componenteModelo.ToEntity());
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }
    }
}