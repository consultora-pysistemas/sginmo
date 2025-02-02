using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Mantenimiento.Sucursales;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Drawing;
using System.Windows.Forms;
using Inmobiliaria.Presentacion.Inicio;

namespace Inmobiliaria.Presentacion.Mantenimiento.Buscadores
{
    public partial class FrmBusquedaSucursales : Genericos.FrmBuscadorGenerico
    {
        public FrmBusquedaSucursales(Principal frmPrincipal):base(frmPrincipal)
        {
            InitializeComponent();
            lblTitulo.Text = string.Empty;
            lblBusqueda.Text = "Búsqueda de Sucursales";
            ConfiguracionesGrid(dgvSucursales);
        }

        public FrmBusquedaSucursales()
        {
            InitializeComponent();
        }
        protected override void Nuevo()
        {
            FrmSucursales frmSucursal = new FrmSucursales(FrmPrincipal, Constantes.Operaciones.NUEVO);

            if (DialogResult.OK.Equals(frmSucursal.ShowDialog()))
            {
                btnCancelar_Click(null, null);
                PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
            }
            btnBuscar_Click(null, null);
        }

        protected override void Editar()
        {
            if (dgvSucursales.CurrentRow != null)
            {
                FrmSucursales frmSucursal = new FrmSucursales(FrmPrincipal, Constantes.Operaciones.EDITAR);
                frmSucursal.Entity = ObtenerEntity();
                if (DialogResult.OK.Equals(frmSucursal.ShowDialog()))
                {

                    PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
                }
                btnCancelar_Click(null, null);
                btnBuscar_Click(null, null);
            }
        }

        private SUCURSALES ObtenerEntity()
        {
            Int64 id = Int64.Parse(dgvSucursales.CurrentRow.Cells[0].Value.ToString());
            using (SucursalesDao sucursalDao = new SucursalesDao())
            {
                return sucursalDao.ObtenerDesdePk(id);
            }
        }

      

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            using (BusquedaSucursalesViewDao sucursalView = new BusquedaSucursalesViewDao())
            {
                Int64 empresaId = Int64.Parse(FrmPrincipal.Configuraciones
                    .ObtenerValorVariableEntorno(Constantes.VariablesEntorno.EMPRESA_ID).VALOR);
                if (!String.IsNullOrEmpty(txtSucursal.Text))
                {
                   
                    dgvSucursales.DataSource = sucursalView.ObtenerDesdeFiltros(it => it.SUCURSAL.ToUpper().Contains(txtSucursal.Text.ToUpper()) && it.EMPRESA_ID == empresaId);
                }
                else
                {
                    dgvSucursales.DataSource = sucursalView.ObtenerDesdeFiltros(s=>s.EMPRESA_ID == empresaId);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtSucursal.Text = txtSucursal.Text = String.Empty;
            dgvSucursales.DataSource = null;
            dgvSucursales.Rows.Clear();
            txtSucursal.Focus();
            btnBuscar_Click(null, null);
        }

        private void dgvSucursales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Editar();
        }

       

        private void dgvSucursales_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //dgvSucursales_CellContentClick(sender, null);
        }

        private void FrmBusquedaSucursales_Shown(object sender, EventArgs e)
        {
            txtSucursal.Focus();
            btnBuscar_Click(null, null);
        }

        private void txtSucursal_TextChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(null, null);
        }

        private void dgvSucursales_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Editar();
        }

        private void dgvSucursales_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvSucursales.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
