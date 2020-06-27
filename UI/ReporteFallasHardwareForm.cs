using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas;

namespace UI
{
    public partial class ReporteFallasHardwareForm : Form, IReporteFallasHardwareVista
    {
        public ReporteFallasHardwareForm()
        {
            InitializeComponent();
        }

        private void ReporteFallasHardwareForm_Load(object sender, EventArgs e)
        {

        }

        public decimal CostoPromedioDeReemplazo { get; set; }
        public decimal TasaFallasPromedio { get; set; }
        public decimal TasaFallasPorUsuario { get; set; }
        public decimal ComponenteMasFallas { get; set; }
    }
}
