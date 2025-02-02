using System;
using System.Windows.Forms;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Cobros;
using Inmobiliaria.Presentacion.Inicio;

namespace Inmobiliaria.Presentacion.EntidadesInmobiliarias.Operaciones
{
    public partial class FrmEditarCuotas : Inmobiliaria.Presentacion.Genericos.FrmMaestro
    {
        public String Operacion { get; set; }
        public CRONOGRAMAS_CUOTAS Entity { get; set; }
        public FrmEditarCuotas(String operacion,Principal frmPrincipal):base(frmPrincipal)
        {
            InitializeComponent();
            Operacion = operacion;
            Entity = new CRONOGRAMAS_CUOTAS();

        }

        public FrmEditarCuotas()
        {
            InitializeComponent();
        }

        private void FrmEditarCuotas_Load(object sender, EventArgs e)
        {
            txtMontoCuota.Text = Entity.MONTO.ToString("N0");
            dtpFechaOperacion.Value = Entity.FECHA_VENCIMIENTO;
            lblNumeroCuota.Text = Entity.NUMERO_CUOTA.ToString();
            lblEstado.Text = Entity.ESTADO;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (CronogramasCuotasDao cronogramasCuotasDao = new CronogramasCuotasDao())
            {
                Entity.FECHA_VENCIMIENTO = dtpFechaOperacion.Value;
                Entity.MONTO = Decimal.Parse(txtMontoCuota.Text);
                Entity.FECHA_MODIFICACION = DateTime.Now;
                Entity.USUARIO_MODIFICACION = FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO;
                cronogramasCuotasDao.Actualizar(Entity);
                cronogramasCuotasDao.Guardar();
                DialogResult = DialogResult.OK;
                Hide();
            }
        }

        private void txtMontoCuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.Controles.ControlesUtilidades.camposNumericos(e);
        }

        private void txtMontoCuota_TextChanged(object sender, EventArgs e)
        {
            if (!txtMontoCuota.Text.Equals(String.Empty))
            {
                double numero = Convert.ToDouble(txtMontoCuota.Text);
                txtMontoCuota.Text = numero.ToString("N0");
                txtMontoCuota.SelectionStart = txtMontoCuota.TextLength;
            }
        }

        private void txtMontoCuota_MouseClick(object sender, MouseEventArgs e)
        {
            txtMontoCuota.SelectAll();
        }
    }
}
