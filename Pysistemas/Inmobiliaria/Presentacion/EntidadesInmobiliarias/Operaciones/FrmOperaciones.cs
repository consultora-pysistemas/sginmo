using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Dao.IngresosEgresos;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Presentacion.Mantenimiento.Buscadores;
using Inmobiliaria.Presentacion.Mantenimiento.SociosNegocios;
using Inmobiliaria.Presentacion.ParametrosReportes;
using Inmobiliaria.Reportes;
using Inmobiliaria.Services.EntidadesInmobiliarias;
using Inmobiliaria.Services.Generales;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Inmobiliaria.Presentacion.EntidadesInmobiliarias.Operaciones
{
    public partial class FrmOperaciones : Genericos.FrmMaestro
    {
        public string Operacion { get; set; }
        public OPERACIONES_PROPIEDADES Entity { get; set; }
        public List<CRONOGRAMAS_CUOTAS> Cuotas { get; set; }

        private string precioAlquiler { get; set; }
        private string montoGarantia { get; set; }
        public decimal MontoComision { get; set; }
        public bool EsRenovacion { get; set; }
        public long plazoModificadoParaRegenerarCuotas;

        public FrmOperaciones(Principal principal, string operacion) : base(principal)
        {
            InitializeComponent();
            Operacion = operacion;
            Entity = new OPERACIONES_PROPIEDADES();
            CargarDatos();
            Cuotas = new List<CRONOGRAMAS_CUOTAS>();
            EsRenovacion = false;

        }

        private async void CargarDatos()
        {
            await CargarSucursal();
            await CargarMoneda();
            await CargarTipoOperaciones();
            await CargarEntidades();
            await CargarTiposContratos();
            await CargarCondicionOperaciones();
            await CargarTiposFinanciaciones();
            await CargarDatosPorDefecto();
            LimpiarDatosInmuebles();
            dtpInicioContrato.LostFocus += DtpInicioContrato_LostFocus;
            txtPlazo.LostFocus += DtpInicioContrato_LostFocus;

        }

        private async Task CargarDatosPorDefecto()
        {
            using (DominiosDao dominiosDao = new DominiosDao())
            {
                //Obtenemos el monto de mora por defecto
                IList<DOMINIOS> listaDominiosMontoMora =
                    dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.MONTO_MORA_DEFECTO));
                if (listaDominiosMontoMora.Count > 0)
                {
                    txtMontoMora.Text = ControlesUtilidades.aplicarFormatoNumerico(listaDominiosMontoMora[0].VALOR_DOMINIO);
                }
                //Cantidad de dias de gracia
                IList<DOMINIOS> lista = dominiosDao.ObtenerDesdeFiltros(d =>
                    d.DOMINIO.Equals(Constantes.Dominios.DIAS_GRACIA_VENCIMIENTO));
                if (lista.Count > 0)
                {
                    txtDiaGracia.Text = ControlesUtilidades.aplicarFormatoNumerico(lista[0].VALOR_DOMINIO);
                }


                IList<DOMINIOS> listaTiposFinanciaciones = dominiosDao.ObtenerDesdeFiltros(d =>
                    d.DOMINIO.Equals(Constantes.Dominios.TIPOS_FINANCIACIONES));
                if (lista.Count > 0)
                {
                    cbTipoFinanciacion.SelectedValue = "FINANCIACION_PROPIA";
                }
            }
        }

        private async Task CargarCondicionOperaciones()
        {
            using (DominiosDao dominiosDao = new DominiosDao())
            {
                cbTiposContratos.DataSource = dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.TIPOS_CONTRATOS));
                ControlesUtilidades.InicializarComboBox(cbTiposContratos);
            }
        }

        private async Task CargarTiposContratos()
        {
            using (DominiosDao dominiosDao = new DominiosDao())
            {
                cbCondicion.DataSource = dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.CONDICION_OPERACION));
                ControlesUtilidades.InicializarComboBox(cbCondicion);
            }
        }

        private async Task CargarTiposFinanciaciones()
        {
            using (DominiosDao dominiosDao = new DominiosDao())
            {
                cbTipoFinanciacion.DataSource = dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.TIPOS_FINANCIACIONES));
                ControlesUtilidades.InicializarComboBox(cbTipoFinanciacion);
            }
        }
        private void DtpInicioContrato_LostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPlazo.Text))
            {
                dtpFinContrato.Value = dtpInicioContrato.Value.AddMonths(int.Parse(txtPlazo.Text));
                //dtpFinContrato.Value = dtpFinContrato.Value.AddDays(-1);
            }
        }

        private void LimpiarDatosInmuebles()
        {
            lblDatosInmuebles.Text = lblCaracteristicas.Text = lblUbicacion.Text = lblPropiedadUnidad.Text = string.Empty;
            txtPrecio.Text = txtPlazo.Text = txtGarantia.Text = "0";

        }

        private async Task CargarEntidades()
        {
            using (EntidadesInmobiliariasDao entidadesInmobiliariasDao = new EntidadesInmobiliariasDao())
            {
                cbEntidades.DataSource = entidadesInmobiliariasDao.ObtenerLista();
                ControlesUtilidades.InicializarComboBox(cbEntidades);
                // CargarPropiedadesEntidadInmobiliaria(Int64.Parse(cbEntidades.SelectedIndex.ToString()));
            }
        }

        public async void CargarPropiedadesEntidadInmobiliaria(long entidadInmobiliaria)
        {
            using (BusquedaPropiedasViewDao propiedadesDao = new BusquedaPropiedasViewDao())
            {
                if (Constantes.Operaciones.NUEVO.Equals(Operacion))
                {
                    if (entidadInmobiliaria == -1)
                    {
                        cbPropiedades.DataSource = propiedadesDao.ObtenerDesdeFiltros(p => p.ENTIDAD_INMOBILIARIA_ID == 0 && p.ESTADO.Equals("LIBRE"));
                    }

                    else
                    {

                        cbPropiedades.DataSource = propiedadesDao.ObtenerDesdeFiltros(p => (p.ENTIDAD_INMOBILIARIA_ID == entidadInmobiliaria || p.ENTIDAD_INMOBILIARIA_ID.Equals(null)) &&
                            p.ESTADO.Equals("LIBRE"));
                    }
                }
                else
                {
                    if (entidadInmobiliaria == -1)
                    {
                        cbPropiedades.DataSource = propiedadesDao.ObtenerDesdeFiltros(p => p.ENTIDAD_INMOBILIARIA_ID == 0);
                    }
                    else
                    {
                        cbPropiedades.DataSource = propiedadesDao.ObtenerDesdeFiltros(p => p.ENTIDAD_INMOBILIARIA_ID == entidadInmobiliaria);
                    }
                }

                ControlesUtilidades.InicializarComboBox(cbPropiedades);
            }

        }

        private async Task CargarTipoOperaciones()
        {
            using (DominiosDao dominiosDao = new DominiosDao())
            {
                cbTipoOperacion.DataSource = dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.TIPOS_OPERACIONES));
                ControlesUtilidades.InicializarComboBox(cbTipoOperacion);
            }
        }

        private async Task CargarMoneda()
        {
            using (MonedasDao monedasDao = new MonedasDao())
            {
                cbMoneda.DataSource = monedasDao.ObtenerLista();
                MonedasService service = new MonedasService();
                cbMoneda.SelectedValue = service.ObtenerMonedaPorDefecto().MONEDA_ID;
            }
        }

        private async Task CargarSucursal()
        {
            lblSucursal.Text = FrmPrincipal.Configuraciones.ObtenerValorVariableEntorno(Constantes.VariablesEntorno.SUCURSAL).VALOR;
            lblSucursal.Tag = FrmPrincipal.Configuraciones.ObtenerValorVariableEntorno(Constantes.VariablesEntorno.SUCURSAL_ID).VALOR;

        }

        private void FrmOperaciones_Load(object sender, EventArgs e)
        {
            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                lblTitulo.Text = "Crear operación Alquiler/Venta";
                lnkGenerarCuotas.Visible = true;
                lnkVerCuotas.Visible = false;
                int dia = DateTime.Now.Day;
                cbDiaPago.SelectedItem = dia.ToString();
                lnkImprimirPagare.Visible = false;
            }
            else
            {
                lblTitulo.Text = "Editar operación Alquiler/Venta";
                lnkGenerarCuotas.Visible = false;
                lnkVerCuotas.Visible = true;
                CargarDatosEntity();
                lnkImprimirPagare.Visible = true;
                VisualizarContrato();
            }
        }

        private void VisualizarContrato()
        {
            long CuotasPendientes = 0;
            using (BusquedaCronogramasCuotasViewDao cuotas = new BusquedaCronogramasCuotasViewDao())
            {
                CuotasPendientes = cuotas.ObtenerDesdeFiltros(c => c.OPERACION_PROPIEDAD_ID == Entity.OPERACION_PROPIEDAD_ID
                    && c.ESTADO == "PENDIENTE").Count;
            }
            if (CuotasPendientes == 0)
            {
                panel2.Enabled = false;
                panel3.Enabled = false;
            }
        }

        private void CargarDatosEntity()
        {
            dtpFechaOperacion.Value = Entity.FECHA_OPERACION;
            cbMoneda.SelectedValue = Entity.MONEDA_ID;
            cbTipoOperacion.SelectedValue = Entity.TIPO_OPERACION;

            if ("ENTIDAD_INMOBILIARIA".Equals(Entity.TIPO_ENTIDAD))
            {
                rbEntidad.Checked = true;
                rbPropiedad.Checked = false;
            }
            else
            {
                rbEntidad.Checked = false;
                rbPropiedad.Checked = true;
            }

            cbEntidades.SelectedValue = Entity.ENTIDAD_INMOBILIARIA_ID;
            cbPropiedades.SelectedValue = Entity.PROPIEDAD_ID;
            cbTiposContratos.SelectedValue = Entity.TIPO_CONTRATO;
            cbCondicion.SelectedValue = Entity.CONDICION_OPERACION;
            dtpInicioContrato.Value = Entity.FECHA_INICIO_CONTRATO;
            dtpFinContrato.Value = (DateTime)Entity.FECHA_FIN_CONTRATO;
            txtPlazo.Text = Entity.PLAZO.ToString();
            using (SociosNegociosDao sociosNegociosDao = new SociosNegociosDao())
            {
                SOCIOS_NEGOCIOS locatario = sociosNegociosDao.ObtenerDesdePk(Entity.SOCIO_NEGOCIO_ID);
                txtLocatario.Text = locatario.RAZON_SOCIAL;
                txtLocatario.Tag = locatario.SOCIO_NEGOCIO_ID;

                if (Entity.VENDEDOR_ID != null)
                {
                    SOCIOS_NEGOCIOS vendedor = sociosNegociosDao.ObtenerDesdePk(Entity.VENDEDOR_ID);
                    txtVendedor.Text = vendedor.RAZON_SOCIAL;
                    txtVendedor.Tag = vendedor.SOCIO_NEGOCIO_ID;
                }

            }
            txtPrecio.Text = Entity.PRECIO.ToString("N0");
            txtGarantia.Text = Entity.GARANTIA.ToString("N0");
            lblFechaFinalizacion.Text = Entity.FECHA_FIN_CONTRATO.ToString();
            chkAvisoRenovacion.Checked = Constantes.Booleano.SI.Equals(Entity.AVISO_RENOVACION) ? true : false;
            txtDiaGracia.Text = Entity.DIAS_GRACIA.ToString();
            txtMontoMora.Text = Entity.MONTO_MORA.ToString("N0");
            cbDiaPago.SelectedItem = Entity.DIA_PAGO.ToString();
            if (Entity.ESTADO != null)
            {
                lblEstado.Text = Entity.ESTADO;
                if (Constantes.EstadosUnidadesInmobiliarias.VIGENTE.Equals(Entity.ESTADO))
                {
                    lblEstado.ForeColor = Color.Green;
                }
                else
                {
                    lblEstado.ForeColor = Color.Red;
                }
            }
            if (Entity.TIPO_FINANCIACION == null)
            {
                ControlesUtilidades.InicializarComboBox(cbTipoFinanciacion);
            }
            else
            {
                cbTipoFinanciacion.SelectedValue = Entity.TIPO_FINANCIACION;
            }


        }

        private void lnkGenerarCuotas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            long plazo = string.IsNullOrWhiteSpace(txtPlazo.Text) ? 0 : long.Parse(txtPlazo.Text);
            if (plazo <= 0)
            {
                PysistemasMensajes.ShowInfo("El plazo debe ser un número mayor a 0");
                return;
            }

            //Generar las cuotas de acuerdo del plazo y precio 
            FrmVerCronogramasCuotasOperaciones frmVerCuotas = new FrmVerCronogramasCuotasOperaciones(FrmPrincipal, Operacion);
            //if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            //{
            if (CargarEntity())
            {
                frmVerCuotas.OperacionPropiedad = Entity;
                //frmVerCuotas.ShowDialog();
                if (DialogResult.OK.Equals(frmVerCuotas.ShowDialog()))
                {
                    Cuotas = frmVerCuotas.Cuotas;

                    btnGuardar_Click(sender, e);

                    frmVerCuotas.Close();

                }
            }
            //}


        }

        private bool CargarEntity()
        {
            Entity.FECHA_OPERACION = dtpFechaOperacion.Value;
            Entity.SUCURSAL_ID = long.Parse(lblSucursal.Tag.ToString());
            Entity.MONEDA_ID = long.Parse(cbMoneda.SelectedValue.ToString());
            if (cbTipoOperacion.SelectedValue == null)
            {
                PysistemasMensajes.ShowInfo("El tipo de operación es requerido");
                return false;
            }
            Entity.TIPO_OPERACION = cbTipoOperacion.SelectedValue.ToString();
            if (rbEntidad.Checked && cbEntidades.SelectedValue == null)
            {
                PysistemasMensajes.ShowInfo("El edificio/loteamiento es requerido para el tipo de inmueble");
                return false;
            }
            if (cbEntidades.SelectedValue != null)
            {
                Entity.ENTIDAD_INMOBILIARIA_ID = long.Parse(cbEntidades.SelectedValue.ToString());
            }

            if (rbPropiedad.Checked && cbPropiedades.SelectedValue == null)
            {
                PysistemasMensajes.ShowInfo("El dpto/lote/casa es requerido para el tipo de inmueble");
                return false;
            }
            Entity.PROPIEDAD_ID = long.Parse(cbPropiedades.SelectedValue.ToString());
            if (txtLocatario.Tag == null)
            {
                PysistemasMensajes.ShowInfo("El locatario del inmueble es requerido para la operación");
                return false;
            }
            Entity.SOCIO_NEGOCIO_ID = long.Parse(txtLocatario.Tag.ToString());
            if (cbTiposContratos.SelectedValue == null)
            {
                PysistemasMensajes.ShowInfo("El tipo de contrato es requerido para la operación");
                return false;
            }
            Entity.TIPO_CONTRATO = cbTiposContratos.SelectedValue.ToString();
            if (cbCondicion.SelectedValue == null)
            {
                PysistemasMensajes.ShowInfo("La condición es requerido para la operación");
                return false;
            }
            Entity.CONDICION_OPERACION = cbCondicion.SelectedValue.ToString();

            precioAlquiler = txtPrecio.Text;
            montoGarantia = txtGarantia.Text;

            if (txtPlazo.Text == "")
            {
                txtPlazo.Text = "0";
            }
            Entity.PLAZO = int.Parse(txtPlazo.Text);
            Entity.PRECIO = decimal.Parse(precioAlquiler.Replace(".", ""));
            /*if (Constantes.TiposOperacionesInmuebles.VENTA.Equals(Entity.TIPO_OPERACION))
            {
                Entity.PRECIO = (decimal)(Entity.PRECIO / Entity.PLAZO);
            }*/
            Entity.GARANTIA = string.IsNullOrWhiteSpace(montoGarantia.Replace(".", "")) ? 0 : decimal.Parse(decimal.Parse(montoGarantia.Replace(".", "")).ToString("N0"));


            Entity.FECHA_INICIO_CONTRATO = dtpInicioContrato.Value;
            Entity.FECHA_FIN_CONTRATO = dtpFinContrato.Value;

            Entity.FECHA_FINALIZACION = dtpFinContrato.Value;
            Entity.FECHA_RENOVACION = dtpFechaRenovacion.Value;

            Entity.MONEDA_ID = long.Parse(cbMoneda.SelectedValue.ToString());
            Entity.ESTADO = "VIGENTE";


            Entity.AVISO_RENOVACION = chkAvisoRenovacion.Checked ? Constantes.Booleano.SI : Constantes.Booleano.NO;
            Entity.TIPO_ENTIDAD = rbEntidad.Checked ? "ENTIDAD_INMOBILIARIA" : "PROPIEDAD";
            Entity.DIA_PAGO = long.Parse(cbDiaPago.SelectedItem.ToString());

            if (txtMontoMora.Text != "")
            {
                Entity.MONTO_MORA = decimal.Parse(txtMontoMora.Text);
            }

            if (txtDiaGracia.Text != "")
            {
                Entity.DIAS_GRACIA = long.Parse(txtDiaGracia.Text);
            }

            if (txtVendedor.Tag != null)
            {
                Entity.VENDEDOR_ID = long.Parse(txtVendedor.Tag.ToString());
            }
            if (cbTipoFinanciacion.SelectedValue != null)
            {
                Entity.TIPO_FINANCIACION = cbTipoFinanciacion.SelectedValue.ToString();
            }

            return true;
        }

        private void rbEntidad_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbEntidad.Checked)
            {
                ControlesUtilidades.InicializarComboBox(cbEntidades);
                cbEntidades.DataSource = null;
            }
            else
            {
                cbEntidades.DisplayMember = "NOMBRE";
                cbEntidades.ValueMember = "ENTIDAD_INMOBILIARIA_ID";
                CargarEntidades();
            }
        }

        private void rbPropiedad_CheckedChanged(object sender, EventArgs e)
        {
            ControlesUtilidades.InicializarComboBox(cbEntidades);
            // si buscamos propiedades recuperar todas las propiedades que tenga entidad = -1 o 0, definir y unificar
            CargarPropiedadesEntidadInmobiliaria(0);
        }

        private void cbEntidades_SelectedValueChanged(object sender, EventArgs e)
        {
            LimpiarDatosInmuebles();
            if (cbEntidades.SelectedValue != null)
            {
                long entidadId = long.Parse(cbEntidades.SelectedValue.ToString());
                CargarPropiedadesEntidadInmobiliaria(entidadId);
                CargarDatosInmuebles();
            }
        }

        private void btnLimpiarEntidad_Click(object sender, EventArgs e)
        {
            ControlesUtilidades.InicializarComboBox(cbEntidades);
            CargarPropiedadesEntidadInmobiliaria(-1);
            LimpiarDatosInmuebles();
        }

        private void cbPropiedades_SelectedValueChanged(object sender, EventArgs e)
        {
            LimpiarDatosInmuebles();
            if (cbPropiedades.SelectedValue != null)
            {
                CargarDatosInmuebles();
            }
        }

        private void CargarDatosInmuebles()
        {

            if (cbPropiedades.SelectedValue != null)
            {
                PROPIEDADES propiedad;
                long propiedadId = long.Parse(cbPropiedades.SelectedValue.ToString());
                using (PropiedadesDao propiedadesDao = new PropiedadesDao())
                {
                    propiedad = propiedadesDao.ObtenerDesdePk(propiedadId);

                }
                if (propiedad != null)
                {
                    lblPropiedadUnidad.Text = cbPropiedades.Text;
                    lblDatosInmuebles.Text = "Cta. Catastral: " + propiedad.CUENTA_CATASTRAL + " - Finca: " + propiedad.NUMERO_FINCA;

                    using (BusquedaPropiedasViewDao busquedaPropiedadesDao = new BusquedaPropiedasViewDao())
                    {
                        IList<PROPIEDADES_VIEW> lista = busquedaPropiedadesDao.ObtenerDesdeFiltros(b => b.PROPIEDAD_ID == propiedad.PROPIEDAD_ID);
                        if (lista != null && lista.Count > 0)
                        {
                            PROPIEDADES_VIEW propiedadSeleccionada = lista[0];
                            lblUbicacion.Text = propiedadSeleccionada.DIRECCION + " - " + propiedadSeleccionada.BARRIO + " - " + propiedadSeleccionada.CIUDAD;
                            if (Constantes.TiposOperacionesInmuebles.ALQUILER.Equals(cbTipoOperacion.SelectedValue))
                            {

                                txtPrecio.Text = propiedadSeleccionada.PRECIO.ToString("N0");
                                txtGarantia.Text = propiedadSeleccionada.PRECIO.ToString("N0");
                            }
                            else
                            {
                                txtPrecio.Text = propiedadSeleccionada.PRECIO.ToString("N0");
                            }

                            if (Constantes.TiposPropiedades.LOTE.Equals(propiedadSeleccionada.TIPO.ToUpper()))
                            {
                                lblCaracteristicas.Text = propiedadSeleccionada.DIMENSIONES;

                            }
                            else
                            {
                                lblCaracteristicas.Text = propiedadSeleccionada.CARACTERISTICAS;
                            }


                        }


                    }
                }


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void btnBuscadorSocioNegocio_Click(object sender, EventArgs e)
        {
            FrmBuscadorSociosNegocios frmBuscadorSociosNegocios = new FrmBuscadorSociosNegocios(FrmPrincipal, Constantes.TiposSociosNegocios.INQUILINO);
            frmBuscadorSociosNegocios.Buscar();
            if (DialogResult.OK.Equals(frmBuscadorSociosNegocios.ShowDialog(this)))
            {
                txtLocatario.Text = frmBuscadorSociosNegocios.Entity.SOCIO_NEGOCIO;
                txtLocatario.Tag = frmBuscadorSociosNegocios.Entity.SOCIO_NEGOCIO_ID;
                frmBuscadorSociosNegocios.Close();
                Activate();
            }
        }

        private void btnNuevoLocatario_Click(object sender, EventArgs e)
        {
            FrmSociosNegocios frmSociosNegocios = new FrmSociosNegocios(FrmPrincipal, Constantes.Operaciones.NUEVO, Constantes.TiposSociosNegocios.INQUILINO);
            frmSociosNegocios.ShowDialog();
            //if (DialogResult.OK.Equals(frmSociosNegocios.ShowDialog()))            
            //{
            txtLocatario.Text = frmSociosNegocios.Entity.RAZON_SOCIAL;
            txtLocatario.Tag = frmSociosNegocios.Entity.SOCIO_NEGOCIO_ID;
            frmSociosNegocios.Close();
            //}
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtLocatario.Text = string.Empty;
            txtLocatario.Tag = null;
        }

        private void chkAvisoRenovacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAvisoRenovacion.Checked)
            {
                dtpFechaRenovacion.Visible = chkAvisoRenovacion.Checked;
                lblFechaRenovacion.Visible = true;
                dtpFechaRenovacion.Value = dtpFinContrato.Value.AddDays(-30);
            }
            else
            {
                dtpFechaRenovacion.Visible = chkAvisoRenovacion.Checked;
                lblFechaRenovacion.Visible = false;
            }

            // si esta en el contrato colocar esa cantidad de dias para la renovacion

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (PysistemasMensajes.AskConfirmation("Está seguro que desea guardar la operación?"))
            {
                CargarEntity();
                if ("0".Equals(txtPlazo.Text))
                {
                    PysistemasMensajes.ShowInfo("El plazo no puede ser 0");
                    txtPlazo.Focus();
                    return;
                }
                /*
                if (Constantes.Operaciones.NUEVO.Equals(Operacion))
                {
                    PysistemasMensajes.ShowInfo("Se generará las cuotas de la operación y se guardará la operación");

                    //CronogramasCuotasService service = new CronogramasCuotasService();
                    //Cuotas = service.GenerarCuotas(Entity);
                    // guardamos lo que esta en el grid que ya fue generado anteriormente y pudo haber sido
                    // modificado por el usuario antes de guardar
                                       
                }
                */


                OperacionesService operacionService = new OperacionesService();
                decimal montoTotalOperacion = long.Parse(txtPlazo.Text) * decimal.Parse(txtPrecio.Text);
                Entity.MONTO_TOTAL_OPERACION = montoTotalOperacion;
                ControlesUtilidades utilidades = new ControlesUtilidades();

                if (Constantes.TiposOperacionesInmuebles.VENTA.Equals(Entity.TIPO_OPERACION))
                {
                    montoTotalOperacion = (decimal)(montoTotalOperacion / Entity.PLAZO);
                    Entity.MONTO_TOTAL_OPERACION = montoTotalOperacion;
                }

                Entity.MONTO_TOTAL_LETRAS = utilidades.Convertir_Numero(montoTotalOperacion.ToString());



                if (Cuotas.Count == 0)
                {
                    if (PysistemasMensajes.AskConfirmation("No se han generado aun las cuotas, desea hacerlo ahora?"))
                    {
                        CronogramasCuotasService service = new CronogramasCuotasService();
                        Cuotas = service.GenerarCuotas(Entity);
                        operacionService.GuardarOperacion(Cuotas, Entity, Operacion, FrmPrincipal.UsuarioLogueado);
                    }
                    else
                    {
                        return;
                    }

                }
                else if (Cuotas.Sum(c => c.MONTO) != Entity.PRECIO && Entity.TIPO_OPERACION.Equals(Constantes.TiposOperacionesInmuebles.VENTA))
                {
                    PysistemasMensajes.ShowInfo("La suma de todas las cuotas no coincide con el precio de venta. Por favor verifique.");
                    return;
                }
                else
                {
                    operacionService.GuardarOperacion(Cuotas, Entity, Operacion, FrmPrincipal.UsuarioLogueado);
                }

                if (Constantes.Operaciones.NUEVO.Equals(Operacion) && !EsRenovacion)
                {
                    //Generamos el egreso del pago de comision de la venta/alquiler
                    try
                    {
                        using (IngresosEgresosDao ingresosEgresosDao = new IngresosEgresosDao())
                        {
                            INGRESOS_EGRESOS ingresoEgreso = new INGRESOS_EGRESOS
                            {
                                ENTIDAD_INMOBILIARIA_ID = long.Parse(cbEntidades.SelectedValue.ToString()),
                                SOCIO_NEGOCIO_ID = long.Parse(txtLocatario.Tag.ToString()),
                                FECHA = Entity.FECHA_OPERACION
                            };
                            ingresoEgreso.FECHA_CREACION = (DateTime)(ingresoEgreso.FECHA_FACTURA = (DateTime?)DateTime.Now.Date);
                            ingresoEgreso.ESTADO = "CANCELADO";
                            ingresoEgreso.USUARIO_CREACION = FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO;
                            using (FormasPagosDao formasPagosDao = new FormasPagosDao())
                            {
                                FORMAS_PAGOS formaPago = formasPagosDao.ObtenerDesdeFiltros(f => f.CODIGO.Equals("EFE")).SingleOrDefault();
                                ingresoEgreso.FORMA_PAGO_ID = formaPago.FORMA_PAGO_ID;
                            }

                            using (ItemsIngresosEgresosDao itemsIngresosEgresosDao = new ItemsIngresosEgresosDao())
                            {
                                string tipo = cbTipoOperacion.SelectedValue.ToString();
                                ITEMS_INGRESOS_EGRESOS item = new ITEMS_INGRESOS_EGRESOS();
                                if (Constantes.TiposOperacionesInmuebles.VENTA.Equals(tipo))
                                {
                                    item = itemsIngresosEgresosDao.ObtenerDesdeFiltros(i =>
                                        i.APLICACION.Equals(Constantes.ItemIngresosEgresosAplicacion.COMISION_VENTA)).SingleOrDefault();
                                }
                                else
                                {
                                    item = itemsIngresosEgresosDao.ObtenerDesdeFiltros(i =>
                                        i.APLICACION.Equals(Constantes.ItemIngresosEgresosAplicacion.COMISION_ALQUILER)).SingleOrDefault();
                                }

                                ingresoEgreso.ITEM_INGRESO_EGRESO_ID = item.ITEM_INGRESO_EGRESO_ID;
                            }
                            ingresoEgreso.TIPO_IMPUTACION = Constantes.TiposImputaciones.PROPIEDADES;
                            ingresoEgreso.TIPO = Constantes.TiposIngresosEgresos.EGRESO;

                            decimal porcentajeComision = 0;
                            decimal montoGarantia = decimal.Parse(txtGarantia.Text);
                            using (PropiedadesDao propiedadesDao = new PropiedadesDao())
                            {
                                long propiedadId = long.Parse(cbPropiedades.SelectedValue.ToString());
                                PROPIEDADES propiedades = propiedadesDao.ObtenerDesdePk(propiedadId);
                                porcentajeComision = propiedades.COMISION;
                            }

                            ingresoEgreso.NUMERO_FACTURA = Entity.OPERACION_PROPIEDAD_ID.ToString();
                            ingresoEgreso.PROPIEDAD_ID = long.Parse(cbPropiedades.SelectedValue.ToString());
                            ingresoEgreso.SOCIO_NEGOCIO_ID = long.Parse(txtVendedor.Tag.ToString());
                            ingresoEgreso.MONTO = CalcularMontoComision();
                            ingresosEgresosDao.Agregar(ingresoEgreso);
                            ingresosEgresosDao.Guardar();




                            if (Constantes.TiposOperacionesInmuebles.ALQUILER.Equals(cbTipoOperacion.SelectedValue.ToString()))
                            {
                                try
                                {
                                    INGRESOS_EGRESOS ingresoEgresoGarantia = new INGRESOS_EGRESOS
                                    {
                                        ENTIDAD_INMOBILIARIA_ID = long.Parse(cbEntidades.SelectedValue.ToString())
                                    };
                                    ingresoEgresoGarantia.FECHA = ingresoEgresoGarantia.FECHA_CREACION = (DateTime)(ingresoEgresoGarantia.FECHA_FACTURA = (DateTime?)DateTime.Now.Date);
                                    ingresoEgresoGarantia.ESTADO = "CANCELADO";
                                    ingresoEgresoGarantia.USUARIO_CREACION = FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO;
                                    using (FormasPagosDao formasPagosDao = new FormasPagosDao())
                                    {
                                        FORMAS_PAGOS formaPago = formasPagosDao.ObtenerDesdeFiltros(f => f.CODIGO.Equals("EFE")).SingleOrDefault();
                                        ingresoEgresoGarantia.FORMA_PAGO_ID = formaPago.FORMA_PAGO_ID;
                                    }

                                    using (ItemsIngresosEgresosDao itemsIngresosEgresosDao = new ItemsIngresosEgresosDao())
                                    {
                                        string tipo = cbTipoOperacion.SelectedValue.ToString();
                                        ITEMS_INGRESOS_EGRESOS item = new ITEMS_INGRESOS_EGRESOS();

                                        item = itemsIngresosEgresosDao.ObtenerDesdeFiltros(i =>
                                            i.APLICACION.Equals(Constantes.ItemIngresosEgresosAplicacion.DEPOSITO_GARANTIA)).SingleOrDefault();


                                        ingresoEgresoGarantia.ITEM_INGRESO_EGRESO_ID = item.ITEM_INGRESO_EGRESO_ID;
                                    }
                                    ingresoEgresoGarantia.TIPO_IMPUTACION = Constantes.TiposImputaciones.PROPIEDADES;
                                    ingresoEgresoGarantia.TIPO = Constantes.TiposIngresosEgresos.INGRESO;


                                    using (PropiedadesDao propiedadesDao = new PropiedadesDao())
                                    {
                                        long propiedadId = long.Parse(cbPropiedades.SelectedValue.ToString());
                                        PROPIEDADES propiedades = propiedadesDao.ObtenerDesdePk(propiedadId);
                                        porcentajeComision = propiedades.COMISION;
                                    }

                                    ingresoEgresoGarantia.NUMERO_FACTURA = Entity.OPERACION_PROPIEDAD_ID.ToString();
                                    ingresoEgresoGarantia.PROPIEDAD_ID = long.Parse(cbPropiedades.SelectedValue.ToString());

                                    ingresoEgresoGarantia.MONTO = decimal.Parse(txtGarantia.Text);
                                    ingresosEgresosDao.Agregar(ingresoEgresoGarantia);
                                    ingresosEgresosDao.Guardar();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex);
                                    throw;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        PysistemasMensajes.ShowError(ex.Message);
                    }



                }
                PysistemasMensajes.ShowInfo("Los datos se guardaron con éxito");

                Operacion = Constantes.Operaciones.EDITAR;

                lnkGenerarCuotas.Visible = false;
                lnkVerCuotas.Visible = true;
                lnkImprimirContrato.Visible = true;
                if (Constantes.TiposOperacionesInmuebles.ALQUILER.Equals(cbTipoOperacion.SelectedValue.ToString()))
                {
                    lnkImprimirPagare.Visible = true;
                }
                else
                {
                    lnkImprimirPagare.Visible = false;
                }

                if (EsRenovacion)
                {
                    PysistemasMensajes.ShowInfo("Se ha realizado la renovación de " + lblPropiedadUnidad.Text);
                    DialogResult = DialogResult.OK;
                    Hide();
                }

            }
        }



        private decimal CalcularMontoComision()
        {
            long propiedadId = long.Parse(cbPropiedades.SelectedValue.ToString());
            string tipoOperacion = cbTipoOperacion.SelectedValue.ToString();
            using (PropiedadesDao propiedadesDao = new PropiedadesDao())
            {
                PROPIEDADES propiedad = propiedadesDao.ObtenerDesdePk(propiedadId);
                if (Constantes.TiposOperacionesInmuebles.ALQUILER.Equals(tipoOperacion))
                {
                    decimal montoGarantia = decimal.Parse(txtGarantia.Text);
                    //Si es alquiler el monto de la comisión es porcentaje por monto garantía
                    MontoComision = (montoGarantia * propiedad.COMISION / 100);
                    return MontoComision;
                }
                else
                {
                    //Si es venta es porcentaje del precio de la propiedad
                    MontoComision = propiedad.PRECIO * propiedad.COMISION / 100;
                    return MontoComision;
                }
            }
        }

        private void lnkVerCuotas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmVerCronogramasCuotasOperaciones frmVerCuotas = new FrmVerCronogramasCuotasOperaciones(FrmPrincipal, Operacion);
            if (Constantes.Operaciones.EDITAR.Equals(Operacion))
            {
                if (CargarEntity())
                {
                    frmVerCuotas.OperacionPropiedad = Entity;
                    if (DialogResult.OK.Equals(frmVerCuotas.ShowDialog()))
                    {
                        if (frmVerCuotas.Cuotas != null)
                        {
                            Cuotas = frmVerCuotas.Cuotas;
                        }
                        //las cuotas ya se guardan al modificar
                        //btnGuardar_Click(sender, e);
                        frmVerCuotas.Close();
                    }
                    else
                    {
                        //igual si le da cancelar cargamos las Cuotas del form
                        if (frmVerCuotas.Cuotas != null)
                        {
                            Cuotas = frmVerCuotas.Cuotas;
                        }
                    }
                }
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (!txtPrecio.Text.Equals(string.Empty))
            {
                double numero = Convert.ToDouble(txtPrecio.Text);
                txtPrecio.Text = numero.ToString("N0");
                txtPrecio.SelectionStart = txtPrecio.TextLength;
            }
        }

        private void txtGarantia_TextChanged(object sender, EventArgs e)
        {
            if (!txtGarantia.Text.Equals(string.Empty))
            {
                double numero = Convert.ToDouble(txtGarantia.Text);
                txtGarantia.Text = numero.ToString("N0");
                txtGarantia.SelectionStart = txtGarantia.TextLength;
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            // solo cuando entra a cargar le cambiamos para agilizar la carga
            /*if (Entity.OPERACION_PROPIEDAD_ID == 0 && )
                txtGarantia.Text = txtPrecio.Text;*/
            if (txtPrecio.Text == "")
            {
                txtPrecio.Text = "0";
            }
        }

        private void cbTipoOperacion_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTipoOperacion.SelectedValue != null)
            {
                string tipoOperacion = cbTipoOperacion.SelectedValue.ToString();
                LimpiarDatosInmuebles();
                CargarDatosInmuebles();
                if (Constantes.TiposOperacionesInmuebles.VENTA.Equals(tipoOperacion))
                {
                    txtGarantia.Enabled = false;
                    chkAvisoRenovacion.Visible = false;
                    chkTieneEntregaInicial.Checked = true;
                }
                else
                {
                    txtGarantia.Enabled = true;
                    chkAvisoRenovacion.Visible = true;
                    chkTieneEntregaInicial.Checked = true;
                }
                // if(Constantes.TiposOperacionesInmuebles.ALQUILER.Equals())
            }


            /*using (DominiosDao dominiosDao = new DominiosDao())
            {
                tipoOperacion = dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.TIPOS_OPERACIONES) && d.CODIGO_DOMINIO == "ALQUILER")[0].VALOR_DOMINIO;
                
            }
            if (cbTipoOperacion.Text.Equals(tipoOperacion))
            {
                chkAvisoRenovacion.Checked = true;
            }*/





        }

        private void cbCondicion_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Constantes.CondicionOperaciones.CONTADO.Equals(cbCondicion.SelectedValue))
            {
                txtPlazo.Text = "1";
            }
            else
            {
                txtPlazo.Text = "0";
            }
        }

        private void FrmOperaciones_Shown(object sender, EventArgs e)
        {
            cbMoneda.Focus();

        }

        private void lnkImprimirContrato_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process process = new Process();
            /*if (Constantes.CondicionOperaciones.CONTADO.Equals(cbCondicion.SelectedValue))
            {
                process.StartInfo.FileName = (Application.StartupPath + @"\Documentos\CONTRATO_CONTADO.docx");
            }
            else
            {
                process.StartInfo.FileName = (Application.StartupPath + @"\Documentos\CONTRATO_CREDITO.docx");
            }

            process.Start();
            */

            prueba___copia_venta pruebaCopiaVenta = new prueba___copia_venta();
            pruebaCopiaVenta.SetParameterValue("entidad_inmobiliaria",cbEntidades.Text);
            pruebaCopiaVenta.SetParameterValue("locatario",txtLocatario.Text);
            ExportOptions exportOptions = pruebaCopiaVenta.ExportOptions;
            exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
            pruebaCopiaVenta.ExportToDisk(ExportFormatType.WordForWindows,Application.UserAppDataPath+@"\\"+cbEntidades.Text+"-"+cbPropiedades.Text+".doc");
            process.StartInfo.FileName = (Application.UserAppDataPath + @"\\" + cbEntidades.Text + "-" + cbPropiedades.Text + ".doc");
            process.Start();

        }

        private void lnkImprimirPagare_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rpt_pagare rptPagare = new rpt_pagare();
            FrmReporte frmReporte = new FrmReporte();
            frmReporte.lblTitulo.Visible = false;

            long empresaId = FrmPrincipal.Empresa.EMPRESA_ID;
            long operacionId = Entity.OPERACION_PROPIEDAD_ID;
            rptPagare.SetParameterValue("EMPRESA_ID", empresaId);
            rptPagare.SetParameterValue("OPERACION_ID", operacionId);
            frmReporte.crystalReportViewer1.ReportSource = rptPagare;
            frmReporte.crystalReportViewer1.Show();
            frmReporte.ShowDialog();
            Activate();
        }

        private void dtpInicioContrato_ValueChanged(object sender, EventArgs e)
        {
            cbDiaPago.SelectedItem = dtpInicioContrato.Value.Day.ToString();

            // quiere decir que ya cargo el plazo antes y entonces calculamos de vuelta
            if (txtPlazo.Text != "0" || txtPlazo.Text != "")
            {
                dtpFinContrato.Value = dtpInicioContrato.Value.AddMonths(int.Parse(txtPlazo.Text));
                dtpFechaRenovacion.Value = dtpFinContrato.Value.AddDays(-30);
            }
        }

        private void btnBuscaPropiedad_Click(object sender, EventArgs e)
        {

        }

        private void txtMontoMora_TextChanged(object sender, EventArgs e)
        {
            if (!txtMontoMora.Text.Equals(string.Empty))
            {
                double numero = Convert.ToDouble(txtMontoMora.Text);
                txtMontoMora.Text = numero.ToString("N0");
                txtMontoMora.SelectionStart = txtMontoMora.TextLength;
            }
        }

        private void txtMontoMora_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void txtMontoMora_Leave(object sender, EventArgs e)
        {
            if (txtMontoMora.Text == "")
            {
                txtMontoMora.Text = "0";
            }
        }

        private void txtPrecio_Click(object sender, EventArgs e)
        {
            //txtPrecio.SelectAll();
        }

        private void txtPrecio_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrecio.SelectAll();
        }

        private void txtPlazo_MouseClick(object sender, MouseEventArgs e)
        {
            txtPlazo.SelectAll();
        }

        private void txtGarantia_MouseClick(object sender, MouseEventArgs e)
        {
            txtGarantia.SelectAll();
        }

        private void txtMontoMora_MouseClick(object sender, MouseEventArgs e)
        {
            txtMontoMora.SelectAll();
        }

        private void txtDiaGracia_MouseClick(object sender, MouseEventArgs e)
        {
            txtDiaGracia.SelectAll();
        }

        private void dtpFechaOperacion_ValueChanged(object sender, EventArgs e)
        {
            dtpInicioContrato.Value = dtpFechaOperacion.Value;
        }

        private void txtPlazo_TextChanged(object sender, EventArgs e)
        {
            if (txtPlazo.Text != "0" && txtPlazo.Text != "")
            {
                dtpFinContrato.Value = dtpInicioContrato.Value.AddMonths(int.Parse(txtPlazo.Text));
                dtpFechaRenovacion.Value = dtpFinContrato.Value.AddDays(-30);
            }

        }

        private void btnCrearVendedor_Click(object sender, EventArgs e)
        {
            FrmSociosNegocios frmSociosNegocios = new FrmSociosNegocios(FrmPrincipal, Constantes.Operaciones.NUEVO, Constantes.TiposSociosNegocios.VENDEDOR);
            frmSociosNegocios.ShowDialog();
            //if (DialogResult.OK.Equals(frmSociosNegocios.ShowDialog()))
            //{
            txtVendedor.Text = frmSociosNegocios.Entity.RAZON_SOCIAL;
            txtVendedor.Tag = frmSociosNegocios.Entity.SOCIO_NEGOCIO_ID;
            frmSociosNegocios.Close();
            //}
        }

        private void btnBuscarVendedor_Click(object sender, EventArgs e)
        {

            FrmBuscadorSociosNegocios frmBuscadorSociosNegocios = new FrmBuscadorSociosNegocios(FrmPrincipal, Constantes.TiposSociosNegocios.VENDEDOR);
            frmBuscadorSociosNegocios.Buscar();
            if (DialogResult.OK.Equals(frmBuscadorSociosNegocios.ShowDialog()))
            {
                txtVendedor.Text = frmBuscadorSociosNegocios.Entity.SOCIO_NEGOCIO;
                txtVendedor.Tag = frmBuscadorSociosNegocios.Entity.SOCIO_NEGOCIO_ID;
                frmBuscadorSociosNegocios.Close();
                Activate();
            }
        }

        private void btnLimpiarVendedor_Click(object sender, EventArgs e)
        {
            txtVendedor.Text = string.Empty;
            txtVendedor.Tag = null;
        }

        private void txtPlazo_Leave(object sender, EventArgs e)
        {
            if (txtPlazo.Text == "")
            {
                txtPlazo.Text = "0";
            }
        }

        private void txtDiaGracia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void txtDiaGracia_Leave(object sender, EventArgs e)
        {
            if (txtDiaGracia.Text == "")
            {
                txtDiaGracia.Text = "0";
            }
        }

        private void txtGarantia_Leave(object sender, EventArgs e)
        {
            if (txtGarantia.Text == "")
            {
                txtGarantia.Text = "0";
            }
        }
    }
}
