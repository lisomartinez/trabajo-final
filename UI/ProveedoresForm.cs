using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Controladores;
using Modelo;
using Vistas;

namespace UI
{
    public partial class ProveedoresForm : Form, IProveedoresVista
    {
        private ProveedoresControlador _controlador;

        public ProveedoresForm()
        {
            InitializeComponent();
            _controlador = new ProveedoresControlador(this);
            _controlador.MostrarProveedores();
        }

        private void ProveedoresForm_Load(object sender, System.EventArgs e)
        {

        }

        public void MostrarExcepcion(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        public List<ProveedorModelo> Proveedores
        {
            get => throw new NotImplementedException();
            set => ProveedoresDGV.DataSource = value;
        }

        public ProveedorModelo ProveedorSeleccionado
        {
            get => ProveedoresDGV.SelectedRows[0].DataBoundItem as ProveedorModelo;
            set => throw new NotImplementedException();
        }

        public int Cuit
        {
            get => int.Parse(CuitTB.Text);
            set => CuitTB.Text = value.ToString();
        }

        public string RazonSocial
        {
            get => RazonSocialTB.Text;
            set => RazonSocialTB.Text = value;
        }

        public string Direccion
        {
            get => DireccionTB.Text;
            set => DireccionTB.Text = value;
        }

        public string Email
        {
            get => EmailTB.Text;
            set => EmailTB.Text = value;
        }

        public string Telefono
        {
            get => TelefonoTB.Text;
            set => TelefonoTB.Text = value;
        }
    }
}