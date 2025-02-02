using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Reportes;
using Inmobiliaria.Utilidades.Controles;

namespace Inmobiliaria.Presentacion.ParametrosReportes
{
    public partial class FrmReporteCuotasCobradas : Inmobiliaria.Presentacion.ParametrosReportes.FrmReporteMaestro
    {
        public FrmReporteCuotasCobradas()
        {
            InitializeComponent();
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

        private void CargarPropiedadesEntidadInmobiliaria(long entidadId)
        {
            using (PropiedadesDao propiedadesDao = new PropiedadesDao())
            {
                cbPropiedades.DataSource = propiedadesDao.ObtenerDesdeFiltros(p => p.ENTIDAD_INMOBILIARIA_ID == entidadId);

                ControlesUtilidades.InicializarComboBox(cbPropiedades);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLimpiarEntidad_Click(object sender, EventArgs e)
        {
            ControlesUtilidades.InicializarComboBox(cbEntidades);
            CargarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ControlesUtilidades.InicializarComboBox(cbPropiedades);
            CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnLimpiarEntidad_Click(null,null);
            button1_Click(null,null);
            crViewer.ReportSource = null;
            dtpFechaDesde.Value = new DateTime(DateTime.Now.Year, 1,1);
            dtpFechaHasta.Value = new DateTime(DateTime.Now.Year, 12, 31);
            cbEntidades.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            rpt_cuotas_cobradas rptCuotasCobradas = new rpt_cuotas_cobradas();

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
            }*/
                entidadId = Int64.Parse(cbEntidades.SelectedValue.ToString());
                propiedadId = Int64.Parse(cbPropiedades.SelectedValue.ToString());

                rptCuotasCobradas.SetParameterValue("ENTIDAD_INMOBILIARIA_ID_IN", entidadId);
                rptCuotasCobradas.SetParameterValue("PROPIEDAD_ID_IN", propiedadId);
                rptCuotasCobradas.SetParameterValue("FECHA_DESDE_IN", dtpFechaDesde.Value);
                rptCuotasCobradas.SetParameterValue("FECHA_HASTA_IN", dtpFechaHasta.Value);
                rptCuotasCobradas.SetParameterValue("SOCIO_NEGOCIO_ID_IN", -1);
                crViewer.ReportSource = rptCuotasCobradas;

                ExportOptions exportOptions = rptCuotasCobradas.ExportOptions;
                exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;

                crViewer.Show();
            }
        }

        private void btnPropiedadesTodos_Click(object sender, EventArgs e)
        {

            if ((cbEntidades.SelectedValue != null && cbEntidades.SelectedIndex != -1) && !"*******Todos*******".Equals(cbEntidades.Text))
            {
                cargarComboPropiedadesTodos();
            }
        }

        private void btnEntidadesTodos_Click(object sender, EventArgs e)
        {
            cargarComboEntidadesTodos();
            cargarComboPropiedadesTodos();
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

        private void FrmReporteCuotasCobradas_Shown(object sender, EventArgs e)
        {
            cbEntidades.Focus();
            btnPropiedadesTodos.Enabled = false;
        }

        private void FrmReporteCuotasCobradas_Load(object sender, EventArgs e)
        {
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}
