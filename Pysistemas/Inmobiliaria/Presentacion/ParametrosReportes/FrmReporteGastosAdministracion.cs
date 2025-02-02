using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Reportes;
using System;
using System.Windows.Forms;
using CrystalDecisions.Shared;


namespace Inmobiliaria.Presentacion.ParametrosReportes
{
    public partial class FrmReporteGastosAdministracion : FrmReporteMaestro
    {
        public Principal FrmPrincipal { get; set; }
        public FrmReporteGastosAdministracion(Principal frmPrincipal)
        {
            InitializeComponent();
            FrmPrincipal = frmPrincipal;
            CargarDatos();
        }

        private async void CargarDatos()
        {
            dtpFechaDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpFechaHasta.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            egresos_por_administrador egresosPorAdministrador = new egresos_por_administrador();
            DateTime fechaDesde;
            DateTime fechaHasta;

            fechaDesde = dtpFechaDesde.Value;
            fechaHasta = dtpFechaHasta.Value;


            try
            {

                egresosPorAdministrador.SetParameterValue("EMPRESA_ID_IN", FrmPrincipal.Empresa.EMPRESA_ID);
                egresosPorAdministrador.SetParameterValue("TIPO_IMPUTACION", Constantes.TiposImputaciones.ADMINISTRADOR);
                egresosPorAdministrador.SetParameterValue("FECHA_DESDE_IN", fechaDesde);
                egresosPorAdministrador.SetParameterValue("FECHA_HASTA_IN", fechaHasta);

                crViewer.ReportSource = egresosPorAdministrador;


                ExportOptions exportOptions = egresosPorAdministrador.ExportOptions;
                exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;

                
                crViewer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No existen datos que mostrar");
            }
            


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void FrmReporteGastosAdministracion_Load(object sender, EventArgs e)
        {
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}
