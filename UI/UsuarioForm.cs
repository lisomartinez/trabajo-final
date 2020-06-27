using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Modelo;
using Vistas;

namespace UI
{
    public partial class UsuarioForm : Form, IUsuarioVista
    {
        public UsuarioForm()
        {
            InitializeComponent();
        }

        private void UsuarioForm_Load(object sender, System.EventArgs e)
        {

        }

        public void MostrarExcepcion(Exception exception)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioModelo> Usuarios { get; set; }
        public UsuarioModelo UsuarioSeleccionado { get; set; }
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public RolModelo Rol { get; set; }
        public string Password { get; set; }
        public void SolicitarIngresoPassword()
        {
            throw new NotImplementedException();
        }

        public void MostrarGestionarComputadoraForm(UsuarioModelo vistaUsuarioSeleccionado)
        {
            throw new NotImplementedException();
        }
    }
}