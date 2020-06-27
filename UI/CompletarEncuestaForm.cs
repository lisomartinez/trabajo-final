using System;
using System.Windows.Forms;
using Modelo;
using Vistas;

namespace UI
{
    public partial class CompletarEncuestaForm : Form, ICompletarEncuestaVista
    {
        public CompletarEncuestaForm()
        {
            InitializeComponent();
        }

        private void CompletarEncuestaForm_Load(object sender, System.EventArgs e)
        {

        }

        public void MostrarException(Exception exception)
        {
            throw new NotImplementedException();
        }

        public void IngresoRespuesta(PreguntaModelo preguntaModelo)
        {
            throw new NotImplementedException();
        }

        public int Calificacion { get; set; }
    }
}