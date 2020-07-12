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
    public partial class OrdenDeCompra : Form, IOrdenDeCompraVista
    {
        private OrdenDeCompraControlador _controlador;

        public OrdenDeCompra(ComponenteModelo componenteModelo, AsistenciaTecnicaModelo asistenciaTecnicaModelo)
        {
            InitializeComponent();
            _controlador = new OrdenDeCompraControlador(this, componenteModelo, asistenciaTecnicaModelo);
        }

        private void OrdenDeCompra_Load(object sender, EventArgs e)
        {
            _controlador.MostrarProveedorVendiendoComponente();
        }

        public void MostrarExcepcion(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        public ProveedorModelo ProveedorSeleccionado
        {
            get
            {
                var modelo = ProveedoresDGV.SelectedRows[0].DataBoundItem as ProveedorPrecioModelo;
                return modelo?.Proveedor ?? null;
            } 
            set => throw new NotImplementedException();
        }

        public decimal Precio { get; set; }

        public List<ProveedorPrecioModelo> Proveedores
        {
            get => throw new NotImplementedException();
            set => ProveedoresDGV.DataSource = value;
        }

        private void GenearOrdenBTN_Click(object sender, EventArgs e)
        {
            _controlador.GenerarOrdenDeCompra();
        }
    }
}
