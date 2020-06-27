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
    public partial class TecnicoForm : Form, ITecnicoVista
    {
        public TecnicoForm()
        {
            InitializeComponent();
        }

        private void TecnicoForm_Load(object sender, EventArgs e)
        {

        }

        public void MostrarExcepcion(Exception exception)
        {
            throw new NotImplementedException();
        }

        public UsuarioModelo TecnicoSeleccionado { get; set; }
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<UsuarioModelo> Tecnicos { get; set; }
        public void SolicitarIngresoPassword()
        {
            throw new NotImplementedException();
        }
    }
}
