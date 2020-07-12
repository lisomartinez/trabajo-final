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
using Vistas;

namespace UI
{
    public partial class PrincipalForm : Form, IPrincipalVista
    {
        private PrincipalControlador _controlador;
        public PrincipalForm()
        {
            InitializeComponent();
            _controlador = new PrincipalControlador(this);
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<LoginForm>().Count() == 1)
                return;
        
            var login = new LoginForm {MdiParent = this};
            login.Show();
        }
   

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            _controlador.MostrarMenus();
        }

        private void IngresarOpcion_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<LoginForm>().Count() == 1)
                return;
            
            var login = new LoginForm {MdiParent = this};
            login.FormClosed += (s, ee) => { OnMdiChildClosed(s as Form, ee.CloseReason); };
            login.Show();
        }

        private void OnMdiChildClosed(Form sender, CloseReason eCloseReason)
        {
            if (Sesion.Instance.NoInciada())
            {
                foreach (ToolStripItem item in MenuPrincipal.Items)
                {
                    item.Visible = true;
                }
            }
        }

        public List<string> Habilitados
        {
            get => throw new NotImplementedException();
            set
            {
                // foreach (ToolStripItem item in MenuPrincipal.Items)
                // {
                    // item.Visible = value.Contains(item.Name);
                // }
            }
        }

        private void SolicitarAsistenciaOpcion_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<SolicitudAsistenciaForm>().Count() == 1)
                return;

            var solicitarAsistencia = new SolicitudAsistenciaForm { MdiParent = this };
            solicitarAsistencia.Show();
        }

        private void ConsultarAsistenciaOpcion_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AsistenciaTecnicaForm>().Count() == 1)
                return;

            var asistencias = new AsistenciaTecnicaForm { MdiParent = this };
            asistencias.Show();
        }

        private void AdministrarOpcion_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<UsuarioForm>().Count() == 1)
                return;

            var usuarios = new UsuarioForm { MdiParent = this };
            usuarios.Show();
        }

        private void ConsultarEncuestaOpcion_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CompletarEncuestaForm>().Count() == 1)
                return;

            var encuestas = new EncuestaForm { MdiParent = this };
            encuestas.Show();
        }

        private void AsistenciaSubMenu_Click(object sender, EventArgs e)
        {

        }

        private void TipoProblemaOpcion_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<TipoProblemaForm>().Count() == 1)
                return;

            var form = new TipoProblemaForm {MdiParent = this};
            form.Show();
        }

        private void EstadoAsistenciaOpcion_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<EstadoAsistenciaForm>().Count() == 1)
                return;

            var form = new EstadoAsistenciaForm { MdiParent = this };
            form.Show();
        }

        //TODO: add Jerarquia CRUD.
        private void CategoriaOpcion_Click(object sender, EventArgs e)
        {
            // if (Application.OpenForms.OfType<>().Count() == 1)
            //     return;
            //
            // var form = new EstadoAsistenciaForm { MdiParent = this };
            // form.Show();
        }

        private void AdministrarProveedorOpcion_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ProveedoresForm>().Count() == 1)
                return;

            var form = new ProveedoresForm { MdiParent = this };
            form.Show();
        }

        private void EstadisticasAsistenciaTecnicaOpcion_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ReporteAsistenciaTecnicaForm>().Count() == 1)
                return;

            var form = new ReporteAsistenciaTecnicaForm { MdiParent = this };
            form.Show();
        }
    }
}