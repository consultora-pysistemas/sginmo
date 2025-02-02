using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Cobros;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Dao.Gastos;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Services.Cobros;

namespace Inmobiliaria.Presentacion.EntidadesInmobiliarias.Operaciones
{
    public partial class FrmPlantillaLiquidacion : Inmobiliaria.Presentacion.Genericos.FrmMaestro
    {
        public List<LIQUIDACIONES_DETALLES_ITEMS> listaItemsPlantilla { get; set; }
        public OPERACIONES_PROPIEDADES OperacionPropiedad { get; set; }
        public DateTime FechaLiquidacion { get; set; }
        public String UsuarioLogueado { get; set; }
        public FrmPlantillaLiquidacion()
        {
            InitializeComponent();
            txtAlquileresPendientes.LostFocus += TxtAlquileresPendientes_LostFocus;
            txtCerrajeria.LostFocus += TxtAlquileresPendientes_LostFocus;
            txtMateriales.LostFocus += TxtAlquileresPendientes_LostFocus;
            txtManoObra.LostFocus += TxtAlquileresPendientes_LostFocus;
            txtAnde.LostFocus += TxtAlquileresPendientes_LostFocus;
            txtAdministrativos.LostFocus += TxtAlquileresPendientes_LostFocus;
            txtLimpieza.LostFocus += TxtAlquileresPendientes_LostFocus;
            txtMora.LostFocus += TxtAlquileresPendientes_LostFocus;


            txtAlquileresPendientes.GotFocus += TxtAlquileresPendientes_GotFocus; ;
            txtCerrajeria.LostFocus += TxtAlquileresPendientes_GotFocus;
            txtMateriales.LostFocus += TxtAlquileresPendientes_GotFocus;
            txtManoObra.LostFocus += TxtAlquileresPendientes_GotFocus;
            txtAnde.LostFocus += TxtAlquileresPendientes_GotFocus;
            txtAdministrativos.LostFocus += TxtAlquileresPendientes_GotFocus;
            txtLimpieza.LostFocus += TxtAlquileresPendientes_GotFocus;
            txtMora.LostFocus += TxtAlquileresPendientes_GotFocus;

            listaItemsPlantilla = new List<LIQUIDACIONES_DETALLES_ITEMS>();
            OperacionPropiedad = new OPERACIONES_PROPIEDADES();
            FechaLiquidacion = DateTime.Now;
        }

        private void TxtAlquileresPendientes_GotFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            
        }

        private void TxtAlquileresPendientes_LostFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox) sender;
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = "0";
            }
            else
            {
                tb.Text = String.Format(tb.Text, "N0");
            }

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            Decimal total = 0;
            Decimal alquileresPendientes = Decimal.Parse(txtAlquileresPendientes.Text);
            Decimal cerrajeria = Decimal.Parse(txtCerrajeria.Text); 
            Decimal materiales = Decimal.Parse(txtMateriales.Text); 
            Decimal manoObra = Decimal.Parse(txtManoObra.Text); 
            Decimal ande = Decimal.Parse(txtAnde.Text); 
            Decimal administrativo = Decimal.Parse(txtAdministrativos.Text); 
            Decimal limpieza = Decimal.Parse(txtLimpieza.Text);
            Decimal mora = Decimal.Parse(txtMora.Text);
            total = alquileresPendientes + cerrajeria + materiales + manoObra + ande + administrativo + limpieza+mora;
            lblTotal.Text = total.ToString("N0");


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender,e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Decimal alquileresPendientes = Decimal.Parse(txtAlquileresPendientes.Text);
            Decimal cerrajeria = Decimal.Parse(txtCerrajeria.Text);
            Decimal materiales = Decimal.Parse(txtMateriales.Text);
            Decimal manoObra = Decimal.Parse(txtManoObra.Text);
            Decimal ande = Decimal.Parse(txtAnde.Text);
            Decimal administrativo = Decimal.Parse(txtAdministrativos.Text);
            Decimal limpieza = Decimal.Parse(txtLimpieza.Text);
            Decimal mora = Decimal.Parse(txtMora.Text);
            if (alquileresPendientes > 0)
            {
                LIQUIDACIONES_DETALLES_ITEMS item = new LIQUIDACIONES_DETALLES_ITEMS();
                using (ItemsIngresosEgresosDao itemsIngresosEgresosDao = new ItemsIngresosEgresosDao())
                {
                    String app = txtAlquileresPendientes.Tag.ToString();
                    ITEMS_INGRESOS_EGRESOS itemsIngresosEgresos = itemsIngresosEgresosDao
                        .ObtenerDesdeFiltros(i => i.APLICACION.Equals(app)).ToList().SingleOrDefault();
                    item.FECHA_CREACION = DateTime.Now;
                    item.ITEM_INGRESO_EGRESO_ID = itemsIngresosEgresos.ITEM_INGRESO_EGRESO_ID;
                    item.ITEM = itemsIngresosEgresos.ITEM;
                    item.MONTO = alquileresPendientes;
                    item.NUMERO_ITEM = listaItemsPlantilla.Count + 1;
                    item.USUARIO_CREACION = UsuarioLogueado;
                    listaItemsPlantilla.Add(item);
                }
            }

            if (cerrajeria > 0)
            {
                LIQUIDACIONES_DETALLES_ITEMS item = new LIQUIDACIONES_DETALLES_ITEMS();
                using (ItemsIngresosEgresosDao itemsIngresosEgresosDao = new ItemsIngresosEgresosDao())
                {
                    String app = txtCerrajeria.Tag.ToString();
                    ITEMS_INGRESOS_EGRESOS itemsIngresosEgresos = itemsIngresosEgresosDao
                        .ObtenerDesdeFiltros(i => i.APLICACION.Equals(app)).ToList().SingleOrDefault();
                    item.FECHA_CREACION = DateTime.Now;
                    item.ITEM_INGRESO_EGRESO_ID = itemsIngresosEgresos.ITEM_INGRESO_EGRESO_ID;
                    item.ITEM = itemsIngresosEgresos.ITEM;
                    item.MONTO = cerrajeria;
                    item.NUMERO_ITEM = listaItemsPlantilla.Count + 1;
                    item.USUARIO_CREACION = UsuarioLogueado;
                    listaItemsPlantilla.Add(item);
                }
            }

            if (materiales > 0)
            {
                LIQUIDACIONES_DETALLES_ITEMS item = new LIQUIDACIONES_DETALLES_ITEMS();
                using (ItemsIngresosEgresosDao itemsIngresosEgresosDao = new ItemsIngresosEgresosDao())
                {
                    String app = txtMateriales.Tag.ToString();
                    ITEMS_INGRESOS_EGRESOS itemsIngresosEgresos = itemsIngresosEgresosDao
                        .ObtenerDesdeFiltros(i => i.APLICACION.Equals(app)).ToList().SingleOrDefault();
                    item.FECHA_CREACION = DateTime.Now;
                    item.ITEM_INGRESO_EGRESO_ID = itemsIngresosEgresos.ITEM_INGRESO_EGRESO_ID;
                    item.ITEM = itemsIngresosEgresos.ITEM;
                    item.MONTO = materiales;
                    item.NUMERO_ITEM = listaItemsPlantilla.Count + 1;
                    item.USUARIO_CREACION = UsuarioLogueado;
                    listaItemsPlantilla.Add(item);
                }
            }

            if (manoObra > 0)
            {
                LIQUIDACIONES_DETALLES_ITEMS item = new LIQUIDACIONES_DETALLES_ITEMS();
                using (ItemsIngresosEgresosDao itemsIngresosEgresosDao = new ItemsIngresosEgresosDao())
                {
                    String app = txtManoObra.Tag.ToString();
                    ITEMS_INGRESOS_EGRESOS itemsIngresosEgresos = itemsIngresosEgresosDao
                        .ObtenerDesdeFiltros(i => i.APLICACION.Equals(app)).ToList().SingleOrDefault();
                    item.FECHA_CREACION = DateTime.Now;
                    item.ITEM_INGRESO_EGRESO_ID = itemsIngresosEgresos.ITEM_INGRESO_EGRESO_ID;
                    item.ITEM = itemsIngresosEgresos.ITEM;
                    item.MONTO = manoObra;
                    item.NUMERO_ITEM = listaItemsPlantilla.Count + 1;
                    item.USUARIO_CREACION = UsuarioLogueado;
                    listaItemsPlantilla.Add(item);
                }
            }

            if (ande > 0)
            {
                LIQUIDACIONES_DETALLES_ITEMS item = new LIQUIDACIONES_DETALLES_ITEMS();
                using (ItemsIngresosEgresosDao itemsIngresosEgresosDao = new ItemsIngresosEgresosDao())
                {
                    String app = txtAnde.Tag.ToString();
                    ITEMS_INGRESOS_EGRESOS itemsIngresosEgresos = itemsIngresosEgresosDao
                        .ObtenerDesdeFiltros(i => i.APLICACION.Equals(app)).ToList().SingleOrDefault();
                    item.FECHA_CREACION = DateTime.Now;
                    item.ITEM_INGRESO_EGRESO_ID = itemsIngresosEgresos.ITEM_INGRESO_EGRESO_ID;
                    item.ITEM = itemsIngresosEgresos.ITEM;
                    item.MONTO = ande;
                    item.NUMERO_ITEM = listaItemsPlantilla.Count + 1;
                    item.USUARIO_CREACION = UsuarioLogueado;
                    listaItemsPlantilla.Add(item);
                }
            }

            if (limpieza > 0)
            {
                LIQUIDACIONES_DETALLES_ITEMS item = new LIQUIDACIONES_DETALLES_ITEMS();
                using (ItemsIngresosEgresosDao itemsIngresosEgresosDao = new ItemsIngresosEgresosDao())
                {
                    String app = txtLimpieza.Tag.ToString();
                    ITEMS_INGRESOS_EGRESOS itemsIngresosEgresos = itemsIngresosEgresosDao
                        .ObtenerDesdeFiltros(i => i.APLICACION.Equals(app)).ToList().SingleOrDefault();
                    item.FECHA_CREACION = DateTime.Now;
                    item.ITEM_INGRESO_EGRESO_ID = itemsIngresosEgresos.ITEM_INGRESO_EGRESO_ID;
                    item.ITEM = itemsIngresosEgresos.ITEM;
                    item.MONTO = limpieza;
                    item.NUMERO_ITEM = listaItemsPlantilla.Count + 1;
                    item.USUARIO_CREACION = UsuarioLogueado;
                    listaItemsPlantilla.Add(item);
                }
            }

            if (administrativo > 0)
            {
                LIQUIDACIONES_DETALLES_ITEMS item = new LIQUIDACIONES_DETALLES_ITEMS();
                using (ItemsIngresosEgresosDao itemsIngresosEgresosDao = new ItemsIngresosEgresosDao())
                {
                    String app = txtAdministrativos.Tag.ToString();
                    ITEMS_INGRESOS_EGRESOS itemsIngresosEgresos = itemsIngresosEgresosDao
                        .ObtenerDesdeFiltros(i => i.APLICACION.Equals(app)).ToList().SingleOrDefault();
                    item.FECHA_CREACION = DateTime.Now;
                    item.ITEM_INGRESO_EGRESO_ID = itemsIngresosEgresos.ITEM_INGRESO_EGRESO_ID;
                    item.ITEM = itemsIngresosEgresos.ITEM;
                    item.MONTO = administrativo;
                    item.NUMERO_ITEM = listaItemsPlantilla.Count + 1;
                    item.USUARIO_CREACION = UsuarioLogueado;
                    listaItemsPlantilla.Add(item);
                }
            }
            if (mora > 0)
            {
                LIQUIDACIONES_DETALLES_ITEMS item = new LIQUIDACIONES_DETALLES_ITEMS();
                using (ItemsIngresosEgresosDao itemsIngresosEgresosDao = new ItemsIngresosEgresosDao())
                {
                    String app = txtMora.Tag.ToString();
                    ITEMS_INGRESOS_EGRESOS itemsIngresosEgresos = itemsIngresosEgresosDao
                        .ObtenerDesdeFiltros(i => i.APLICACION.Equals(app)).ToList().SingleOrDefault();
                    item.FECHA_CREACION = DateTime.Now;
                    item.ITEM_INGRESO_EGRESO_ID = itemsIngresosEgresos.ITEM_INGRESO_EGRESO_ID;
                    item.ITEM = itemsIngresosEgresos.ITEM;
                    item.MONTO = mora;
                    item.NUMERO_ITEM = listaItemsPlantilla.Count + 1;
                    item.USUARIO_CREACION = UsuarioLogueado;
                    listaItemsPlantilla.Add(item);
                }
            }
            Hide();
            
        }

        private void FrmPlantillaLiquidacion_Load(object sender, EventArgs e)
        {
            using (CronogramasCuotasDao cronogramasCuotasDao = new CronogramasCuotasDao())
            {
                IList<CRONOGRAMAS_CUOTAS> cuotasPendientes =
                    cronogramasCuotasDao.ObtenerDesdeFiltros(c =>
                        c.ESTADO.Equals(Constantes.EstadosIngresosEgresos.PENDIENTE) && c.OPERACION_PROPIEDAD_ID == OperacionPropiedad.OPERACION_PROPIEDAD_ID);
                Decimal total = cuotasPendientes.Sum(c => c.MONTO);
                txtAlquileresPendientes.Text = total.ToString("N0");
                Decimal montoMora = 0;
                foreach (CRONOGRAMAS_CUOTAS cuota in cuotasPendientes)
                {
                    montoMora = montoMora + CalcularMontoPagar(cuota, FechaLiquidacion);
                }

                txtMora.Text = montoMora.ToString("N0");
                CalcularTotal();
            }
            
        }

        public Decimal CalcularMontoPagar(CRONOGRAMAS_CUOTAS cuota,DateTime fechaLiquidacion)
        {
            Decimal montoMora = 0;
           
           
            
            CalculoDiasMontoMora calculoMontoMora = new CalculoDiasMontoMora();
            OPERACIONES_PROPIEDADES operacionPropiedad = new OPERACIONES_PROPIEDADES();
            using (OperacionesPropiedadesDao operacionesPropiedadesDao = new OperacionesPropiedadesDao())
            {
                operacionPropiedad = operacionesPropiedadesDao.ObtenerDesdePk(cuota.OPERACION_PROPIEDAD_ID);
            }

            calculoMontoMora.diaGracias = operacionPropiedad.DIAS_GRACIA;
            calculoMontoMora.montoMoraDia = operacionPropiedad.MONTO_MORA;
            calculoMontoMora.fechaVencimiento = cuota.FECHA_VENCIMIENTO.AddDays(double.Parse(operacionPropiedad.DIAS_GRACIA.ToString()));
            calculoMontoMora.fechaCobro = fechaLiquidacion ;
            CobrosService service  = new CobrosService();
            calculoMontoMora = service.CalcularMora(calculoMontoMora);
            if (calculoMontoMora.montoMora > 0)
            {
               
                montoMora = calculoMontoMora.montoMora;
            }

            return montoMora;


        }

        private void txtAlquileresPendientes_MouseClick(object sender, MouseEventArgs e)
        {
            txtAlquileresPendientes.SelectAll();
        }

        private void txtCerrajeria_MouseClick(object sender, MouseEventArgs e)
        {
            txtCerrajeria.SelectAll();
        }

        private void txtMateriales_MouseClick(object sender, MouseEventArgs e)
        {
            txtMateriales.SelectAll();
        }

        private void txtManoObra_MouseClick(object sender, MouseEventArgs e)
        {
            txtManoObra.SelectAll();
        }

        private void txtAnde_MouseClick(object sender, MouseEventArgs e)
        {
            txtAnde.SelectAll();
        }

        private void txtAdministrativos_MouseClick(object sender, MouseEventArgs e)
        {
            txtAdministrativos.SelectAll();
        }

        private void txtLimpieza_MouseClick(object sender, MouseEventArgs e)
        {
            txtLimpieza.SelectAll();
        }

        private void txtAlquileresPendientes_TextChanged(object sender, EventArgs e)
        {
            if (!txtAlquileresPendientes.Text.Equals(String.Empty))
            {
                double numero = Convert.ToDouble(txtAlquileresPendientes.Text);
                txtAlquileresPendientes.Text = numero.ToString("N0");
                txtAlquileresPendientes.SelectionStart = txtAlquileresPendientes.TextLength;
            }
        }

        private void txtMora_TextChanged(object sender, EventArgs e)
        {
            if (!txtMora.Text.Equals(String.Empty))
            {
                double numero = Convert.ToDouble(txtMora.Text);
                txtMora.Text = numero.ToString("N0");
                txtMora.SelectionStart = txtMora.TextLength;
            }
        }

        private void txtCerrajeria_TextChanged(object sender, EventArgs e)
        {
            if (!txtCerrajeria.Text.Equals(String.Empty))
            {
                double numero = Convert.ToDouble(txtCerrajeria.Text);
                txtCerrajeria.Text = numero.ToString("N0");
                txtCerrajeria.SelectionStart = txtCerrajeria.TextLength;
            }
        }

        private void txtMateriales_TextChanged(object sender, EventArgs e)
        {
            if (!txtMateriales.Text.Equals(String.Empty))
            {
                double numero = Convert.ToDouble(txtMateriales.Text);
                txtMateriales.Text = numero.ToString("N0");
                txtMateriales.SelectionStart = txtMateriales.TextLength;
            }
        }

        private void txtManoObra_TextChanged(object sender, EventArgs e)
        {
            if (!txtManoObra.Text.Equals(String.Empty))
            {
                double numero = Convert.ToDouble(txtManoObra.Text);
                txtManoObra.Text = numero.ToString("N0");
                txtManoObra.SelectionStart = txtManoObra.TextLength;
            }
        }

        private void txtAnde_TextChanged(object sender, EventArgs e)
        {
            if (!txtAnde.Text.Equals(String.Empty))
            {
                double numero = Convert.ToDouble(txtAnde.Text);
                txtAnde.Text = numero.ToString("N0");
                txtAnde.SelectionStart = txtAnde.TextLength;
            }
        }

        private void txtAdministrativos_TextChanged(object sender, EventArgs e)
        {
            if (!txtAdministrativos.Text.Equals(String.Empty))
            {
                double numero = Convert.ToDouble(txtAdministrativos.Text);
                txtAdministrativos.Text = numero.ToString("N0");
                txtAdministrativos.SelectionStart = txtAdministrativos.TextLength;
            }
        }

        private void txtLimpieza_TextChanged(object sender, EventArgs e)
        {
            if (!txtLimpieza.Text.Equals(String.Empty))
            {
                double numero = Convert.ToDouble(txtLimpieza.Text);
                txtLimpieza.Text = numero.ToString("N0");
                txtLimpieza.SelectionStart = txtLimpieza.TextLength;
            }
        }

        private void txtMora_MouseClick(object sender, MouseEventArgs e)
        {
            txtMora.SelectAll();

        }
    }
}
