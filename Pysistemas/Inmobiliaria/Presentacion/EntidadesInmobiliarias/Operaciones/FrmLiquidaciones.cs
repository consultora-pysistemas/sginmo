using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Dao.IngresosEgresos;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.EntidadesInmobiliarias.Buscadores;
using Inmobiliaria.Presentacion.Gastos.Gastos;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Services.IngresosEgresos;
using Inmobiliaria.Utilidades.Controles;
using Inmobiliaria.Presentacion.ParametrosReportes;
using Inmobiliaria.Reportes;

namespace Inmobiliaria.Presentacion.EntidadesInmobiliarias.Operaciones
{
    public partial class FrmLiquidaciones : Genericos.FrmMaestro
    {
        public String Operacion { get; set; }
        public LIQUIDACIONES Cabecera { get; set; }
        public List<LIQUIDACIONES_DETALLES_ITEMS> Detalles {get; set; }
        public FrmLiquidaciones(Principal frmPrincipal,string operacion):base(frmPrincipal)
        {
            InitializeComponent();
            Operacion = operacion;
            CargarDatos();
            ConfiguracionesGrid(dgvItemsLiquidacion);
            txtMonto.LostFocus += TxtMonto_LostFocus;
            Cabecera = new LIQUIDACIONES();
            Detalles = new List<LIQUIDACIONES_DETALLES_ITEMS>();
            cbEntregoLlaves.SelectedItem = Constantes.Booleano.SI;
        }

        private void TxtMonto_LostFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = "0";
            }
            else
            {
                tb.Text = String.Format(tb.Text, "N0");
            }
        }

        public FrmLiquidaciones()
        {
            InitializeComponent();
        }
        async void CargarDatos()
        {
            await CargarItemEgresos();
            await CargarMotivoLiquidacion();

        }

        async Task CargarItemEgresos()
        {
            using (ItemsIngresosEgresosDao itemsIngresosEgresosDao = new ItemsIngresosEgresosDao())
            {
                cbItemEgreso.DataSource =
                    itemsIngresosEgresosDao.ObtenerDesdeFiltros(i =>
                        i.TIPO_ITEM.Equals(Constantes.TiposIngresosEgresos.EGRESO.ToUpper()));
                ControlesUtilidades.InicializarComboBox(cbItemEgreso);
            }
        }
        async Task CargarMotivoLiquidacion()
        {
            using (DominiosDao dominiosDao = new DominiosDao())
            {
                cbMotivoLiquidacion.DataSource = dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.MOTIVO_LIQUIDACION));
                ControlesUtilidades.InicializarComboBox(cbMotivoLiquidacion);
            }
        }
       

        private void btnBuscadorOperacion_Click(object sender, EventArgs e)
        {
            FrmBuscadorOperaciones frmBuscadorOperaciones = new FrmBuscadorOperaciones(FrmPrincipal,"L");
            if (DialogResult.OK.Equals(frmBuscadorOperaciones.ShowDialog()))
            {
                txtOperacion.Tag = frmBuscadorOperaciones.Entity.OPERACION_PROPIEDAD_ID;
                
                ObtenerDatosOperacion(frmBuscadorOperaciones.Entity);
                frmBuscadorOperaciones.Close();
                
            }
        }

        public void ObtenerDatosOperacion(OPERACIONES_PROPIEDADES entity)
        {
            String unidadPropiedad = String.Empty;
            //Obtener unidad de negocio
            using (EntidadesInmobiliariasDao entidadesInmobiliariasDao = new EntidadesInmobiliariasDao())
            {
                ENTIDADES_INMOBILIARIAS entidad =
                    entidadesInmobiliariasDao.ObtenerDesdePk(entity.ENTIDAD_INMOBILIARIA_ID);
                unidadPropiedad = entidad.NOMBRE + "-";
            }

            using (PropiedadesDao propiedadesDao = new PropiedadesDao())
            {
                PROPIEDADES propiedad = propiedadesDao.ObtenerDesdePk(entity.PROPIEDAD_ID);
                unidadPropiedad = unidadPropiedad + propiedad.NOMBRE;
            }

            lblPropiedadUnidad.Text = unidadPropiedad;
            using (SociosNegociosDao sociosNegociosDao = new SociosNegociosDao())
            {
                SOCIOS_NEGOCIOS cliente = sociosNegociosDao.ObtenerDesdePk(entity.SOCIO_NEGOCIO_ID);
                lblCliente.Text = cliente.RAZON_SOCIAL + " - " + cliente.NUMERO_DOCUMENTO;
            }

            txtOperacion.Text = unidadPropiedad + " - " + lblCliente.Text;
            lblInicioContrato.Text = entity.FECHA_INICIO_CONTRATO.ToShortDateString();
            lblFinContrato.Text = entity.FECHA_FIN_CONTRATO.Value.ToShortDateString();
            lblMontoGarantia.Text = entity.GARANTIA.ToString("N0");
            txtGarantia.Text= entity.GARANTIA.ToString("N0");
            CalcularSaldo();
        }

        private void CalcularSaldo()
        {
            Decimal montoGarantia = Decimal.Parse(txtGarantia.Text);
            Decimal montoGasto = Decimal.Parse(txtGastos.Text);
            Decimal saldo = montoGarantia - montoGasto;
            if (saldo < 0)
            {
                txtSaldo.BackColor = Color.Red;
                txtSaldo.ForeColor = Color.White;
            }
            else
            {
                txtSaldo.BackColor = Color.WhiteSmoke;
                txtSaldo.ForeColor = Color.Black;
            }
            txtSaldo.Text = saldo.ToString("N0");
        }

        private void FrmLiquidaciones_Load(object sender, EventArgs e)
        {
            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                lblTitulo.Text = "Crear liquidación";
            }
            else
            {
                lblTitulo.Text = "Modificar liquidación";
                CargarDatosLiquidacion();
                lnkImprimirLiquidacion.Visible = true;
                txtOperacion.ReadOnly = true;
                btnBuscadorOperacion.Enabled = false;
                toolStripLabel1.Visible = false;
            }
        }

        private void CargarDatosLiquidacion()
        {
            dtpFechaOperacion.Value = Cabecera.FECHA_FISCALIZACION;
            dtpFechaSalida.Value = Cabecera.FECHA;
            txtOperacion.Tag = Cabecera.OPERACION_PROPIEDAD_ID;
            cbEntregoLlaves.SelectedValue = Cabecera.ENTREGO_LLAVES;
            cbMotivoLiquidacion.SelectedValue = Cabecera.MOTIVO_LIQUIDACION;
            txtObservacion.Text = Cabecera.OBSERVACION;
            txtGastos.Text = Cabecera.TOTAL_GASTOS.ToString();
            txtGarantia.Text = Cabecera.TOTAL_GARANTIA.ToString();
            txtSaldo.Text = Cabecera.SALDO.ToString();
            

            if (txtOperacion.Tag != null)
            {
                using (OperacionesPropiedadesDao operacionesPropiedadesDao = new OperacionesPropiedadesDao())
                {
                    OPERACIONES_PROPIEDADES operacion = operacionesPropiedadesDao.ObtenerDesdePk(Cabecera.OPERACION_PROPIEDAD_ID);
                    ObtenerDatosOperacion(operacion);
                }
            }

            using (BusquedaLiquidacionesDetallesViewDao liquidacionesDetallesViewDao = new BusquedaLiquidacionesDetallesViewDao())
            {
                IList<LIQUIDACIONES_DETALLES_ITEMS> liquidacionesDetalles =
                    liquidacionesDetallesViewDao.ObtenerDesdeFiltros(c => c.LIQUIDACION_ID == Cabecera.LIQUIDACION_ID);

                if (liquidacionesDetalles != null && liquidacionesDetalles.Count > 0)
                {
                    dgvItemsLiquidacion.DataSource = liquidacionesDetalles;
                   

                }
            }
            


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender,e);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (txtOperacion.Tag == null)
            {
                PysistemasMensajes.ShowInfo("Debe elegir una operación para continuar con la liquidación");
                btnBuscadorOperacion.Focus();
                return;
            }

            Int64 operacionId = Int64.Parse(txtOperacion.Tag.ToString());
            FrmPlantillaLiquidacion frmPlantillaLiquidacion = new FrmPlantillaLiquidacion();
            using (OperacionesPropiedadesDao operacionesPropiedadesDao = new OperacionesPropiedadesDao())
            {
                OPERACIONES_PROPIEDADES operacion = operacionesPropiedadesDao.ObtenerDesdePk(operacionId);
                frmPlantillaLiquidacion.OperacionPropiedad = operacion;
                frmPlantillaLiquidacion.FechaLiquidacion = dtpFechaOperacion.Value;
                frmPlantillaLiquidacion.UsuarioLogueado = FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO;
            }
            if (DialogResult.OK.Equals(frmPlantillaLiquidacion.ShowDialog()))
            {
                dgvItemsLiquidacion.DataSource = frmPlantillaLiquidacion.listaItemsPlantilla;
            }
        }

        private void dgvItemsLiquidacion_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Decimal total = 0;
            foreach (DataGridViewRow dr in dgvItemsLiquidacion.Rows)
            {
                Decimal monto = Decimal.Parse(dr.Cells["mONTODataGridViewTextBoxColumn"].Value.ToString());
                total = total + monto;
            }

            txtGastos.Text = total.ToString("N0");
            CalcularSaldo();
            //lbl
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {            
            if (txtOperacion.Tag == null)
            {
                PysistemasMensajes.ShowInfo("Debe elegir una operación Alquiler/Venta");
                txtOperacion.Focus();
                return;
            }

            if (cbMotivoLiquidacion.SelectedItem == null)
            {
                PysistemasMensajes.ShowInfo("Debe elegir un motivo de la liquidación");
                cbMotivoLiquidacion.Focus();
                return;
            }

            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                Cabecera.USUARIO_CREACION = FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO;
                Cabecera.FECHA_CREACION = DateTime.Now;
            }
            else if (Constantes.Operaciones.EDITAR.Equals(Operacion))
            {              
                Cabecera.USUARIO_MODIFICACION = FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO;
                Cabecera.FECHA_MODIFICACION = DateTime.Now;
            }
            Cabecera.FECHA_FISCALIZACION = dtpFechaOperacion.Value;
            Cabecera.FECHA = dtpFechaSalida.Value;
            Cabecera.ENTREGO_LLAVES = cbEntregoLlaves.SelectedItem.ToString();
            Cabecera.MOTIVO_LIQUIDACION = cbMotivoLiquidacion.SelectedValue.ToString();
            Cabecera.OBSERVACION = txtObservacion.Text;
            Int64 operacionId = Int64.Parse(txtOperacion.Tag.ToString());
            Cabecera.OPERACION_PROPIEDAD_ID = operacionId;
            Cabecera.SALDO = Decimal.Parse(txtSaldo.Text);
            Cabecera.TOTAL_GARANTIA = Decimal.Parse(txtGarantia.Text);
            Cabecera.TOTAL_GASTOS = Decimal.Parse(txtGastos.Text);
            Detalles = dgvItemsLiquidacion.DataSource as List<LIQUIDACIONES_DETALLES_ITEMS>;
            if (Detalles == null)
            {
                Detalles = new List<LIQUIDACIONES_DETALLES_ITEMS>();
            }
            LiquidacionesService service = new LiquidacionesService();
            service.Guardar(Cabecera,Detalles,Operacion);
            PysistemasMensajes.ShowInfo("Los datos de la liquidación se guardaron con éxito");
            if (PysistemasMensajes.AskConfirmation("Desea seguir registrando liquidaciones?"))
            {
                LimpiarPantalla();
            }
            else
            {
                Operacion = Constantes.Operaciones.EDITAR;
                lnkImprimirLiquidacion.Visible = true;
                dgvItemsLiquidacion.DataSource = null;
                dgvItemsLiquidacion.Rows.Clear();
                dgvItemsLiquidacion.DataSource = Detalles;
            }

        }

        protected override void LimpiarPantalla()
        {
            Operacion = Constantes.Operaciones.NUEVO;
            dtpFechaOperacion.Value = dtpFechaSalida.Value = DateTime.Now;
            lblInicioContrato.Text = lblFinContrato.Text = lblCliente.Text = lblMontoGarantia.Text = String.Empty;
            txtOperacion.Tag = null;
            txtOperacion.Text = string.Empty;
            cbEntregoLlaves.SelectedItem = Constantes.Booleano.SI;
            ControlesUtilidades.InicializarComboBox(cbMotivoLiquidacion);
            dgvItemsLiquidacion.DataSource = null;
            dgvItemsLiquidacion.Rows.Clear();
            txtOperacion.Focus();
        }

        private void FrmLiquidaciones_Shown(object sender, EventArgs e)
        {
            dgvItemsLiquidacion.Columns["mONTODataGridViewTextBoxColumn"].DefaultCellStyle.Format = "N0";
            dgvItemsLiquidacion.Columns["mONTODataGridViewTextBoxColumn"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.BottomRight;
        }

        private void tsbtnAgregar_Click(object sender, EventArgs e)
        {
            if (cbItemEgreso.SelectedValue == null)
            {
                PysistemasMensajes.ShowInfo("Debe seleccionar un item para agregar");
                cbItemEgreso.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtMonto.Text))
            {
                PysistemasMensajes.ShowInfo("Debe ingresar un monto para el item");
                txtMonto.Focus();
                return;
            }

            Decimal monto = Decimal.Parse(txtMonto.Text);
            if (monto == 0)
            {
                PysistemasMensajes.ShowInfo("Debe ingresar un monto mayor a 0 para el item");
                txtMonto.Focus();
                return;
            }
            List<LIQUIDACIONES_DETALLES_ITEMS> detalles =
                dgvItemsLiquidacion.DataSource as List<LIQUIDACIONES_DETALLES_ITEMS>;
            if (detalles!= null && detalles.Count > 0)
            {
               
                
                LIQUIDACIONES_DETALLES_ITEMS item = new LIQUIDACIONES_DETALLES_ITEMS();
                item.FECHA_CREACION = DateTime.Now;
                item.USUARIO_CREACION = FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO;
                item.NUMERO_ITEM = detalles.Count + 1;
                item.ITEM_INGRESO_EGRESO_ID = Int64.Parse(cbItemEgreso.SelectedValue.ToString());
                item.MONTO = monto;
                item.ITEM = cbItemEgreso.Text;
                detalles.Add(item);

            }
            else
            {
                detalles = new List<LIQUIDACIONES_DETALLES_ITEMS>();
                LIQUIDACIONES_DETALLES_ITEMS item = new LIQUIDACIONES_DETALLES_ITEMS();
                item.FECHA_CREACION = DateTime.Now;
                item.USUARIO_CREACION = FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO;
                item.NUMERO_ITEM = detalles.Count + 1;
                item.ITEM_INGRESO_EGRESO_ID = Int64.Parse(cbItemEgreso.SelectedValue.ToString());
                item.ITEM = cbItemEgreso.Text;
                item.MONTO = monto;
                detalles.Add(item);
            }

            dgvItemsLiquidacion.DataSource = null;
            dgvItemsLiquidacion.DataSource = detalles;
            ControlesUtilidades.InicializarComboBox(cbItemEgreso);
            txtMonto.Text = "0";
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.Controles.ControlesUtilidades.camposNumericos(e);
        }

        private void tsbtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvItemsLiquidacion.CurrentRow != null)
            {
                List<LIQUIDACIONES_DETALLES_ITEMS> detalles =
                    dgvItemsLiquidacion.DataSource as List<LIQUIDACIONES_DETALLES_ITEMS>;
                if (dgvItemsLiquidacion.CurrentRow.Cells["lIQUIDACIONDETALLEIDDataGridViewTextBoxColumn"].Value != null && Int64.Parse(dgvItemsLiquidacion.CurrentRow.Cells["lIQUIDACIONDETALLEIDDataGridViewTextBoxColumn"].Value.ToString())>0)//vamos a eliminar un registro existente en db
                {
                    Int64 liquidacionDetalleId = Int64.Parse(dgvItemsLiquidacion.CurrentRow
                        .Cells["lIQUIDACIONDETALLEIDDataGridViewTextBoxColumn"].Value.ToString());
                    using (LiquidacionesDetallesDao liquidacionesDetallesDao = new LiquidacionesDetallesDao())
                    {
                        LIQUIDACIONES_DETALLES liquidacionesDetalles =
                            liquidacionesDetallesDao.ObtenerDesdePk(liquidacionDetalleId);
                        liquidacionesDetallesDao.Remover(liquidacionesDetalles);
                        liquidacionesDetallesDao.Guardar();
                        detalles.RemoveAt(dgvItemsLiquidacion.CurrentRow.Index);
                    }
                }
                else
                {
                    detalles.RemoveAt(dgvItemsLiquidacion.CurrentRow.Index);
                    
                }
                dgvItemsLiquidacion.DataSource = null;
                dgvItemsLiquidacion.DataSource = detalles;


            }
        }

        private void dgvItemsLiquidacion_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Decimal total = 0;
            foreach (DataGridViewRow dr in dgvItemsLiquidacion.Rows)
            {
                Decimal monto = Decimal.Parse(dr.Cells["mONTODataGridViewTextBoxColumn"].Value.ToString());
                total = total - monto;
            }

            txtGastos.Text = total.ToString("N0");
            CalcularSaldo();
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            if (!txtMonto.Text.Equals(String.Empty))
            {
                double numero = Convert.ToDouble(txtMonto.Text);
                txtMonto.Text = numero.ToString("N0");
                txtMonto.SelectionStart = txtMonto.TextLength;
            }
        }

        private void txtMonto_MouseClick(object sender, MouseEventArgs e)
        {
            txtMonto.SelectAll();
        }

        private void btnNuevoItem_Click(object sender, EventArgs e)
        {
            FrmItemIngresoEgreso frmItemIngresoEgreso = new FrmItemIngresoEgreso(FrmPrincipal, Constantes.Operaciones.NUEVO);
           
            frmItemIngresoEgreso.cbTipoItem.SelectedValue = Constantes.TiposIngresosEgresos.EGRESO;
            frmItemIngresoEgreso.ShowDialog();            
            CargarItemEgresos();
            if (frmItemIngresoEgreso.Entity.ITEM_INGRESO_EGRESO_ID != 0)
                cbItemEgreso.SelectedValue = frmItemIngresoEgreso.Entity.ITEM_INGRESO_EGRESO_ID;
                
            
        }

        private void lnkImprimirLiquidacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            liquidacion_operacion liquidacionOperacion = new liquidacion_operacion();
            FrmReporte frmReporte = new FrmReporte();
            frmReporte.lblTitulo.Visible = false;

            Int64 liquidacinId = Cabecera.LIQUIDACION_ID;
            liquidacionOperacion.SetParameterValue("LIQUIDACION_ID_IN", liquidacinId);
            frmReporte.crystalReportViewer1.ReportSource = liquidacionOperacion;
            frmReporte.crystalReportViewer1.Show();
            frmReporte.ShowDialog();
            Activate();
        }
    }
}
