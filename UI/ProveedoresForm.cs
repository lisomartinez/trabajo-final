using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Modelo;
using Vistas;

namespace UI
{
    public partial class ProveedoresForm : Form, IProveedoresVista
    {
        public ProveedoresForm()
        {
            InitializeComponent();
        }

        private void ProveedoresForm_Load(object sender, System.EventArgs e)
        {

        }

        public void MostrarExcepcion(Exception exception)
        {
            throw new NotImplementedException();
        }

        public List<ProveedorModelo> Proveedores { get; set; }
        public ProveedorModelo ProveedorSeleccionado { get; set; }
        public int Cuit { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}