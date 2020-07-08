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

        public OrdenDeCompraControlador(IOrdenDeCompraVista vista, ComponenteModelo componenteModelo)
        {
            _vista = vista;
            _componenteModelo = componenteModelo;
            _servicio =new ComprasServicio();
        }

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