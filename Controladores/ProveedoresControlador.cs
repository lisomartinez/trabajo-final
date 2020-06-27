using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;
using Servicios;
using Vistas;

namespace Controladores
{
    public class ProveedoresControlador
    {
        private IProveedoresVista _vista;
        private ProveedoresServicio _servicio;

        public ProveedoresControlador(IProveedoresVista vista, ProveedoresServicio servicio)
        {
            _vista = vista;
            _servicio = servicio;
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

                var cuit = new CUIT(_vista.Cuit);
                var proveedor = new Proveedor(
                    cuit: cuit, 
                    razonSoncial: _vista.RazonSocial,
                    direccion: _vista.Direccion,
                    email: _vista.Email,
                    telefono: _vista.Telefono);
                _servicio.AltaProveedor(proveedor);
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
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        private void ValidarCampos()
        {
            throw new NotImplementedException();
        }

        public void EliminarProveedor()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                var seleccionado = new CUIT(_vista.Cuit);
                _servicio.BajaProveedor(seleccionado);
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void GestionarListaDePrecios()
        {
            throw new NotImplementedException();
        }
    }
}