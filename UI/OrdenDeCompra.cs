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
using Vistas;

namespace UI
{
    public partial class OrdenDeCompra : Form, IOrdenDeCompraVista
    {
        public OrdenDeCompra()
        {
            InitializeComponent();
        }

        private void OrdenDeCompra_Load(object sender, EventArgs e)
        {

        }

        public void MostrarExcepcion(Exception exception)
        {
            throw new NotImplementedException();
        }

        public List<ProveedorModelo> Proveedores { get; set; }
    }
}
