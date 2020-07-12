using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
using Modelo;
using Vistas;

namespace UI
{
    public partial class ListaDePreciosForm : Form, IListaDePreciosVista
    {
        private ListaDePreciosControlador _controlador;

        public ListaDePreciosForm(ProveedorModelo proveedorModelo)
        {
            InitializeComponent();
            _controlador = new ListaDePreciosControlador(this, proveedorModelo);
        }

        private void ListaDePreciosForm_Load(object sender, EventArgs e)
        {
            _controlador.MostrarListaDePrecios();
        }

        public List<ComponentePrecioModelo> ListaPrecios
        {
            get => ComponentesPrecioDGV.DataSource as List<ComponentePrecioModelo>;
            set => ComponentesPrecioDGV.DataSource = value;
        }

        public ComponentePrecioModelo ComponenteSeleccionado
        {
            get => ComponentesPrecioDGV.SelectedRows[0].DataBoundItem as ComponentePrecioModelo;
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

        public decimal Precio
        {
            get => decimal.Parse(PrecioTB.Text);
            set => PrecioTB.Text = value.ToString(CultureInfo.InvariantCulture);
        }

        public void MostrarExcepcion(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        public void MostrarAgregarForm(ProveedorModelo proveedor)
        {
            if (Application.OpenForms.OfType<AgregarComponenteAListaPrecios>().Count() == 1)
                return;

            var agregarComponente = new AgregarComponenteAListaPrecios(proveedor);
            agregarComponente.FormClosed += (s, ee) => { Actualizar(s as CompletarEncuestaForm, ee.CloseReason); };
            agregarComponente.Show();
        }

        private void Actualizar(CompletarEncuestaForm sender, CloseReason eeCloseReason)
        {
            _controlador.MostrarListaDePrecios();
        }

        private void ComponentesPrecioDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _controlador.MostrarPrecioComponente();
        }

        private void AsignarPrecioBTN_Click(object sender, EventArgs e)
        {
            _controlador.CambiarPrecio();
        }

        private void EliminarComponenteBTN_Click(object sender, EventArgs e)
        {
            _controlador.EliminarComponenteDeLista();
        }

        private void AgregarComponenteBTN_Click(object sender, EventArgs e)
        {
            _controlador.MostrarAgregarComponente();
        }
    }
}
