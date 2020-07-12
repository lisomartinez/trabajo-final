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
    public partial class ReporteFallasHardwareForm : Form, IReporteFallasHardwareVista
    {
        private ReporteFallasHardwareControlador _controlador;
        public ReporteFallasHardwareForm()
        {
            InitializeComponent();
            _controlador = new ReporteFallasHardwareControlador(this);
        }

        private void ReporteFallasHardwareForm_Load(object sender, EventArgs e)
        {
            _controlador.MostrarEstadisticas();
        }

        public decimal CostoPromedioDeReemplazo
        {
            get => Decimal.Parse(CostoPromedioTB.Text);
            set => CostoPromedioTB.Text = value.ToString();
        }

        public decimal TasaFallasPromedio
        {
            get => Decimal.Parse(TasaFallasTB.Text);
            set => TasaFallasTB.Text = value.ToString();
        }

        public decimal TasaFallasPorUsuario
        {
            get => Decimal.Parse(TasaFallasPorLegajoTB.Text);
            set => TasaFallasPorLegajoTB.Text = value.ToString();
        }

        public decimal ComponenteMasFallas
        {
            get => Decimal.Parse(MayorFallasTB.Text);
            set => MayorFallasTB.Text = value.ToString();
        }

        public decimal CostoMensual
        {
            get => Decimal.Parse(TotalAcumuladoMensualTB.Text);
            set => TotalAcumuladoMensualTB.Text = value.ToString();
        }

        public void MostrarExcepcion(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }
    }
}
