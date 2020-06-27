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
    public partial class ComponenteForm : Form, IComponenteVista
    {
        public ComponenteForm()
        {
            InitializeComponent();
        }

        private void ComponenteForm_Load(object sender, EventArgs e)
        {

        }

        public void MostrarExcepcion(Exception exception)
        {
            throw new NotImplementedException();
        }

        public List<ComponenteModelo> Componentes { get; set; }
        public ComponenteModelo ComponenteSeleccionado { get; set; }
        public int NumeroSerie { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public List<EspecificacionTecnicaModelo> EspecificacionesTecnicas { get; set; }
        public int CodigoEspecificacionTecnica { get; set; }
        public string NombreEspecificacion { get; set; }
        public string DescripcionEspecificacion { get; set; }
        public EspecificacionTecnicaModelo EspecificacionTecnicaSeleccionada { get; set; }
    }
}
