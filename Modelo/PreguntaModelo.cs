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
            return new Pregunta(
                numero: Numero,
                texto: Texto,
                pesoRelativo: PesoRelativo,
                puntajeMaximo: PuntajeMaximo,
                puntajeMinimo: PuntajeMinimo
            );
        }

        public static PreguntaModelo From(Pregunta pregunta)
        {
            return new PreguntaModelo(
                numero: pregunta.Numero,
                texto: pregunta.Texto,
                pesoRelativo: pregunta.PesoRelativo,
                puntajeMaximo: pregunta.PuntajeMaximo,
                puntajeMinimo: pregunta.PuntajeMinimo
                );
        }
    }
}