using System;
using System.Drawing;
using System.Windows.Forms;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Views;

namespace Inmobiliaria.Presentacion.EntidadesInmobiliarias.Buscadores
{
    public partial class FrmBuscadorEntidadesInmobiliarias : Genericos.FrmMaestro
    {
        public ENTIDADES_INMOBILIARIAS Entity { get; set; }

        public FrmBuscadorEntidadesInmobiliarias()
        {
            InitializeComponent();
            ConfiguracionesGrid(dgvSociosNegocios);
            Entity = new ENTIDADES_INMOBILIARIAS();
        }

        private void FrmBuscadorEntidadesInmobiliarias_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Buscador de Edificios/Loteamientos";
        }

        private void dgvSociosNegocios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }

        private void Buscar()
        {


            using (BusquedaEntidadesInmobiliariasViewDao entidadesInmobiliariasViewDao =
                new BusquedaEntidadesInmobiliariasViewDao())
            {
                if (!String.IsNullOrWhiteSpace(txtBusqueda.Text))
                {
                    dgvSociosNegocios.DataSource =
                        entidadesInmobiliariasViewDao.ObtenerDesdeFiltros(e =>
                            e.NOMBRE.ToUpper().Contains(txtBusqueda.Text.ToUpper()));
                    
                    return;
                }
                dgvSociosNegocios.DataSource =
                    entidadesInmobiliariasViewDao.ObtenerLista();

            }

        }


        private void dgvSociosNegocios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Seleccionar();
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                Buscar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            btnClose_Click(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void Seleccionar()
        {
            if (dgvSociosNegocios.CurrentRow != null)
            {
                Int64 entidadInmobiliariaId = Int64.Parse(dgvSociosNegocios.CurrentRow.Cells[0].Value.ToString());
                using (EntidadesInmobiliariasDao entidadesInmobiliariasViewDao =
                    new EntidadesInmobiliariasDao())
                {
                    Entity = entidadesInmobiliariasViewDao.ObtenerDesdePk(entidadInmobiliariaId);
                    DialogResult = DialogResult.OK;
                    Hide();
                }

            }
        }

        private void FrmBuscadorEntidadesInmobiliarias_Shown(object sender, EventArgs e)
        {
            txtBusqueda.Focus();
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char) 13))
            {
                Buscar();
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void dgvSociosNegocios_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            
        }

        private void dgvSociosNegocios_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvSociosNegocios.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}

