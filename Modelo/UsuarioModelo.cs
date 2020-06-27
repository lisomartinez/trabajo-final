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

        public static UsuarioModelo From(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }

        public Usuario ToEntity()
        {
            throw new System.NotImplementedException();
        }
    }
}