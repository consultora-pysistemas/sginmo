using Inmobiliaria.Modelo.Dao.Mantenimiento;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inmobiliaria.Modelo.Dao.Gastos;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Gastos.Gastos;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Utilidades.Controles;
using Inmobiliaria.Modelo;

namespace Inmobiliaria.Presentacion.Gastos.Buscadores
{
    public partial class FrmBusquedaItemIngresosEgresos : Genericos.FrmBuscadorGenerico
    {
        public FrmBusquedaItemIngresosEgresos(Principal frmPrincipal):base(frmPrincipal)
        {
            InitializeComponent();
            CargarDatos();
            ConfiguracionesGrid(dgvItemIngresoEgreso);
        }

        private void FrmBusquedaItemIngresosEgresos_Load(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            lblBusqueda.Text = "Búsqueda items ingresos/egresos";
        }

        private void FrmBusquedaItemIngresosEgresos_Shown(object sender, EventArgs e)
        {
            txtItem.Focus();
        }
        async void CargarDatos()
        {
            await CargarTiposItems();
            await CargarTiposIngresosEgresos();
        }

        async Task CargarTiposIngresosEgresos()
        {
            using (DominiosDao dominiosDao = new DominiosDao())
            {
                cbTipo.DataSource =
                    dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.TIPOS_GASTOS));

            }
            ControlesUtilidades.InicializarComboBox(cbTipo);
        }

        async Task CargarTiposItems()
        {
            using (DominiosDao dominiosDao = new DominiosDao())
            {
                cbTipoItem.DataSource = dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.TIPO_ITEM_INGR_EGR));

            }
            ControlesUtilidades.InicializarComboBox(cbTipoItem);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtItem.Text = String.Empty;
            ControlesUtilidades.InicializarComboBox(cbTipoItem);
            ControlesUtilidades.InicializarComboBox(cbTipo);
            dgvItemIngresoEgreso.DataSource = null;
            dgvItemIngresoEgreso.Rows.Clear();
            txtItem.Focus();

        }

        private void txtItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char) 13))
            {
                Buscar();
            }
        }

        protected override void Buscar()
        {
            String tipoItem = String.Empty;
            String tipo = String.Empty;

            /*
            if(String.IsNullOrEmpty(txtItem.Text) && cbTipoItem.SelectedValue == null && cbTipo.SelectedValue == null)
            {
                PysistemasMensajes.ShowInfo("Para realizar la búsqueda debe completar criterios");
                return;
            }
            */
            if (cbTipoItem.SelectedValue != null)
            {
                tipoItem = cbTipoItem.SelectedValue.ToString();
            }
            if (cbTipo.SelectedValue != null)
            {
                tipo = cbTipo.SelectedValue.ToString();
            }
            using (ItemsIngresosEgresosDao itemsIngresosEgresosDao = new ItemsIngresosEgresosDao())
            {
                if (!String.IsNullOrWhiteSpace(txtItem.Text) && tipoItem != String.Empty && tipo != String.Empty)
                {
                    dgvItemIngresoEgreso.DataSource =
                        itemsIngresosEgresosDao.ObtenerDesdeFiltros(i => i.ITEM.ToUpper().Contains(txtItem.Text.ToUpper())
                        && i.TIPO_ITEM.Equals(tipoItem) && i.TIPO.Equals(tipo)).OrderBy(i=>i.ITEM).ToString();
                    //return;

                }
                else if (String.IsNullOrWhiteSpace(txtItem.Text) && tipoItem != String.Empty && tipo != String.Empty)
                {
                    dgvItemIngresoEgreso.DataSource =
                        itemsIngresosEgresosDao.ObtenerDesdeFiltros(i => i.TIPO_ITEM.Equals(tipoItem) && i.TIPO.Equals(tipo)).OrderBy(i => i.ITEM).ToString();
                    //return;
                }
                else if (String.IsNullOrWhiteSpace(txtItem.Text) && tipoItem == String.Empty && tipo != String.Empty)
                {
                    dgvItemIngresoEgreso.DataSource =
                        itemsIngresosEgresosDao.ObtenerDesdeFiltros(i => i.TIPO.Equals(tipo)).OrderBy(i => i.ITEM).ToString();
                    //return;
                }
                else if (String.IsNullOrWhiteSpace(txtItem.Text) && tipo == String.Empty && tipoItem != String.Empty)
                {
                    dgvItemIngresoEgreso.DataSource =
                        itemsIngresosEgresosDao.ObtenerDesdeFiltros(i => i.TIPO_ITEM.Equals(tipoItem)).OrderBy(i => i.ITEM).ToString();
                    //return;
                }

                else
                {
                    dgvItemIngresoEgreso.DataSource =
                        itemsIngresosEgresosDao.ObtenerLista().OrderBy(i => i.ITEM).ToString();
                }
                return;    
            }
            




        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        protected override void Nuevo()
        {
            FrmItemIngresoEgreso frmItemIngresoEgreso = new FrmItemIngresoEgreso(FrmPrincipal, Constantes.Operaciones.NUEVO);
            frmItemIngresoEgreso.Show(this);
            Activate();
        }

        protected override void Editar()
        {
            if (dgvItemIngresoEgreso.CurrentRow != null)
            {
                FrmItemIngresoEgreso frmItemIngresoEgreso = new FrmItemIngresoEgreso(FrmPrincipal,Constantes.Operaciones.EDITAR);
                frmItemIngresoEgreso.Entity = ObtenerEntity();
                if (DialogResult.OK.Equals(frmItemIngresoEgreso.ShowDialog(this)))
                {
                    frmItemIngresoEgreso.Close();
                    Activate();
                }
                btnCancelar_Click(null,null);
                
            }
        }

        private ITEMS_INGRESOS_EGRESOS ObtenerEntity()
        {
            if (dgvItemIngresoEgreso.CurrentRow != null)
            {
                Int64 id = Int64.Parse(dgvItemIngresoEgreso.CurrentRow.Cells[0].Value.ToString());
                using (ItemsIngresosEgresosDao itemsIngresosEgresosDao = new ItemsIngresosEgresosDao())
                {
                    return itemsIngresosEgresosDao.ObtenerDesdePk(id);
                }
            }

            return null;
        }

        private void dgvItemIngresoEgreso_CellContentDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void dgvItemIngresoEgreso_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvItemIngresoEgreso_CellContentDoubleClick(sender,null);
        }

        private void dgvItemIngresoEgreso_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvItemIngresoEgreso.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
