using System.Security.Cryptography;
using Entidades;

namespace Modelo
{
    public class UsuarioModelo
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public RolModelo Rol { get; set; }
        public ComputadoraModelo Computadora { get; set; }
        public string Password { get; set; }


        public UsuarioModelo(int legajo, string nombre, string apellido, string email, RolModelo rol, ComputadoraModelo computadora, string password)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Rol = rol;
            Computadora = computadora;
            Password = password;
        }

        public static UsuarioModelo From(Usuario usuario)
        {
            return new UsuarioModelo(
                legajo: usuario.Legajo.AsInt(),
                nombre: usuario.Nombre,
                apellido: usuario.Apellido,
                email: usuario.Email,
                rol: RolModelo.From(usuario.Rol),
                computadora: ComputadoraModelo.From(usuario.Computadora),
                password: usuario.Password
            );
        }

        public Usuario ToEntity()
        {
            return new Usuario(
                legajo: new Legajo(Legajo),
                nombre: Nombre,
                apellido: Apellido,
                email:  Email,
                rol: Rol.ToEntity(),
                computadora: Computadora.ToEntity(),
                password: Password
                );
        }
    }
}