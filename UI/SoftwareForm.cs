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
    public partial class SoftwareForm : Form, ISoftwareVista
    {
        public SoftwareForm()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void SoftwareForm_Load(object sender, EventArgs e)
        {

        }

        public void MostrarExcepcion(Exception exception)
        {
            throw new NotImplementedException();
        }

        public List<SoftwareModelo> Softwares { get; set; }
        public SoftwareModelo SoftwareSeleccionado { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Version { get; set; }
        public string Desarrollador { get; set; }
    }
}
