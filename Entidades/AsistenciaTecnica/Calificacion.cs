using System;
using Entidades;

namespace Controladores
{
    public class Calificacion
    {
        public decimal Nota { get; }

        public Calificacion(int nota)
        {
            Nota = nota;
        }
    }
}