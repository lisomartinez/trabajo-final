namespace Modelo
{
    public class RespuestaModelo

    {
        public int Puntaje { get; set; }
        public bool Respondida { get; set;  }

        public RespuestaModelo(int puntaje, bool respondida)
        {
            Puntaje = puntaje;
            Respondida = respondida;
        }
    }
}