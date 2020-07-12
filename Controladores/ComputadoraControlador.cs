using System;
using System.Linq;
using Entidades;
using Modelo;
using Servicios;
using Vistas;

namespace Controladores
{
    public class ComputadoraControlador
    {
        private IComputadoraVista _vista;
        private ComputadoraServicio _servicio;

        public ComputadoraControlador(IComputadoraVista vista)
        {
            _vista = vista;
            _servicio = new ComputadoraServicio();
        }

        public void MostrarComputadoras()
        {
            try
            {
                _vista.Computadoras = _servicio.ObtenerTodas().Select(ComputadoraModelo.From).ToList();
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void MostrarComputadora()
        {
            try
            {
                var seleccionada = _vista.ComputadoraSeleccionada;
                _vista.Codigo = seleccionada.Codigo;
                _vista.Marca = seleccionada.Marca;
                _vista.Modelo = seleccionada.Modelo;
                _vista.Componentes = seleccionada.Componentes;
                _vista.Software = seleccionada.Software;
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void AgregarComputadora()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                ValidarCampos();
             
                var computadora = new Computadora(new ComputadoraId(_vista.Codigo), _vista.Marca, _vista.Modelo,
                    _vista.Componentes.Select(c => c.ToEntity()).ToList(),
                    _vista.Software.Select(s => s.ToEntity()).ToList());
                _servicio.CrearComputadora(computadora);
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

        public void ModificarComputadora()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                ValidarCampos();
                var seleccionada = _vista.ComputadoraSeleccionada;
                seleccionada.Marca = _vista.Marca;
                seleccionada.Modelo = _vista.Modelo;
                seleccionada.Componentes = _vista.Componentes;
                seleccionada.Software = _vista.Software;

                _servicio.ActualizarComputadora(seleccionada.ToEntity());
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void EliminarComputadora()
        {
            try
            {
                var seleccionada = _vista.ComputadoraSeleccionada;
                _servicio.EliminarComputadora(seleccionada.ToEntity());
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
                _vista.MostrarComponentesForm(_vista.ComputadoraSeleccionada);
                _servicio.ActualizarSoftwareComputadora(_vista.ComputadoraSeleccionada.ToEntity());
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        
        public void EliminarComponente()
        {
            try
            {
                var componenteSeleccionado = _vista.ComponenteSeleccionado;
                _servicio.EliminarComponenteDeComputadora(_vista.ComputadoraSeleccionada.ToEntity(),
                    componenteSeleccionado.ToEntity());
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
                _vista.MostrarGestionarSoftwareForm(_vista.ComputadoraSeleccionada);
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
                var seleccionado = _vista.SoftwareSeleccionado;
                _servicio.EliminarSoftwareDeComputadora(_vista.ComputadoraSeleccionada.ToEntity(),
                    seleccionado.ToEntity());
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void GestionarComponentes()
        {
            _vista.MostrarComponentesForm(null);
        }

        public void GestionarSoftwares()
        {
            _vista.MostrarGestionarSoftwareForm(null);
        }
    }
}