using CrystalDecisions.Shared;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Reportes;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.ParametrosReportes
{
    public partial class FrmReportePropiedadesContratosVencimiento : FrmReporteMaestro
    {
        
        public FrmReportePropiedadesContratosVencimiento()
        {
            InitializeComponent();
            CargarDatos();
        }
        async void CargarDatos()
        {
            await CargarEntidadesInmobiliarias();
            dtpFechaDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpFechaHasta.Value = new DateTime(DateTime.Now.Year, 12, 31);


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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnLimpiarEntidad_Click(sender, e);
            crViewer.ReportSource = null;
            cbEntidades.Focus();

        }

        private void btnLimpiarEntidad_Click(object sender, EventArgs e)
        {
            //ControlesUtilidades.InicializarComboBox(cbEntidades);

            //ControlesUtilidades.InicializarControl(dtpFechaDesde);
            //ControlesUtilidades.InicializarControl(dtpFechaHasta);
            CargarDatos();
            
        }

        private void FrmReportePropiedadesContratosVencimiento_Shown(object sender, EventArgs e)
        {
            cbEntidades.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var propiedadesConContratosVencer = new propiedades_con_contratos_a_vencer();
            Int64 entidadInmobiliariaId = -1;
            DateTime fechaDesde;
            DateTime fechaHasta;
            if (cbEntidades.SelectedValue == null)
            {
                PysistemasMensajes.ShowInfo("Debe elegir un Edificio/Loteamiento");
            }
            else
            {
                // solo se muestra si selecciona una entidad

                entidadInmobiliariaId = Int64.Parse(cbEntidades.SelectedValue.ToString());
                fechaDesde = dtpFechaDesde.Value;
                fechaHasta = dtpFechaHasta.Value;

                propiedadesConContratosVencer.SetParameterValue("ENTIDAD_INMOBILIARIA_ID_IN", entidadInmobiliariaId);
                propiedadesConContratosVencer.SetParameterValue("FECHA_DESDE_IN", fechaDesde);
                propiedadesConContratosVencer.SetParameterValue("FECHA_HASTA_IN", fechaHasta);
                crViewer.ReportSource = propiedadesConContratosVencer;

                ExportOptions exportOptions = propiedadesConContratosVencer.ExportOptions;
                exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;

                crViewer.Show();
            }
        }

        private void btnEntidadesTodos_Click(object sender, EventArgs e)
        {
            cargarComboEntidadesTodos();
        }
        private void cargarComboEntidadesTodos()
        {
            cbEntidades.DisplayMember = "NOMBRE";
            cbEntidades.ValueMember = "ENTIDAD_INMOBILIARIA_ID";
            var itemsEntidades = new[] {
            new { NOMBRE = "*******Todos*******", ENTIDAD_INMOBILIARIA_ID = "-1" }
            };
            cbEntidades.DataSource = itemsEntidades;
            cbEntidades.SelectedIndex = 0;

        }

        private void FrmReportePropiedadesContratosVencimiento_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}
