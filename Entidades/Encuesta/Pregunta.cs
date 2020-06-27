namespace Entidades
{
    public class Pregunta
    {
        public int Numero { get; }
        public string Texto { get; }
        public decimal PesoRelativo { get; }
        public decimal PuntajeMaximo { get; }
        public decimal PuntajeMinimo { get; }

        public Pregunta(int numero, string texto, decimal pesoRelativo, decimal puntajeMaximo, decimal puntajeMinimo)
        {
            Numero = numero;
            Texto = texto;
            PesoRelativo = pesoRelativo;
            PuntajeMaximo = puntajeMaximo;
            PuntajeMinimo = puntajeMinimo;
        }
    }
}