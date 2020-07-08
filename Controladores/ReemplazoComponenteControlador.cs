using System;
using Entidades;
using Modelo;
using Servicios;
using Vistas;

namespace Controladores
{
    public class ReemplazoComponenteControlador
    {
        private IReemplazoComponenteVista _vista;
        private AsistenciaTecnicaModelo _asistenciaTecnicaModelo;
        private AsistenciaTecnicaServicio _servicio;

        public ReemplazoComponenteControlador(IReemplazoComponenteVista vista, AsistenciaTecnicaModelo asistenciaTecnicaModelo, AsistenciaTecnicaServicio servicio)
        {
            try
            {
                if (Sesion.Instance.Rol == Rol.USUARIO)  return;
                _vista = vista;
                _asistenciaTecnicaModelo = asistenciaTecnicaModelo;
                _servicio = servicio;
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }

        }

        public ReemplazoComponenteControlador(IReemplazoComponenteVista vista, AsistenciaTecnicaModelo asistenciaTecnicaModelo)
        {
            _vista = vista;
            _asistenciaTecnicaModelo = asistenciaTecnicaModelo;
            _servicio = new AsistenciaTecnicaServicio();
        }

        public void MostrarComputadora()
        {
            try
            {
                if (Sesion.Instance.Rol == Rol.USUARIO) return;

                var computadora = _asistenciaTecnicaModelo.Usuario.Computadora;
                _vista.Codigo = computadora.Codigo;
                _vista.Marca = computadora.Marca;
                _vista.Modelo = computadora.Modelo;
                _vista.Componentes = computadora.Componentes;
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }

        }

        public void ReemplazarComponente()
        {
            try
            {
                if (Sesion.Instance.Rol == Rol.USUARIO) return;

                var componenteSeleccionado = _vista.ComponenteSeleccionado;
                _vista.MostrarOrdenDeCompraForm(componenteSeleccionado);
                // _asistenciaTecnicaModelo.Estado = new EstadoAsistenciaTecnicaModelo();
                _servicio.ReemplazarComponente(_asistenciaTecnicaModelo.ToEntity(), componenteSeleccionado.ToEntity());
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }

        }
    }
}