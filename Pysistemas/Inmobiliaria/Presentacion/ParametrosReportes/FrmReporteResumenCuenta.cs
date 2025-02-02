using System;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using Inmobiliaria.Presentacion.EntidadesInmobiliarias.Buscadores;
using Inmobiliaria.Presentacion.Mantenimiento.Buscadores;
using Inmobiliaria.Reportes;

namespace Inmobiliaria.Presentacion.ParametrosReportes
{
    public partial class FrmReporteResumenCuenta : Inmobiliaria.Presentacion.ParametrosReportes.FrmReporteMaestro
    {
        public FrmReporteResumenCuenta()
        {
            InitializeComponent();
        }

        private void FrmReporteResumenCuenta_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void btnLimpiarEntidad_Click(object sender, EventArgs e)
        {
            txtSocioNegocio.Text = String.Empty;
            txtSocioNegocio.Tag = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPropiedad.Text = String.Empty;
            txtPropiedad.Tag = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnLimpiarEntidad_Click(sender,e);
            button1_Click(sender,e);
            crViewer.ReportSource = null;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            rpt_resumen_cuentas rptResumenCta = new rpt_resumen_cuentas();
            Int64 propiedadId = -1;
            Int64 socioNegocioId = -1;
            if (txtSocioNegocio.Tag != null)
                socioNegocioId = Int64.Parse(txtSocioNegocio.Tag.ToString());
            if (txtPropiedad.Tag != null)
                propiedadId = Int64.Parse(txtPropiedad.Tag.ToString());
            rptResumenCta.SetParameterValue("SOCIO_NEGOCIO_ID_IN",socioNegocioId);
            rptResumenCta.SetParameterValue("PROPIEDAD_ID_IN", propiedadId);
            crViewer.ReportSource = rptResumenCta;

            ExportOptions exportOptions = rptResumenCta.ExportOptions;
            exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;

            crViewer.Show();
        }

        private void btnBuscadorSocioNegocio_Click(object sender, EventArgs e)
        {
            FrmBuscadorSociosNegocios frmBuscadorSociosNegocios = new FrmBuscadorSociosNegocios(FrmPrincipal, "socio negocio");
            frmBuscadorSociosNegocios.lblTitulo.Text = "Búsqueda de personas";
            if (DialogResult.OK.Equals(frmBuscadorSociosNegocios.ShowDialog(this)))
            {
                txtSocioNegocio.Text = frmBuscadorSociosNegocios.Entity.SOCIO_NEGOCIO;
                txtSocioNegocio.Tag = frmBuscadorSociosNegocios.Entity.SOCIO_NEGOCIO_ID;
                frmBuscadorSociosNegocios.Close();
                Activate();
            }
        }

        private void btnBuscarPropiedad_Click(object sender, EventArgs e)
        {
            FrmBuscadorPropiedad frmBuscadorPropiedad = new FrmBuscadorPropiedad();
            frmBuscadorPropiedad.lblTitulo.Text = "Búsqueda de departamentos/casas/dúplex/lote";
            if (DialogResult.OK.Equals(frmBuscadorPropiedad.ShowDialog()))
            {
                txtPropiedad.Text = frmBuscadorPropiedad.Entity.NOMBRE;
                txtPropiedad.Tag = frmBuscadorPropiedad.Entity.PROPIEDAD_ID;
            }
        }

        
    }
}
