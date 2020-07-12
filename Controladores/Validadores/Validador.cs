using System.Runtime.InteropServices;

namespace Controladores.Validadores
{
    public class Validador
    {
        public static bool ValidarLegajo(string legajo)
        {
            return legajo.Length == 8 && int.TryParse(legajo, out _);
        }


        public static bool ValidarId(int id)
        {
            return id > 0;
        }

        public static bool ValidarPrecio(decimal precio)
        {
            return precio > 0;
        }
    }
}