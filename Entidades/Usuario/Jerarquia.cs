namespace Entidades
{
    public class Jerarquia : Entidad
    {
        public string Denominacion { get; set; }
        public int Valor { get; set; }
        public Jerarquia(JerarquiId id, string denominacion, int valor) : base(id)
        {
            Denominacion = denominacion;
            Valor = valor;
        }
    }
}