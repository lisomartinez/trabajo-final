using System.Collections.Generic;
using System.Linq;
using Entidades;

namespace Modelo
{
    public class ComponenteModelo
    {
        public int NumeroSerie { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public List<EspecificacionTecnicaModelo> EspecificacionesTecnicas { get; set; }

        public ComponenteModelo(int numeroSerie, string marca, string modelo,
            List<EspecificacionTecnicaModelo> especificacionesTecnicas)
        {
            NumeroSerie = numeroSerie;
            Marca = marca;
            Modelo = modelo;
            EspecificacionesTecnicas = especificacionesTecnicas;
        }

        public Componente ToEntity()
        {
            return new Componente(
                numeroDeSerie: new NumeroDeSerie(NumeroSerie), 
                marca: Marca,
                modelo: Modelo,
                especificacionTecnicas: EspecificacionesTecnicas.Select(e => e.ToEntity())
                    .ToList()
                );
        }

        public static ComponenteModelo From(Componente componente)
        {
            return new ComponenteModelo(
                numeroSerie: componente.NumeroDeSerie.AsInt(),
                marca: componente.Marca,
                modelo: componente.Modelo,
                especificacionesTecnicas: componente.EspecificacionTecnicas.Select(EspecificacionTecnicaModelo.From)
                    .ToList()
            );
        }
    }
}