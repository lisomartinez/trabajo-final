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
    public partial class AgregarComponenteAListaPrecios : Form, IAgregarComponenteAListaDePrecios
    {
        private AgregarComponenteAListaPreciosControlador _controlador;
        public AgregarComponenteAListaPrecios(ProveedorModelo proveedor)
        {
            InitializeComponent();
            _controlador = new AgregarComponenteAListaPreciosControlador(this, proveedor);
        }

        private void AgregarComponenteAListaPrecios_Load(object sender, EventArgs e)
        {
            _controlador.MostrarComponentes();
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

        public decimal Precio
        {
            get => decimal.Parse(PrecioTB.Text);
            set => PrecioTB.Text = value.ToString();
        }

        public void MostrarExcepcion(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        public int NumeroDeSerie
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

        private void AgregarBTN_Click(object sender, EventArgs e)
        {
            _controlador.AgregarComponente();
        }

        private void ComponentesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _controlador.MostrarComponente();
        }
    }
}
