using System;

namespace Entidades
{
    public class Usuario : Entidad
    {
        public Legajo Legajo { get; }
        public string Nombre { get; }
        public string Apellido { get; }
        public string Email { get; }
        public string Password { get; }
        public Rol Rol { get; }
        public Computadora Computadora { get; }

        public Usuario(Legajo legajo, string nombre, string apellido, string email, string password, Rol rol, Computadora computadora) : base(legajo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Password = password;
            Rol = rol;
            Computadora = computadora;
        }
    }
}