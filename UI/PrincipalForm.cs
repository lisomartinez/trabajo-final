using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

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

        // private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        // {
        //     if (Application.OpenForms.OfType<LoginForm>().Count() == 1)
        //         return;
        //
        //     var login = new LoginForm {MdiParent = this};
        //     login.Show();
        //
        // }
        //
        // private void solicitarToolStripMenuItem_Click(object sender, EventArgs e)
        // {
        //     if (Application.OpenForms.OfType<SolicitudAsistenciaForm>().Count() == 1)
        //         return;
        //
        //     var solicitarAsistencia = new SolicitudAsistenciaForm {MdiParent = this};
        //     solicitarAsistencia.Show();
        // }
        //
        // private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        // {
        //     if (Application.OpenForms.OfType<AsistenciaTecnicaForm>().Count() == 1)
        //         return;
        //
        //     var asistencias = new AsistenciaTecnicaForm {MdiParent = this};
        //     asistencias.Show();
        // }
        //
        // private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        // {
        //     if (Application.OpenForms.OfType<UsuarioForm>().Count() == 1)
        //         return;
        //
        //     var usuarios = new UsuarioForm {MdiParent = this};
        //     usuarios.Show();
        // }
        //
        // private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        // {
        //     if (Application.OpenForms.OfType<CompletarEncuestaForm>().Count() == 1)
        //         return;
        //
        //     var encuestas = new EncuestaForm {MdiParent = this};
        //     encuestas.Show();
        // }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            _controlador.MostrarMenus();
            // if (Sesion.Instance.NoInciada())
            // {
            //     foreach (ToolStripItem item in MenuPrincipal.Items)
            //     {
            //         item.Visible = false;
            //     }
            // }
            // MenuPrincipal.Items["PrincipalSubMenu"].Visible = true;
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
                foreach (ToolStripItem item in MenuPrincipal.Items)
                {
                    // if (value.Contains(item.Name)) item.Visible = true;
                    // else item.Visible = false;
                }
            }
        }
    }

    public class PrincipalControlador
    {
        private IPrincipalVista _vista;

        public PrincipalControlador(IPrincipalVista vista)
        {
            _vista = vista;
        }

        public void MostrarMenus()
        {
            if (Sesion.Instance.NoInciada())
            {
                _vista.Habilitados = new List<string> { "PrincipalSubMenu" };
            } 
            
        }
    }

    public interface IPrincipalVista
    {
        List<string> Habilitados { get; set; }
    }
}