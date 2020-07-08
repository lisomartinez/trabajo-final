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
    public partial class ComponenteForm : Form, IComponenteVista
    {
        private ComponenteControlador _controlador;

        public ComponenteForm()
        {
            InitializeComponent();
            
        }

        public ComponenteForm(ComputadoraModelo computadoraModelo)
        {
            InitializeComponent();
            _controlador = new ComponenteControlador(this, computadoraModelo);
        }

        private void ComponenteForm_Load(object sender, EventArgs e)
        {

        }

        public void MostrarExcepcion(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        public List<ComponenteModelo> Componentes
        {
            get => throw new NotImplementedException();
            set => ComponentesDGV.DataSource = value;
        }

        public ComponenteModelo ComponenteSeleccionado
        {
            get => ComponentesDGV.SelectedRows[0].DataBoundItem as ComponenteModelo;
            set => throw new NotImplementedException();
        }

        public int NumeroSerie
        {
            get => int.Parse(NroSerieTB.Text);
            set => NroSerieTB.Text = value.ToString();
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

        public List<EspecificacionTecnicaModelo> EspecificacionesTecnicas
        {
            get => throw new NotImplementedException();
            set => EspecificacionDGV.DataSource = value;
        }

        public int CodigoEspecificacionTecnica
        {
            get => int.Parse(CodigoTB.Text);
            set => CodigoTB.Text = value.ToString();
        }

        public string NombreEspecificacion
        {
            get => NombreTB.Text;
            set => NombreTB.Text = value;
        }

        public string DescripcionEspecificacion
        {
            get => DescripcionTB.Text;
            set => DescripcionTB.Text = value;
        }

        public EspecificacionTecnicaModelo EspecificacionTecnicaSeleccionada
        {
            get => EspecificacionDGV.SelectedRows[0].DataBoundItem as EspecificacionTecnicaModelo;
            set => throw new NotImplementedException();
        }
    }
}
