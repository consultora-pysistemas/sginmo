using CrystalDecisions.Shared;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Reportes;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.ParametrosReportes
{
    public partial class FrmReporteCobroAlquileres : Inmobiliaria.Presentacion.ParametrosReportes.FrmReporteMaestro
    {
        public FrmReporteCobroAlquileres()
        {
            InitializeComponent();
            CargarDatos();
        }
        async void CargarDatos()
        {
            txtAnho.Text = DateTime.Now.Year.ToString();

            await CargarEntidadesInmobiliarias();
        }
        async Task CargarEntidadesInmobiliarias()
        {
            using (EntidadesInmobiliariasDao entidadesInmobiliariasDao = new EntidadesInmobiliariasDao())
            {
                cbEntidades.DataSource = entidadesInmobiliariasDao.ObtenerLista();
            }
            ControlesUtilidades.InicializarComboBox(cbEntidades);

            return;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var planillaCobrosAlquileres = new planilla_cobros_alquileres();
            Int64 entidadInmobiliariaId = -1;
            Int64 anho;

            if (cbEntidades.SelectedValue == null)
            {
                PysistemasMensajes.ShowInfo("Debe elegir un Edificio/Loteamiento");
            }
            else
            {
                // solo se muestra si selecciona una entidad

                entidadInmobiliariaId = Int64.Parse(cbEntidades.SelectedValue.ToString());
                anho = Int64.Parse(txtAnho.Text);
                planillaCobrosAlquileres.SetParameterValue("ENTIDAD_INMOBILIARIA_ID_IN", entidadInmobiliariaId);
                planillaCobrosAlquileres.SetParameterValue("ANHO_IN", anho);

                crViewer.ReportSource = planillaCobrosAlquileres;

                ExportOptions exportOptions = planillaCobrosAlquileres.ExportOptions;
                exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;

                crViewer.Show();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnLimpiarEntidad_Click(sender, e);
            crViewer.ReportSource = null;
            cbEntidades.Focus();
        }

        private void btnLimpiarEntidad_Click(object sender, EventArgs e)
        {
            ControlesUtilidades.InicializarComboBox(cbEntidades);
            CargarDatos();
        }

        private void FrmReporteCobroAlquileres_Shown(object sender, EventArgs e)
        {
            cbEntidades.Focus();
        }

        private void txtAnho_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void FrmReporteCobroAlquileres_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}
