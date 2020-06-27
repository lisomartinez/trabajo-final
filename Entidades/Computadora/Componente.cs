using System.Collections.Generic;

namespace Entidades
{
    public class Componente : Entidad
    {
        public NumeroDeSerie NumeroDeSerie { get; }
        public string Marca { get; }
        public string Modelo { get; }
        public List<EspecificacionTecnica> EspecificacionTecnicas { get; } 


        public Componente(NumeroDeSerie id) : base(id)
        {
        }


        public Componente(NumeroDeSerie numeroDeSerie, string marca, string modelo, List<EspecificacionTecnica> especificacionTecnicas) : base(numeroDeSerie)
        {
            NumeroDeSerie = numeroDeSerie;
            Marca = marca;
            Modelo = modelo;
            EspecificacionTecnicas = especificacionTecnicas;
        }

    }
}