using System;
using System.Linq;
using System.Runtime.InteropServices;
using Entidades;
using Modelo;
using Servicios;
using Vistas;

namespace Controladores
{
    public class SolicitudAsistenciaControlador
    {
        private ISolicitudAsistenciaVista _vista;
        private SolicitarAsistenciaServicio _servicio;
        private TipoProblemaServicio _tipoProblemaServicio;
        private SolicitudAsistenciaTecnica _solicitud = null;

        public SolicitudAsistenciaControlador(ISolicitudAsistenciaVista vista)
        {
            _vista = vista;
            _servicio = new SolicitarAsistenciaServicio();
            _tipoProblemaServicio = new TipoProblemaServicio();
        }

        public void CargarTiposDeProblemas()
        {
            try
            {
                var tiposDeProblemas = _tipoProblemaServicio.ObtenerTodos();
                _vista.TiposDeProblemas = tiposDeProblemas.Select(TipoProblemaModelo.From).ToList();
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void SolicitarTurno()
        {
            try
            {
                var usuario = Sesion.Instance.Usuario;
                var descripcion = _vista.Descripcion;
                var tipoProblemaSeleccionado = _vista.TipoProblemaSeleccionado.ToEntitty();

                _solicitud = new SolicitudAsistenciaTecnica(usuario, descripcion, tipoProblemaSeleccionado);
                var turnos = _servicio.SolicitarTurno(_solicitud);

                _vista.Turnos = turnos.Select(TurnoModelo.From).ToList();
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void ConfirmarTurno()
        {
            try
            {
                _solicitud.Turno = _vista.TurnoSeleccionado.ToEntity();
                _servicio.ConfirmarTurno(_solicitud);
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }
    }
}