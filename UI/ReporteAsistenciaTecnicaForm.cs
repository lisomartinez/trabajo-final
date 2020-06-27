using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Vistas;

namespace UI
{
    public partial class ReporteAsistenciaTecnicaForm : Form , IReporteAsistenciaTecnicaVista
    {
        public ReporteAsistenciaTecnicaForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReporteAsistenciaTecnicaForm_Load(object sender, EventArgs e)
        {

        }

        public void MostrarExcepcion(Exception exception)
        {
            throw new NotImplementedException();
        }

        public int TiempoMedioDuracion { get; set; }
        public int TiempoMedioDeInicio { get; set; }
        public int TiempoMedioInicioFinalizacion { get; set; }
        public List<UsuarioModelo> Tecnicos { get; set; }
        public UsuarioModelo TecnicoSeleccionado { get; set; }
        public decimal CalificacionPromedio { get; set; }
        public int TiempoMedioDuracionTecnico { get; set; }
        public int TiempoMedioDeInicioTecnico { get; set; }
        public int TiempoMedioInicioFinalizacionTecnico { get; set; }
        public int DesviacionDuracionTecnico { get; set; }
        public int DesviacionInicioTecnico { get; set; }
        public int DesviacionInicioFinalizacion { get; set; }
    }
}
