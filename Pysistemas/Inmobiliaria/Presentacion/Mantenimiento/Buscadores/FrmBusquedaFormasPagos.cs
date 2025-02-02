using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Presentacion.Mantenimiento.Generales;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.Mantenimiento.Buscadores
{
    public partial class FrmBusquedaFormasPagos : Genericos.FrmBuscadorGenerico
    {
        public FrmBusquedaFormasPagos(Principal principal) : base(principal)
        {
            InitializeComponent();
            lblTitulo.Text = string.Empty;
            lblBusqueda.Text = "Búsqueda de Formas de Pagos";
            

            
            ConfiguracionesGrid(dgvFormasPagos);
        }

        protected override void Nuevo()
        {
            FrmFormasPagos frmFormasPagos = new FrmFormasPagos(FrmPrincipal, Constantes.Operaciones.NUEVO);

            if (DialogResult.OK.Equals(frmFormasPagos.ShowDialog()))
            {
                //btnCancelar_Click(null, null);
                PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
            }
            btnCancelar_Click(null, null);
            //btnBuscar_Click(null, null);

        }

        protected override void Editar()
        {
            if (dgvFormasPagos.CurrentRow != null)
            {
                FrmFormasPagos frmFormasPagos = new FrmFormasPagos(FrmPrincipal, Constantes.Operaciones.EDITAR);
                frmFormasPagos.Entity = ObtenerEntity();
                if (DialogResult.OK.Equals(frmFormasPagos.ShowDialog()))
                {

                    PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
                }
                btnCancelar_Click(null, null);
                
            }
        }
        protected override void Buscar()
        {
            btnBuscar_Click(null, null);
        }
        private FORMAS_PAGOS ObtenerEntity()
        {
            Int64 id = Int64.Parse(dgvFormasPagos.CurrentRow.Cells[0].Value.ToString());
            using (FormasPagosDao formaPagoDao = new FormasPagosDao())
            {
                return formaPagoDao.ObtenerDesdePk(id);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            using (BusquedaFormasPagosViewDao formaPagoView = new BusquedaFormasPagosViewDao())
            {
                if (!String.IsNullOrEmpty(txtFormaPago.Text))
                {
                    dgvFormasPagos.DataSource = formaPagoView.ObtenerDesdeFiltros(it => it.FORMA_PAGO.ToUpper().Contains(txtFormaPago.Text.ToUpper()));
                }
                else
                {
                    dgvFormasPagos.DataSource = formaPagoView.ObtenerLista();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtFormaPago.Text = txtFormaPago.Text = String.Empty;
            dgvFormasPagos.DataSource = null;
            dgvFormasPagos.Rows.Clear();
            txtFormaPago.Focus();
            btnBuscar_Click(sender, e);
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            //btnBuscar_Click(sender, e);
        }

        private void dgvFormasPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Editar();
        }

        private void txtFormaPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                btnBuscar_Click(sender, e);
            }
        }

        private void FrmBusquedaFormasPagos_Load(object sender, EventArgs e)
        {
            txtFormaPago.Focus();
            btnBuscar_Click(sender, e);
        }

        private void FrmBusquedaFormasPagos_Shown(object sender, EventArgs e)
        {
            txtFormaPago.Focus();

        }

        private void dgvFormasPagos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Editar();
        }

        private void dgvFormasPagos_MouseClick(object sender, MouseEventArgs e)
        {
            Editar();
        }

        private void txtFormaPago_TextChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void dgvFormasPagos_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvFormasPagos.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
