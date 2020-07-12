using System;
using System.Linq;
using Controladores.Validadores;
using Entidades;
using Modelo;
using Servicios;
using Vistas;

namespace Controladores
{
    public class EstadoAsistenciaControlador
    {
        private IEstadoAsistenciaVista _vista;
        private EstadoAsistenciaTecnicaServicio _servicio;

        public EstadoAsistenciaControlador(IEstadoAsistenciaVista vista)
        {
            _vista = vista;
            _servicio = new EstadoAsistenciaTecnicaServicio();
        }

        public void MostrarEstados()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                _vista.Estados = _servicio.ObtenerTodos().Select(EstadoAsistenciaTecnicaModelo.From).ToList();
            }
            catch (Exception e)
            {
                _vista.MostrarException(e);
            }
           
        }

        public void EliminarEstado()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                var seleccionado = _vista.EstadoSeleccionado;
                _vista.Estados = _vista.Estados.Where(e => e.Codigo != seleccionado.Codigo).ToList();
                _servicio.EliminarEstado(seleccionado.ToEntity());
                _vista.Codigo = 0;
                _vista.Nombre = "";
                _vista.Descripcion = "";
            }
            catch (Exception e)
            {
                _vista.MostrarException(e);
            }
        }

        public void ModificarEstado()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                ValidarCampos();
                var seleccionado = _vista.EstadoSeleccionado;
                seleccionado.Nombre = _vista.Nombre;
                seleccionado.Descripcion = _vista.Descripcion;
                _servicio.Actualizar(seleccionado.ToEntity());
                _vista.Estados = _vista.Estados
                    .Where(e => e.Codigo != seleccionado.Codigo)
                    .Append(seleccionado)
                    .ToList();
            }
            catch (Exception e)
            {
                _vista.MostrarException(e);
            }
        }

        private void ValidarCampos()
        {
            try
            {
                var id = _vista.Codigo;
                if (Validador.ValidarId(id)) throw new ArgumentException("");
            }
            catch (Exception e)
            {
                throw new IdentificadorInvalidoException();
            }
        }

        public void AgregarEstado()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                ValidarCampos();
                var nuevo = new EstadoAsistenciaTecnicaModelo(_vista.Codigo, _vista.Nombre, _vista.Descripcion);
                _servicio.Guardar(nuevo.ToEntity());
                _vista.Estados = _vista.Estados
                    .Append(nuevo)
                    .ToList();
            }
            catch (Exception e)
            {
                _vista.MostrarException(e);
            }
        }

        public void MostrarEstado()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                var estado = _vista.EstadoSeleccionado;
                _vista.Codigo = estado.Codigo;
                _vista.Nombre = estado.Nombre;
                _vista.Descripcion = estado.Descripcion;
            }
            catch (Exception e)
            {
                _vista.MostrarException(e);
            }
        }
    }
}