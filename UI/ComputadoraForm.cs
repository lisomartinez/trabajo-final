using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Modelo;
using Vistas;

namespace UI
{
    public partial class ComputadoraForm : Form, IComputadoraVista
    {
        public ComputadoraForm()
        {
            InitializeComponent();
        }

        private void ComputadoraForm_Load(object sender, System.EventArgs e)
        {

        }

        public void MostrarExcepcion(Exception exception)
        {
            throw new NotImplementedException();
        }

        public List<ComputadoraModelo> Computadoras { get; set; }
        public ComputadoraModelo ComputadoraSeleccionada { get; set; }
        public int Codigo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public List<ComponenteModelo> Componentes { get; set; }
        public List<SoftwareModelo> Software { get; set; }
        public ComponenteModelo ComponenteSeleccionado { get; set; }
        public SoftwareModelo SoftwareSeleccionado { get; set; }
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