using CrystalDecisions.Shared;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Reportes;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.ParametrosReportes
{
    public partial class FrmReportePlanillaRecaudacion : Inmobiliaria.Presentacion.ParametrosReportes.FrmReporteMaestro
    {
        Int64 EmpresaId;
        public FrmReportePlanillaRecaudacion(Int64 empresaId)
        {
            InitializeComponent();
            EmpresaId = empresaId;
            CargarDatos();
        }
        async void CargarDatos()
        {
            await CargarTipoOperaciones();
            txtAnho.Text = DateTime.Now.Year.ToString();
            //dtpFechaDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //dtpFechaHasta.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            CargarComboMeses();
            cbMeses.SelectedValue = DateTime.Now.Month.ToString();
            
        }
        async Task CargarTipoOperaciones()
        {
            using (DominiosDao dominiosDao = new DominiosDao())
            {
                cbTipoOperacion.DataSource = dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.TIPOS_OPERACIONES));

            }
            ControlesUtilidades.InicializarComboBox(cbTipoOperacion);
            return;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CargarDatos();
            crViewer.ReportSource = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            planilla_recaudacion_mensual planillaRecaudacionMensual = new planilla_recaudacion_mensual();

            

            if (cbTipoOperacion.SelectedValue == null)
            {
                PysistemasMensajes.ShowInfo("Debe elegir un Tipo de Operacion.");
            }
            else
            {
                int anho = int.Parse(txtAnho.Text.ToString());
                int mes = int.Parse(cbMeses.SelectedValue.ToString());

                DateTime fechaDesde = new DateTime(anho, mes, 1);
                DateTime fechaHasta = new DateTime(anho, mes, DateTime.DaysInMonth(anho, mes));

                dtpFechaDesde.Value = fechaDesde;
                dtpFechaHasta.Value = fechaHasta;

                String TipoOperacion = cbTipoOperacion.SelectedValue.ToString();

                planillaRecaudacionMensual.SetParameterValue("EMPRESA_ID_IN", EmpresaId);
                planillaRecaudacionMensual.SetParameterValue("ENTIDAD_INMOBILIARIA_ID_IN", -1);
                planillaRecaudacionMensual.SetParameterValue("FECHA_DESDE_INI", dtpFechaDesde.Value);
                planillaRecaudacionMensual.SetParameterValue("FECHA_HASTA_INI", dtpFechaHasta.Value);
                planillaRecaudacionMensual.SetParameterValue("TIPO_OPERACION_IN", TipoOperacion);
                crViewer.ReportSource = planillaRecaudacionMensual;

                ExportOptions exportOptions = planillaRecaudacionMensual.ExportOptions;
                exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;

                crViewer.Show();
            }
        }
        private void CargarComboMeses()
        {
            var meses = new[] {
                new { NOMBRE = "Enero", VALOR = "1" },
                new { NOMBRE = "Febrero", VALOR = "2" },
                new { NOMBRE = "Marzo", VALOR = "3" },
                new { NOMBRE = "Abril", VALOR = "4" },
                new { NOMBRE = "Mayo", VALOR = "5" },
                new { NOMBRE = "Junio", VALOR = "6" },
                new { NOMBRE = "Julio", VALOR = "7" },
                new { NOMBRE = "Agosto", VALOR = "8" },
                new { NOMBRE = "Septiembre", VALOR = "9" },
                new { NOMBRE = "Octubre", VALOR = "10" },
                new { NOMBRE = "Noviembre", VALOR = "11" },
                new { NOMBRE = "Diciembre", VALOR = "12" }
            };
            cbMeses.DataSource = meses;            
            ControlesUtilidades.InicializarComboBox(cbMeses);
            
        }

        private void FrmReportePlanillaRecaudacion_Shown(object sender, EventArgs e)
        {
            cbMeses.Focus();
        }

        private void FrmReportePlanillaRecaudacion_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void btnLimpiarTipoOperacion_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnTipoOperacionTodos_Click(object sender, EventArgs e)
        {
            cargarComboTiposOperaciones();
        }
        private void cargarComboTiposOperaciones()
        {
            cbTipoOperacion.DisplayMember = "VALOR_DOMINIO";
            cbTipoOperacion.ValueMember = "CODIGO_DOMINIO";
            var itemsEntidades = new[] {
            new { VALOR_DOMINIO = "*******Todos*******", CODIGO_DOMINIO = "-1" }
            };
            cbTipoOperacion.DataSource = itemsEntidades;
            cbTipoOperacion.SelectedIndex = 0;
        }
    }
}
