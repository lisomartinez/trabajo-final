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
        private bool _completada = false;

        public CompletarEncuestaForm(AsistenciaTecnicaModelo asistenciaTecnicaModelo)
        {
            InitializeComponent();
            _controlador = new CompletarEncuestaControlador(this, asistenciaTecnicaModelo);
            _controlador.MostrarPreguntas();
        }

        private void CompletarEncuestaForm_Load(object sender, System.EventArgs e)
        {
            _controlador.MostrarPreguntas();
        }

        public void MostrarException(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        public void IngresoRespuesta(PreguntaModelo preguntaModelo)
        {
            throw new NotImplementedException();
        }

        public int Calificacion
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public List<PreguntaModelo> Preguntas
        {
            get => throw new NotImplementedException();
            set => PreguntasDGV.DataSource = value;
        }

        public PreguntaModelo PreguntaSeleccionada
        {
            get => PreguntasDGV.SelectedRows[0].DataBoundItem as PreguntaModelo;
            set => throw new NotImplementedException();
        }

        public string PreguntaTexto
        {
            get => PreguntaTB.Text;
            set => PreguntaTB.Text = value;
        }

        public int PreguntaNro
        {
            get => int.Parse(PreguntaNroTB.Text);
            set => PreguntaNroTB.Text = value.ToString();
        }

        public int Respuesta
        {
            get => int.Parse(RespuestaTB.Text);
            set => RespuestaTB.Text = value.ToString();
        }

        public bool Completada
        {
            get => _completada;
            set => _completada = value;
        }


        private void ResponderBTN_Click(object sender, EventArgs e)
        {
            _controlador.ResponderPregunta();
        }

        private void PreguntasDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _controlador.MostrarPregunta();
        }

        private void EnviarCalificacionBTN_Click(object sender, EventArgs e)
        {
            _controlador.EnviarCalificacion();
        }
    }
}