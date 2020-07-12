using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Controladores;
using Modelo;
using Vistas;

namespace UI
{
    public partial class AsistenciaTecnicaForm : Form, IAsistenciaTecnicaVista
    {
        private AsistenciaTecnicaControlador _controlador;

        public AsistenciaTecnicaForm()
        {
            InitializeComponent();
            _controlador = new AsistenciaTecnicaControlador(this);
        }

        private void AsistenciaTecnicaForm_Load(object sender, System.EventArgs e)
        {
            _controlador.MostrarAsistencias();
        }

        public List<AsistenciaTecnicaModelo> AsistenciasTecnicas
        {
            get => throw new NotImplementedException();
            set => AsistenciasTecnicasDGV.DataSource = value;
        }

        public AsistenciaTecnicaModelo AsistenciaSelccionado
        {
            get
            {
                if (AsistenciasTecnicasDGV.SelectedRows.Count == 1)
                {
                    return AsistenciasTecnicasDGV.SelectedRows[0].DataBoundItem as AsistenciaTecnicaModelo;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set => throw new NotImplementedException();
        }

        public int Codigo
        {
            get => int.Parse(CodigoTB.Text);
            set => CodigoTB.Text = value.ToString();
        }

        public TipoProblemaModelo TipoProblema
        {
            get => TipoProblemaCB.SelectedItem as TipoProblemaModelo;
            set
            {
                var tipos =  TipoProblemaCB.DataSource as List<TipoProblemaModelo>;
                if (tipos == null) return;
                var index = tipos.FindIndex(t => t.Id == value.Id);
                TipoProblemaCB.SelectedIndex = index;
            }
        }

        public DateTime Fecha
        {
            get => DateTime.Parse(FechaTB.Text);
            set => FechaTB.Text = value.ToLongDateString();
        }

        public UsuarioModelo Usuario
        {
            get => throw new NotImplementedException();
            set => UsuarioTB.Text = value.Nombre + " " + value.Apellido;
        }

        public UsuarioModelo Tecnico
        {
            get => throw new NotImplementedException();
            set => TecnicoTB.Text = value.Nombre + " " + value.Apellido;
        }

        public EstadoAsistenciaTecnicaModelo Estado
        {
            get => EstadoCB.SelectedItem as EstadoAsistenciaTecnicaModelo;
            set
            {
                var tipos = EstadoCB.DataSource as List<EstadoAsistenciaTecnicaModelo>;
                if (tipos == null) return;
                var index = tipos.FindIndex(t => t.Codigo == value.Codigo);
                EstadoCB.SelectedIndex = index;
            }
        }

        public int Calificacion
        {
            get => int.Parse(CalificacionTB.Text);
            set => CalificacionTB.Text = value.ToString();
        }

        public string Descripcion
        {
            get => DescripcionTB.Text;
            set => DescripcionTB.Text = value;
        }

        public List<TipoProblemaModelo> TiposProblema
        {
            get => throw new NotImplementedException();
            set => TipoProblemaCB.DataSource = value;
        }

        public List<EstadoAsistenciaTecnicaModelo> Estados
        {
            get => throw new NotImplementedException();
            set => EstadoCB.DataSource = value;
        }

        public void MostrarExcepcion(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        public void MostrarGestionarComputadora(UsuarioModelo usuario)
        {
            if (Application.OpenForms.OfType<GestionarComputadoraUsuarioForm>().Count() == 1)
                return;

            var gestion = new GestionarComputadoraUsuarioForm(usuario);
            gestion.Show();
        }

        public void MostrarCompletarEncuesta(AsistenciaTecnicaModelo seleccionada)
        {
            if (Application.OpenForms.OfType<CompletarEncuestaForm>().Count() == 1)
                return;

            var completarEncuesta = new CompletarEncuestaForm(seleccionada);
            completarEncuesta.FormClosed += (s, ee) => { Calificado(s as CompletarEncuestaForm, ee.CloseReason); };
            completarEncuesta.Show();
        }

        private void Calificado(CompletarEncuestaForm sender, CloseReason eeCloseReason)
        {
            var nota = sender.Calificacion;

            if (sender.Completada)
                Calificacion = nota;
        }

        private void ActualizarEstadoBTN_Click(object sender, EventArgs e)
        {
            _controlador.ActualizarEstado();
        }

        private void AsistenciasTecnicasDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _controlador.MostrarAsistencia();
        }

        private void ModificarBTN_Click(object sender, EventArgs e)
        {
            _controlador.ModificarAsistencia();
        }

        private void EliminarBTN_Click(object sender, EventArgs e)
        {
            _controlador.EliminarAsistencia();
        }

        private void GestionComputadoraBTN_Click(object sender, EventArgs e)
        {
            _controlador.GestionarComputadora();
        }

        private void CalificarBTN_Click(object sender, EventArgs e)
        {
            _controlador.CalificarAsistencia();
        }
    }
}