using System;
using System.Collections.Generic;
using Entidades;
using Modelo;

namespace Vistas
{
    public interface IUsuarioVista
    {
        void MostrarExcepcion(Exception exception);
        List<UsuarioModelo> Usuarios { get; set; }
        UsuarioModelo UsuarioSeleccionado { get; set; }
        int Legajo { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        string Email { get; set; }
        RolModelo Rol { get; set; }
        string Password { get; set; }
        void SolicitarIngresoPassword();
        void MostrarGestionarComputadoraForm(UsuarioModelo vistaUsuarioSeleccionado);
    }
}