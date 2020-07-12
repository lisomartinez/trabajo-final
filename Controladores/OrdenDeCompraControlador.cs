using System;
using System.Linq;
using Entidades;
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
        private AsistenciaTecnicaModelo _asistencia;

        public OrdenDeCompraControlador(IOrdenDeCompraVista vista, ComponenteModelo componenteModelo,
            AsistenciaTecnicaModelo asistenciaTecnicaModelo)
        {
            _vista = vista;
            _componenteModelo = componenteModelo;
            _asistencia = asistenciaTecnicaModelo;
            _servicio = new ComprasServicio();
        }

        public void MostrarProveedorVendiendoComponente()
        {
            try
            {
                _vista.Proveedores = _servicio.ObtenerProveedoresVendiendoComponente(_componenteModelo.ToEntity())
                    .Select(ProveedorPrecioModelo.From)
                    .OrderBy(p => p.Precio)
                    .ToList();
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
                ProveedorModelo proveedor = _vista.ProveedorSeleccionado;
                var orden = new OrdenDeCompra(proveedor.ToEntity(), _asistencia.ToEntity(),
                    _componenteModelo.ToEntity(), new Precio(_vista.Precio));
                _servicio.GenerarOrdenDeCompra(orden);
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }
    }
}