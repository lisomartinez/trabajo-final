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
using Modelo;
using Vistas;

namespace UI
{
    public partial class TecnicoForm : Form, ITecnicoVista
    {
        private TecnicoControlador _controlador;

        public TecnicoForm()
        {
            InitializeComponent();
            _controlador = new TecnicoControlador(this);
            _controlador.MostrarTecnicos();
        }

        private void TecnicoForm_Load(object sender, EventArgs e)
        {
            _controlador.MostrarTecnicos();
        }

        public void MostrarExcepcion(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        public UsuarioModelo TecnicoSeleccionado
        {
            get => TecnicosDGV.SelectedRows[0].DataBoundItem as UsuarioModelo;
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

        public List<UsuarioModelo> Tecnicos
        {
            get => throw new NotImplementedException();
            set => TecnicosDGV.DataSource = value;
        }

        public void SolicitarIngresoPassword()
        {
            throw new NotImplementedException();
        }

        private void AltaBTN_Click(object sender, EventArgs e)
        {
            _controlador.CrearTecnico();
        }

        private void BajaBTN_Click(object sender, EventArgs e)
        {
            _controlador.EliminarTecnico();
        }

        private void ModificacionBTN_Click(object sender, EventArgs e)
        {
            _controlador.ModificarTecnico();
        }

        private void CambiarPasswordBTN_Click(object sender, EventArgs e)
        {
            _controlador.CambiarPassword();
        }

        private void TecnicosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _controlador.MostrarTecnico();
        }
    }
}