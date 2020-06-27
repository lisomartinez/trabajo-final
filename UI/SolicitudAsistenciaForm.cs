using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Controladores;
using Vistas;

namespace UI
{
    public partial class SolicitudAsistenciaForm : Form, ISolicitudAsistenciaVista
    {
        public SolicitudAsistenciaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void SolicitudAsistenciaForm_Load(object sender, EventArgs e)
        {

        }

        public List<TipoProblemaModelo> TiposDeProblemas { get; set; }
        public string Descripcion { get; set; }
        public List<TurnoModelo> Turnos { get; set; }
        public TipoProblemaModelo TipoProblemaSeleccionado { get; set; }
        public TurnoModelo TurnoSeleccionado()
        {
            throw new NotImplementedException();
        }

        public void MostrarExcepcion(Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}