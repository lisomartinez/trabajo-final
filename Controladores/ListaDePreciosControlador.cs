using System;
using System.Linq;
using Controladores.Validadores;
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

        public ListaDePreciosControlador(IListaDePreciosVista vista, ProveedorModelo proveedorModelo)
        {
            _vista = vista;
            _proveedor = proveedorModelo;
            _servicio = new ProveedoresServicio();
        }

        public void MostrarListaDePrecios()
        {
            try
            {
                if (Sesion.Instance.Rol == Rol.USUARIO) return;

                _vista.ListaPrecios = _servicio.ObtenerListaPrecios(_proveedor.ToEntity())
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
                if (Sesion.Instance.Rol == Rol.USUARIO) return;

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
                if (Sesion.Instance.Rol == Rol.USUARIO) return;
                ValidarPrecio();

                var seleccionado = _vista.ComponenteSeleccionado;
                seleccionado.Precio = _vista.Precio;

                _servicio.ActualizarPrecio(_proveedor.ToEntity(), new NumeroDeSerie(seleccionado.NumeroSerie),
                    new Precio(seleccionado.Precio));
                _vista.ListaPrecios = _vista.ListaPrecios
                    .Where(lp => lp.NumeroSerie != seleccionado.NumeroSerie)
                    .Append(seleccionado)
                    .ToList();
                _vista.Precio = seleccionado.Precio;
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        private void ValidarPrecio()
        {
            try
            {
                var precio = _vista.Precio;
                if (!Validador.ValidarPrecio(precio)) throw new ArgumentException("");
            }
            catch (Exception e)
            {
                throw new PrecioInvalidoException();
            }
        }

        public void EliminarComponenteDeLista()
        {
            try
            {
                _servicio.EliminarComponenteDeListaDePrecios(_proveedor.ToEntity(),
                    new NumeroDeSerie(_vista.ComponenteSeleccionado.NumeroSerie));
                _vista.ListaPrecios = _vista.ListaPrecios
                    .Where(lp => lp.NumeroSerie != _vista.ComponenteSeleccionado.NumeroSerie)
                    .ToList();
                _vista.Marca = "";
                _vista.NumeroSerie = 0;
                _vista.Modelo = "";
                _vista.Precio = 0;
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void MostrarAgregarComponente()
        {
            try
            {
                _vista.MostrarAgregarForm(_proveedor);
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }
    }
}