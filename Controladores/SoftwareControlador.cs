using System;
using System.Linq;
using Entidades;
using Vistas;

namespace Controladores
{
    public class SoftwareControlador
    {
        private ISoftwareVista _vista;
        private SoftwareServicio _servicio;
        private ComputadoraModelo _computadoraModelo;
        public SoftwareControlador(ISoftwareVista vista, SoftwareServicio servicio)
        {
            _vista = vista;
            _servicio = servicio;
        }

        public void MostrarSoftwares()
        {
            try
            {
                _vista.Softwares = _servicio.ObtenerTodos().Select(SoftwareModelo.From).ToList();
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void MostrarSoftware()
        {
            try
            {
                var seleccionado = _vista.SoftwareSeleccionado;
                _vista.Codigo = seleccionado.Codigo;
                _vista.Nombre = seleccionado.Nombre;
                _vista.Version = seleccionado.Version;
                _vista.Desarrollador = seleccionado.Desarrollador;
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void AgregarSoftware()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                ValidarCampos();
                var software = new Software(new CodigoSoftware(_vista.Codigo), _vista.Nombre, _vista.Version, _vista.Desarrollador);
                _servicio.AgregarSoftware(software);
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


        public void ModificarSoftware()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                ValidarCampos();

                var seleccionado = _vista.SoftwareSeleccionado;
                seleccionado.Nombre = _vista.Nombre;
                seleccionado.Version = _vista.Version;
                seleccionado.Desarrollador = _vista.Desarrollador;
                _servicio.ModificarSoftware(seleccionado.ToEntity());
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void EliminarSoftware()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                ValidarCampos();

                var seleccionado = _vista.SoftwareSeleccionado;
                _servicio.EliminarSoftware(seleccionado.ToEntity());
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void InstalarSoftwareEnComputadora()
        {
            try
            {
                var seleccionado = _vista.SoftwareSeleccionado;
                _computadoraModelo.Software.Add(seleccionado);
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }
        
    }
}