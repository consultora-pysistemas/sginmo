using CrystalDecisions.Shared;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Dao.Gastos;
using Inmobiliaria.Reportes;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.ParametrosReportes
{
    public partial class FrmReportePagosPorItems : Inmobiliaria.Presentacion.ParametrosReportes.FrmReporteMaestro
    {
        public FrmReportePagosPorItems()
        {
            InitializeComponent();
            CargarDatos();
        }
        async void CargarDatos()
        {
            txtAnho.Text = DateTime.Now.Year.ToString();

            await CargarEntidadesInmobiliarias();
            await CargarItemsIngresosEgresos();
        }

        async Task CargarItemsIngresosEgresos()
        {
            using (ItemsIngresosEgresosDao itemIngresoEgreso = new ItemsIngresosEgresosDao())
            {
                cbItemEgreso.DataSource = itemIngresoEgreso.ObtenerDesdeFiltros(c => c.TIPO_ITEM == "EGRESO");
            }
            ControlesUtilidades.InicializarComboBox(cbItemEgreso);

            return;
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
            var planillaControlPagoAnde = new planilla_control_pago_ande();
            //var planillaPagoAgua = new planilla_pagos_agua();
            //var planillaPagoDorby = new planilla_pagos_dobby();
            var planillaPagosPorItems = new planilla_pagos_por_items();


            Int64 entidadInmobiliariaId = -1;
            Int64 itemIngresoEgresoId = -1;
            String TipoIngresoEgreso = null;
            Int64 anho;

            if (cbEntidades.SelectedValue == null)
            {
                PysistemasMensajes.ShowInfo("Debe elegir un Edificio/Loteamiento");
            }
            else if (cbItemEgreso.SelectedValue == null)
            {
                PysistemasMensajes.ShowInfo("Debe elegir un Item de Egreso");
            }
            else
            {
                // solo se muestra si selecciona una entidad


                entidadInmobiliariaId = Int64.Parse(cbEntidades.SelectedValue.ToString());
                itemIngresoEgresoId = Int64.Parse(cbItemEgreso.SelectedValue.ToString());
                anho = Int64.Parse(txtAnho.Text);

                using (ItemsIngresosEgresosDao itemIngresoEgreso = new ItemsIngresosEgresosDao())
                {
                    // falta actualizar el modelo
                    TipoIngresoEgreso = itemIngresoEgreso.ObtenerDesdePk(itemIngresoEgresoId).APLICACION;
                }

                if (("ANDE").Equals(TipoIngresoEgreso))
                {
                    planillaControlPagoAnde.SetParameterValue("ENTIDAD_INMOBILIARIA_ID_IN", entidadInmobiliariaId);
                    planillaControlPagoAnde.SetParameterValue("ITEM_INGRESO_EGRESO_ID_IN", itemIngresoEgresoId);
                    planillaControlPagoAnde.SetParameterValue("ANHO_IN", anho);

                    crViewer.ReportSource = planillaControlPagoAnde;

                    ExportOptions exportOptions = planillaControlPagoAnde.ExportOptions;
                    exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                }
                else //if (("ESSAP").Equals(TipoIngresoEgreso))
                {
                    planillaPagosPorItems.SetParameterValue("ENTIDAD_INMOBILIARIA_ID_IN", entidadInmobiliariaId);
                    planillaPagosPorItems.SetParameterValue("ITEM_INGRESO_EGRESO_ID_IN", itemIngresoEgresoId);
                    planillaPagosPorItems.SetParameterValue("ANHO_IN", anho);

                    crViewer.ReportSource = planillaPagosPorItems;

                    ExportOptions exportOptions = planillaPagosPorItems.ExportOptions;
                    exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                }
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

        private void btnLimpiarItems_Click(object sender, EventArgs e)
        {
            ControlesUtilidades.InicializarComboBox(cbItemEgreso);
            CargarDatos();
        }

        private void FrmReportePagosPorItems_Shown(object sender, EventArgs e)
        {
            cbEntidades.Focus();
        }

        private void txtAnho_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void FrmReportePagosPorItems_Load(object sender, EventArgs e)
        {            
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}
