using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Views;

namespace Inmobiliaria.Presentacion.EntidadesInmobiliarias.Buscadores
{
    public partial class FrmBuscadorPropiedad : Genericos.FrmMaestro
    {
        public PROPIEDADES Entity { get; set; }
        public FrmBuscadorPropiedad()
        {
            InitializeComponent();
            ConfiguracionesGrid(dgvSociosNegocios);
            Entity = new PROPIEDADES();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            btnClose_Click(sender,e);
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char) 13))
            {
                Buscar();
            }
        }

        private void Buscar()
        {
            using (BusquedaOperacionesPropiedadesViewDao busquedaOperacionesPropiedadesViewDao =
                new BusquedaOperacionesPropiedadesViewDao())
            {
                if (!String.IsNullOrWhiteSpace(txtBusqueda.Text))
                {
                    dgvSociosNegocios.DataSource =
                    busquedaOperacionesPropiedadesViewDao.ObtenerDesdeFiltros(p =>
                        p.PROPIEDAD.ToUpper().Contains(txtBusqueda.Text.ToUpper())).OrderBy(p=>p.PROPIEDAD).ToList();
                }else
                {
                    dgvSociosNegocios.DataSource =
                    busquedaOperacionesPropiedadesViewDao.ObtenerLista().OrderBy(p => p.PROPIEDAD).ToList();
                }
            }
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                Buscar();
            }
        }

        private void dgvSociosNegocios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }

        private void Seleccionar()
        {
            if (dgvSociosNegocios.CurrentRow != null)
            {
                Int64 propiedadId = Int64.Parse(dgvSociosNegocios.CurrentRow.Cells[0].Value.ToString());
                using (PropiedadesDao propiedadesDao = new PropiedadesDao())
                {
                    Entity = propiedadesDao.ObtenerDesdePk(propiedadId);
                    DialogResult = DialogResult.OK;
                    Hide();
                }
            }
        }

        private void FrmBuscadorPropiedad_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Búsqueda de Departamentos/Casas/Dúplex";
        }

        private void FrmBuscadorPropiedad_Shown(object sender, EventArgs e)
        {
            txtBusqueda.Focus();
            Buscar();
        }

        private void dgvSociosNegocios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Seleccionar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            Buscar();
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
