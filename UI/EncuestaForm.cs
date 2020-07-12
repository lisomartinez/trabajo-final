using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Controladores;
using Modelo;
using Vistas;

namespace UI
{
    public partial class EncuestaForm : Form, IEncuestaVista
    {
        private EncuestaControlador _controlador;
        public EncuestaForm()
        {
            InitializeComponent();
            _controlador = new EncuestaControlador(this);
        }

        private void EncuestaForm_Load(object sender, System.EventArgs e)
        {
            _controlador.MostrarEncuestas();
        }

        public void MostrarExcepcion(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        public List<EncuestaModelo> Encuestas
        {
            get => throw new NotImplementedException();
            set => EncuestasDGV.DataSource = value;
        }

        public EncuestaModelo EncuestaSeleccionada
        {
            get => EncuestasDGV.SelectedRows[0].DataBoundItem as EncuestaModelo;
            set => throw new NotImplementedException();
        }

        public int Codigo
        {
            get => int.Parse(CodigoTB.Text);
            set => CodigoTB.Text = value.ToString();
        }

        public DateTime FechaCreacion
        {
            get => DateTime.Parse(FechaTB.Text);
            set => FechaTB.Text = value.ToLongDateString();
        }

        public bool Vigente
        {
            get => VigenteCHKB.Checked;
            set => VigenteCHKB.Checked = value;
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

        public int PreguntaNumero
        {
            get => int.Parse(NroTB.Text);
            set => NroTB.Text = value.ToString();
        }

        public string PreguntaTexto
        {
            get => TextoTB.Text;
            set => TextoTB.Text = value;
        }

        public decimal PesoRelativo
        {
            get => decimal.Parse(PesoRelativoTB.Text);
            set => PesoRelativoTB.Text = value.ToString();
        }

        public decimal PuntajeMaximo
        {
            get => decimal.Parse(PuntajeMaxTB.Text);
            set => PuntajeMaxTB.Text = value.ToString();
        }

        public decimal PuntajeMinimo
        {
            get => decimal.Parse(PuntajeMinTB.Text);
            set => PuntajeMinTB.Text = value.ToString();
        }

        private void EncuestasDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _controlador.MostrarEncuesta();
        }

        private void PreguntasDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _controlador.MostrarPregunta();;
        }
    }
}