using System.Collections.Generic;

namespace Entidades
{
    public class Computadora : Entidad
    {
        public string Marca { get; }
        public string Modelo { get; }
        public List<Componente> Componentes { get; }
        public List<Software> Software { get; }

        public Computadora(ComputadoraId id) : base(id)
        {
        }

        public Computadora(ComputadoraId id, string marca, string modelo, List<Componente> componentes, List<Software> software) : base(id)
        {
            Marca = marca;
            Modelo = modelo;
            Componentes = componentes;
            Software = software;
            throw new System.NotImplementedException();
        }
    }
}