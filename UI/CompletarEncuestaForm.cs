using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Controladores;
using Modelo;
using Vistas;

namespace UI
{
    public partial class CompletarEncuestaForm : Form, ICompletarEncuestaVista
    {
        private CompletarEncuestaControlador _controlador;

        public CompletarEncuestaForm(AsistenciaTecnicaModelo asistenciaTecnicaModelo)
        {
            InitializeComponent();
            _controlador = new CompletarEncuestaControlador(this, asistenciaTecnicaModelo);
            _controlador.MostrarPreguntas();
        }

        private void CompletarEncuestaForm_Load(object sender, System.EventArgs e)
        {

        }

        public void MostrarException(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        public void IngresoRespuesta(PreguntaModelo preguntaModelo)
        {
            throw new NotImplementedException();
        }

        public int Calificacion { get; set; }
        public List<PreguntaModelo> Preguntas { get; set; }
        public PreguntaModelo PreguntaSeleccionada { get; set; }
        public string PreguntaTexto { get; set; }
        public int PreguntaNro { get; set; }
        public int Respuesta { get; set; }
    }
}