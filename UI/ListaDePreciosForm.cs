using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Vistas;

namespace UI
{
    public partial class ListaDePreciosForm : Form, IListaDePreciosVista
    {
        public ListaDePreciosForm()
        {
            InitializeComponent();
        }

        private void ListaDePreciosForm_Load(object sender, EventArgs e)
        {

        }

        public List<ComponentePrecioModelo> ListaPrecios { get; set; }
        public ComponentePrecioModelo ComponenteSeleccionado { get; set; }
        public int NumeroSerie { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public void MostrarExcepcion(Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}
