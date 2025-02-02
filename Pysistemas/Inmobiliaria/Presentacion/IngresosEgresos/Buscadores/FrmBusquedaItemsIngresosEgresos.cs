using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.IngresosEgresos;
using Inmobiliaria.Modelo.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.IngresosEgresos.Buscadores
{
    public partial class FrmBusquedaItemsIngresosEgresos : Genericos.FrmBuscadorGenerico
    {
        public FrmBusquedaItemsIngresosEgresos()
        {
            InitializeComponent();
            lblTitulo.Text = string.Empty;
            lblBusqueda.Text = "Búsqueda de Items de Ingresos y Gastos";
            ConfiguracionesGrid(dgvItemsIngresosEgresos);
        }

        protected override void Nuevo()
        {
            /*
            FrmItemsIngresosEgresos frmItemIngresoEgreso = new FrmItemsIngresosEgresos(FrmPrincipal, Constantes.Operaciones.NUEVO);

            if (DialogResult.OK.Equals(frmItemIngresoEgreso.ShowDialog()))
            {
                btnCancelar_Click(null, null);
                PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
            }
            */

        }

        protected override void Editar()
        {
            if (dgvItemsIngresosEgresos.CurrentRow != null)
            {
                /*
                FrmItemsIngresosEgresos frmItemIngresoEgreso = new FrmItemsIngresosEgresos(FrmPrincipal, Constantes.Operaciones.EDITAR);
                frmItemIngresoEgreso.Entity = ObtenerEntity();
                if (DialogResult.OK.Equals(frmItemIngresoEgreso.ShowDialog()))
                {

                    PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
                }
                btnCancelar_Click(null, null);
                */
            }
        }

        private ITEMS_INGRESOS_EGRESOS ObtenerEntity()
        {
            Int64 id = Int64.Parse(dgvItemsIngresosEgresos.CurrentRow.Cells[0].Value.ToString());
            using (ItemsIngresosEgresosDao itemIngresoEgresoDao = new ItemsIngresosEgresosDao())
            {
                return itemIngresoEgresoDao.ObtenerDesdePk(id);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtItem.Text))
                return;
            using (BusquedaItemsIngresosEgresosViewDao itemIngresoEgreso = new BusquedaItemsIngresosEgresosViewDao())
            {
                if (!String.IsNullOrEmpty(txtItem.Text))
                {
                    dgvItemsIngresosEgresos.DataSource = itemIngresoEgreso.ObtenerDesdeFiltros(it => it.ITEM.ToUpper().Contains(txtItem.Text.ToUpper()));
                }
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtItem.Text = txtItem.Text = String.Empty;
            dgvItemsIngresosEgresos.DataSource = null;
            dgvItemsIngresosEgresos.Rows.Clear();
            txtItem.Focus();
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void dgvItemsItemsIngresosGastos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void dgvItemsItemsIngresosGastos_MouseClick(object sender, MouseEventArgs e)
        {
            dgvItemsItemsIngresosGastos_CellContentClick(sender, null);
        }

        private void dgvItemsIngresosEgresos_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvItemsIngresosEgresos.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
