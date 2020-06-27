using System.Collections.Generic;

namespace Entidades
{
    public class Software : Entidad
    {
        public CodigoSoftware Codigo { get; }
        public string Nombre { get; }
        public string Version { get; }
        public string Desarrollador { get; }


        public Software(CodigoSoftware codigo, string nombre, string version, string desarrollador) : base(codigo)
        {
            Codigo = codigo;
            Nombre = nombre;
            Version = version;
            Desarrollador = desarrollador;
            
        }

      
    }
}