using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Controladores;
using Modelo;
using Vistas;

namespace UI
{
    public partial class ComputadoraForm : Form, IComputadoraVista
    {
        private ComputadoraControlador _controlador;
        public ComputadoraForm()
        {
            InitializeComponent();
            _controlador = new ComputadoraControlador(this);
        }

        private void ComputadoraForm_Load(object sender, System.EventArgs e)
        {

        }

        public void MostrarExcepcion(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        public List<ComputadoraModelo> Computadoras
        {
            get => throw new NotImplementedException();
            set => ComputadorasDGV.DataSource = value;
        }

        public ComputadoraModelo ComputadoraSeleccionada
        {
            get => ComputadorasDGV.SelectedRows[0].DataBoundItem as ComputadoraModelo;
            set => throw new NotImplementedException();
        }

        public int Codigo
        {
            get => int.Parse(CodigoTB.Text);
            set => CodigoTB.Text = value.ToString();
        }

        public string Marca
        {
            get => MarcaTB.Text;
            set => MarcaTB.Text = value;
        }

        public string Modelo
        {
            get => ModeloTB.Text;
            set => ModeloTB.Text = value;
        }

        public List<ComponenteModelo> Componentes
        {
            get => throw new NotImplementedException();
            set => ComponenteDGV.DataSource = value;
        }

        public List<SoftwareModelo> Software
        {
            get => throw new NotImplementedException();
            set => SoftwareDGV.DataSource = value;
        }

        public ComponenteModelo ComponenteSeleccionado
        {
            get => ComponenteDGV.SelectedRows[0].DataBoundItem as ComponenteModelo;
            set => throw new NotImplementedException();
        }

        public SoftwareModelo SoftwareSeleccionado
        {
            get => SoftwareDGV.SelectedRows[0].DataBoundItem  as SoftwareModelo;
            set => throw new NotImplementedException();
        }

        public void MostrarComponentesForm(ComputadoraModelo vistaComputadoraSeleccionada)
        {
            throw new NotImplementedException();
        }

        public void MostrarGestionarSoftwareForm(ComputadoraModelo vistaComputadoraSeleccionada)
        {
            throw new NotImplementedException();
        }

    }
}