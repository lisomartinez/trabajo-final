using Entidades;

namespace Modelo
{
    public class SoftwareModelo
    {
        
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Version { get; set; }
        public string Desarrollador { get; set; }

        public static SoftwareModelo From(Software software)
        {
            throw new System.NotImplementedException();
        }

        public Software ToEntity()
        {
            throw new System.NotImplementedException();
        }
    }
}