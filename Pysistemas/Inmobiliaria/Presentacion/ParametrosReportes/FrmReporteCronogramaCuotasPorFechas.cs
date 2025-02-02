using CrystalDecisions.Shared;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Reportes;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.ParametrosReportes
{
    public partial class FrmReporteCronogramaCuotasPorFechas : Inmobiliaria.Presentacion.ParametrosReportes.FrmReporteMaestro
    {
        Int64 EmpresaId;
        public FrmReporteCronogramaCuotasPorFechas(Int64 empresaId)
        {
            InitializeComponent();
            EmpresaId = empresaId;
            CargarDatos();
        }
        async void CargarDatos()
        {
            await CargarEntidadesInmobiliarias();
            btnPropiedadesTodos.Enabled = false;
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
        private void cargarComboEntidadesTodos()
        {
            cbEntidades.DisplayMember = "NOMBRE";
            cbEntidades.ValueMember = "ENTIDAD_INMOBILIARIA_ID";
            var itemsEntidades = new[] {
            new { NOMBRE = "*******Todos*******", ENTIDAD_INMOBILIARIA_ID = "-1" }
            };
            cbEntidades.DataSource = itemsEntidades;
            cbEntidades.SelectedIndex = 0;
            btnPropiedadesTodos.Enabled = false;

        }
        private void cargarComboPropiedadesTodos()
        {
            cbPropiedades.DisplayMember = "INMUEBLE";
            cbPropiedades.ValueMember = "PROPIEDAD_ID";
            var itemsPropiedades = new[] {
            new { INMUEBLE = "*******Todos*******", PROPIEDAD_ID = "-1" }
            };
            cbPropiedades.DataSource = itemsPropiedades;
            cbPropiedades.SelectedIndex = 0;
        }
        private void CargarPropiedadesEntidadInmobiliaria(long entidadId)
        {   
            // cargamos el combo en base a las propiedades que tienen operacion vigente nada mas
            using (OperacionesPendientesView operacionPendienteDao = new OperacionesPendientesView())
            {
                cbPropiedades.DataSource = operacionPendienteDao.ObtenerDesdeFiltros(p => p.ENTIDAD_INMOBILIARIA_ID == entidadId);
                ControlesUtilidades.InicializarComboBox(cbPropiedades);
            }
        }
        private void FrmReporteCronogramaCuotasPorFechas_Shown(object sender, EventArgs e)
        {
            cbEntidades.Focus();
            btnPropiedadesTodos.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var cronogramaCuotasPorFechas = new cronograma_cuotas_semanal();
            Int64 entidadInmobiliariaId = -1;
            Int64 propiedadId = -1;
            //Int64 empresaId = 0;
            DateTime fechaDesde;
            DateTime fechaHasta;

            if (cbEntidades.SelectedValue == null)
            {
                PysistemasMensajes.ShowInfo("Debe elegir un Edificio/Loteamiento");
                //return;
            }
            else if (cbPropiedades.SelectedValue == null)
            {
                PysistemasMensajes.ShowInfo("Debe elegir un Departamento/casa/dúplex/lote");
                //return;
            }
            else
            {
                // solo se muestra si selecciona una entidad
                fechaDesde = dtpFechaDesde.Value;
                fechaHasta = dtpFechaHasta.Value;

                entidadInmobiliariaId = Int64.Parse(cbEntidades.SelectedValue.ToString());
                if (cbPropiedades.SelectedValue != null)
                    propiedadId = Int64.Parse(cbPropiedades.SelectedValue.ToString());
                cronogramaCuotasPorFechas.SetParameterValue("EMPRESA_ID_IN", EmpresaId);
                cronogramaCuotasPorFechas.SetParameterValue("ENTIDAD_INMOBILIARIA_ID_IN", entidadInmobiliariaId);
                cronogramaCuotasPorFechas.SetParameterValue("PROPIEDAD_ID_IN", propiedadId);
                cronogramaCuotasPorFechas.SetParameterValue("FECHA_DESDE_INI", fechaDesde);
                cronogramaCuotasPorFechas.SetParameterValue("FECHA_HASTA_INI", fechaHasta);
                crViewer.ReportSource = cronogramaCuotasPorFechas;

                ExportOptions exportOptions = cronogramaCuotasPorFechas.ExportOptions;
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

        private void btnEntidadesTodos_Click(object sender, EventArgs e)
        {
            
            cargarComboEntidadesTodos();
            cargarComboPropiedadesTodos();
        }

        private void btnPropiedadesTodos_Click(object sender, EventArgs e)
        {
            if ((cbEntidades.SelectedValue != null && cbEntidades.SelectedIndex != -1) && !"*******Todos*******".Equals(cbEntidades.Text))
            {
                cargarComboPropiedadesTodos();
            }
        }

        private void btnLimpiarEntidad_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnLimpiarPropiedad_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void cbEntidades_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbEntidades.SelectedValue != null)
            {

                if (cbEntidades.SelectedValue != null)
                {
                    Int64 entidadId = Int64.Parse(cbEntidades.SelectedValue.ToString());
                    CargarPropiedadesEntidadInmobiliaria(entidadId);
                    btnPropiedadesTodos.Enabled = true;

                }
            }
        }

        private void FrmReporteCronogramaCuotasPorFechas_Load(object sender, EventArgs e)
        {
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}
