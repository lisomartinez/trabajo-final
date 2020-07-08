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
    public partial class SoftwareForm : Form, ISoftwareVista
    {
        private SoftwareControlador _controlador;
        public SoftwareForm(ComputadoraModelo computadoraModelo)
        {
            InitializeComponent();
            _controlador = new SoftwareControlador(this, computadoraModelo);
        }


        private void SoftwareForm_Load(object sender, EventArgs e)
        {
            _controlador.MostrarSoftwares();

        }

        public void MostrarExcepcion(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        public List<SoftwareModelo> Softwares
        {
            get => throw new NotImplementedException();
            set => SoftwareDGV.DataSource = value;
        }

        public SoftwareModelo SoftwareSeleccionado
        {
            get => SoftwareDGV.SelectedRows[0].DataBoundItem as SoftwareModelo;
            set => throw new NotImplementedException();
        }

        public int Codigo
        {
            get => int.Parse(CodigoTB.Text);
            set => CodigoTB.Text = value.ToString();
        }

        public string Nombre
        {
            get => NombreTB.Text;
            set => NombreTB.Text = value;
        }

        public string Version
        {
            get => VersionTB.Text;
            set => VersionTB.Text = value;
        }

        public string Desarrollador
        {
            get => DesarrolladorTB.Text;
            set => DesarrolladorTB.Text = value;
        }

        private void SoftwareDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _controlador.MostrarSoftware();
        }

        private void AltaBTN_Click(object sender, EventArgs e)
        {
            _controlador.AgregarSoftware();
        }

        private void BajaBTN_Click(object sender, EventArgs e)
        {
            _controlador.EliminarSoftware();
        }

        private void ModificacionBTN_Click(object sender, EventArgs e)
        {
            _controlador.ModificarSoftware();
        }
    }
}
