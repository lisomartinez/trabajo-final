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
    public partial class GestionarComputadoraUsuarioForm : Form, IGestionarComputadoraUsuarioVista
    {
        public GestionarComputadoraUsuarioForm()
        {
            InitializeComponent();
        }

        private void GestionarComputadoraUsuarioForm_Load(object sender, EventArgs e)
        {

        }

        public void MostrarExcepcion(Exception exception)
        {
            throw new NotImplementedException();
        }

        public List<ComputadoraModelo> Computadoras { get; set; }
        public ComputadoraModelo ComputadoraSeleccionada { get; set; }
    }
}
