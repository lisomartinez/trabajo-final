namespace Entidades
{
    public class Calificacion
    {
        public int Numero { get; }
        public decimal Nota { get; }

        public Calificacion(int numero, int nota)
        {
            Numero = numero;
            Nota = nota;
        }
    }
}