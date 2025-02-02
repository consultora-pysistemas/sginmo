using CrystalDecisions.Shared;
using Inmobiliaria.Reportes;
using System;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.ParametrosReportes
{
    public partial class FrmReporteVentasPropiedades : Inmobiliaria.Presentacion.ParametrosReportes.FrmReporteMaestro
    {
        
        public FrmReporteVentasPropiedades()
        {
            InitializeComponent();
            CargarDatos();
        }
        private void CargarDatos()
        {         
            dtpFechaDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpFechaHasta.Value = new DateTime(DateTime.Now.Year, 12, 31);

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var ventasPropiedades = new ventas_propiedades();
            DateTime fechaDesde;
            DateTime fechaHasta;

            fechaDesde = dtpFechaDesde.Value;
            fechaHasta = dtpFechaHasta.Value;

            ventasPropiedades.SetParameterValue("FECHA_DESDE_INI", fechaDesde);
            ventasPropiedades.SetParameterValue("FECHA_HASTA_INI", fechaHasta);
            crViewer.ReportSource = ventasPropiedades;

            ExportOptions exportOptions = ventasPropiedades.ExportOptions;
            exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;

            crViewer.Show();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            crViewer.ReportSource = null;
            CargarDatos();
        }

        private void FrmReporteVentasPropiedades_Load(object sender, EventArgs e)
        {
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;            
        }
    }
}
