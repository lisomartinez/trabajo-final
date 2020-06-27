using System;
using System.Windows.Forms;
using Vistas;

namespace UI
{
    public partial class LoginForm : Form, ILoginVista
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, System.EventArgs e)
        {

        }

        public void MostrarExcepcion(Exception exception)
        {
            throw new NotImplementedException();
        }

        public string Usuario { get; set; }
        public string Password { get; set; }
    }
}