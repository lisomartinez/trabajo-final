using System;

namespace Entidades
{
    public class Usuario : Entidad
    {
        public Legajo Legajo => Id as Legajo;
        public string Nombre { get; }
        public string Apellido { get; }
        public string Email { get; }
        public string Password { get; }
        public Rol Rol { get; }
        public Computadora Computadora { get; }
        public Jerarquia Categoria { get; set; }

        public Usuario(Legajo legajo, string nombre, string apellido, string email, string password, Rol rol,
            Jerarquia categoria, Computadora computadora) : base(legajo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Password = password;
            Rol = rol;
            Categoria = categoria;
            Computadora = computadora;
        }

        public Usuario(Legajo legajo, string nombre, string apellido, Rol rol, Jerarquia categoria,
            Computadora computadora) : base(legajo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Rol = rol;
            Categoria = categoria;
            Computadora = computadora;
            Password = "";
        }

        public Usuario(Legajo legajo) : base(legajo)
        {
        }

        public Usuario(Legajo legajo, Jerarquia categoria, Rol tecnico) : base(legajo)
        {

            Categoria = categoria;
            Rol = tecnico;
        }
    }
}