using Entidades;

namespace Vistas
{
    public class EspecificacionTecnicaModelo
    {
        public EspecificacionTecnicaModelo(int vistaCodigoEspecificacionTecnica, string vistaNombreEspecificacion, string vistaDescripcionEspecificacion)
        {
            throw new System.NotImplementedException();
        }

        public int Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public EspecificacionTecnica ToEntity()
        {
            throw new System.NotImplementedException();
        }
    }
}