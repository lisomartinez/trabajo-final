﻿using System;
using System.Linq;
using Entidades;
using Vistas;

namespace Controladores
{
    public class TecnicoControlador
        {
            private ITecnicoVista _vista;
            private TecnicoServicio _servicio;

            public TecnicoControlador(ITecnicoVista vista, TecnicoServicio servicio)
            {
                _vista = vista;
                _servicio = servicio;
            }

            public void MostrarTecnicos()
            {
                try
                {
                    _vista.Tecnicos = _servicio.ObtenerTodos().Select(UsuarioModelo.From).ToList();
                }
                catch (Exception e)
                {
                    _vista.MostrarExcepcion(e);
                }
            }

            public void MostrarUsuario()
            {
                try
                {
                    var seleccionado = _vista.TecnicoSeleccionado;
                    _vista.Legajo = seleccionado.Legajo;
                    _vista.Nombre = seleccionado.Nombre;
                    _vista.Apellido = seleccionado.Apellido;
                    _vista.Email = seleccionado.Email;
                }
                catch (Exception e)
                {
                    _vista.MostrarExcepcion(e);
                }
            }


            public void CrearTecnico()
            {
                try
                {
                    ValidarCampos();
                    var usuario = new Usuario(new Legajo(_vista.Legajo), _vista.Nombre, _vista.Apellido, _vista.Email, Rol.TECNICO);
                    _servicio.CrearTecnico(usuario);
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

            public void ModificarUsuario()
            {
                try
                {
                    ValidarCampos();
                    var seleccionado = _vista.TecnicoSeleccionado;
                    seleccionado.Nombre = _vista.Nombre;
                    seleccionado.Apellido = _vista.Apellido;
                    seleccionado.Email = _vista.Email;
                    _servicio.Actualizar(seleccionado.ToEntity());
                }
                catch (Exception e)
                {
                    _vista.MostrarExcepcion(e);
                }
            }

            public void EliminarUsuario()
            {
                try
                {
                    var tecnico = _vista.TecnicoSeleccionado.ToEntity();
                    _servicio.EliminarTecnico(tecnico);
                }
                catch (Exception e)
                {
                    _vista.MostrarExcepcion(e);
                }
            }

            public void CambiarPassword()
            {
                try
                {
                    var seleccionado = _vista.TecnicoSeleccionado;
                    _vista.SolicitarIngresoPassword();
                    seleccionado.Password = _vista.Password;
                    _servicio.CambiarPassword(seleccionado.ToEntity());
                }
                catch (Exception e)
                {
                    _vista.MostrarExcepcion(e);
                }
            }
        }
}