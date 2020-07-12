using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;
using Modelo;
using Servicios;
using Vistas;

namespace Controladores
{
    public class AgregarComponenteAListaPreciosControlador
    {
        private IAgregarComponenteAListaDePrecios _vista;
        private ProveedoresServicio _proveedoresServicio;
        private ProveedorModelo _proveedor;
        private ComponenteServicio _componenteServicio;

        public AgregarComponenteAListaPreciosControlador(IAgregarComponenteAListaDePrecios vista,
            ProveedorModelo proveedor)
        {
            _vista = vista;
            _proveedor = proveedor;
            _proveedoresServicio = new ProveedoresServicio();
            _componenteServicio = new ComponenteServicio();
        }

        public void MostrarComponentes()
        {
            try
            {
                if (Sesion.Instance.Rol == Rol.USUARIO) return;

                _vista.Componentes = _componenteServicio.ObtenerTodos().Select(ComponenteModelo.From).ToList();
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void AgregarComponente()
        {
            try
            {
                if (Sesion.Instance.Rol == Rol.USUARIO) return;

                var seleccionado = _vista.ComponenteSeleccionado;
                var precio = _vista.Precio;
                _proveedoresServicio.AgregarComponenteAListaDePrecios(_proveedor.ToEntity(),
                    new NumeroDeSerie(seleccionado.NumeroSerie), new Precio(precio));
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void MostrarComponente()
        {
            try
            {
                var seleccionado = _vista.ComponenteSeleccionado;
                _vista.NumeroDeSerie = seleccionado.NumeroSerie;
                _vista.Marca = seleccionado.Marca;
                _vista.Modelo = seleccionado.Modelo;
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }
    }
}