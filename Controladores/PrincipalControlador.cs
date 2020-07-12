using System.Collections.Generic;
using Entidades;
using Vistas;

namespace Controladores
{
    public class PrincipalControlador
    {
        private IPrincipalVista _vista;

        public PrincipalControlador(IPrincipalVista vista)
        {
            // VALUES(36176, 'Juan', 'Perez', 'jperez@empresa.com', 'asda13123', 'USUARIO', 4, 2);

            _vista = vista;
            Sesion.Instance.Usuario = new Usuario(new Legajo(36176), "Juan", "Perez",
                "jperez@empresa.com", "password", Rol.JEFE, new Jerarquia(new JerarquiId(3), "Empleado Senior", 3),
                new Computadora(new ComputadoraId(4)));
        }

        public void MostrarMenus()
        {
            if (Sesion.Instance.NoInciada())
            {
                _vista.Habilitados = new List<string> {"PrincipalSubMenu"};
            }
            else if (Sesion.Instance.Rol == Rol.JEFE)
            {
            }
            else if (Sesion.Instance.Rol == Rol.TECNICO)
            {
            }
            else if (Sesion.Instance.Rol == Rol.USUARIO)
            {
            }
        }
    }
}