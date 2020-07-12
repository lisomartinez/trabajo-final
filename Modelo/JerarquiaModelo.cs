using Entidades;

namespace Modelo
{
    public class JerarquiaModelo
    {
        public int Id { get; set; }
        public string Denominacion { get; set; }
        public int Valor { get; set; }

        public JerarquiaModelo(int id, string denominacion, int valor)
        {
            Id = id;
            Denominacion = denominacion;
            Valor = valor;
        }

        public static JerarquiaModelo From(Jerarquia categoria)
        {
            return new JerarquiaModelo(
                id: categoria.Id.AsInt(),
                denominacion: categoria.Denominacion,
                valor: categoria.Valor
            );
        }

        public Jerarquia ToEntity()
        {
            return new Jerarquia(new JerarquiId(Id), Denominacion, Valor);
        }

        public override string ToString()
        {
            return $"{Denominacion}";
        }
    }
}