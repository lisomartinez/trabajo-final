using Entidades;

namespace Controladores

{
    public class Sesion

    {
        private static Sesion _instance;
        public static Sesion Instance => _instance ?? (_instance = new Sesion());
        public  Usuario Usuario { get; set; }
        public Rol Rol => Usuario.Rol;

        private Sesion()
        {
        }

        public bool NoInciada()
        {
            return Usuario == null;
        }
    }
}