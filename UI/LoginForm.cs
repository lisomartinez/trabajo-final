using System;
using System.Windows.Forms;
using Controladores;
using Vistas;

namespace UI
{
    public partial class LoginForm : Form, ILoginVista
    {
        private LoginControlador _controlador;
        public LoginForm()
        {
            InitializeComponent();
            _controlador = new LoginControlador(this);
        }

        private void LoginForm_Load(object sender, System.EventArgs e)
        {

        }

        public void MostrarExcepcion(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        public string Legajo
        {
            get => LegajoTB.Text;
            set => LegajoTB.Text = value;
        }

        public string Password
        {
            get => PasswordTB.Text;
            set => PasswordTB.Text = value;
        }

        private void IngresarBTN_Click(object sender, EventArgs e)
        {
            _controlador.Logearse();
        }

        private void LegajoTB_Leave(object sender, EventArgs e)
        {
            _controlador.ValidarFormatoLegajo();
        }
    }
}