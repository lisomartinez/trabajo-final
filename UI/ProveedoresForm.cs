using System;
using System.Collections.Generic;
using System.Linq;
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
            get => ProveedoresDGV.DataSource as List<ProveedorModelo>;
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

        public void MostrarListaPreciosForm(ProveedorModelo proveedor)
        {
            if (Application.OpenForms.OfType<ListaDePreciosForm>().Count() == 1)
                return;

            var form = new ListaDePreciosForm(proveedor);
            form.Show();
        }

        private void ProveedoresDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _controlador.MostrarProveedor();
        }

        private void AltaBTN_Click(object sender, EventArgs e)
        {
            _controlador.AltaProveedor();
        }

        private void BajaBTN_Click(object sender, EventArgs e)
        {
            _controlador.EliminarProveedor();
        }

        private void ModificacionBTN_Click(object sender, EventArgs e)
        {
            _controlador.ModificarProveedor();
        }

        private void GestionarPreciosBTN_Click(object sender, EventArgs e)
        {
            _controlador.GestionarListaDePrecios();
        }
    }
}