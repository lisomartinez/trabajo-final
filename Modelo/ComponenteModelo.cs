using System.Collections.Generic;
using Entidades;

namespace Modelo
{
    public class ComponenteModelo
    {
        public Componente ToEntity()
        {
            throw new System.NotImplementedException();
        }

        public static ComponenteModelo From(Componente componente)
        {
            throw new System.NotImplementedException();
        }

        public int NumeroSerie { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public List<EspecificacionTecnicaModelo> EspecificacionesTecnicas { get; set; }
    }
}