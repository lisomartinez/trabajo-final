using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Controladores;
using Modelo;
using Vistas;

namespace UI
{
    public partial class ReemplazoComponenteForm : Form, IReemplazoComponenteVista
    {
        private ReemplazoComponenteControlador _controlador;
        public ReemplazoComponenteForm(AsistenciaTecnicaModelo asistenciaTecnicaModelo)
        {
            InitializeComponent();
            _controlador = new ReemplazoComponenteControlador(this, asistenciaTecnicaModelo);
        }

        private void ReemplazoComponenteForm_Load(object sender, System.EventArgs e)
        {
            _controlador.MostrarComputadora();
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
            set => ComponentesDGV.DataSource = value;
        }

        public ComponenteModelo ComponenteSeleccionado
        {
            get => ComponentesDGV.SelectedRows[0].DataBoundItem as ComponenteModelo;
            set => throw new NotImplementedException();
        }

        public void MostrarOrdenDeCompraForm(ComponenteModelo componenteSeleccionado)
        {
            throw new NotImplementedException();
        }

        public void MostrarExcepcion(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        private void ReemplazarBTN_Click(object sender, EventArgs e)
        {
            _controlador.ReemplazarComponente();
        }

        private void ComponentesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}