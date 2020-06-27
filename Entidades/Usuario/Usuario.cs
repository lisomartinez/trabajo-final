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

        public Usuario(Legajo id) : base(id)
        {
        }

        public Usuario(Legajo id, string vistaNombre, string vistaApellido, string vistaEmail, Rol vistaRol) : base(id)
        {
            throw new NotImplementedException();
        }
    }
}