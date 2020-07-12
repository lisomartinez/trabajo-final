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
    public partial class TipoProblemaForm : Form, ITipoProblemaVista
    {
        private TipoProblemaControlador _controlador;

        public TipoProblemaForm()
        {
            InitializeComponent();
            _controlador = new TipoProblemaControlador(this);
        }

        private void TipoProblemaForm_Load(object sender, EventArgs e)
        {
            _controlador.MostrarTiposProblemas();
        }

        private void AgregarBTN_Click(object sender, EventArgs e)
        {
            _controlador.AgregarTipoProblema();
        }

        private void ModificarBTN_Click(object sender, EventArgs e)
        {
            _controlador.ModificarTipoProblema();
        }

        private void EliminarBTN_Click(object sender, EventArgs e)
        {
            _controlador.EliminarTipoProblema();
        }

        private void EstadosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _controlador.MostrarTipoProblema();
        }

        public List<TipoProblemaModelo> TiposProblemas
        {
            get => TiposProblemaDGV.DataSource as List<TipoProblemaModelo>;
            set => TiposProblemaDGV.DataSource = value;
        }

        public TipoProblemaModelo TipoProblemaSeleccionado
        {
            get => TiposProblemaDGV.SelectedRows[0].DataBoundItem as TipoProblemaModelo;
            set => throw new NotImplementedException();
        }

        public int Id
        {
            get => int.Parse(IdTB.Text);
            set => IdTB.Text = value.ToString();
        }

        public string Nombre
        {
            get => NombreTB.Text;
            set => NombreTB.Text = value;
        }

        public void MostrarException(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }
    }
}
