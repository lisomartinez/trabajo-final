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

        public SolicitudAsistenciaForm()
        {
            InitializeComponent();
            _controlador = new SolicitudAsistenciaControlador(this);
        }


        private void SolicitudAsistenciaForm_Load(object sender, EventArgs e)
        {
            _controlador.CargarTiposDeProblemas();
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
            get => throw new NotImplementedException();
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

        private void SolicitarTurnoBTN_Click(object sender, EventArgs e)
        {
            _controlador.SolicitarTurno();
        }

        private void ConfirmarSolicitudBTN_Click(object sender, EventArgs e)
        {
            _controlador.ConfirmarTurno();
        }
    }
}