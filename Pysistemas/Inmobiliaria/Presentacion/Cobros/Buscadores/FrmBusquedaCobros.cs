using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Cobros;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Cobros.Cobros;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Drawing;
using System.Windows.Forms;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Presentacion.Mantenimiento.Buscadores;
using Inmobiliaria.Presentacion.EntidadesInmobiliarias.Buscadores;

namespace Inmobiliaria.Presentacion.Cobros.Buscadores
{
    public partial class FrmBusquedaCobros : Genericos.FrmBuscadorGenerico
    {
        public FrmBusquedaCobros(Principal frmPrincipal):base(frmPrincipal)
        {
            InitializeComponent();
            lblTitulo.Text = string.Empty;
            lblBusqueda.Text = "Búsqueda de Cobros";
            ConfiguracionesGrid(dgvCobros);
        }
        public FrmBusquedaCobros()
        {
            InitializeComponent();
            
        }

        protected override void Nuevo()
        {
            
            FrmCobros frmCobros = new FrmCobros(FrmPrincipal, Constantes.Operaciones.NUEVO);

            if (DialogResult.OK.Equals(frmCobros.ShowDialog(this)))
            {
                btnCancelar_Click(null, null);
                PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
            }
            

        }

        protected override void Editar()
        {
            if (dgvCobros.CurrentRow != null)
            {
                
                FrmCobros frmCobros = new FrmCobros(FrmPrincipal, Constantes.Operaciones.EDITAR);
                frmCobros.Cabecera = ObtenerEntity();
                if (DialogResult.OK.Equals(frmCobros.ShowDialog(this)))
                {

                    PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
                }
                btnCancelar_Click(null, null);
                
            }
        }

        private COBROS ObtenerEntity()
        {
            Int64 id = Int64.Parse(dgvCobros.CurrentRow.Cells[0].Value.ToString());
            using (CobrosDao cobrosDao = new CobrosDao())
            {
                return cobrosDao.ObtenerDesdePk(id);
            }

        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {            
            FrmBuscadorSociosNegocios frmBuscadorSociosNegocios = new FrmBuscadorSociosNegocios(FrmPrincipal, Constantes.TiposSociosNegocios.INQUILINO);
            if (DialogResult.OK.Equals(frmBuscadorSociosNegocios.ShowDialog()))
            {
                txtSocioNegocio.Text = frmBuscadorSociosNegocios.Entity.SOCIO_NEGOCIO;
                txtSocioNegocio.Tag = frmBuscadorSociosNegocios.Entity.SOCIO_NEGOCIO_ID;
                frmBuscadorSociosNegocios.Close();

                if (txtSocioNegocio.Tag != null)
                {
                    pbBusquedaPropiedad.Enabled = false;
                }
                else
                {
                    pbBusquedaPropiedad.Enabled = true;
                }
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            using (BusquedaCobrosViewDao cobrosView = new BusquedaCobrosViewDao())
            {
                if (!String.IsNullOrEmpty(txtSocioNegocio.Text) && !String.IsNullOrEmpty(txtNumeroFactura.Text))
                {
                    dgvCobros.DataSource = cobrosView.ObtenerDesdeFiltros(it => it.SOCIO_NEGOCIO.ToUpper().Contains(txtSocioNegocio.Text.ToUpper()) && it.NUMERO_FACTURA.Contains(txtNumeroFactura.Text));
                }else if (!String.IsNullOrEmpty(txtSocioNegocio.Text) && String.IsNullOrEmpty(txtNumeroFactura.Text))
                {
                    dgvCobros.DataSource = cobrosView.ObtenerDesdeFiltros(it => it.SOCIO_NEGOCIO.ToUpper().Contains(txtSocioNegocio.Text.ToUpper()));
                }
                else if (String.IsNullOrEmpty(txtSocioNegocio.Text) && !String.IsNullOrEmpty(txtNumeroFactura.Text))
                {
                    dgvCobros.DataSource = cobrosView.ObtenerDesdeFiltros(it => it.NUMERO_FACTURA.Contains(txtNumeroFactura.Text.ToUpper()));
                }

                else
                {
                    dgvCobros.DataSource = cobrosView.ObtenerLista();
                }
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtSocioNegocio.Text = txtPropiedades.Text = txtNumeroFactura.Text = String.Empty;
            dgvCobros.DataSource = null;
            dgvCobros.Rows.Clear();
            txtSocioNegocio.Focus();
            pbBuscar.Enabled = true;
            pbBusquedaPropiedad.Enabled = true;
        }

        private void dgvCobros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void dgvCobros_MouseClick(object sender, MouseEventArgs e)
        {
            dgvCobros_CellContentClick(sender, null);
        }       

        private void txtNumeroFactura_TextChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(sender,e);
        }

        private void pbBusquedaPropiedad_Click(object sender, EventArgs e)
        {
            FrmBuscadorPropiedad frmBuscadorPropiedad = new FrmBuscadorPropiedad();
            
            if (DialogResult.OK.Equals(frmBuscadorPropiedad.ShowDialog()))
            {
                txtPropiedades.Text = frmBuscadorPropiedad.Entity.NOMBRE;
                txtPropiedades.Tag = frmBuscadorPropiedad.Entity.PROPIEDAD_ID;
                frmBuscadorPropiedad.Close();
                if (txtPropiedades.Tag != null)
                {
                    pbBuscar.Enabled = false;
                }
                else
                {
                    pbBuscar.Enabled = true;
                }
            }
        }

        private void dgvCobros_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvCobros.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
