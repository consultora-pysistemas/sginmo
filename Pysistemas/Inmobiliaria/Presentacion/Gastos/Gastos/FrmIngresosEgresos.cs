using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Dao.IngresosEgresos;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Utilidades.Controles;
using Inmobiliaria.Presentacion.Mantenimiento.Buscadores;
using Inmobiliaria.Presentacion.Mantenimiento.SociosNegocios;
using Inmobiliaria.Services.IngresosEgresos;
using ItemsIngresosEgresosDao = Inmobiliaria.Modelo.Dao.Gastos.ItemsIngresosEgresosDao;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.Gastos.Gastos
{
    public partial class FrmIngresosEgresos : Genericos.FrmMaestro
    {
        public String Operacion { get; set; }
        public string Tipo { get; set; }
        public INGRESOS_EGRESOS Entity { get; set; }
        public FrmIngresosEgresos(Principal frmPrincipal,String operacion,String tipo):base(frmPrincipal)
        {
            InitializeComponent();
            Operacion = operacion;
            Tipo = tipo;
            Entity = new INGRESOS_EGRESOS();
            CargarDatos();
        }
        async void CargarDatos()
        {
            await CargarTiposImputacion();
            await CargarEstadosIngresosEgresos();
            await CargarTiposItemsIngresosEgresos();
            await CargarFormasPagos();
        }

        async Task CargarFormasPagos()
        {
            using (FormasPagosDao formasPagosDao = new FormasPagosDao())
            {
                cbFormaPago.DataSource = formasPagosDao.ObtenerLista();
                ControlesUtilidades.InicializarComboBox(cbFormaPago);
                cbFormaPago.SelectedValue = formasPagosDao.ObtenerDesdeFiltros(f => f.CODIGO.Equals("EFE"))[0].FORMA_PAGO_ID;
            }
        }

        async Task CargarTiposImputacion()
        {
            using (DominiosDao dominiosDao = new DominiosDao())
            {
                cbTipoImputacion.DataSource = dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.TIPO_IMPUTACION));
                ControlesUtilidades.InicializarComboBox(cbTipoImputacion);
            }
        }
        async Task CargarEstadosIngresosEgresos()
        {
            using (DominiosDao dominiosDao = new DominiosDao())
            {
                cbEstados.DataSource = dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.ESTADO_INGRESO_EGRESO));
                ControlesUtilidades.InicializarComboBox(cbEstados);
            }
        }
        async Task CargarTiposItemsIngresosEgresos()
        {
            using (ItemsIngresosEgresosDao itemIngresoEgresoDao = new ItemsIngresosEgresosDao())
            {
                cbTipoItemIngresoEgreso.DataSource = itemIngresoEgresoDao.ObtenerDesdeFiltros(d => d.TIPO_ITEM.Equals(Tipo));
                ControlesUtilidades.InicializarComboBox(cbTipoItemIngresoEgreso);
            }
        }

        async Task CargarEntitdadesInmobiliarias()
        {
            using (EntidadesInmobiliariasDao entidadesInmobiliariasDao = new EntidadesInmobiliariasDao())
            {
                cbEntidades.DataSource = entidadesInmobiliariasDao.ObtenerLista();
                ControlesUtilidades.InicializarComboBox(cbEntidades);
            }
        }
        private void FrmIngresosEgresos_Load(object sender, EventArgs e)
        {
            if (Constantes.TiposIngresosEgresos.EGRESO.Equals(Tipo))
            {
                tcIngresosEgresos.TabPages[0].Text = "Egresos";
                gbDatosIngresosEgresos.Text = "Datos Egresos";
                if (Constantes.Operaciones.NUEVO.Equals(Operacion))
                {
                    lblTitulo.Text = "Crear egresos";
                    /*
                    using (FormasPagosDao formasPagosDao = new FormasPagosDao())
                    {                        
                        cbFormaPago.SelectedValue = formasPagosDao.ObtenerDesdeFiltros(f => f.CODIGO.Equals("EFE"))[0].FORMA_PAGO_ID;
                    }
                    */
                }
                else
                {
                    lblTitulo.Text = "Modificar egresos";
                }

                lblImputarA.Text = "Egreso de:";
            }
            else
            {
                tcIngresosEgresos.TabPages[0].Text = "Ingresos";
                gbDatosIngresosEgresos.Text = "Datos Ingresos";
                if (Constantes.Operaciones.NUEVO.Equals(Operacion))
                {
                    lblTitulo.Text = "Crear ingresos";
                }
                else
                {
                    lblTitulo.Text = "Modificar ingresos";
                }
                lblImputarA.Text = "Ingreso de:";
            }

            if (Constantes.Operaciones.EDITAR.Equals(Operacion))
            {
                using (IngresosEgresosDao ingresosEgresosDao = new IngresosEgresosDao())
                {
                    Entity = ingresosEgresosDao.ObtenerDesdePk(Entity.INGRESO_EGRESO_ID);
                    dtpFechaOperacion.Value = Entity.FECHA;
                    
                    cbTipoImputacion.SelectedValue = Entity.TIPO_IMPUTACION;
                    if (Entity.ENTIDAD_INMOBILIARIA_ID != null)
                        cbEntidades.SelectedValue = Entity.ENTIDAD_INMOBILIARIA_ID;
                    if(Entity.PROPIEDAD_ID != null)
                        cbPropiedades.SelectedValue = Entity.PROPIEDAD_ID;
                    
                    if (Entity.SOCIO_NEGOCIO_ID != null && Entity.SOCIO_NEGOCIO_ID != 0)
                    {
                        txtSocioNegocio.Tag = Entity.SOCIO_NEGOCIO_ID;
                        using (SociosNegociosDao sociosNegociosDao = new SociosNegociosDao())
                        {
                            SOCIOS_NEGOCIOS socioNegocio = sociosNegociosDao.ObtenerDesdePk(Entity.SOCIO_NEGOCIO_ID);
                            txtSocioNegocio.Text = socioNegocio.RAZON_SOCIAL;
                        }
                    }

                    txtMonto.Text = Entity.MONTO.ToString("N0");
                    dtpFechaFactura.Value = (DateTime)Entity.FECHA_FACTURA;
                    txtNumeroFactura.Text = Entity.NUMERO_FACTURA;
                    cbEstados.SelectedValue = Entity.ESTADO;
                    txtObservacion.Text = Entity.OBSERVACION;
                    cbTipoItemIngresoEgreso.SelectedValue = Entity.ITEM_INGRESO_EGRESO_ID;
                    if (Entity.FORMA_PAGO_ID != null)
                        cbFormaPago.SelectedValue = Entity.FORMA_PAGO_ID;
                    txtNumeroPago.Text = Entity.NUMERO_DOCUMENTO_PAGO;
                    cbEstados.SelectedValue = Entity.ESTADO;


                }
            }
            
        }

        

        

        private void btnLimpiarEntidad_Click(object sender, EventArgs e)
        {
            ControlesUtilidades.InicializarComboBox(cbEntidades);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSocioNegocio.Text = String.Empty;
            txtSocioNegocio.Tag = null;
        }

        private void cbTipoImputacion_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTipoImputacion.SelectedValue != null)
            {
                Limpiar();
                String tipoImputacion = cbTipoImputacion.SelectedValue.ToString();
                if (Constantes.TiposImputaciones.ENTIDAD_INMOBILIARIA.Equals(tipoImputacion))
                {
                    cbPropiedades.Enabled = false;
                    btnBuscaPropiedad.Enabled = false;
                    txtSocioNegocio.Enabled = false;
                    btnBuscadorSocioNegocio.Enabled = false;
                    btnNuevoLocatario.Enabled = false;
                    btnLimpiarSocioNegocio.Enabled = false;
                    cbEntidades.Enabled = true;
                    CargarEntidades();
                }
                else if(Constantes.TiposImputaciones.PROPIEDADES.Equals(tipoImputacion))
                {
                    cbPropiedades.Enabled = true;
                    btnBuscaPropiedad.Enabled = true;
                    txtSocioNegocio.Enabled = false;
                    btnBuscadorSocioNegocio.Enabled = false;
                    btnNuevoLocatario.Enabled = false;
                    btnLimpiarSocioNegocio.Enabled = false;
                    cbEntidades.Enabled = true;
                    CargarEntidades();
                }
                else if(Constantes.TiposImputaciones.INQUILINOS.Equals(tipoImputacion))
                {
                    cbPropiedades.Enabled = true;
                    btnBuscaPropiedad.Enabled = true;
                    txtSocioNegocio.Enabled = true;
                    btnBuscadorSocioNegocio.Enabled = true;
                    btnNuevoLocatario.Enabled = true;
                    btnLimpiarSocioNegocio.Enabled = true;
                    cbEntidades.Enabled = true;
                }
                else if (Constantes.TiposImputaciones.PROPIETARIOS.Equals(tipoImputacion))
                {
                    cbPropiedades.Enabled = false;
                    btnBuscaPropiedad.Enabled = false;
                    txtSocioNegocio.Enabled = true;
                    btnBuscadorSocioNegocio.Enabled = true;
                    btnNuevoLocatario.Enabled = true;
                    btnLimpiarSocioNegocio.Enabled = true;
                    cbEntidades.Enabled = false;
                }
                else if (Constantes.TiposImputaciones.ADMINISTRADOR.Equals(tipoImputacion))
                {
                    cbPropiedades.Enabled = false;
                    btnBuscaPropiedad.Enabled = false;
                    txtSocioNegocio.Enabled = true;
                    btnBuscadorSocioNegocio.Enabled = true;
                    btnNuevoLocatario.Enabled = true;
                    btnLimpiarSocioNegocio.Enabled = true;
                    cbEntidades.Enabled = true;
                }
                else if (Constantes.TiposImputaciones.VENDEDOR.Equals(tipoImputacion))
                {
                    cbPropiedades.Enabled = true;
                    btnBuscaPropiedad.Enabled = true;
                    txtSocioNegocio.Enabled = true;
                    btnBuscadorSocioNegocio.Enabled = true;
                    btnNuevoLocatario.Enabled = true;
                    btnLimpiarSocioNegocio.Enabled = true;
                    cbEntidades.Enabled = true;
                }
            }
        }

        private void Limpiar()
        {
            btnLimpiarEntidad_Click(null,null);
            btnLimpiar_Click(null,null);
            button1_Click(null,null);
            btn_Click(null,null);
            ControlesUtilidades.InicializarComboBox(cbEstados);
            //ControlesUtilidades.InicializarComboBox(cbFormaPago);
        }

        private void CargarEntidades()
        {
            using (EntidadesInmobiliariasDao entidadesInmobiliariasDao = new EntidadesInmobiliariasDao())
            {
                cbEntidades.DataSource = entidadesInmobiliariasDao.ObtenerLista();
                ControlesUtilidades.InicializarComboBox(cbEntidades);
            }
        }

        private void cbTipoItemIngresoEgreso_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTipoItemIngresoEgreso.SelectedValue != null)
            {
                Int64 itemIngresoEgresoId = Int64.Parse(cbTipoItemIngresoEgreso.SelectedValue.ToString());
                using (ItemsIngresosEgresosDao itemsIngresosEgresosDao = new ItemsIngresosEgresosDao())
                {
                    ITEMS_INGRESOS_EGRESOS item = itemsIngresosEgresosDao.ObtenerDesdePk(itemIngresoEgresoId);
                    if (Constantes.Booleano.NO.Equals(item.MODIFICA_ESTADO))
                    {
                        cbEstados.SelectedValue = Constantes.EstadosIngresosEgresos.CANCELADO;
                        cbEstados.Enabled = false;
                    }
                    else
                    {
                        cbEstados.SelectedValue = Constantes.EstadosIngresosEgresos.PENDIENTE;
                        cbEstados.Enabled = true;
                    }
                   
                }
            }
        }

        private void cbEntidades_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbEntidades.SelectedValue != null)
            {
                Int64 entidadInmobiliariaId = Int64.Parse(cbEntidades.SelectedValue.ToString());
                CargarPropiedadesEntidadInmobiliaria(entidadInmobiliariaId);
            }
        }
        async void CargarPropiedadesEntidadInmobiliaria(Int64 entidadInmobiliaria)
        {
            using (PropiedadesDao propiedadesDao = new PropiedadesDao())
            {
                cbPropiedades.DataSource =
                    propiedadesDao.ObtenerDesdeFiltros(p => p.ENTIDAD_INMOBILIARIA_ID == entidadInmobiliaria);

                ControlesUtilidades.InicializarComboBox(cbPropiedades);
            }

        }

        private void btnLimpiarTipoImputacion_Click(object sender, EventArgs e)
        {
            ControlesUtilidades.InicializarComboBox(cbTipoImputacion);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ControlesUtilidades.InicializarComboBox(cbTipoItemIngresoEgreso);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlesUtilidades.InicializarComboBox(cbPropiedades);
        }

        private void btnBuscadorSocioNegocio_Click(object sender, EventArgs e)
        {
            String tipoSocioNegocio = String.Empty;
            if (Constantes.TiposImputaciones.INQUILINOS.Equals(cbTipoImputacion.SelectedValue))
            {
                tipoSocioNegocio = Constantes.TiposSociosNegocios.INQUILINO;
            }else if (Constantes.TiposImputaciones.PROPIETARIOS.Equals(cbTipoImputacion.SelectedValue))
            {
                tipoSocioNegocio = Constantes.TiposSociosNegocios.PROPIETARIO;
            }
            else if (Constantes.TiposImputaciones.ADMINISTRADOR.Equals(cbTipoImputacion.SelectedValue))
            {
                tipoSocioNegocio = Constantes.TiposSociosNegocios.ADMINISTRADOR;
            }
            else if (Constantes.TiposImputaciones.VENDEDOR.Equals(cbTipoImputacion.SelectedValue))
            {
                tipoSocioNegocio = Constantes.TiposSociosNegocios.VENDEDOR;
            }
            FrmBuscadorSociosNegocios frmBuscadorSociosNegocios = new FrmBuscadorSociosNegocios(FrmPrincipal, tipoSocioNegocio);
            if (System.Windows.Forms.DialogResult.OK.Equals(frmBuscadorSociosNegocios.ShowDialog()))
            {
                txtSocioNegocio.Text = frmBuscadorSociosNegocios.Entity.SOCIO_NEGOCIO;
                txtSocioNegocio.Tag = frmBuscadorSociosNegocios.Entity.SOCIO_NEGOCIO_ID;
                frmBuscadorSociosNegocios.Close();
                Activate();
            }
        }

        private void btnNuevoLocatario_Click(object sender, EventArgs e)
        {
            String tipoSocioNegocio = String.Empty;
            if (Constantes.TiposImputaciones.INQUILINOS.Equals(cbTipoImputacion.SelectedValue))
            {
                tipoSocioNegocio = Constantes.TiposSociosNegocios.INQUILINO;
            }
            else if (Constantes.TiposImputaciones.PROPIETARIOS.Equals(cbTipoImputacion.SelectedValue))
            {
                tipoSocioNegocio = Constantes.TiposSociosNegocios.PROPIETARIO;
            }
            else if (Constantes.TiposImputaciones.ADMINISTRADOR.Equals(cbTipoImputacion.SelectedValue))
            {
                tipoSocioNegocio = Constantes.TiposSociosNegocios.ADMINISTRADOR;
            }
            else if (Constantes.TiposImputaciones.VENDEDOR.Equals(cbTipoImputacion.SelectedValue))
            {
                tipoSocioNegocio = Constantes.TiposSociosNegocios.VENDEDOR;
            }
            FrmSociosNegocios frmSociosNegocios = new FrmSociosNegocios(FrmPrincipal, Constantes.Operaciones.NUEVO, tipoSocioNegocio);
            if (System.Windows.Forms.DialogResult.OK.Equals(frmSociosNegocios.ShowDialog()))
            {
                txtSocioNegocio.Text = frmSociosNegocios.Entity.RAZON_SOCIAL;
                txtSocioNegocio.Tag = frmSociosNegocios.Entity.SOCIO_NEGOCIO_ID;
                frmSociosNegocios.Close();
            }
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

        private void txtMonto_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender,e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                Entity.TIPO = Tipo;
                Entity.TIPO_IMPUTACION = cbTipoImputacion.SelectedValue.ToString();
                Entity.FECHA = dtpFechaOperacion.Value;
                Entity.ESTADO = cbEstados.SelectedValue.ToString();
                Entity.MONTO = Decimal.Parse(String.IsNullOrWhiteSpace(txtMonto.Text)?"0":txtMonto.Text);
                if(txtSocioNegocio.Tag != null)
                    Entity.SOCIO_NEGOCIO_ID =Int64.Parse(txtSocioNegocio.Tag.ToString());
                Entity.ITEM_INGRESO_EGRESO_ID = Int64.Parse(cbTipoItemIngresoEgreso.SelectedValue.ToString());
                if (cbEntidades.SelectedValue != null)
                    Entity.ENTIDAD_INMOBILIARIA_ID = Int64.Parse(cbEntidades.SelectedValue.ToString());
                if (cbPropiedades.SelectedValue != null)
                    Entity.PROPIEDAD_ID = Int64.Parse(cbPropiedades.SelectedValue.ToString());
                Entity.FECHA_FACTURA = dtpFechaFactura.Value;
                Entity.OBSERVACION = txtObservacion.Text;
                Entity.NUMERO_FACTURA = txtNumeroFactura.Text;
                if (cbFormaPago.SelectedValue != null)
                    Entity.FORMA_PAGO_ID = Int64.Parse(cbFormaPago.SelectedValue.ToString());
                Entity.NUMERO_DOCUMENTO_PAGO = txtNumeroPago.Text;
                IngresosEgresosService service = new IngresosEgresosService();
                try
                {
                    service.Guardar(Operacion, Entity, FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO);
                    PysistemasMensajes.ShowInfo("Los datos se guardaron con éxito");
                    if (PysistemasMensajes.AskConfirmation("Desea cargar otro movimiento?"))
                    {
                        // limpiar formulario
                        LimpiarPantalla();

                    }
                    else
                    {                        
                        Close();
                    }
                }
                catch (Exception exception)
                {
                    PysistemasMensajes.ShowError(exception.Message);
                }
                
            }
            else
            {
                PysistemasMensajes.ShowInfo("Favor cargue los campos obligatorios");
            }
        }

        private bool Validaciones()
        {
            String Estado = cbEstados.SelectedValue.ToString();
            Int64 formaPagoEfectivo = 0;
            if ("CANCELADO".Equals(Estado))
            {
                using (FormasPagosDao formasPagosDao = new FormasPagosDao())
                {
                    formaPagoEfectivo = formasPagosDao.ObtenerDesdeFiltros(f => f.CODIGO == "EFE")[0].FORMA_PAGO_ID;
                 
                }

                if (cbFormaPago.SelectedIndex == -1 || txtNumeroFactura.Text == "" || 
                    (Int64.Parse(cbFormaPago.SelectedValue.ToString()) != formaPagoEfectivo && txtNumeroPago.Text ==""))
                {
                    //PysistemasMensajes.ShowInfo("Favor cargue todos los campos relacionados a la cancelacion del documento.");
                    return false;
                }
            }
            if (txtMonto.Text == "" || txtMonto.Text == "0")
            {
                //PysistemasMensajes.ShowInfo("Favor cargue el monto del documento.");
                return false;
            }
            return true;
        }

        private void cbPropiedades_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbPropiedades.SelectedValue != null)
            {
                
                    Int64 propiedadId = Int64.Parse(cbPropiedades.SelectedValue.ToString());
                   

                    using (OperacionesPropiedadesDao operacionesPropiedadesDao = new OperacionesPropiedadesDao())
                    {
                        IList<OPERACIONES_PROPIEDADES> contrato = operacionesPropiedadesDao.ObtenerDesdeFiltros(ope =>
                            ope.PROPIEDAD_ID == propiedadId &&
                            ope.ESTADO.Equals(Constantes.EstadosUnidadesInmobiliarias.VIGENTE));
                        if (contrato.Count == 1)
                        {
                            using (SociosNegociosDao sociosNegociosDao = new SociosNegociosDao())
                            {
                                SOCIOS_NEGOCIOS inquilino =
                                    sociosNegociosDao.ObtenerDesdePk(contrato[0].SOCIO_NEGOCIO_ID);
                                txtSocioNegocio.Text = inquilino.RAZON_SOCIAL;
                                txtSocioNegocio.Tag = inquilino.SOCIO_NEGOCIO_ID;
                            }
                        // si tiene un contrato asumimos que vamos a pagar la comision al vendedor
                            using (PropiedadesDao propiedadDao = new PropiedadesDao())
                            {
                                PROPIEDADES propiedad = propiedadDao.ObtenerDesdePk(contrato[0].PROPIEDAD_ID);
                                txtMonto.Text = (propiedad.PRECIO * (propiedad.COMISION/100)).ToString();

                            }
                        }else
                        {
                            txtSocioNegocio.Text = String.Empty;
                            txtSocioNegocio.Tag = null;
                            txtMonto.Text = "0";
                        }
                    }

            }
            else
            {
                txtSocioNegocio.Text = String.Empty;
                txtSocioNegocio.Tag = null;
                txtMonto.Text = "0";
            }
        }
        protected override void LimpiarPantalla()
        {
            ControlesUtilidades.ClearComponents(gbDatosIngresosEgresos);
            ControlesUtilidades.ClearComponents(gbDatosFacturacion);
            cbTipoImputacion.Focus();
            txtMonto.Text = "0";            
            dtpFechaFactura.Value = DateTime.Now;
        }

        private void txtNumeroFactura_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtNumeroFactura_Leave(object sender, EventArgs e)
        {
            String NumeroFactura = ControlesUtilidades.GetNumeroFactura(txtNumeroFactura.Text);
            txtNumeroFactura.Text = NumeroFactura;
            txtNumeroFactura.SelectionStart = txtNumeroFactura.TextLength;
        }

        private void txtMonto_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            txtMonto.SelectAll();
        }

        private void txtNumeroFactura_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.InitialDelay = 0;
            tt.ShowAlways = true;
            tt.SetToolTip(txtNumeroFactura, "Si ingresa por ejemplo: 1-1-123 se autocompletara 001-001-0000123 en base al formato de facturas.");
        }

        private async void btnAgregarItemIngEgr_Click(object sender, EventArgs e)
        {
            FrmItemIngresoEgreso frm = new FrmItemIngresoEgreso(FrmPrincipal, Constantes.Operaciones.NUEVO);
            if (DialogResult.OK.Equals(frm.ShowDialog(this)))
            {
                await CargarTiposItemsIngresosEgresos();
                Activate();
            }
        }
    }
}
