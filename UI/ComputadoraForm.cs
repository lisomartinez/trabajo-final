using System;
using System.Collections.Generic;
using System.Linq;
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
            _controlador.MostrarComputadoras();
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

        public void MostrarComponentesForm(ComputadoraModelo computadora)
        {
            if (Application.OpenForms.OfType<ComponenteForm>().Count() == 1)
                return;

            var gestionComponente = new ComponenteForm(computadora);
            gestionComponente.FormClosed += (s, ee) => { ComponenteFromCerrado(s as ComponenteForm, ee.CloseReason); };
            gestionComponente.Show();
        }

        private void ComponenteFromCerrado(ComponenteForm sender, CloseReason eeCloseReason)
        {
            throw new NotImplementedException();
        }

        public void MostrarGestionarSoftwareForm(ComputadoraModelo computadora)
        {
            if (Application.OpenForms.OfType<SoftwareForm>().Count() == 1)
                return;

            var gestionSoftware = new SoftwareForm(computadora);
            gestionSoftware.FormClosed += (s, ee) => { SoftwareFromCerrado(s as SoftwareForm, ee.CloseReason); };
            gestionSoftware.Show();
        }

        private void SoftwareFromCerrado(SoftwareForm sender, CloseReason eeCloseReason)
        {
            throw new NotImplementedException();
        }

        private void GestionarComputadoraBTN_Click(object sender, EventArgs e)
        {
            _controlador.GestionarComponentes();
        }

        private void GestionarSoftwareBTN_Click(object sender, EventArgs e)
        {
            _controlador.GestionarSoftwares();
        }

        private void AgregarComponenteBTN_Click(object sender, EventArgs e)
        {
            _controlador.AgregarComponente();
        }

        private void QuitarComponenteBTN_Click(object sender, EventArgs e)
        {
            _controlador.EliminarComponente();
        }

        private void AgregarSoftwareBTN_Click(object sender, EventArgs e)
        {
            _controlador.AgregarSoftware();
        }

        private void QuitarSoftwareBTN_Click(object sender, EventArgs e)
        {
            _controlador.EliminarSoftware();
        }

        private void AltaBTN_Click(object sender, EventArgs e)
        {
            _controlador.AgregarComputadora();
        }

        private void BajaBTN_Click(object sender, EventArgs e)
        {
            _controlador.EliminarComputadora();
        }

        private void ModificacionBTN_Click(object sender, EventArgs e)
        {
            _controlador.ModificarComputadora();
        }
    }
}