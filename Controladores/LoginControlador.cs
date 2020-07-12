using System;
using Controladores.Validadores;
using Entidades;
using Servicios;
using Vistas;

namespace Controladores
{
    public class LoginControlador
    {
        private ILoginVista _vista;
        private LoginServicio _servicio;


        public LoginControlador(ILoginVista vista)
        {
            _vista = vista;
            _servicio = new LoginServicio();
        }

        public void Logearse()
        {
            try
            {
                var nombreUsuario = _vista.Legajo;
                var password =  _vista.Password;

                 var usuario = _servicio.Ingresar(nombreUsuario, password);
                 if (usuario == null) throw new NotImplementedException();

                 Sesion.Instance.Usuario = usuario;
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void ValidarFormatoLegajo()
        {
            if (!Validador.ValidarLegajo(_vista.Legajo))
            {
                throw new NotImplementedException();
            }
        }
    }
}