using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<LoginForm>().Count() == 1)
                return;

            var login = new LoginForm {MdiParent = this};
            login.Show();

        }

        private void solicitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<SolicitudAsistenciaForm>().Count() == 1)
                return;

            var solicitarAsistencia = new SolicitudAsistenciaForm {MdiParent = this};
            solicitarAsistencia.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AsistenciaTecnicaForm>().Count() == 1)
                return;

            var asistencias = new AsistenciaTecnicaForm {MdiParent = this};
            asistencias.Show();
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<UsuarioForm>().Count() == 1)
                return;

            var usuarios = new UsuarioForm {MdiParent = this};
            usuarios.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CompletarEncuestaForm>().Count() == 1)
                return;

            var encuestas = new EncuestaForm {MdiParent = this};
            encuestas.Show();
        }
    }
}