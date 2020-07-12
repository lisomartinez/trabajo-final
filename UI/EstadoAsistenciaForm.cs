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
    public partial class EstadoAsistenciaForm : Form, IEstadoAsistenciaVista
    {
        private EstadoAsistenciaControlador _controlador;

        public EstadoAsistenciaForm()
        {
            InitializeComponent();
            _controlador = new EstadoAsistenciaControlador(this);
        }

        private void EstadoAsistenciaForm_Load(object sender, EventArgs e)
        {
            _controlador.MostrarEstados();
        }

        public void MostrarException(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        public List<EstadoAsistenciaTecnicaModelo> Estados
        {
            get => EstadosDGV.DataSource as List<EstadoAsistenciaTecnicaModelo>;
            set => EstadosDGV.DataSource = value;
        }

        public EstadoAsistenciaTecnicaModelo EstadoSeleccionado
        {
            get => EstadosDGV.SelectedRows[0].DataBoundItem as EstadoAsistenciaTecnicaModelo;
            set => throw new NotImplementedException();
        }

        public string Nombre
        {
            get => NombreTB.Text;
            set => NombreTB.Text = value;
        }

        public string Descripcion
        {
            get => DescripcionTB.Text;
            set => DescripcionTB.Text = value;
        }

        public int Codigo
        {
            get => int.Parse(CodigoTB.Text);
            set => CodigoTB.Text = value.ToString();
        }

        private void EstadosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _controlador.MostrarEstado();
        }

        private void AgregarBTN_Click(object sender, EventArgs e)
        {
            _controlador.AgregarEstado();
        }

        private void ModificarBTN_Click(object sender, EventArgs e)
        {
            _controlador.ModificarEstado();
        }

        private void EliminarBTN_Click(object sender, EventArgs e)
        {
            _controlador.EliminarEstado();
        }
    }
}
