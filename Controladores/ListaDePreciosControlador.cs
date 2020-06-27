using System;
using System.Linq;
using Entidades;
using Modelo;
using Servicios;
using Vistas;

namespace Controladores
{
    public class ListaDePreciosControlador
    {
        private IListaDePreciosVista _vista;
        private ProveedorModelo _proveedor;
        private ProveedoresServicio _servicio;

        public ListaDePreciosControlador(IListaDePreciosVista vista, ProveedorModelo proveedor,
            ProveedoresServicio servicio)
        {
            _vista = vista;
            _proveedor = proveedor;
            _servicio = servicio;
        }

        public void MostrarListaDePrecios()
        {
            try
            {
                if (Sesion.Instance.Rol == Rol.USUARIO) return;

                _vista.ListaPrecios = _proveedor.ListaDePrecios(_proveedor.ToEntity())
                    .Select(ComponentePrecioModelo.From)
                    .ToList();
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void MostrarPrecioComponente()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.TECNICO) return;

                var seleccionado = _vista.ComponenteSeleccionado;
                _vista.NumeroSerie = seleccionado.NumeroSerie;
                _vista.Marca = seleccionado.Marca;
                _vista.Modelo = seleccionado.Modelo;
                _vista.Precio = seleccionado.Precio;
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }


        public void CambiarPrecio()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.TECNICO) return;
                ValidarPrecio();

                var seleccionado = _vista.ComponenteSeleccionado;
                seleccionado.Precio = _vista.Precio;

                _servicio.ActualizarPrecio(_proveedor.ToEntity(), new NumeroDeSerie(seleccionado.NumeroSerie),
                    new Precio(seleccionado.Precio));
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        private void ValidarPrecio()
        {
            throw new NotImplementedException();
        }
    }
}