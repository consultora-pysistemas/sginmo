using CrystalDecisions.Shared;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Threading.Tasks;
using Inmobiliaria.Reportes;
using System.Windows.Forms;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;

namespace Inmobiliaria.Presentacion.ParametrosReportes
{
    public partial class FrmReporteIngresosFijosPorEntidades : Inmobiliaria.Presentacion.ParametrosReportes.FrmReporteMaestro
    {
        public FrmReporteIngresosFijosPorEntidades()
        {
            InitializeComponent();
            CargarDatos();
        }
        async void CargarDatos()
        {
            await CargarTipoOperaciones();
            await CargarEntidadesInmobiliarias();            
        }
        async Task CargarEntidadesInmobiliarias()
        {
            using (EntidadesInmobiliariasDao entidadesInmobiliariasDao = new EntidadesInmobiliariasDao())
            {
                cbEntidades.DataSource = entidadesInmobiliariasDao.ObtenerLista();
                //cbEntidades.DataSource = entidadesInmobiliariasDao.ObtenerDesdeFiltros(c => c.NATURALEZA == "ALQUILER");
            }
            ControlesUtilidades.InicializarComboBox(cbEntidades);

            return;
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
            btnLimpiarEntidad_Click(sender, e);
            crViewer.ReportSource = null;
            cbTipoOperacion.Focus();
        }

        private void btnLimpiarEntidad_Click(object sender, EventArgs e)
        {
            //ControlesUtilidades.InicializarComboBox(cbEntidades);
            CargarDatos();
        }

        private void FrmReporteIngresosFijosPorEntidades_Shown(object sender, EventArgs e)
        {
            cbTipoOperacion.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            var ingresoFijosEntidades = new ingresos_fijos_por_entidades();
            Int64 entidadInmobiliariaId = -1;
           
            if (cbEntidades.SelectedValue == null)
            {
                PysistemasMensajes.ShowInfo("Debe elegir un Edificio/Loteamiento");
            }
            else if (cbTipoOperacion.SelectedValue == null)
            {
                PysistemasMensajes.ShowInfo("Debe elegir un Tipo de Operacion.");
            }
            else
            {
                // solo se muestra si selecciona una entidad

                entidadInmobiliariaId = Int64.Parse(cbEntidades.SelectedValue.ToString());
                String TipoOperacion = cbTipoOperacion.SelectedValue.ToString();
                Int64 AnhoIn = DateTime.Now.Year;
                Int64 MesIn = DateTime.Now.Month;

                ingresoFijosEntidades.SetParameterValue("ENTIDAD_INMOBILIARIA_ID_IN", entidadInmobiliariaId);
                ingresoFijosEntidades.SetParameterValue("TIPO_OPERACION_IN", TipoOperacion);
                ingresoFijosEntidades.SetParameterValue("MES_IN", MesIn);
                ingresoFijosEntidades.SetParameterValue("ANHO_IN", AnhoIn);

                crViewer.ReportSource = ingresoFijosEntidades;

                ExportOptions exportOptions = ingresoFijosEntidades.ExportOptions;
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

        private void FrmReporteIngresosFijosPorEntidades_Load(object sender, EventArgs e)
        {            
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void cbTipoOperacion_SelectedValueChanged(object sender, EventArgs e)
        {

            //cbEntidades.DataSource = null;
            
            if (cbTipoOperacion.SelectedValue != null)
            {
                String TipoOperacion = cbTipoOperacion.SelectedValue.ToString();

                using (EntidadesInmobiliariasDao entidadesInmobiliariasDao = new EntidadesInmobiliariasDao())
                {
                    cbEntidades.DataSource = entidadesInmobiliariasDao.ObtenerDesdeFiltros(c => c.NATURALEZA == TipoOperacion);
                    cbEntidades.SelectedIndex = -1;
                }
                //ControlesUtilidades.InicializarComboBox(cbEntidades);
            }
            
        }

        private void btnTipoOperacionTodos_Click(object sender, EventArgs e)
        {
            cargarComboTiposOperaciones();
            cargarComboEntidadesTodos();

        }

        private void btnLimpiarTipoOperacion_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
