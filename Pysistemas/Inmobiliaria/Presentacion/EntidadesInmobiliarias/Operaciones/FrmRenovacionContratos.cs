using System;
using System.Linq;
using System.Windows.Forms;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Utilidades.Controles;

namespace Inmobiliaria.Presentacion.EntidadesInmobiliarias.Operaciones
{
    public partial class FrmRenovacionContratos : Inmobiliaria.Presentacion.Genericos.FrmMaestro
    {
        public FrmRenovacionContratos(Principal frmPrincipal):base(frmPrincipal)
        {
            InitializeComponent();
            CargarDatos();
            ConfiguracionesGrid(dgvContratosVencidos);
        }

        private void CargarDatos()
        {
            using (OperacionesContratosVencidosDao operacionesContratosVencidosDao =
                new OperacionesContratosVencidosDao())
            {
                dgvContratosVencidos.DataSource = operacionesContratosVencidosDao.ObtenerLista();
            }
        }

        public FrmRenovacionContratos()
        {
            InitializeComponent();
        }

        private void btnRenovarContrato_Click(object sender, EventArgs e)
        {
            using (OperacionesPropiedadesDao operacionesPropiedadesDao = new OperacionesPropiedadesDao())
            {
                if (dgvContratosVencidos.CurrentRow != null)
                {
                    Int64 operacionId = Int64.Parse(dgvContratosVencidos.CurrentRow.Cells[0].Value.ToString());
                    if (!ControlCuotasPendientes(operacionId))
                    {
                        OPERACIONES_PROPIEDADES operacion = operacionesPropiedadesDao.ObtenerDesdePk(operacionId);
                        RenovarContrato(operacion);
                    }
                    else
                    {
                        PysistemasMensajes.ShowAlert("El contrato actual aun tiene cuotas pendientes de cobro, por favor verifique.");
                        
                    }

                }
                
            }
        }
        private bool ControlCuotasPendientes(Int64 OperacionId)
        {
            using (BusquedaCronogramasCuotasViewDao cuotasPendientes = new BusquedaCronogramasCuotasViewDao())
            {
                if (OperacionId > 0)
                {
                    if (cuotasPendientes.ObtenerDesdeFiltros(c => c.OPERACION_PROPIEDAD_ID == OperacionId &&
                    c.ESTADO.Equals("PENDIENTE")).Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            

        }
        private void RenovarContrato(OPERACIONES_PROPIEDADES operacion)
        {
            if (PysistemasMensajes.AskConfirmation("Está seguro que desea renovar el contrato?. Esto finalizará el existente y creará uno nuevo"))
            {
                FrmOperaciones frmOperaciones = new FrmOperaciones(FrmPrincipal, Constantes.Operaciones.NUEVO);
                frmOperaciones.EsRenovacion = true;
                frmOperaciones.dtpFechaOperacion.Value = operacion.FECHA_FIN_CONTRATO.Value.AddDays(1);
                frmOperaciones.dtpInicioContrato.Value = operacion.FECHA_FIN_CONTRATO.Value.AddDays(1);
                frmOperaciones.cbMoneda.SelectedValue = operacion.MONEDA_ID;
                frmOperaciones.cbTipoOperacion.SelectedValue = operacion.TIPO_OPERACION;
                frmOperaciones.cbEntidades.SelectedValue = operacion.ENTIDAD_INMOBILIARIA_ID;
                frmOperaciones.cbEntidades.Enabled = false;
                frmOperaciones.cbCondicion.SelectedValue = operacion.CONDICION_OPERACION;
                using (BusquedaPropiedasViewDao propiedadesDao = new BusquedaPropiedasViewDao())
                {
                   
                    frmOperaciones.cbPropiedades.DataSource = propiedadesDao.ObtenerDesdeFiltros(p =>
                        p.ENTIDAD_INMOBILIARIA_ID == operacion.ENTIDAD_INMOBILIARIA_ID);

                }

                frmOperaciones.cbPropiedades.SelectedValue = operacion.PROPIEDAD_ID;
                frmOperaciones.cbPropiedades.Enabled = false;
                frmOperaciones.txtPlazo.Text = operacion.PLAZO.ToString();
                frmOperaciones.txtGarantia.Text = operacion.GARANTIA.ToString();
                using (BusquedaSociosNegociosViewDao busquedaSociosNegociosViewDao = new BusquedaSociosNegociosViewDao())
                {
                    SOCIOS_NEGOCIOS_VIEW cliente =
                        busquedaSociosNegociosViewDao
                            .ObtenerDesdeFiltros(o => o.SOCIO_NEGOCIO_ID == operacion.SOCIO_NEGOCIO_ID).ToList()
                            .SingleOrDefault();
                    SOCIOS_NEGOCIOS_VIEW vendedor = busquedaSociosNegociosViewDao.ObtenerDesdeFiltros(o => o.SOCIO_NEGOCIO_ID == operacion.VENDEDOR_ID).ToList()
                        .SingleOrDefault(); ;
                    frmOperaciones.txtLocatario.Text = cliente.SOCIO_NEGOCIO;
                    frmOperaciones.txtLocatario.Tag = cliente.SOCIO_NEGOCIO_ID;
                    
                    frmOperaciones.txtVendedor.Text = vendedor.SOCIO_NEGOCIO;
                    frmOperaciones.txtVendedor.Tag = vendedor.SOCIO_NEGOCIO_ID;
                }

                frmOperaciones.cbTipoOperacion.SelectedValue = operacion.TIPO_OPERACION;
                frmOperaciones.cbTiposContratos.SelectedValue = operacion.TIPO_CONTRATO;
                if (DialogResult.OK.Equals(frmOperaciones.ShowDialog()))
                {
                    using (OperacionesPropiedadesDao operacionesPropiedadesDao = new OperacionesPropiedadesDao())
                    {
                        operacion.ESTADO = "FINALIZADO";
                        operacion.USUARIO_MODIFICACION = FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO;
                        operacion.FECHA_MODIFICACION = DateTime.Now;
                        operacion.FECHA_RENOVACION = DateTime.Now;
                        operacionesPropiedadesDao.Actualizar(operacion);
                        operacionesPropiedadesDao.Guardar();
                    }
                    CargarDatos();
                }
            }
        }

        private void btnFinalizarContrato_Click(object sender, EventArgs e)
        {

            using (OperacionesPropiedadesDao operacionesPropiedadesDao = new OperacionesPropiedadesDao())
            {
                if (dgvContratosVencidos.CurrentRow != null)
                {
                    Int64 operacionId = Int64.Parse(dgvContratosVencidos.CurrentRow.Cells[0].Value.ToString());
                    OPERACIONES_PROPIEDADES operacion = operacionesPropiedadesDao.ObtenerDesdePk(operacionId);
                    FrmLiquidaciones frmLiquidaciones = new FrmLiquidaciones(FrmPrincipal, Constantes.Operaciones.NUEVO);
                    frmLiquidaciones.txtOperacion.Tag = operacion.OPERACION_PROPIEDAD_ID;
                    frmLiquidaciones.ObtenerDatosOperacion(operacion);
                    
                    if (DialogResult.OK.Equals(frmLiquidaciones.ShowDialog()))
                    {

                    }

                }

            }

            
        }
    }
}
