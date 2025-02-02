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
    public partial class FrmBusquedaMonedas : Genericos.FrmBuscadorGenerico
    {
        public FrmBusquedaMonedas(Principal principal) : base(principal)
        {
            InitializeComponent();
            lblTitulo.Text = string.Empty;
            lblBusqueda.Text = "Búsqueda de Monedas";
            ConfiguracionesGrid(dgvMonedas);
            
        }

        protected override void Nuevo()
        {
            FrmMonedas frmMoneda = new FrmMonedas(FrmPrincipal, Constantes.Operaciones.NUEVO);

            if (DialogResult.OK.Equals(frmMoneda.ShowDialog()))
            {
                PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
                //frmMoneda.Close();
                //Activate();
            }
            //btnCancelar_Click(null, null);
            btnBuscar_Click(null,null);

        }

        protected override void Editar()
        {
            if (dgvMonedas.CurrentRow != null)
            {
                FrmMonedas frmMoneda = new FrmMonedas(FrmPrincipal, Constantes.Operaciones.EDITAR);
                frmMoneda.Entity = ObtenerEntity();
                if (DialogResult.OK.Equals(frmMoneda.ShowDialog()))
                {

                    PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
                    
                }
                btnCancelar_Click(null, null);
                //btnBuscar_Click(null, null);

            }
        }

        private MONEDAS ObtenerEntity()
        {
            Int64 id = Int64.Parse(dgvMonedas.CurrentRow.Cells[0].Value.ToString());
            using (MonedasDao monedaDao = new MonedasDao())
            {
                return monedaDao.ObtenerDesdePk(id);
            }
        }

        protected override void Buscar()
        {
            btnBuscar_Click(null, null);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            using (BusquedaMonedasViewDao monedaView = new BusquedaMonedasViewDao())
            {
                if (!String.IsNullOrEmpty(txtMoneda.Text))
                {
                    dgvMonedas.DataSource = monedaView.ObtenerDesdeFiltros(it => it.MONEDA.ToUpper().Contains(txtMoneda.Text.ToUpper()));
                }
                else
                {
                    dgvMonedas.DataSource = monedaView.ObtenerLista();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtMoneda.Text = txtMoneda.Text = String.Empty;
            dgvMonedas.DataSource = null;
            dgvMonedas.Rows.Clear();
            txtMoneda.Focus();
            btnBuscar_Click(null, null);
        }

        private void FrmBusquedaMonedas_Load(object sender, EventArgs e)
        {
            txtMoneda.Focus();
            btnBuscar_Click(null, null);
        }

        private void FrmBusquedaMonedas_Shown(object sender, EventArgs e)
        {
            txtMoneda.Focus();
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void dgvMonedas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Editar();
        }

        private void txtMoneda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                btnBuscar_Click(sender, e);
            }
        }

        private void dgvMonedas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Editar();
            
        }

        private void dgvMonedas_MouseClick(object sender, MouseEventArgs e)
        {
            Editar();
            
        }

        private void txtMoneda_TextChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(null, null);
        }

        private void dgvMonedas_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvMonedas.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
