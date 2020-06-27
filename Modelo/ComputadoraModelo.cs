using System.Collections.Generic;
using Entidades;

namespace Vistas
{
    public class ComputadoraModelo
    {
        public int Codigo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public List<ComponenteModelo> Componentes { get; set; }
        public List<SoftwareModelo> Software { get; set; }

        public static ComputadoraModelo From(Computadora computadora)
        {
            throw new System.NotImplementedException();
        }

        public Computadora ToEntity()
        {
            throw new System.NotImplementedException();
        }
    }
}