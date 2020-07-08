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
    public partial class GestionarComputadoraUsuarioForm : Form, IGestionarComputadoraUsuarioVista
    {
        private GestionarComputadoraUsuarioControlador _controlador;

        public GestionarComputadoraUsuarioForm(UsuarioModelo usuarioModelo)
        {
            InitializeComponent();
            _controlador = new GestionarComputadoraUsuarioControlador(this, usuarioModelo);
        }

        private void GestionarComputadoraUsuarioForm_Load(object sender, EventArgs e)
        {
            _controlador.MostrarUsuario();
            _controlador.MostrarComputadoras();
        }

        public void MostrarExcepcion(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        public List<ComputadoraModelo> Computadoras
        {
            get => throw new NotImplementedException();
            set => ComputadorasDGV.DataSource = value;
        }

        public ComputadoraModelo ComputadoraSeleccionada
        {
            get => ComputadorasDGV.SelectedRows[0].DataBoundItem as ComputadoraModelo;
            set => throw new NotImplementedException();
        }

        public int Legajo
        {
            get => int.Parse(LegajoTB.Text);
            set => LegajoTB.Text = value.ToString();
        }

        public string Nombre
        {
            get => NombreTB.Text;
            set => NombreTB.Text = value;
        }

        public string Apellido
        {
            get => ApellidoTB.Text;
            set => ApellidoTB.Text = value;
        }
    }
}
