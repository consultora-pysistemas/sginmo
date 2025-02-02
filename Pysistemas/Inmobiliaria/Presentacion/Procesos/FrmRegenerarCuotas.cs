using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Cobros;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.EntidadesInmobiliarias.Operaciones;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Presentacion.ParametrosReportes;
using Inmobiliaria.Reportes;
using Inmobiliaria.Services.EntidadesInmobiliarias;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.Procesos
{
    public partial class FrmRegenerarCuotas : Genericos.FrmMaestro
    {
        public OPERACIONES_PROPIEDADES OperacionPropiedad { get; set; }
        public String Operacion { get; set; }
        public List<CRONOGRAMAS_CUOTAS> Cuotas { get; set; }
        private Decimal totalCuotas = 0;

        private DateTime FechaFinContrato;
        private DateTime FechaRenovacionContrato;

        public FrmRegenerarCuotas(Principal principal, String operacion) : base(principal)
        {
            InitializeComponent();
            OperacionPropiedad = new OPERACIONES_PROPIEDADES();
            Cuotas = new List<CRONOGRAMAS_CUOTAS>();
            ConfiguracionesGrid(dgvCuotas);
            Operacion = operacion;
        }

     
        private void FrmRegenerarCuotas_Load(object sender, EventArgs e)
        {
            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                lblTitulo.Text = "Generar cuotas";
            }
            else
            {
                lblTitulo.Text = "Generar cuotas";
                //btnGenerarCuotas.Visible = false;
                //btnGuardar.Visible = false;
                lnkImprimirCuotas.Visible = true;
                btnRegenerarCuotas.Visible = true;


                CargarCuotas();
            }
            CargarDatos();
        }

        private void CargarCuotas()
        {
            using (CronogramasCuotasDao cronogramaCuotaDao = new CronogramasCuotasDao())
            {
                dgvCuotas.DataSource = cronogramaCuotaDao.ObtenerDesdeFiltros(c => c.OPERACION_PROPIEDAD_ID == OperacionPropiedad.OPERACION_PROPIEDAD_ID);
            }
            List<CRONOGRAMAS_CUOTAS> listaCuotas = dgvCuotas.DataSource as List<CRONOGRAMAS_CUOTAS>;
            if (listaCuotas != null)
            {
                totalCuotas = listaCuotas.Sum(c => c.MONTO);
                lbTotalCuotas.Text = totalCuotas.ToString("N0");
            }
        }

        private void CargarDatos()
        {
            if (OperacionPropiedad != null)
            {
                dtpFechaOperacion.Value = OperacionPropiedad.FECHA_OPERACION;
                lblSucursal.Text = FrmPrincipal.Configuraciones.ObtenerValorVariableEntorno(Constantes.VariablesEntorno.SUCURSAL).VALOR;
                if (OperacionPropiedad.ENTIDAD_INMOBILIARIA_ID != null)
                {
                    using (EntidadesInmobiliariasDao entidadesInmobiliariasDao = new EntidadesInmobiliariasDao())
                    {
                        lblEdificioLoteamiento.Text = entidadesInmobiliariasDao.ObtenerDesdePk(OperacionPropiedad.ENTIDAD_INMOBILIARIA_ID).NOMBRE;

                    }
                }

                using (PropiedadesDao propiedadesDao = new PropiedadesDao())
                {
                    lblDptoCasa.Text = propiedadesDao.ObtenerDesdePk(OperacionPropiedad.PROPIEDAD_ID).NOMBRE;

                    if ("LOTE".Equals(propiedadesDao.ObtenerDesdePk(OperacionPropiedad.PROPIEDAD_ID).TIPO))
                    {
                        lblSocioNegocio.Text = "Comprador:";
                    }


                }

                FechaFinContrato = OperacionPropiedad.FECHA_FIN_CONTRATO.Value;
                FechaRenovacionContrato = OperacionPropiedad.FECHA_RENOVACION.Value;

                lblInicioContrato.Text = OperacionPropiedad.FECHA_INICIO_CONTRATO.ToShortDateString();
                lblFinContrato.Text = OperacionPropiedad.FECHA_FIN_CONTRATO.Value.ToShortDateString();
                lblPrecio.Text = OperacionPropiedad.PRECIO.ToString("N0");
                txtPlazo.Text = OperacionPropiedad.PLAZO.ToString();
                using (SociosNegociosDao sociosNegociosDao = new SociosNegociosDao())
                {
                    lblLocatario.Text = sociosNegociosDao.ObtenerDesdePk(OperacionPropiedad.SOCIO_NEGOCIO_ID).RAZON_SOCIAL;
                }

                if (OperacionPropiedad.TIPO_OPERACION.Equals(Constantes.TiposOperacionesInmuebles.VENTA))
                {
                    lbTotalAPagar.Text = lblPrecio.Text;
                }
                else
                {
                    Decimal TotalAPagar = OperacionPropiedad.PRECIO * Decimal.Parse(OperacionPropiedad.PLAZO.ToString());
                    lbTotalAPagar.Text = TotalAPagar.ToString("N0");
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<CRONOGRAMAS_CUOTAS> lista = dgvCuotas.DataSource as List<CRONOGRAMAS_CUOTAS>;
            if (lista == null || lista.Count == 0)
            {
                PysistemasMensajes.ShowInfo("Para guardar la operación primero debe generar cuotas. Favor genere las cuotas");
                return;
            }else if (!existeDiferenciaEntreSumaYTotal())
            {
                PysistemasMensajes.ShowInfo("La suma de todas las cuotas no coincide con el precio de venta. Por favor verifique.");
                return;
            }
            else
            {
                //Operacion = "R"; //regenerar
                OperacionesService operacionService = new OperacionesService();
                operacionService.GuardarOperacion(lista, OperacionPropiedad, Operacion, FrmPrincipal.UsuarioLogueado);
                PysistemasMensajes.ShowInfo("Los datos se guardaron con éxito");

                // levantamos 
                FrmOperaciones frmOperacionesPropiedades = new FrmOperaciones(FrmPrincipal, Constantes.Operaciones.EDITAR);
                frmOperacionesPropiedades.Entity = OperacionPropiedad;
                frmOperacionesPropiedades.Cuotas = lista;
                frmOperacionesPropiedades.ShowDialog();
                Close();
            }            
            //DialogResult = DialogResult.OK;
            //Hide();
        }

        private bool existeDiferenciaEntreSumaYTotal()
        {
            Decimal CuotasSum = 0;

            List<CRONOGRAMAS_CUOTAS> lista = dgvCuotas.DataSource as List<CRONOGRAMAS_CUOTAS>;
            if (lista != null || lista.Count > 0)
            {
                CuotasSum = lista.Sum(c => c.MONTO);
            }
            if (CuotasSum != OperacionPropiedad.PRECIO && OperacionPropiedad.TIPO_OPERACION.Equals(Constantes.TiposOperacionesInmuebles.VENTA))
            {
                return false;
            }else
            {
                return true;
            }
            
        }

        private void btnGenerarCuotas_Click(object sender, EventArgs e)
        {            

            if (OperacionPropiedad.PLAZO != Int32.Parse(txtPlazo.Text))
            {
                OperacionPropiedad.PLAZO = Int32.Parse(txtPlazo.Text);
                OperacionPropiedad.FECHA_FIN_CONTRATO = DateTime.Parse(lblFinContrato.Text);
                OperacionPropiedad.FECHA_RENOVACION = FechaRenovacionContrato;

            }

            CronogramasCuotasService cronogramaService = new CronogramasCuotasService();
            dgvCuotas.DataSource = cronogramaService.GenerarCuotas(OperacionPropiedad);

            List<CRONOGRAMAS_CUOTAS> listaCuotas = dgvCuotas.DataSource as List<CRONOGRAMAS_CUOTAS>;
            if (listaCuotas != null)
            {
                Decimal totalOperacion = Decimal.Parse(lbTotalAPagar.Text);
                totalCuotas = listaCuotas.Sum(c => c.MONTO);
                Decimal diferencia = totalCuotas - totalOperacion;
                lbTotalCuotas.Text = totalCuotas.ToString("N0");

                if (diferencia != 0)
                {
                    redondearMontoDataGridView(diferencia);
                }
            }

        }
        private void redondearMontoDataGridView(Decimal diferencia)
        {
            if (txtPlazo.Text != "0")
            {
                int index = int.Parse(txtPlazo.Text) - 1;
                foreach (DataGridViewRow row in dgvCuotas.Rows)
                {
                    if (row.Index == index)
                    {
                        if (diferencia > 0)
                            row.Cells["mONTODataGridViewTextBoxColumn"].Value = Decimal.Parse(row.Cells["mONTODataGridViewTextBoxColumn"].Value.ToString()) - diferencia;
                        else
                            row.Cells["mONTODataGridViewTextBoxColumn"].Value = Decimal.Parse(row.Cells["mONTODataGridViewTextBoxColumn"].Value.ToString()) + (diferencia * -1);

                    }
                }
            }
            List<CRONOGRAMAS_CUOTAS> listaCuotas = dgvCuotas.DataSource as List<CRONOGRAMAS_CUOTAS>;
            if (listaCuotas != null)
            {
                totalCuotas = listaCuotas.Sum(c => c.MONTO);
                lbTotalCuotas.Text = totalCuotas.ToString("N0");
            }
        }
        private void generarCuotasDesdeGrid()
        {
          
        }

        private void btnRegenerarCuotas_Click(object sender, EventArgs e)
        {
            if (PysistemasMensajes.AskConfirmation("Esta seguro que desean Regenerar las cuotas? Se borraran todas las cuotas actuales."))
            {
                // limpiar las variables y de los labels de total cuotas
                List<CRONOGRAMAS_CUOTAS> listaCuotas = dgvCuotas.DataSource as List<CRONOGRAMAS_CUOTAS>;
                if (listaCuotas != null)
                {
                    int contadorCancelado = listaCuotas.Count(c => c.ESTADO.Equals(Constantes.EstadosIngresosEgresos.CANCELADO));
                    int contadorAnulado = listaCuotas.Count(c => c.ESTADO.Equals("ANULADO"));
                    if (contadorCancelado > 0 || contadorAnulado > 0)
                    {
                        PysistemasMensajes.ShowAlert("No se pueden generar de vuelta las cuotas porque ya existen cuotas canceladas o anuladas.");
                        return;
                    }
                    else
                    {
                        if (Constantes.Operaciones.EDITAR.Equals(Operacion))
                        {
                            // borrar todas las cuotas actuales, obtener las cuotas en base a la operacion
                            CronogramasCuotasService cronogramaService = new CronogramasCuotasService();
                            cronogramaService.BorrarCuotasParaRegenerar(listaCuotas);
                            
                            totalCuotas = 0;
                            btnGenerarCuotas_Click(null, null);
                            Operacion = "R"; // estamos regenerando las cuotas
                            btnGuardar_Click(null, null);


                        }

                    }


                }
            }
        }

        private void lnkImprimirCuotas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cronograma_cuotas rptCronogramaCuotas = new cronograma_cuotas();
            FrmReporte frmReporte = new FrmReporte();
            frmReporte.lblTitulo.Visible = false;
            
            Int64 operacionId = OperacionPropiedad.OPERACION_PROPIEDAD_ID;

            rptCronogramaCuotas.SetParameterValue("OPERACION_PROPIEDAD_ID_IN", operacionId);
            frmReporte.crystalReportViewer1.ReportSource = rptCronogramaCuotas;
            frmReporte.crystalReportViewer1.Show();
            frmReporte.ShowDialog();
            Activate();
        }

        private void dgvCuotas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
                  

        }

        private void dgvCuotas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dgvCuotas_CellMouseDoubleClick(sender, null);
        }

        private void dgvCuotas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Operacion = "E"; // aqui estamos editando las cuotas
            if (Constantes.Operaciones.EDITAR.Equals(Operacion))
            {
                if (dgvCuotas.CurrentRow != null)
                {
                    String estadoCuota = dgvCuotas.CurrentRow.Cells["eSTADODataGridViewTextBoxColumn"].Value.ToString();
                    if (Constantes.EstadosIngresosEgresos.PENDIENTE.Equals(estadoCuota))
                    {
                        FrmEditarCuotas frmEditarCuotas = new FrmEditarCuotas(Constantes.Operaciones.EDITAR, FrmPrincipal);
                        using (CronogramasCuotasDao cronogramasCuotasDao = new CronogramasCuotasDao())
                        {
                            //Int64 cronogramaCuotaId =
                            Int64 cuotaId = Int64.Parse(dgvCuotas.CurrentRow.Cells[0].Value.ToString());
                            CRONOGRAMAS_CUOTAS cuota = cronogramasCuotasDao.ObtenerDesdePk(cuotaId);
                            frmEditarCuotas.Entity = cuota;
                            if (DialogResult.OK.Equals(frmEditarCuotas.ShowDialog()))
                            {
                                PysistemasMensajes.ShowInfo("Se modificó con éxito la cuota");
                                CargarCuotas();
                                List<CRONOGRAMAS_CUOTAS> listaCuotas = dgvCuotas.DataSource as List<CRONOGRAMAS_CUOTAS>;
                                if (listaCuotas != null)
                                {
                                    Decimal totalOperacion = Decimal.Parse(lbTotalAPagar.Text);
                                    Decimal totalCuotas = listaCuotas.Sum(c => c.MONTO);
                                    Decimal diferencia = totalCuotas - totalOperacion;
                                    lbTotalCuotas.Text = totalCuotas.ToString("N0");
                                    if (diferencia != 0)
                                    {
                                        if (diferencia < 0)
                                            diferencia = diferencia * -1;
                                        PysistemasMensajes.ShowAlert("Atención!!!! Existe diferencia entre monto de operación y monto total de cuotas [DIFERENCIA " + diferencia.ToString("N0") + "] . Favor verifique");
                                        
                                    }
                                }
                            }
                        }

                    }
                }
            }
        }

        private void dgvCuotas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
      
        }

        private void txtPlazo_TextChanged(object sender, EventArgs e)
        {
            if (txtPlazo.Text != "0" && txtPlazo.Text != "")
            {
                lblFinContrato.Text = OperacionPropiedad.FECHA_INICIO_CONTRATO.AddMonths(Int32.Parse(txtPlazo.Text)).ToShortDateString();
                FechaFinContrato = OperacionPropiedad.FECHA_INICIO_CONTRATO.AddMonths(Int32.Parse(txtPlazo.Text));
                FechaRenovacionContrato = FechaFinContrato.AddDays(-30);  
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegenerarCuotasPendientes_Click(object sender, EventArgs e)
        {
            if (PysistemasMensajes.AskConfirmation("Esta seguro que desean Regenerar las cuotas? Se borraran todas las cuotas pendientes."))
            {
                // limpiar las variables y de los labels de total cuotas
                List<CRONOGRAMAS_CUOTAS> listaCuotas = dgvCuotas.DataSource as List<CRONOGRAMAS_CUOTAS>;
                if (listaCuotas != null)
                {
                    int contadorCancelado = listaCuotas.Count(c => c.ESTADO.Equals(Constantes.EstadosIngresosEgresos.CANCELADO));
                    int contadorAnulado = listaCuotas.Count(c => c.ESTADO.Equals("ANULADO"));
                    int contadorTotal = contadorCancelado + contadorAnulado;
                    Decimal totalPendiente = listaCuotas.Where(c => c.ESTADO == Constantes.EstadosIngresosEgresos.PENDIENTE).Sum(c => c.MONTO);

                    OperacionPropiedad.FECHA_INICIO_CONTRATO = OperacionPropiedad.FECHA_INICIO_CONTRATO.AddMonths(contadorTotal);

                    OperacionPropiedad.PLAZO = OperacionPropiedad.PLAZO - contadorTotal;

                    if (Constantes.Operaciones.EDITAR.Equals(Operacion))
                    {
                            // borrar todas las cuotas actuales, obtener las cuotas en base a la operacion
                        CronogramasCuotasService cronogramaService = new CronogramasCuotasService();
                        cronogramaService.RefinanciarCuotas(contadorTotal+1,listaCuotas, OperacionPropiedad);

                        totalCuotas = 0;
                        btnGenerarCuotas_Click(null, null);
                        Operacion = "R"; // estamos regenerando las cuotas
                        btnGuardar_Click(null, null);


                        

                    }


                }
            }
        }
    }
}
