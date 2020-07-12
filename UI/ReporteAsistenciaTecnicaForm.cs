using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
using Modelo;
using Vistas;

namespace UI
{
    public partial class ReporteAsistenciaTecnicaForm : Form , IReporteAsistenciaTecnicaVista
    {
        private ReporteAsistenciaTecnicaControlador _controlador;
        public ReporteAsistenciaTecnicaForm()
        {
            InitializeComponent();
            _controlador = new ReporteAsistenciaTecnicaControlador(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReporteAsistenciaTecnicaForm_Load(object sender, EventArgs e)
        {
            _controlador.MostrarEstadisticasGenerales();
            _controlador.MostrarTipoProblemas();
        }

        public void MostrarExcepcion(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        public decimal TiempoMedioDuracion
        {
            get => decimal.Parse(MediaDuracionTB.Text);
            set => MediaDuracionTB.Text = value.ToString();
        }

        public decimal TiempoMedioDeInicio
        {
            get => decimal.Parse(MediaSolicitudInicioTB.Text);
            set => MediaSolicitudInicioTB.Text = value.ToString();
        }

        public decimal TiempoMedioInicioFinalizacion
        {
            get => decimal.Parse(MediaInicioFinTB.Text);
            set => MediaInicioFinTB.Text = value.ToString();
        }

        public List<TecnicoModelo> Tecnicos
        {
            get => throw new NotImplementedException();
            set => TecnicosDGV.DataSource = value;
        }

        public TecnicoModelo TecnicoSeleccionado
        {
            get => TecnicosDGV.SelectedRows[0].DataBoundItem as TecnicoModelo;
            set => throw new NotImplementedException();
        }

        public List<TipoProblemaModelo> TipoProblemas
        {
            get => throw new NotImplementedException();
            set => TipoProblemaCB.DataSource = value;
        }

        public TipoProblemaModelo TipoProblemaSeleccionado
        {
            get => TipoProblemaCB.SelectedItem as TipoProblemaModelo;
            set => throw new NotImplementedException();
        }

        public decimal CalificacionPromedio
        {
            get => decimal.Parse(PromedioTecnicosTB.Text);
            set => PromedioTecnicosTB.Text = value.ToString();
        }

        public decimal TiempoMedioDuracionTecnico
        {
            get => decimal.Parse(MediaDuracionTecnicoTB.Text);
            set => MediaDuracionTecnicoTB.Text = value.ToString();
        }

        public decimal TiempoMedioDeInicioTecnico
        {
            get => decimal.Parse(MediaInicioTecTB.Text);
            set => MediaInicioTecTB.Text = value.ToString();
        }

        public decimal TiempoMedioInicioFinalizacionTecnico
        {
            get => decimal.Parse(MediaInicioFinTecTB.Text);
            set => MediaInicioFinTecTB.Text = value.ToString();
        }

        public decimal DesviacionDuracionTecnico
        {
            get => decimal.Parse(MediaDuracionTecnicoDesvTB.Text);
            set => MediaDuracionTecnicoDesvTB.Text = value.ToString();
        }

        public decimal DesviacionInicioTecnico
        {
            get => decimal.Parse(MediaInicioTecDesvTB.Text);
            set => MediaInicioTecDesvTB.Text = value.ToString();
        }

        public decimal DesviacionInicioFinalizacion
        {
            get => decimal.Parse(MediaInicioFinTecDesvTB.Text);
            set => MediaInicioFinTecDesvTB.Text = value.ToString();
        }

        public decimal CalificacionPromedioTecnico
        {
            get => decimal.Parse(PromedioTecnicoTB.Text);
            set => PromedioTecnicoTB.Text = value.ToString();
        }

        public decimal DesviacionCalificacionPromedioTecnico
        {
            get => decimal.Parse(PromedioTecnicoDesvTB.Text);
            set => PromedioTecnicoDesvTB.Text = value.ToString();
        }

        public decimal CalificacionPromedioTecnicoTotal
        {
            get => decimal.Parse(PromedioTecnicoTotalTB.Text);
            set => PromedioTecnicoTotalTB.Text = value.ToString();
        }

        public decimal DesviacionCalificacionPromedioTecnicoTotal
        {
            get => decimal.Parse(PromedioTecnicoTotalDesvTB.Text);
            set => PromedioTecnicoTotalDesvTB.Text = value.ToString();
        }

        private void TecnicosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _controlador.MostrarEstadisticasDeTecnico();
        }
    }
}
