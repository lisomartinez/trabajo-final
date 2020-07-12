using System.Collections.Generic;
using System.Linq;
using Entidades;

namespace Modelo
{
    public class ComputadoraModelo
    {
        public int Codigo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public List<ComponenteModelo> Componentes { get; set; }
        public List<SoftwareModelo> Software { get; set; }

        public ComputadoraModelo(int codigo, string marca, string modelo, List<ComponenteModelo> componentes, List<SoftwareModelo> software)
        {
            Codigo = codigo;
            Marca = marca;
            Modelo = modelo;
            Componentes = componentes;
            Software = software;
        }

        public static ComputadoraModelo From(Computadora computadora)
        {
            return new ComputadoraModelo(
                codigo: computadora.Id.AsInt(),
                marca: computadora.Marca,
                modelo: computadora.Modelo,
                componentes: computadora.Componentes.Select(ComponenteModelo.From).ToList(),
                software: computadora.Software.Select(SoftwareModelo.From).ToList()
            );
        }

        public Computadora ToEntity()
        {
            return new Computadora(
                id: new ComputadoraId(Codigo),
                marca: Marca,
                modelo: Modelo,
                componentes: Componentes.Select(comp => comp.ToEntity()).ToList(),
                software: Software.Select(sw => sw.ToEntity()).ToList()
            );
        }

        public override string ToString()
        {
            return $"{Marca} {Modelo}";
        }
    }
}