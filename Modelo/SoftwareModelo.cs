using Entidades;

namespace Modelo
{
    public class SoftwareModelo
    {
        
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Version { get; set; }
        public string Desarrollador { get; set; }

        public SoftwareModelo(int codigo, string nombre, string version, string desarrollador)
        {
            Codigo = codigo;
            Nombre = nombre;
            Version = version;
            Desarrollador = desarrollador;
        }

        public static SoftwareModelo From(Software software)
        {
            return new SoftwareModelo(
                codigo: software.Id.AsInt(),
                nombre: software.Nombre,
                version: software.Version,
                desarrollador: software.Desarrollador
                );
        }

        public Software ToEntity()
        {
            return new Software(
                codigo: new CodigoSoftware(Codigo),
                nombre: Nombre,
                version: Version,
                desarrollador: Desarrollador
                );
        }
    }
}