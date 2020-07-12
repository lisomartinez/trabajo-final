using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Controladores;
using Modelo;
using Vistas;

namespace UI
{
    public partial class SolicitudAsistenciaForm : Form, ISolicitudAsistenciaVista
    {
        private SolicitudAsistenciaControlador _controlador;
        public decimal Seconds { get; set; }

        public SolicitudAsistenciaForm()
        {
            InitializeComponent();
            _controlador = new SolicitudAsistenciaControlador(this);
        }


        private void SolicitudAsistenciaForm_Load(object sender, EventArgs e)
        {
            _controlador.CargarTiposDeProblemas();
        }

        public bool ConfirmarHabilitado
        {
            get => ConfirmarSolicitudBTN.Enabled;
            set => ConfirmarSolicitudBTN.Enabled = value;
        }

        public void MostrarMensaje(string msj)
        {
            MessageBox.Show(msj);
        }

        public List<TipoProblemaModelo> TiposDeProblemas
        {
            get => throw new NotImplementedException();
            set => TipoProblemaCB.DataSource = value;
        }

        public string Descripcion
        {
            get => DescripcionTB.Text;
            set => DescripcionTB.Text = value;
        }

        public List<TurnoModelo> Turnos
        {
            get => TurnosDGV.DataSource as List<TurnoModelo>;
            set => TurnosDGV.DataSource = value;
        }

        public TipoProblemaModelo TipoProblemaSeleccionado
        {
            get => TipoProblemaCB.SelectedItem as TipoProblemaModelo;
            set
            {
                var lista = TipoProblemaCB.DataSource as List<TipoProblemaModelo>;
                var item = (lista ?? throw new InvalidOperationException()).First(p => p.Id.Equals(value.Id));
                TipoProblemaCB.SelectedItem = item;
            }
        }

        public TurnoModelo TurnoSeleccionado
        {
            get => TurnosDGV.SelectedRows[0].DataBoundItem as TurnoModelo;
            set => throw new NotImplementedException();
        }

        public void MostrarExcepcion(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        public void IniciarTimer()
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void SolicitarTurnoBTN_Click(object sender, EventArgs e)
        {
            _controlador.SolicitarTurno();
        }

        private void ConfirmarSolicitudBTN_Click(object sender, EventArgs e)
        {
            _controlador.ConfirmarTurno();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Seconds == 0)
            {
                timer1.Stop();
            }
            else
            {
                Seconds--;
                var tiempo = _controlador.CrearLabelTiempo();

                TiempoRestanteLBL.Text = $"Tiempo Restante: {tiempo}";
            }
        }

        private void TurnosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}