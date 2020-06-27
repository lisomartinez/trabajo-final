using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;
using Servicios;
using Vistas;

namespace Controladores
{
    public class AsistenciaTecnicaControlador
    {
        private IAsistenciaTecnicaVista _vista;
        private AsistenciaTecnicaServicio _servicio;

        public AsistenciaTecnicaControlador(IAsistenciaTecnicaVista vista, AsistenciaTecnicaServicio servicio)
        {
            _vista = vista;
            _servicio = servicio;
        }

        public void MostrarAsistencias()
        {
            try
            {
                List<AsistenciaTecnica> asistencias = new List<AsistenciaTecnica>();
                var usuario = Sesion.Instance.Usuario;
                switch (usuario.Rol)
                {
                    case Rol.TECNICO:
                        asistencias = _servicio.ObtenerAsistenciaTecnico(usuario.Legajo);
                        break;
                    case Rol.USUARIO:
                        asistencias = _servicio.ObtenerAsistenciasUsuario(usuario.Legajo);
                        break;
                    case Rol.JEFE:
                        asistencias = _servicio.ObtenerAsistenciasJefe(usuario.Legajo);
                        break;
                }

                _vista.AsistenciasTecnicas = asistencias.Select(AsistenciaTecnicaModelo.From).ToList();
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void MostrarAsistencia()
        {
            try
            {
                var seleccionada = _vista.AsistenciaSelccionado;
                _vista.Codigo = seleccionada.Codigo;
                _vista.TipoProblema = seleccionada.TipoProblema;
                _vista.Descripcion = seleccionada.Descripcion;
                _vista.Estado = seleccionada.Estado;
                _vista.Fecha = seleccionada.Fecha;
                _vista.Usuario = seleccionada.Usuario;
                _vista.Tecnico = seleccionada.Tecnico;
                _vista.Calificacion = seleccionada.Calificacion;
                HabilitarBotonesSegunRol(Sesion.Instance.Rol);
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void ModificarAsistencia()
        {
            try
            {
                var seleccionada = _vista.AsistenciaSelccionado;
                ValidarCampos();
                seleccionada.Codigo = _vista.Codigo;
                seleccionada.TipoProblema = _vista.TipoProblema;
                seleccionada.Descripcion = _vista.Descripcion;
                seleccionada.Estado = _vista.Estado;
                seleccionada.Fecha = _vista.Fecha;
                seleccionada.Usuario = _vista.Usuario;
                seleccionada.Tecnico = _vista.Tecnico;
                seleccionada.Calificacion = _vista.Calificacion;
                _servicio.Modificar(seleccionada.ToEntity());
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

        public void EliminarAsistencia()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                
                var seleccionada = _vista.AsistenciaSelccionado;
                _servicio.EliminarAsistencia(seleccionada.ToEntity().Codigo);
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }


        public void GestionarComputadora()
        {
            try
            {
                if (Sesion.Instance.Rol == Rol.USUARIO) return;
                var seleccionada = _vista.AsistenciaSelccionado;
                throw new NotImplementedException();

            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }


        public void ActualizarEstado()
        {
            try
            {
                ValidarCampos();
                var seleccionada = _vista.AsistenciaSelccionado.ToEntity();
                seleccionada.Estado = _vista.Estado.ToEntity();
                _servicio.ActualizarEstado(seleccionada);
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void CalificarAsistencia()
        {
            try
            {
                ValidarCampos();
                if (Sesion.Instance.Rol != Rol.USUARIO) return;

                var seleccionada = _vista.AsistenciaSelccionado.ToEntity();
                seleccionada.Calificacion = _vista.Calificacion;
                _servicio.CalificarAsistencia(seleccionada);
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        private void HabilitarBotonesSegunRol(Rol rol)
        {
            switch (rol)
            {
                case Rol.USUARIO:
                    break;
                case Rol.TECNICO:
                    break;
                case Rol.JEFE:
                    break;
                default:
                    break;
            }
        }
    }
}