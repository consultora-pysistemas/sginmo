using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Services.Cobros;
using Inmobiliaria.Utilidades.Controles;
using System.Collections.Generic;
using Inmobiliaria.Modelo.Dao.Cobros;
using Inmobiliaria.Modelo.Dao.Gastos;

namespace Inmobiliaria.Presentacion.Cobros.Cobros
{
    public partial class FrmCobros : Genericos.FrmMaestro
    {
        public COBROS Cabecera { get; set; }
        public string Operacion { get; set; }

        public FrmCobros(Principal frmPrincipal, String operacion) : base(frmPrincipal)
        {
            InitializeComponent();
            Cabecera = new COBROS();
            Operacion = operacion;
            ConfiguracionesGrid(dgvSociosNegocios);
            ConfiguracionesGrid(dgvCuotasPendientes);
            ConfiguracionesGrid(dgvPagos);
            CargarDatos();
            txtNumeroFactura.LostFocus += TxtNumeroFactura_LostFocus;
        }

        private void TxtNumeroFactura_LostFocus(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNumeroFactura.Text))
            {
                ControlesUtilidades.GetNumeroFactura(txtNumeroFactura.Text);
            }
        }

        async Task CargarDatos()
        {
            using (FormasPagosDao formasPagosDao = new FormasPagosDao())
            {
                cbFormaPago.DataSource = formasPagosDao.ObtenerLista();
                ControlesUtilidades.InicializarComboBox(cbFormaPago);
                cbFormaPago.SelectedValue =
                    formasPagosDao.ObtenerDesdeFiltros(f => f.CODIGO.Equals("DB"))[0].FORMA_PAGO_ID;
            }
        }

        private void FrmCobros_Load(object sender, EventArgs e)
        {
            CargarDatosLoad(Operacion);
        }
        private void CargarDatosLoad(String Operacion)
        {
            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                lblTitulo.Text = "Cobros";
                btnAnular.Visible = false;
                splitContainer1.Panel1.Visible = true;
                btnModificar.Visible = false;
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = true;
                dtpFechaCobro.Value = DateTime.Now;
            }
            else
            {
                lblTitulo.Text = "Ver cobros";
                CargarDatosEntity();
                btnAgregar.Enabled = false;
                btnCobrar.Enabled = false;
                btnEliminar.Enabled = false;
                btnAnular.Visible = true;
                splitContainer1.Panel1.Visible = false;
                btnModificar.Visible = true;

                if (Cabecera.ESTADO.Equals("ANULADO"))
                {
                    btnAnular.Enabled = false;
                    btnModificar.Enabled = false;
                }

            }
        }
        private void CargarDatosEntity()
        {
            Int64 documentoId = 0;
            dtpFechaCobro.Value = Cabecera.FECHA;
            dtpFechaFactura.Value = DateTime.Parse(Cabecera.FECHA_FACTURA.ToString());
            txtNumeroFactura.Text = Cabecera.NUMERO_FACTURA;
            txtNumeroPago.Text = Cabecera.NUMERO_DOCUMENTO_COBRO;
            txtObservacion.Text = Cabecera.OBSERVACION;
            txtMontoCobrar.Text = Cabecera.TOTAL.ToString();

            using (CobrosDetallesDao cobrosDetallesDao = new CobrosDetallesDao())
            {
                IList<COBROS_DETALLES> cobrosDetalles =
                    cobrosDetallesDao.ObtenerDesdeFiltros(c => c.COBRO_ID == Cabecera.COBRO_ID);

                if (cobrosDetalles != null && cobrosDetalles.Count > 0)
                {
                    dgvPagos.DataSource = cobrosDetalles;
                    documentoId = Int64.Parse(cobrosDetalles[0].DOCUMENTO_ID.ToString());

                }
            }

            using (OperacionesPendientesView operacionesPendientesView = new OperacionesPendientesView())
            {
                Int64 socioNegocioId = Cabecera.SOCIO_NEGOCIO_ID;
                using (CronogramasCuotasDao cronogramasCuotasDao = new CronogramasCuotasDao())
                {
                    CRONOGRAMAS_CUOTAS cuota = cronogramasCuotasDao.ObtenerDesdePk(documentoId);
                    dgvSociosNegocios.DataSource = operacionesPendientesView.ObtenerDesdeFiltros
                        (c => c.SOCIO_NEGOCIO_ID == socioNegocioId && c.OPERACION_PROPIEDAD_ID == cuota.OPERACION_PROPIEDAD_ID);
                }
                

            }

            using (BusquedaCronogramasCuotasViewDao busquedaCronogramasCuotasViewDao =
                    new BusquedaCronogramasCuotasViewDao())
            {
                dgvCuotasPendientes.DataSource = busquedaCronogramasCuotasViewDao.ObtenerDesdeFiltros(c => c.OPERACION_PROPIEDAD_ID == documentoId && c.ESTADO.Equals("CANCELADO"));
                //dgvCuotasPendientes.Columns["Seleccionado"] ;

            }


        }

        private void txtRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char) 13))
            {
                Buscar();
            }
        }

        private void Buscar()
        {
            using (OperacionesPendientesView busquedaSociosNegociosViewDao = new OperacionesPendientesView())
            {
                if (String.IsNullOrWhiteSpace(txtRazonSocial.Text) &&
                    String.IsNullOrWhiteSpace(txtNumeroDocumento.Text))
                {
                    PysistemasMensajes.ShowInfo("Debe elegir los criterios de búsqueda");
                    return;

                }

                if (!String.IsNullOrWhiteSpace(txtRazonSocial.Text))
                {
                    dgvSociosNegocios.DataSource = busquedaSociosNegociosViewDao.ObtenerDesdeFiltros(s =>
                        s.RAZON_SOCIAL.ToUpper().Contains(txtRazonSocial.Text.ToUpper()));
                    return;
                }

                if (!String.IsNullOrWhiteSpace(txtNumeroDocumento.Text))
                {
                    dgvSociosNegocios.DataSource =
                        busquedaSociosNegociosViewDao.ObtenerDesdeFiltros(s =>
                            s.NUMERO_DOCUMENTO.Equals(txtNumeroDocumento.Text));
                }

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void FrmCobros_Shown(object sender, EventArgs e)
        {
            txtNumeroDocumento.Focus();
            dgvCuotasPendientes.Columns["mONTODataGridViewTextBoxColumn"].DefaultCellStyle.Format = "N0";
            dgvPagos.Columns["mONTODOCUMENTODataGridViewTextBoxColumn"].DefaultCellStyle.Format = "N0";
        }

        private void dgvSociosNegocios_CellContentDoubleClick(object sender,
            System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                SeleccionarSocioNegocio();
            }
        }

        private void SeleccionarSocioNegocio()
        {
            if (dgvSociosNegocios.CurrentRow != null)
            {
                using (BusquedaCronogramasCuotasViewDao busquedaCronogramasCuotasViewDao =
                    new BusquedaCronogramasCuotasViewDao())
                {
                    Int64 operacionId = Int64.Parse(dgvSociosNegocios.CurrentRow.Cells[0].Value.ToString());
                    Int64 socioNegocioId = Int64.Parse(dgvSociosNegocios.CurrentRow.Cells[1].Value.ToString());
                    Cabecera.SOCIO_NEGOCIO_ID = socioNegocioId;
                    dgvCuotasPendientes.DataSource = busquedaCronogramasCuotasViewDao.ObtenerDesdeFiltros(c =>
                        c.OPERACION_PROPIEDAD_ID == operacionId && c.ESTADO.Equals("PENDIENTE"));

                }
            }
        }

        private void dgvSociosNegocios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                SeleccionarSocioNegocio();
            }
        }

        private void dgvCuotasPendientes_CellContentClick(object sender,
            System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                if (e.ColumnIndex == dgvCuotasPendientes.Columns["Seleccionado"].Index)

                {
                    dgvCuotasPendientes.EndEdit();


                    if ((bool) dgvCuotasPendientes.CurrentRow.Cells[0].Value)
                    {
                        CalcularMontoPagar(Constantes.OperacionTotal.MAS);
                    }
                    else
                    {
                        CalcularMontoPagar(Constantes.OperacionTotal.MENOS);
                    }



                }
            }
        }


        public void CalcularMontoPagar(String operacionTotal)
        {
            Decimal montoMora = 0;
            DateTime fechaVencimiento = DateTime.Parse(dgvCuotasPendientes.CurrentRow
                .Cells["fECHAVENCIMIENTODataGridViewTextBoxColumn"].Value.ToString());
            Int64 operacionId = Int64.Parse(dgvCuotasPendientes.CurrentRow
                .Cells["oPERACIONPROPIEDADIDDataGridViewTextBoxColumn"].Value.ToString());
            CobrosService service = new CobrosService();
            CalculoDiasMontoMora calculoMontoMora = new CalculoDiasMontoMora();
            OPERACIONES_PROPIEDADES operacionPropiedad = new OPERACIONES_PROPIEDADES();
            using (OperacionesPropiedadesDao operacionesPropiedadesDao = new OperacionesPropiedadesDao())
            {
                operacionPropiedad = operacionesPropiedadesDao.ObtenerDesdePk(operacionId);
            }

            calculoMontoMora.diaGracias = operacionPropiedad.DIAS_GRACIA;
            calculoMontoMora.montoMoraDia = operacionPropiedad.MONTO_MORA;
            calculoMontoMora.fechaVencimiento = fechaVencimiento;
            calculoMontoMora.fechaCobro = dtpFechaCobro.Value;

            calculoMontoMora = service.CalcularMora(calculoMontoMora);
            if (calculoMontoMora.montoMora > 0)
            {
                if (Constantes.OperacionTotal.MAS.Equals(operacionTotal))
                    PysistemasMensajes.ShowInfo("Esta cuota esta en mora hace " + calculoMontoMora.diasMoras +
                                                " días se aplicará el cobro de Gs. " +
                                                calculoMontoMora.montoMora.ToString("N0") + " en concepto de mora");
                montoMora = calculoMontoMora.montoMora;
            }


            if (Constantes.OperacionTotal.MAS.Equals(operacionTotal))
            {
                Decimal montoPagar = Decimal.Parse(txtMontoCobrar.Text);
                Decimal monto = Decimal.Parse(dgvCuotasPendientes.CurrentRow
                    .Cells["mONTODataGridViewTextBoxColumn"].Value.ToString());
                montoPagar = montoPagar + monto + montoMora;
                txtMontoCobrar.Text = montoPagar.ToString("N0");
            }
            else
            {
                Decimal montoPagar = Decimal.Parse(txtMontoCobrar.Text);
                Decimal monto = Decimal.Parse(dgvCuotasPendientes.CurrentRow
                    .Cells["mONTODataGridViewTextBoxColumn"].Value.ToString());
                montoPagar = montoPagar - monto - montoMora;
                txtMontoCobrar.Text = montoPagar.ToString("N0");
            }

        }

        private void dgvCuotasPendientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvCuotasPendientes.Rows.Count > 0 && dgvCuotasPendientes.Columns.Count > 0)
            {
                foreach (DataGridViewRow r in dgvCuotasPendientes.Rows)
                {
                    DateTime fechaVencimiento =
                        DateTime.Parse(r.Cells["fECHAVENCIMIENTODataGridViewTextBoxColumn"].Value.ToString());
                    if (dtpFechaCobro.Value.Date > fechaVencimiento.Date)
                    {
                        r.DefaultCellStyle.BackColor = Color.Red;
                        r.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbFormaPago.SelectedValue == null)
            {
                PysistemasMensajes.ShowInfo("Debe elegir la forma de pago");
                return;
            }

            IList<CRONOGRAMAS_CUOTAS_VIEW> listaCuotas =
                dgvCuotasPendientes.DataSource as IList<CRONOGRAMAS_CUOTAS_VIEW>;
            IList<CRONOGRAMAS_CUOTAS_VIEW> lista = new List<CRONOGRAMAS_CUOTAS_VIEW>();
            Int64 formaPagoId = Int64.Parse(cbFormaPago.SelectedValue.ToString());

            foreach (DataGridViewRow r in dgvCuotasPendientes.Rows)
            {
                dgvCuotasPendientes.EndEdit();
                if (r.Cells[0].Value != null && (bool) r.Cells[0].Value)
                {
                    CRONOGRAMAS_CUOTAS_VIEW cuota = new CRONOGRAMAS_CUOTAS_VIEW();
                    lista.Add(listaCuotas[r.Index]);

                }
            }

            if (lista == null || lista.Count == 0)
            {
                PysistemasMensajes.ShowInfo("Debe elegir la cuota/cuotas a pagar");
                return;
            }
            IList<COBROS_DETALLES> listaDetalles = ObtenerDatosDetalles(lista, formaPagoId, txtObservacion.Text);
            if (dgvPagos.Rows.Count > 0)
            {
                dgvPagos.DataSource = null;
                dgvPagos.Rows.Clear();

            }

            dgvPagos.DataSource = listaDetalles;
            //SeleccionarSocioNegocio();
            btnCobrar.Enabled = true;

        }

        private IList<COBROS_DETALLES> ObtenerDatosDetalles(IList<CRONOGRAMAS_CUOTAS_VIEW> lista, Int64 formaPagoId,
            String observacion)
        {
            IList<COBROS_DETALLES> listaDetalles = new List<COBROS_DETALLES>();
            int numeroItem = 1;
            foreach (CRONOGRAMAS_CUOTAS_VIEW cuota in lista)
            {
                COBROS_DETALLES cobro = new COBROS_DETALLES();
                cobro.DOCUMENTO_ID = cuota.CRONOGRAMA_CUOTA_ID;
                cobro.TIPO_DOCUMENTO = "CUOTA";
                cobro.FORMA_PAGO_ID = formaPagoId;
                cobro.MONTO_DOCUMENTO = cuota.MONTO;
                cobro.MONTO_PAGADO = cuota.MONTO;
                cobro.MONEDA_DOCUMENTO = 1;
                cobro.MONEDA_PAGO = 1;
                cobro.TASA_CAMBIO = 1;
                cobro.OBSERVACION = observacion;
                cobro.NUMERO_ITEM = numeroItem;

                listaDetalles.Add(cobro);
                numeroItem++;
                CalculoDiasMontoMora calculoMontoMora = new CalculoDiasMontoMora();
                OPERACIONES_PROPIEDADES operacionPropiedad = new OPERACIONES_PROPIEDADES();
                using (OperacionesPropiedadesDao operacionesPropiedadesDao = new OperacionesPropiedadesDao())
                {
                    operacionPropiedad = operacionesPropiedadesDao.ObtenerDesdePk(cuota.OPERACION_PROPIEDAD_ID);
                }

                calculoMontoMora.diaGracias = operacionPropiedad.DIAS_GRACIA;
                calculoMontoMora.montoMoraDia = operacionPropiedad.MONTO_MORA;
                calculoMontoMora.fechaVencimiento = (DateTime) cuota.FECHA_VENCIMIENTO;
                calculoMontoMora.fechaCobro = dtpFechaCobro.Value;
                CobrosService service = new CobrosService();
                calculoMontoMora = service.CalcularMora(calculoMontoMora);
                Decimal montoMora = 0;
                if (calculoMontoMora.montoMora > 0)
                {
                    //PysistemasMensajes.ShowInfo("Esta cuota esta en mora hace " + calculoMontoMora.diasMoras + " días se aplicará el cobro de Gs. " + calculoMontoMora.montoMora.ToString("N0") + " en concepto de mora");
                    montoMora = calculoMontoMora.montoMora;
                    COBROS_DETALLES cobroMora = new COBROS_DETALLES();
                    cobroMora.DOCUMENTO_ID = cuota.CRONOGRAMA_CUOTA_ID;
                    cobroMora.FORMA_PAGO_ID = formaPagoId;
                    cobroMora.MONTO_DOCUMENTO = montoMora;
                    cobroMora.MONTO_PAGADO = montoMora;
                    cobroMora.TIPO_DOCUMENTO = "MORA";
                    cobroMora.MONEDA_DOCUMENTO = 1;
                    cobroMora.MONEDA_PAGO = 1;
                    cobroMora.TASA_CAMBIO = 1;
                    cobroMora.OBSERVACION = observacion;
                    cobroMora.NUMERO_ITEM = numeroItem;
                    numeroItem++;
                    listaDetalles.Add(cobroMora);
                }
            }

            return listaDetalles;
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            
            Cabecera.FECHA = dtpFechaCobro.Value;
            Cabecera.FECHA_FACTURA = dtpFechaFactura.Value;
            Cabecera.CONDICION = "CONTADO";
            Cabecera.NUMERO_FACTURA = txtNumeroFactura.Text;
            Cabecera.ESTADO = "CANCELADO";
            Cabecera.OBSERVACION = "Cobro de cuotas";
            Cabecera.TOTAL = Decimal.Parse(txtMontoCobrar.Text);
            Cabecera.NUMERO_DOCUMENTO_COBRO = txtNumeroPago.Text;

            CobrosService service = new CobrosService();
            List<COBROS_DETALLES> detalles = dgvPagos.DataSource as List<COBROS_DETALLES>;
            if (detalles == null || detalles.Count == 0)
            {
                PysistemasMensajes.ShowInfo("El cobro no puede ser de valor 0");
                return;
            }
            service.GuardarCobro(Operacion, Cabecera, detalles, FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO);
            PysistemasMensajes.ShowInfo("El cobro se realizó con éxito");

            if (PysistemasMensajes.AskConfirmation("Desea cargar otro registro?"))
            {
                Limpiar();
                Operacion = Constantes.Operaciones.NUEVO;
               
            }
            else
            {
                Close();
            }

        }

        private void Limpiar()
        {
            txtNumeroFactura.Text = txtObservacion.Text =
                txtRazonSocial.Text = txtNumeroDocumento.Text = txtNumeroPago.Text = String.Empty;
            ControlesUtilidades.InicializarComboBox(cbFormaPago);
            txtMontoCobrar.Text = "0";
            dgvSociosNegocios.DataSource = null;
            dgvCuotasPendientes.DataSource = null;
            dgvPagos.DataSource = null;
            dgvSociosNegocios.Rows.Clear();
            dgvCuotasPendientes.Rows.Clear();
            dgvPagos.Rows.Clear();
            CargarDatos();
            txtNumeroDocumento.Focus();


           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!"ADMINISTRADOR".Equals(FrmPrincipal.UsuarioLogueado.PERFIL))
            {
                PysistemasMensajes.ShowAlert("Para eliminar el detalle del cobros debe contar con privilegio de administrador, PERFIL ACTUAL " + FrmPrincipal.UsuarioLogueado.PERFIL);
                return;
            }
            if (dgvPagos.CurrentRow != null)
            {
                Decimal montoEliminar = Decimal.Parse(dgvPagos.CurrentRow
                    .Cells["mONTODOCUMENTODataGridViewTextBoxColumn"].Value.ToString());
                Decimal montoPagar = Decimal.Parse(txtMontoCobrar.Text) - montoEliminar;
                int id = dgvPagos.CurrentRow.Index;
                List<COBROS_DETALLES> detalles = dgvPagos.DataSource as List<COBROS_DETALLES>;

                detalles.RemoveAt(id);
                dgvPagos.DataSource = null;
                dgvPagos.DataSource = detalles;
                txtMontoCobrar.Text = montoPagar.ToString("N0");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dtpFechaCobro_ValueChanged(object sender, EventArgs e)
        {
            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                //CalcularMontoPagar(Constantes.OperacionTotal.MAS);
                dtpFechaFactura.Value = dtpFechaCobro.Value;

                txtMontoCobrar.Text = "0";
                SeleccionarSocioNegocio();
                //dgvCuotasPendientes_DataBindingComplete(null, null);
                //CalcularMontoPagar(Constantes.OperacionTotal.MAS);

                txtMontoCobrar.Text = "0";
                //CalcularMontoPagar(Constantes.OperacionTotal.MAS);
            }
        }




        private void dgvSociosNegocios_SelectionChanged(object sender, EventArgs e)
        {
            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                SeleccionarSocioNegocio();
            }
        }

        private void txtMontoCobrar_TextChanged(object sender, EventArgs e)
        {
            if (!txtMontoCobrar.Text.Equals(String.Empty))
            {
                double numero = Convert.ToDouble(txtMontoCobrar.Text);
                txtMontoCobrar.Text = numero.ToString("N0");
                txtMontoCobrar.SelectionStart = txtMontoCobrar.TextLength;
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (!"ADMINISTRADOR".Equals(FrmPrincipal.UsuarioLogueado.PERFIL))
            {
                PysistemasMensajes.ShowAlert("Para realizar la anulación de cobros debe contar con privilegio de administrador, PERFIL ACTUAL "+FrmPrincipal.UsuarioLogueado.PERFIL);
                return;
            }
            if (!Constantes.EstadosIngresosEgresos.CANCELADO.Equals(Cabecera.ESTADO))
            {
                PysistemasMensajes.ShowAlert("Solo se pueden anular los cobros con estado CANCELADO. Estado del cobro "+Cabecera.ESTADO);
                return;
            }else
            {
                if(PysistemasMensajes.AskConfirmation("Está seguro que desea cancelar el cobro. Esto anulará el cobro"))
                {
                    List<COBROS_DETALLES> detalles = dgvPagos.DataSource as List<COBROS_DETALLES>;
                    foreach (COBROS_DETALLES det in detalles)
                    {
                        using (CobrosDetallesDao cobrosDetallesDao = new CobrosDetallesDao())
                        {
                            using (CronogramasCuotasDao cronogramasCuotasDao = new CronogramasCuotasDao())
                            {
                                CRONOGRAMAS_CUOTAS cuota = cronogramasCuotasDao.ObtenerDesdePk(det.DOCUMENTO_ID);
                                cuota.ESTADO = "PENDIENTE";
                                cuota.USUARIO_MODIFICACION = FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO;
                                cuota.FECHA_CANCELACION = null;
                                cuota.FECHA_MODIFICACION = DateTime.Now;
                                cronogramasCuotasDao.Actualizar(cuota);
                                cronogramasCuotasDao.Guardar();
                            }
                        }
                    }

                    using (CobrosDao cobrosDao = new CobrosDao())
                    {
                        COBROS cobro = cobrosDao.ObtenerDesdePk(Cabecera.COBRO_ID);
                        cobro.ESTADO = "ANULADO";
                        cobro.USUARIO_MODIFICACION = FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO;
                        cobro.FECHA_MODIFICACION = DateTime.Now;
                        cobrosDao.Actualizar(cobro);
                        cobrosDao.Guardar();
                    }
                    PysistemasMensajes.ShowInfo("Se ha anulado el cobro");
                    Close();
                }
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cabecera.FECHA = dtpFechaCobro.Value;
            Cabecera.FECHA_FACTURA = dtpFechaFactura.Value;
            Cabecera.CONDICION = "CONTADO";
            Cabecera.NUMERO_FACTURA = txtNumeroFactura.Text;
            Cabecera.ESTADO = "CANCELADO";
            Cabecera.OBSERVACION = "Cobro de cuotas";
            Cabecera.TOTAL = Decimal.Parse(txtMontoCobrar.Text);
            Cabecera.NUMERO_DOCUMENTO_COBRO = txtNumeroPago.Text;
            Cabecera.USUARIO_MODIFICACION = FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO;
            Cabecera.FECHA_MODIFICACION = DateTime.Now;
            

            CobrosService service = new CobrosService();
            List<COBROS_DETALLES> detalles = dgvPagos.DataSource as List<COBROS_DETALLES>;
            service.GuardarCobro(Operacion, Cabecera, detalles, FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO);
            PysistemasMensajes.ShowInfo("Los datos se guardaron con éxito");

            if (PysistemasMensajes.AskConfirmation("Desea cargar otro registro?"))
            {
                Limpiar();

                Operacion = Constantes.Operaciones.NUEVO;
                
                CargarDatosLoad(Operacion);
            }
            else
            {
                Close();
            }
        }

        private void txtNumeroFactura_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.InitialDelay = 0;
            tt.ShowAlways = true;
            tt.SetToolTip(txtNumeroFactura, "Si ingresa por ejemplo: 1-1-123 se autocompletara 001-001-0000123 en base al formato de facturas.");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            if (!"ADMINISTRADOR".Equals(FrmPrincipal.UsuarioLogueado.PERFIL))
            {
                PysistemasMensajes.ShowAlert("Para realizar la aplicación de descuentos en cobros debe contar con privilegio de administrador, PERFIL ACTUAL " + FrmPrincipal.UsuarioLogueado.PERFIL);
                return;
            }
            FrmAgregarDescuento frmAgregarDescuento = new FrmAgregarDescuento();
            frmAgregarDescuento.txtMontoCobrar.Text = txtMontoCobrar.Text;
            if (DialogResult.OK.Equals(frmAgregarDescuento.ShowDialog()))
            {
                Decimal montoDescuento = -1 * Decimal.Parse(frmAgregarDescuento.txtDescuento.Text);
                using(ItemsIngresosEgresosDao itemsIngresosEgresosDao = new ItemsIngresosEgresosDao())
                {
                    ITEMS_INGRESOS_EGRESOS itemDescuento = (itemsIngresosEgresosDao.ObtenerDesdeFiltros(i => i.APLICACION.Equals("DESCUENTO")))[0];
                    List<COBROS_DETALLES> detalles = dgvPagos.DataSource as List<COBROS_DETALLES>;
                    if(detalles.Count != 0)
                    {
                        dgvPagos.DataSource = null;
                        dgvPagos.Rows.Clear();
                    }
                    COBROS_DETALLES detalleDescuento = new COBROS_DETALLES();
                    String socioNegocio = dgvSociosNegocios.CurrentRow.Cells["rAZONSOCIALDataGridViewTextBoxColumn"].Value.ToString();
                    String departamento = dgvSociosNegocios.CurrentRow.Cells["iNMUEBLEDataGridViewTextBoxColumn"].Value.ToString();
                    detalleDescuento.FECHA_CREACION = DateTime.Now;
                    detalleDescuento.USUARIO_CREACION = FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO;
                    detalleDescuento.NUMERO_ITEM = detalles.Count + 1;
                    detalleDescuento.TIPO_DOCUMENTO = "DESCUENTO";
                    detalleDescuento.OBSERVACION = "Descuento para el cobro de " + socioNegocio + " inmueble " + departamento;
                    detalleDescuento.MONTO_DOCUMENTO = detalleDescuento.MONTO_PAGADO = montoDescuento;
                    detalleDescuento.MONEDA_PAGO = detalleDescuento.MONEDA_DOCUMENTO = 1;
                    detalleDescuento.FORMA_PAGO_ID = 8;
                    detalleDescuento.TASA_CAMBIO = 1;
                    Decimal montoCobrar = Decimal.Parse(txtMontoCobrar.Text) + montoDescuento;
                    txtMontoCobrar.Text = montoCobrar.ToString("N0");
                    if (Constantes.Operaciones.NUEVO.Equals(Operacion))
                    {
                        detalles.Add(detalleDescuento);
                        dgvPagos.DataSource = detalles;
                    }else
                    {
                        detalleDescuento.COBRO_ID = Cabecera.COBRO_ID;
                        detalleDescuento.DOCUMENTO_ID = detalles[0].DOCUMENTO_ID;
                        detalles.Add(detalleDescuento);
                        using (CobrosDetallesDao cobrosDetallesDao = new CobrosDetallesDao())
                        {
                            cobrosDetallesDao.Agregar(detalleDescuento);
                            cobrosDetallesDao.Guardar();
                            btnModificar_Click(null, null);
                            dgvPagos.DataSource = cobrosDetallesDao.ObtenerDesdeFiltros(c => c.COBRO_ID == Cabecera.COBRO_ID);
                        }
                    }
                   
                    
                   
                    
                    
                    
                     
                }
            }
        }
    }
}

