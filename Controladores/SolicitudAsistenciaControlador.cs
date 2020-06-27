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
        private SolicitudAsistenciaTecnica solicitud;

        public SolicitudAsistenciaControlador(ISolicitudAsistenciaVista vista, SolicitarAsistenciaServicio servicio)
        {
            _vista = vista;
            _servicio = servicio;
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

                solicitud = new SolicitudAsistenciaTecnica(usuario, descripcion, tipoProblemaSeleccionado);
                var turnos = _servicio.SolicitarTurno(solicitud);

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
                solicitud.Turno = _vista.TurnoSeleccionado().ToEntity();
                _servicio.ConfirmarTurno(solicitud);
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }
    }
}