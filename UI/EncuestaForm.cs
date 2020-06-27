using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Vistas;

namespace UI
{
    public partial class EncuestaForm : Form, IEncuestaVista
    {
        public EncuestaForm()
        {
            InitializeComponent();
        }

        private void EncuestaForm_Load(object sender, System.EventArgs e)
        {

        }

        public void MostrarExcepcion(Exception exception)
        {
            throw new NotImplementedException();
        }

        public List<EncuestaModelo> Encuestas { get; set; }
        public EncuestaModelo EncuestaSeleccionada { get; set; }
        public int Codigo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Vigente { get; set; }
        public List<PreguntaModelo> Preguntas { get; set; }
        public PreguntaModelo PreguntaSeleccionada { get; set; }
        public int PreguntaNumero { get; set; }
        public string PreguntaTexto { get; set; }
        public decimal PesoRelativo { get; set; }
        public decimal PuntajeMaximo { get; set; }
        public decimal PuntajeMinimo { get; set; }
    }
}