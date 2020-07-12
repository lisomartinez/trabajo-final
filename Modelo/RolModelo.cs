using System;
using Entidades;

namespace Modelo
{
    public class RolModelo
    {
        public string Rol { get; set; }

        private RolModelo(string rol)
        {
            Rol = rol;
        }

        public Entidades.Rol ToEntity()
        {
            switch (Rol)
            {
                case "TECNICO":
                    return Entidades.Rol.TECNICO;
                case "USUARIO":
                    return Entidades.Rol.USUARIO;
                default:
                    return Entidades.Rol.JEFE;
            }
        }

        public static RolModelo From(Rol usuarioRol)
        {
            switch (usuarioRol)
            {
                case Entidades.Rol.TECNICO:
                    return new RolModelo("TECNICO");
                case Entidades.Rol.USUARIO:
                    return new RolModelo("USUARIO");
                case Entidades.Rol.JEFE:
                    return new RolModelo("JEFE");
                default:
                    throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
            return $"{Rol}";
        }
    }
}