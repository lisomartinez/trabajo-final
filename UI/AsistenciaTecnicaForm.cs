using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Modelo;
using Vistas;

namespace UI
{
    public partial class AsistenciaTecnicaForm : Form, IAsistenciaTecnicaVista
    {
        public AsistenciaTecnicaForm()
        {
            InitializeComponent();
        }

        private void AsistenciaTecnicaForm_Load(object sender, System.EventArgs e)
        {

        }

        public List<AsistenciaTecnicaModelo> AsistenciasTecnicas { get; set; }
        public AsistenciaTecnicaModelo AsistenciaSelccionado { get; set; }
        public int Codigo { get; set; }
        public TipoProblemaModelo TipoProblema { get; set; }
        public DateTime Fecha { get; set; }
        public UsuarioModelo Usuario { get; set; }
        public UsuarioModelo Tecnico { get; set; }
        public EstadoAsistenciaTecnicaModelo Estado { get; set; }
        public int Calificacion { get; set; }
        public string Descripcion { get; set; }
        public void MostrarExcepcion(Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}