using Inmobiliaria.Utilidades.Controles;
using System;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.Cobros.Cobros
{
    public partial class FrmAgregarDescuento : Inmobiliaria.Presentacion.Genericos.FrmMaestro
    {
        public decimal TotalCobrar  { get; set; }
        public decimal TotalDescuento { get; set; }
        public FrmAgregarDescuento()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FrmAgregarDescuento_Load(object sender, EventArgs e)
        {
            txtDescuento.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Hide();
        }

        private void txtDescuento_MouseClick(object sender, MouseEventArgs e)
        {
            txtDescuento.SelectAll();
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            if (!txtDescuento.Text.Equals(String.Empty))
            {
                double numero = Convert.ToDouble(txtDescuento.Text);
                txtDescuento.Text = numero.ToString("N0");
                txtDescuento.SelectionStart = txtDescuento.TextLength;
            }
        }

        private void FrmAgregarDescuento_Shown(object sender, EventArgs e)
        {
            txtDescuento.Focus();
        }
    }
}
