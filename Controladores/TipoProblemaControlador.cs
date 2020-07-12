using System;
using System.Linq;
using Controladores.Validadores;
using Entidades;
using Modelo;
using Servicios;
using Vistas;

namespace Controladores
{
    public class TipoProblemaControlador
    {
        private ITipoProblemaVista _vista;
        private TipoProblemaServicio _servicio;

        public TipoProblemaControlador(ITipoProblemaVista vista)
        {
            _vista = vista;
            _servicio = new TipoProblemaServicio();
        }

        public void MostrarTiposProblemas()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;

                _vista.TiposProblemas = _servicio.ObtenerTodos().Select(TipoProblemaModelo.From).ToList();
            }
            catch (Exception e)
            {
                _vista.MostrarException(e);
            }
        }

        public void MostrarTipoProblema()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;

                var seleccionado = _vista.TipoProblemaSeleccionado;
                _vista.Id = seleccionado.Id;
                _vista.Nombre = seleccionado.Nombre;
            }
            catch (Exception e)
            {
                _vista.MostrarException(e);
            }
        }

        public void AgregarTipoProblema()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                ValidarCampos();
                var nuevo =  new TipoProblemaModelo(_vista.Id, _vista.Nombre);
                _servicio.Guardar(nuevo.ToEntitty());
                _vista.TiposProblemas = _vista.TiposProblemas
                    .Append(nuevo)
                    .ToList();
            }
            catch (Exception e)
            {
                _vista.MostrarException(e);
            }
        }

        public void ModificarTipoProblema()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                ValidarCampos();
                var seleccionado = _vista.TipoProblemaSeleccionado;
                seleccionado.Id = _vista.Id;
                seleccionado.Nombre = _vista.Nombre;
                _servicio.Actualizar(seleccionado.ToEntitty());
                _vista.TiposProblemas = _vista.TiposProblemas
                    .Where(tp => tp.Id != seleccionado.Id)
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
                var id = _vista.Id;
                if (Validador.ValidarId(id)) throw new ArgumentException("");
            }
            catch (Exception e)
            {
                throw new IdentificadorInvalidoException();
            }
        }

        public void EliminarTipoProblema()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                var seleccionado = _vista.TipoProblemaSeleccionado;
                var id = _vista.TipoProblemaSeleccionado.ToEntitty().Id;
                _servicio.Eliminar(id);
                _vista.TiposProblemas = _vista.TiposProblemas
                    .Where(tp => tp.Id != seleccionado.Id)
                    .Append(seleccionado)
                    .ToList();
            }
            catch (Exception e)
            {
                _vista.MostrarException(e);
            }
        }
    }
}