using System;
using System.Collections.Generic;
using System.Linq;
using Controladores.Validadores;
using Entidades;
using Modelo;
using Servicios;
using Vistas;

namespace Controladores
{
    public class ProveedoresControlador
    {
        private IProveedoresVista _vista;
        private ProveedoresServicio _servicio;


        public ProveedoresControlador(IProveedoresVista vista)
        {
            _vista = vista;
            _servicio = new ProveedoresServicio();
        }

        public void MostrarProveedores()
        {
            try
            {
                _vista.Proveedores = _servicio.ObtenerProveedores().Select(ProveedorModelo.From).ToList();
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void MostrarProveedor()
        {
            try
            {
                var seleccionado =  _vista.ProveedorSeleccionado;
                _vista.Cuit = seleccionado.CUIT;
                _vista.RazonSocial = seleccionado.RazonSocial;
                _vista.Direccion = seleccionado.Direccion;
                _vista.Email = seleccionado.Email;
                _vista.Telefono = seleccionado.Telefono;
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void AltaProveedor()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                ValidarCampos();

                var proveedor = new ProveedorModelo(
                    cuit: _vista.Cuit, 
                    razonSocial: _vista.RazonSocial,
                    direccion: _vista.Direccion,
                    email: _vista.Email,
                    telefono: _vista.Telefono);
                _servicio.AltaProveedor(proveedor.ToEntity());
                _vista.Proveedores = _vista.Proveedores
                    .Append(proveedor)
                    .ToList();
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void ModificarProveedor()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                ValidarCampos();

                var seleccionado = _vista.ProveedorSeleccionado;
                seleccionado.RazonSocial = _vista.RazonSocial;
                seleccionado.Email = _vista.Email;
                seleccionado.Direccion = _vista.Direccion;
                seleccionado.Telefono = _vista.Telefono;
                _servicio.ModificarProveedor(seleccionado.ToEntity());
                _vista.Proveedores = _vista.Proveedores
                    .Where(p => p.CUIT != seleccionado.CUIT)
                    .Append(seleccionado)
                    .ToList();
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        private void ValidarCampos()
        {
            try
            {
                var id = _vista.Cuit;
                if (!Validador.ValidarId(id)) throw new ArgumentException("");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void EliminarProveedor()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                var seleccionado = _vista.ProveedorSeleccionado;
                _servicio.BajaProveedor(seleccionado.ToEntity().CUIT);
                _vista.Proveedores = _vista.Proveedores
                    .Where(p => p.CUIT != seleccionado.CUIT)
                    .ToList();
                _vista.Cuit = 0;
                _vista.Email = "";
                _vista.RazonSocial = "";
                _vista.Telefono = "";
                _vista.Direccion = "";
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void GestionarListaDePrecios()
        {
            _vista.MostrarListaPreciosForm(_vista.ProveedorSeleccionado);
        }
    }
}