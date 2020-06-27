using System;
using System.Linq;
using Servicios;
using Vistas;

namespace Controladores
{
    public class GestionarComputadoraUsuarioControlador
    {
        private IGestionarComputadoraUsuarioVista _vista;
        private UsuarioServicio _usuarioServicio;
        private ComputadoraServicio _computadoraServicio;
        private UsuarioModelo _usuarioModelo;

        public GestionarComputadoraUsuarioControlador(IGestionarComputadoraUsuarioVista vista,
            UsuarioServicio usuarioServicio, ComputadoraServicio computadoraServicio)
        {
            _vista = vista;
            _usuarioServicio = usuarioServicio;
            _computadoraServicio = computadoraServicio;
        }

        public void MostrarComputadoras()
        {
            try
            {
                var computadoras = _computadoraServicio.ObtenerComputadorasSinAsignar();
                computadoras.AddRange(_usuarioServicio.ObtenerTodos().Select(u => u.Computadora).ToList());

                _vista.Computadoras = computadoras.Select(ComputadoraModelo.From).ToList();
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }


        public void AsignarComputadora()
        {
            try
            {
                var seleccionada = _vista.ComputadoraSeleccionada;
                _usuarioModelo.Computadora = seleccionada;
                _usuarioServicio.Actualizar(_usuarioModelo.ToEntity());
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }


        public void DesasignarComputadora()
        {
            try
            {
                _usuarioModelo.Computadora = null;
                _usuarioServicio.Actualizar(_usuarioModelo.ToEntity());
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }
    }
}