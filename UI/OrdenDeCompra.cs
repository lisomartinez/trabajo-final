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

        public OrdenDeCompra(ComponenteModelo componenteModelo)
        {
            InitializeComponent();
            _controlador = new OrdenDeCompraControlador(this, componenteModelo);
            _controlador.MostrarProveedorVendiendoComponente();
        }

        private void OrdenDeCompra_Load(object sender, EventArgs e)
        {

        }

        public void MostrarExcepcion(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        public List<ProveedorModelo> Proveedores
        {
            get => throw new NotImplementedException();
            set => ProveedoresDGV.DataSource = value;
        }
    }
}
