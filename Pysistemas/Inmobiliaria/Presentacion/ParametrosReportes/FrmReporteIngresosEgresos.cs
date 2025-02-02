using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Reportes;
using Inmobiliaria.Utilidades.Controles;

namespace Inmobiliaria.Presentacion.ParametrosReportes
{
    public partial class FrmReporteIngresosEgresos : Inmobiliaria.Presentacion.ParametrosReportes.FrmReporteMaestro
    {
        public Principal FrmPrincipal { get; set; }
        public FrmReporteIngresosEgresos(Principal frmPrincipal)
        {
            InitializeComponent();
            FrmPrincipal = frmPrincipal;
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

        private void cbEntidades_SelectionChangeCommitted(object sender, EventArgs e)
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
        private void CargarPropiedadesEntidadInmobiliaria(long entidadId)
        {
            using (PropiedadesDao propiedadesDao = new PropiedadesDao())
            {
                cbPropiedades.DataSource = propiedadesDao.ObtenerDesdeFiltros(p => p.ENTIDAD_INMOBILIARIA_ID == entidadId);

                ControlesUtilidades.InicializarComboBox(cbPropiedades);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlesUtilidades.InicializarComboBox(cbEntidades);
            ControlesUtilidades.InicializarComboBox(cbPropiedades);
            CargarDatos();
        }

        private void btnLimpiarPropiedad_Click(object sender, EventArgs e)
        {
            ControlesUtilidades.InicializarComboBox(cbPropiedades);
            CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            button1_Click(null, null);
            button1_Click(null, null);
            crViewer.ReportSource = null;
            dtpFechaDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpFechaHasta.Value = new DateTime(DateTime.Now.Year, 12, 31);
            cbEntidades.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            rpt_ingresos_egresos rptIngresosEgresos = new rpt_ingresos_egresos();

            Int64 entidadId = -1;
            Int64 propiedadId = -1;
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

                /*
                if (cbEntidades.SelectedValue != null)
                {
                    entidadId = Int64.Parse(cbEntidades.SelectedValue.ToString());
                }

                if (cbPropiedades.SelectedValue != null)
                {
                    propiedadId = Int64.Parse(cbPropiedades.SelectedValue.ToString());
                }
                */
                entidadId = Int64.Parse(cbEntidades.SelectedValue.ToString());
                propiedadId = Int64.Parse(cbPropiedades.SelectedValue.ToString());

                rptIngresosEgresos.SetParameterValue("ENTIDAD_INMOBILIARIA_ID", entidadId);
                rptIngresosEgresos.SetParameterValue("PROPIEDAD_ID", propiedadId);
                rptIngresosEgresos.SetParameterValue("FECHA_INI", dtpFechaDesde.Value);
                rptIngresosEgresos.SetParameterValue("FECHA_FIN", dtpFechaHasta.Value);
                Int64 empresaId = Int64.Parse(FrmPrincipal.Configuraciones.VariablesEntornos[Constantes.VariablesEntorno.EMPRESA_ID].VALOR);
                rptIngresosEgresos.SetParameterValue("EMPRESA_ID", empresaId);

                crViewer.ReportSource = rptIngresosEgresos;

                ExportOptions exportOptions = rptIngresosEgresos.ExportOptions;
                exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;

                crViewer.Show();
            }
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
            cbPropiedades.DisplayMember = "NOMBRE";
            cbPropiedades.ValueMember = "PROPIEDAD_ID";
            var itemsPropiedades = new[] {
                new { NOMBRE = "*******Todos*******", PROPIEDAD_ID = "-1" }
            };
            cbPropiedades.DataSource = itemsPropiedades;
            cbPropiedades.SelectedIndex = 0;
        }

        private void FrmReporteIngresosEgresos_Shown(object sender, EventArgs e)
        {
            cbEntidades.Focus();
            btnPropiedadesTodos.Enabled = false;
        }

        private void FrmReporteIngresosEgresos_Load(object sender, EventArgs e)
        {
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}
