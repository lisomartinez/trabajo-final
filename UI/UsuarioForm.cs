using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Controladores;
using Modelo;
using Vistas;

namespace UI
{
    public partial class UsuarioForm : Form, IUsuarioVista
    {
        private UsuarioControlador _controlador;
        public UsuarioForm()
        {
            InitializeComponent();
            _controlador = new UsuarioControlador(this);
        }

        private void UsuarioForm_Load(object sender, System.EventArgs e)
        {
            _controlador.MostrarUsuarios();
        }

        public void MostrarExcepcion(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        public List<UsuarioModelo> Usuarios
        {
            get => throw new NotImplementedException();
            set => UsuariosDGV.DataSource = value;
        }

        public UsuarioModelo UsuarioSeleccionado
        {
            get => UsuariosDGV.SelectedRows[0].DataBoundItem as UsuarioModelo;
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

        public string Email
        {
            get => EmailTB.Text;
            set => EmailTB.Text = value;
        }


        public void SolicitarIngresoPassword()
        {
            throw new NotImplementedException();
        }

        public void MostrarGestionarComputadoraForm(UsuarioModelo vistaUsuarioSeleccionado)
        {
            throw new NotImplementedException();
        }

        private void AltaBTN_Click(object sender, EventArgs e)
        {
            _controlador.CrearUsuario();
        }

        private void BajaBTN_Click(object sender, EventArgs e)
        {
            _controlador.EliminarUsuario();
        }

        private void ModificacionBTN_Click(object sender, EventArgs e)
        {
            _controlador.ModificarUsuario();
        }

        private void CambiarPasswordBTN_Click(object sender, EventArgs e)
        {
            _controlador.CambiarPassword();
        }

        private void UsuariosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _controlador.MostrarUsuario();
        }
    }
}