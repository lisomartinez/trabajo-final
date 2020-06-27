using System;
using System.Linq;
using Entidades;
using Modelo;
using Servicios;
using Vistas;

namespace Controladores
{
    public class ComponenteControlador
    {
        private IComponenteVista _vista;
        private ComponenteServicio _servicio;
        private ComputadoraModelo _computadoraModelo;

        public ComponenteControlador(IComponenteVista vista, ComponenteServicio servicio,
            ComputadoraModelo computadoraModelo)
        {
            _vista = vista;
            _servicio = servicio;
            _computadoraModelo = computadoraModelo;
        }

        public ComponenteControlador(IComponenteVista vista, ComponenteServicio servicio)
        {
            _vista = vista;
            _servicio = servicio;
        }

        public void MostrarComponentes()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                _vista.Componentes = _servicio.ObtenerTodos().Select(ComponenteModelo.From).ToList();
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
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                var seleccionado = _vista.ComponenteSeleccionado;
                _vista.NumeroSerie = seleccionado.NumeroSerie;
                _vista.Marca = seleccionado.Marca;
                _vista.Modelo = seleccionado.Modelo;
                MostrarEspecificacionesTecnicas(seleccionado);
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        private void MostrarEspecificacionesTecnicas(ComponenteModelo seleccionado)
        {
            throw new NotImplementedException();
        }

        public void AgregarComponente()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                ValidarCamposComponente();

                var componente = new Componente(new NumeroDeSerie(_vista.NumeroSerie), _vista.Marca, _vista.Modelo,
                    _vista.EspecificacionesTecnicas.Select(e => e.ToEntity()).ToList());

                _servicio.Guardar(componente);
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        private void ValidarCamposComponente()
        {
            throw new NotImplementedException();
        }

        public void ModificarComponente()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                ValidarCamposComponente();

                var seleccionado = _vista.ComponenteSeleccionado;
                seleccionado.Marca = _vista.Marca;
                seleccionado.Modelo = _vista.Modelo;
                seleccionado.EspecificacionesTecnicas = _vista.EspecificacionesTecnicas;

                _servicio.Modificar(seleccionado.ToEntity());
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
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                ValidarCamposComponente();

                var seleccionado = _vista.ComponenteSeleccionado;
                _servicio.Eliminar(seleccionado.ToEntity());
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }


        public void AgregarEspecificacionTecnica()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                ValidarCamposEspecificacionTecnica();

                var especificacion = new EspecificacionTecnicaModelo(
                    _vista.CodigoEspecificacionTecnica,
                    _vista.NombreEspecificacion,
                    _vista.DescripcionEspecificacion);

                var seleccionado = _vista.ComponenteSeleccionado;

                seleccionado.EspecificacionesTecnicas.Add(especificacion);

                _servicio.Modificar(seleccionado.ToEntity());
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        private void ValidarCamposEspecificacionTecnica()
        {
            throw new NotImplementedException();
        }

        public void ModificarEspecificacionTecnica()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                ValidarCamposEspecificacionTecnica();
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }


        public void EliminarEspecificacionTecnica()
        {
            try
            {
                var seleccionado = _vista.ComponenteSeleccionado;
                var especificacion = _vista.EspecificacionTecnicaSeleccionada;

                var aModificar = seleccionado.EspecificacionesTecnicas
                        .FirstOrDefault(et => et.Codigo == especificacion.Codigo);

                if (aModificar == null) throw new NotImplementedException();

                aModificar.Nombre = _vista.NombreEspecificacion;
                aModificar.Descripcion = _vista.DescripcionEspecificacion;

                _servicio.Modificar(seleccionado.ToEntity());
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void AgregarComponenteAComputadora()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;

                var componente = _vista.ComponenteSeleccionado;
                _computadoraModelo.Componentes.Add(componente);
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }
    }
}