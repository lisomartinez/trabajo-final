using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Vistas;

namespace UI
{
    public partial class ReemplazoComponenteForm : Form, IReemplazoComponenteVista
    {
        public ReemplazoComponenteForm()
        {
            InitializeComponent();
        }

        private void ReemplazoComponenteForm_Load(object sender, System.EventArgs e)
        {

        }

        public int Codigo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public List<ComponenteModelo> Componentes { get; set; }
        public ComponenteModelo ComponenteSeleccionado { get; set; }
        public void MostrarOrdenDeCompraForm(ComponenteModelo componenteSeleccionado)
        {
            throw new NotImplementedException();
        }

        public void MostrarExcepcion(Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}