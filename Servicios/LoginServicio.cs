using Entidades;

namespace Servicios
{
    public class LoginServicio
    {
        private PasswordHasher _passwordHasher;
        private UsuarioServicio _usuarioServicio;

        public LoginServicio()
        {
            _usuarioServicio = new UsuarioServicio();
            _passwordHasher = new PasswordHasher();
        }

        public Usuario Ingresar(string usuario, string password)
        {
            return _usuarioServicio.Logearse(usuario, _passwordHasher.HashPassword(password));
        }
    }
}