using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Cobros;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Presentacion.ParametrosReportes;
using Inmobiliaria.Reportes;
using Inmobiliaria.Services.EntidadesInmobiliarias;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.EntidadesInmobiliarias.Operaciones
{
    public partial class FrmVerCronogramasCuotasOperaciones : Genericos.FrmMaestro
    {
        public OPERACIONES_PROPIEDADES OperacionPropiedad { get; set; }
        public String Operacion { get; set; }
        public List<CRONOGRAMAS_CUOTAS> Cuotas { get; set; }
        private Decimal totalCuotas = 0;
        public FrmVerCronogramasCuotasOperaciones(Principal principal,String operacion):base(principal)
        {
            InitializeComponent();
            OperacionPropiedad = new OPERACIONES_PROPIEDADES();
            Cuotas = new List<CRONOGRAMAS_CUOTAS>();
            ConfiguracionesGrid(dgvCuotas);
            Operacion = operacion;
           
        }

        private void FrmVerCronogramasCuotasOperaciones_Load(object sender, EventArgs e)
        {
            if(Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                lblTitulo.Text = "Generar cuotas";
            }
            else
            {
                lblTitulo.Text = "Ver cuotas";
                btnGenerarCuotas.Visible = false;
                //btnGuardar.Visible = false;
                lnkImprimirCuotas.Visible = true;
                //btnRegenerarCuotas.Visible = true;


                CargarCuotas();
            }
            CargarDatos();

        }

        private void CargarCuotas()
        {
            using(CronogramasCuotasDao cronogramaCuotaDao = new CronogramasCuotasDao())
            {
                dgvCuotas.DataSource = cronogramaCuotaDao.ObtenerDesdeFiltros(c => c.OPERACION_PROPIEDAD_ID == OperacionPropiedad.OPERACION_PROPIEDAD_ID);
                Cuotas = dgvCuotas.DataSource as List<CRONOGRAMAS_CUOTAS>;
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
            if(OperacionPropiedad != null)
            {
                dtpFechaOperacion.Value = OperacionPropiedad.FECHA_OPERACION;
                lblSucursal.Text = FrmPrincipal.Configuraciones.ObtenerValorVariableEntorno(Constantes.VariablesEntorno.SUCURSAL).VALOR;
                if(OperacionPropiedad.ENTIDAD_INMOBILIARIA_ID != null)
                {
                    using (EntidadesInmobiliariasDao entidadesInmobiliariasDao = new EntidadesInmobiliariasDao())
                    {
                        lblEdificioLoteamiento.Text = entidadesInmobiliariasDao.ObtenerDesdePk(OperacionPropiedad.ENTIDAD_INMOBILIARIA_ID).NOMBRE;

                    }
                }
               
                using(PropiedadesDao propiedadesDao = new PropiedadesDao())
                {
                    lblDptoCasa.Text = propiedadesDao.ObtenerDesdePk(OperacionPropiedad.PROPIEDAD_ID).NOMBRE;

                    if ("LOTE".Equals(propiedadesDao.ObtenerDesdePk(OperacionPropiedad.PROPIEDAD_ID).TIPO))
                    {
                        lblSocioNegocio.Text = "Comprador:";
                    }


                }

                lblInicioContrato.Text = OperacionPropiedad.FECHA_INICIO_CONTRATO.ToShortDateString();
                lblFinContrato.Text = OperacionPropiedad.FECHA_FIN_CONTRATO.Value.ToShortDateString();
                lblPrecio.Text = OperacionPropiedad.PRECIO.ToString("N0");
                lblPlazo.Text = OperacionPropiedad.PLAZO.ToString();             
                using(SociosNegociosDao sociosNegociosDao = new SociosNegociosDao())
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
            // cargar en Cuotas las cuotas generadas y modificadas en el grid 
            List<CRONOGRAMAS_CUOTAS> lista = dgvCuotas.DataSource as List<CRONOGRAMAS_CUOTAS>;
            if (lista == null || lista.Count == 0)
            {
                PysistemasMensajes.ShowInfo("Para guardar la operación primero debe generar cuotas. Favor genere las cuotas");
                return;
            }
            else if (!existeDiferenciaEntreSumaYTotal())
            {
                PysistemasMensajes.ShowInfo("La suma de todas las cuotas no coincide con el precio de venta. Por favor verifique.");
                return;
            }
            //generarCuotasDesdeGrid();
            DialogResult = DialogResult.OK;
            Hide();
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
            }
            else
            {
                return true;
            }

        }
        private void btnGenerarCuotas_Click(object sender, EventArgs e)
        {
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
                Cuotas = listaCuotas;
            }

        }
        private void redondearMontoDataGridView(Decimal diferencia)
        {
            if (lblPlazo.Text != "0")
            {
                int index = int.Parse(lblPlazo.Text) - 1;
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cuotas = dgvCuotas.DataSource as List<CRONOGRAMAS_CUOTAS>;
            Close();
        }

        private void generarCuotasDesdeGrid()
        {
            // si se va modificar tenemos que borrar todas las cuotas antes de agregar de vuelta en base al nuevo plazo
            
            /*
            List<CRONOGRAMAS_CUOTAS> listaCuotas = dgvCuotas.DataSource as List<CRONOGRAMAS_CUOTAS>;
            if (listaCuotas != null)
            {                
                Cuotas = listaCuotas;
                totalCuotas = listaCuotas.Sum(c => c.MONTO);
                
            }
            
            lbTotalCuotas.Text = totalCuotas.ToString("N0");

       
            // solo controlamos las ventas
            if (totalCuotas != Decimal.Parse(lbTotalAPagar.Text) && OperacionPropiedad.TIPO_OPERACION.Equals(Constantes.TiposOperacionesInmuebles.VENTA))
            {
                PysistemasMensajes.ShowInfo("El monto total de las cuotas no coincide con el precio de la operación");
                return;
            }
            */
        }
        private void lnkImprimirCuotas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cronograma_cuotas rptCronogramaCuotas = new cronograma_cuotas();
            FrmReporte frmReporte = new FrmReporte();
            frmReporte.lblTitulo.Visible = false;

            //Int64 empresaId = FrmPrincipal.Empresa.EMPRESA_ID;
            Int64 operacionId = OperacionPropiedad.OPERACION_PROPIEDAD_ID;
            //rptPagare.SetParameterValue("EMPRESA_ID", empresaId);
            rptCronogramaCuotas.SetParameterValue("OPERACION_PROPIEDAD_ID_IN", operacionId);
            frmReporte.crystalReportViewer1.ReportSource = rptCronogramaCuotas;
            frmReporte.crystalReportViewer1.Show();
            frmReporte.ShowDialog();
            Activate();
        }

        

        private void dgvCuotas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvCuotas.CurrentCell.ColumnIndex == 3)
            {
                Decimal montoModificado = Decimal.Parse(dgvCuotas.CurrentCell.Value.ToString());
                totalCuotas -= montoModificado;
            }

        }

        private void dgvCuotas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvCuotas.DataSource != null && dgvCuotas.RowCount > 0) 
            {
                if (dgvCuotas.CurrentCell.ColumnIndex == 3)
                {
                    Decimal montoModificado = Decimal.Parse(dgvCuotas.CurrentCell.Value.ToString());
                    
                    totalCuotas += montoModificado; 
                    lbTotalCuotas.Text = totalCuotas.ToString("N0");
                }
            }
        }

        private void dgvCuotas_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (dgvCuotas.DataSource != null && dgvCuotas.RowCount > 0)
            {
                if (dgvCuotas.CurrentCell.ColumnIndex == 3)
                {
                    Decimal montoModificado = Decimal.Parse(dgvCuotas.CurrentCell.Value.ToString());
                    totalCuotas += montoModificado;
                    lbTotalCuotas.Text = totalCuotas.ToString("N0");
                }
            }
            */
        }

        private void dgvCuotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvCuotas.DataSource != null && dgvCuotas.RowCount > 0)
            {
                if (dgvCuotas.CurrentCell.ColumnIndex == 3)
                {
                    //Decimal montoModificado = Decimal.Parse(dgvCuotas.CurrentCell.Value.ToString());

                    //dgvCuotas.CurrentCell.Value = montoModificado.ToString("N0");
                    //dgvCuotas.CurrentCell.
                    //totalCuotas += montoModificado;
                    //lbTotalCuotas.Text = totalCuotas.ToString("N0");

                    //double numero = Convert.ToDouble(txtPrecio.Text);
                    //txtPrecio.Text = numero.ToString("N0");
                    //txtPrecio.SelectionStart = txtPrecio.TextLength;
                }
            }
        }

        private void dgvCuotas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCuotas_CellMouseDoubleClick(sender, null);
        }

        private void dgvCuotas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Constantes.Operaciones.EDITAR.Equals(Operacion))
            {
                if (dgvCuotas.CurrentRow != null)
                {
                    String estadoCuota = dgvCuotas.CurrentRow.Cells["eSTADODataGridViewTextBoxColumn"].Value.ToString();
                    if (Constantes.EstadosIngresosEgresos.PENDIENTE.Equals(estadoCuota))
                    {
                        FrmEditarCuotas frmEditarCuotas = new FrmEditarCuotas(Constantes.Operaciones.EDITAR,FrmPrincipal);
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
                                        PysistemasMensajes.ShowAlert("Atención!!!! Existe diferencia entre monto de operación y monto total de cuotas [DIFERENCIA "+diferencia.ToString("N0")+ "] . Favor verifique");
                                    }
                                }
                            }
                        }
                        
                    }
                }    
            }
            Cuotas = dgvCuotas.DataSource as List<CRONOGRAMAS_CUOTAS>;
        }

        private void btnRegenerarCuotas_Click(object sender, EventArgs e)
        {
            /*

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
                            //lbTotalCuotas.Text = "0";
                            totalCuotas = 0;
                            btnGenerarCuotas_Click(null, null);
                            btnGuardar_Click(null, null);
                        }

                    }


                }
            }
            */
        }
    }
}
