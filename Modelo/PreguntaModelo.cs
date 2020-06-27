using Entidades;

namespace Modelo
{
    public class PreguntaModelo
    {
        public int Numero { get; set; }
        public string Texto { get; set; }
        public decimal PesoRelativo { get; set; }
        public decimal PuntajeMaximo { get; set; }
        public decimal PuntajeMinimo { get; set; }

        public PreguntaModelo(int numero, string texto, decimal pesoRelativo, decimal puntajeMaximo, decimal puntajeMinimo)
        {
            Numero = numero;
            Texto = texto;
            PesoRelativo = pesoRelativo;
            PuntajeMaximo = puntajeMaximo;
            PuntajeMinimo = puntajeMinimo;
        }

        public Pregunta ToEntity()
        {
            throw new System.NotImplementedException();
        }

        public static PreguntaModelo From(Pregunta pregunta)
        {
            throw new System.NotImplementedException();
        }
    }
}