using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.Mantenimiento.Parametricos
{
    public partial class FrmParametrosSistema : Genericos.FrmMaestro
    {
        public string Operacion { get; set; }
        public DOMINIOS Entity { get; set; }

        private String SueldoMinimo { get; set; }
        private String JornalMinimo { get; set; }
        private String MoraPorDia { get; set; }

        public FrmParametrosSistema(Principal principal, String operacion) : base(principal)
        {
            InitializeComponent();
            Operacion = operacion;
            Entity = new DOMINIOS();
            CargarDatos();
        }

        private void CargarDatos()
        {            
            using (DominiosDao dominio = new DominiosDao())
            {
                txtSalarioMinimo.Text = dominio.ObtenerDesdeFiltros(c => c.CODIGO_DOMINIO.Equals("SUELDO_MINIMO"))[0].VALOR_DOMINIO;
                //dtpFechaInicioVigencia.Text = dominio.ObtenerDesdeFiltros(c => c.CODIGO_DOMINIO.Equals("SUELDO_MINIMO"))[0].FECHA_INICIO_VIGENCIA;
                txtJornalMinimo.Text = dominio.ObtenerDesdeFiltros(c => c.CODIGO_DOMINIO.Equals("JORNAL_MINIMO"))[0].VALOR_DOMINIO;
                txtPorcentajeVenta.Text = dominio.ObtenerDesdeFiltros(c => c.CODIGO_DOMINIO.Equals("PORCENTAJE_COMISION_VENTA"))[0].VALOR_DOMINIO;
                txtPorcentajeAlquiler.Text = dominio.ObtenerDesdeFiltros(c => c.CODIGO_DOMINIO.Equals("PORCENTAJE_COMISION_ALQUILER"))[0].VALOR_DOMINIO;
                txtMontoMoraPorDia.Text = dominio.ObtenerDesdeFiltros(c => c.CODIGO_DOMINIO.Equals("MONTO_MORA_DEFECTO"))[0].VALOR_DOMINIO;
                txtDiasGracia.Text = dominio.ObtenerDesdeFiltros(c => c.CODIGO_DOMINIO.Equals("DIAS_GRACIA_VENCIMIENTO"))[0].VALOR_DOMINIO;

            }
        }

        private void txtSalarioMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void txtJornalMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void txtMontoMoraPorDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void txtDiasGracia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void txtPorcentajeVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void txtPorcentajeAlquiler_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DominiosDao dominio = new DominiosDao())
            {
                try
                {


                    DOMINIOS salario = dominio.ObtenerDesdeFiltros(c => c.CODIGO_DOMINIO.Equals("SUELDO_MINIMO"))[0];

                    SueldoMinimo = txtSalarioMinimo.Text;
                    salario.VALOR_DOMINIO = SueldoMinimo.Replace(".", "");
                    //salario.FECHA_INICIO_VIGENCIA = dtpFechaInicioVigencia.Text;
                    dominio.Actualizar(salario);
                    dominio.Guardar();


                    DOMINIOS jornal = dominio.ObtenerDesdeFiltros(c => c.CODIGO_DOMINIO.Equals("JORNAL_MINIMO"))[0];
                    JornalMinimo = txtJornalMinimo.Text;
                    jornal.VALOR_DOMINIO = JornalMinimo.Replace(".", "");
                    dominio.Actualizar(jornal);
                    dominio.Guardar();

                    DOMINIOS porcentajeVenta = dominio.ObtenerDesdeFiltros(c => c.CODIGO_DOMINIO.Equals("PORCENTAJE_COMISION_VENTA"))[0];
                    porcentajeVenta.VALOR_DOMINIO = txtPorcentajeVenta.Text;
                    dominio.Actualizar(porcentajeVenta);
                    dominio.Guardar();

                    DOMINIOS porcentajeAlquiler = dominio.ObtenerDesdeFiltros(c => c.CODIGO_DOMINIO.Equals("PORCENTAJE_COMISION_ALQUILER"))[0];
                    porcentajeAlquiler.VALOR_DOMINIO = txtPorcentajeAlquiler.Text;
                    dominio.Actualizar(porcentajeAlquiler);
                    dominio.Guardar();

                    DOMINIOS mora = dominio.ObtenerDesdeFiltros(c => c.CODIGO_DOMINIO.Equals("MONTO_MORA_DEFECTO"))[0];
                    MoraPorDia = txtMontoMoraPorDia.Text;
                    mora.VALOR_DOMINIO = MoraPorDia.Replace(".", "");
                    dominio.Actualizar(mora);
                    dominio.Guardar();

                    DOMINIOS gracia = dominio.ObtenerDesdeFiltros(c => c.CODIGO_DOMINIO.Equals("DIAS_GRACIA_VENCIMIENTO"))[0];
                    gracia.VALOR_DOMINIO = txtDiasGracia.Text;
                    dominio.Actualizar(gracia);
                    dominio.Guardar();

                    PysistemasMensajes.ShowInfo("Sus datos han sido guardados con éxito");
                    Close();


                }
                catch (Exception exception)
                {
                    PysistemasMensajes.ShowError(exception.Message);

                }
                

            }
      
        }

        private bool VerificarDatosObligatorios()
        {
            throw new NotImplementedException();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }

        private void txtSalarioMinimo_TextChanged(object sender, EventArgs e)
        {
            if (!txtSalarioMinimo.Text.Equals(String.Empty))
            {                
                double numero = Convert.ToDouble(txtSalarioMinimo.Text);

                //double jornalDiario = numero / 26;
                //txtJornalMinimo.Text = jornalDiario.ToString("N0");

                txtSalarioMinimo.Text = numero.ToString("N0");
                txtSalarioMinimo.SelectionStart = txtSalarioMinimo.TextLength;
            }
        }

        private void txtSalarioMinimo_MouseClick(object sender, MouseEventArgs e)
        {
            txtSalarioMinimo.SelectAll();
        }

        private void txtJornalMinimo_TextChanged(object sender, EventArgs e)
        {
            if (!txtJornalMinimo.Text.Equals(String.Empty))
            {
                double numero = Convert.ToDouble(txtJornalMinimo.Text);
                txtJornalMinimo.Text = numero.ToString("N0");
                txtJornalMinimo.SelectionStart = txtJornalMinimo.TextLength;
            }
        }

        private void txtJornalMinimo_MouseClick(object sender, MouseEventArgs e)
        {
            txtJornalMinimo.SelectAll();
        }

        private void txtMontoMoraPorDia_TextChanged(object sender, EventArgs e)
        {
            if (!txtMontoMoraPorDia.Text.Equals(String.Empty))
            {
                double numero = Convert.ToDouble(txtMontoMoraPorDia.Text);
                txtMontoMoraPorDia.Text = numero.ToString("N0");
                txtMontoMoraPorDia.SelectionStart = txtMontoMoraPorDia.TextLength;
            }
        }

        private void txtMontoMoraPorDia_MouseClick(object sender, MouseEventArgs e)
        {
            txtMontoMoraPorDia.SelectAll();
        }

        private void txtSalarioMinimo_Leave(object sender, EventArgs e)
        {
            
            if (!txtSalarioMinimo.Text.Equals(String.Empty))
            {
                double numero = Convert.ToDouble(txtSalarioMinimo.Text);
                double jornalDiario = numero / 26;
                txtJornalMinimo.Text = jornalDiario.ToString("N0");                
            }
            
        }

        private void txtDiasGracia_MouseClick(object sender, MouseEventArgs e)
        {
            txtDiasGracia.SelectAll();
        }

        private void txtPorcentajeVenta_MouseClick(object sender, MouseEventArgs e)
        {
            txtPorcentajeVenta.SelectAll();
        }

        private void txtPorcentajeAlquiler_MouseClick(object sender, MouseEventArgs e)
        {
            txtPorcentajeAlquiler.SelectAll();
        }
    }
}
