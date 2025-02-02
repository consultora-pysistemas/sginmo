using System;
using System.Drawing;
using System.Windows.Forms;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Presentacion.Mantenimiento.Empresa;
using Inmobiliaria.Utilidades.Controles;

namespace Inmobiliaria.Presentacion.Mantenimiento.Buscadores
{
    public partial class FrmBusquedaEmpresas : Genericos.FrmBuscadorGenerico
    {
        public FrmBusquedaEmpresas(Principal frmPrincipal):base(frmPrincipal)
        {
            InitializeComponent();
            lblTitulo.Text = string.Empty;
            lblBusqueda.Text = "Búsqueda de Empresas";
            ConfiguracionesGrid(dgvEmpresas);
            tsbtnEliminar.Visible = false;
        }

        public FrmBusquedaEmpresas()
        {
            InitializeComponent();
        }
        protected override void Nuevo()
        {
            FrmEmpresa frmEmpresa = new FrmEmpresa(FrmPrincipal, Constantes.Operaciones.NUEVO);
           
            if (DialogResult.OK.Equals(frmEmpresa.ShowDialog()))
            {
                
                PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
            }
            btnCancelar_Click(null, null);
            Buscar();

        }
        protected override void Editar()
        {
            if (dgvEmpresas.CurrentRow != null)
            {
                FrmEmpresa frmEmpresa = new FrmEmpresa(FrmPrincipal, Constantes.Operaciones.EDITAR);
                frmEmpresa.Entity = ObtenerEntity();
                
                if (DialogResult.OK.Equals(frmEmpresa.ShowDialog()))
                {

                    PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
                }
                else
                {
                    Activate();
                }
                btnCancelar_Click(null, null);
                Buscar();
                
            }
        }

        private EMPRESAS ObtenerEntity()
        {
            Int64 id = Int64.Parse(dgvEmpresas.CurrentRow.Cells[0].Value.ToString());
            using (EmpresasDao empresaDao = new EmpresasDao())
            {
                return empresaDao.ObtenerDesdePk(id);
            }

        }

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtEmpresa.Text = txtEmpresa.Text = String.Empty;
            dgvEmpresas.DataSource = null;
            dgvEmpresas.Rows.Clear();
            txtEmpresa.Focus();
            Buscar();
        }

        private void dgvEmpresas_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            //Editar();
        }

        private void dgvEmpresas_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //dgvEmpresas_CellContentClick(sender, null);
            Editar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           Buscar();
            
        }

        private void Buscar()
        {
            using (BusquedaEmpresasViewDao empresasView = new BusquedaEmpresasViewDao())
            {
                if (!String.IsNullOrEmpty(txtEmpresa.Text))
                {
                    dgvEmpresas.DataSource = empresasView.ObtenerDesdeFiltros(it => it.EMPRESA.ToUpper().Contains(txtEmpresa.Text.ToUpper()));
                }
                else
                {
                    dgvEmpresas.DataSource = empresasView.ObtenerLista();
                }
            }
        }

        private void dgvEmpresas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //dgvEmpresas_CellContentClick(sender,null);
        }

        private void FrmBusquedaEmpresas_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void dgvEmpresas_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvEmpresas.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
