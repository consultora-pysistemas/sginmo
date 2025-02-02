using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.IngresosEgresos;
using Inmobiliaria.Modelo.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.IngresosEgresos.Buscadores
{
    public partial class FrmBusquedaIngresosEgresos : Genericos.FrmBuscadorGenerico
    {
        public FrmBusquedaIngresosEgresos()
        {
            InitializeComponent();
            lblTitulo.Text = string.Empty;
            lblBusqueda.Text = "Búsqueda de Ingresos y Egresos";
            ConfiguracionesGrid(dgvIngresosEgresos);

        }

        protected override void Nuevo()
        {
            /*
            FrmIngresosEgresos frmIngresoEgreso = new FrmIngresosEgresos(FrmPrincipal, Constantes.Operaciones.NUEVO);

            if (DialogResult.OK.Equals(frmItemIngresoEgreso.ShowDialog()))
            {
                btnCancelar_Click(null, null);
                PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
            }
            */

        }

        protected override void Editar()
        {
            if (dgvIngresosEgresos.CurrentRow != null)
            {
                /*
                FrmIngresosEgresos frmIngresoEgreso = new FrmIngresosEgresos(FrmPrincipal, Constantes.Operaciones.EDITAR);
                frmIngresoEgreso.Entity = ObtenerEntity();
                if (DialogResult.OK.Equals(frmIngresoEgreso.ShowDialog()))
                {

                    PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
                }
                btnCancelar_Click(null, null);
                */
            }
        }

        private INGRESOS_EGRESOS ObtenerEntity()
        {
            Int64 id = Int64.Parse(dgvIngresosEgresos.CurrentRow.Cells[0].Value.ToString());
            using (IngresosEgresosDao ingresoEgresoDao = new IngresosEgresosDao())
            {
                return ingresoEgresoDao.ObtenerDesdePk(id);
            }

        }

        private void dgvIngresosEgresos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSocioNegocio.Text))
                return;
            using (BusquedaIngresosEgresosViewDao ingresoEgresoDao = new BusquedaIngresosEgresosViewDao())
            {
                if (!String.IsNullOrEmpty(txtSocioNegocio.Text))
                {
                    dgvIngresosEgresos.DataSource = ingresoEgresoDao.ObtenerDesdeFiltros(it => it.SOCIO_NEGOCIO.ToUpper().Contains(txtSocioNegocio.Text.ToUpper()));
                }

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtSocioNegocio.Text = txtSocioNegocio.Text = String.Empty;
            dgvIngresosEgresos.DataSource = null;
            dgvIngresosEgresos.Rows.Clear();
            txtSocioNegocio.Focus();

        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void dgvIngresosEgresos_MouseClick(object sender, MouseEventArgs e)
        {
            dgvIngresosEgresos_CellContentClick(sender, null);
        }

        private void dgvIngresosEgresos_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvIngresosEgresos.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
