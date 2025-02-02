using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Dao.IngresosEgresos;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.EntidadesInmobiliarias.Operaciones;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Presentacion.Mantenimiento.Buscadores;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.EntidadesInmobiliarias.Buscadores
{
    public partial class FrmBusquedaLiquidaciones : Genericos.FrmBuscadorGenerico
    {
        public FrmBusquedaLiquidaciones(Principal principal) : base(principal)
        {
            InitializeComponent();

            lblTitulo.Text = string.Empty;
            lblBusqueda.Text = "Búsqueda de Liquidaciones";
            ConfiguracionesGrid(dgvLiquidacion);
        }
        protected override void Nuevo()
        {
            FrmLiquidaciones frmLiquidaciones = new FrmLiquidaciones(FrmPrincipal, Constantes.Operaciones.NUEVO);

            if (DialogResult.OK.Equals(frmLiquidaciones.ShowDialog()))
            {
                PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
            }
        }
        protected override void Editar()
        {

            if (dgvLiquidacion.CurrentRow != null)
            {
                FrmLiquidaciones frmLiquidaciones = new FrmLiquidaciones(FrmPrincipal, Constantes.Operaciones.EDITAR);
                frmLiquidaciones.Cabecera = ObtenerEntity();
                if (DialogResult.OK.Equals(frmLiquidaciones.ShowDialog()))
                {

                    PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
                  

                }
                btnCancelar_Click(null, null);
            }

        }
        private LIQUIDACIONES ObtenerEntity()
        {
            Int64 id = Int64.Parse(dgvLiquidacion.CurrentRow.Cells[0].Value.ToString());
            using (LiquidacionesDao liquidacionesDao = new LiquidacionesDao())
            {
                return liquidacionesDao.ObtenerDesdePk(id);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtSocioNegocio.Text = txtPropiedad.Text = String.Empty;
            ControlesUtilidades.InicializarComboBox(cbUnidadInmobiliaria);
            dgvLiquidacion.DataSource = null;
            dgvLiquidacion.Rows.Clear();
            txtSocioNegocio.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            using (BusquedaLiquidacionesViewDao busquedaLiquidacionesViewDao = new BusquedaLiquidacionesViewDao())
            {
                if (!String.IsNullOrEmpty(txtSocioNegocio.Text))
                {
                    dgvLiquidacion.DataSource = busquedaLiquidacionesViewDao.ObtenerDesdeFiltros(it => it.CLIENTE.ToUpper().Contains(txtSocioNegocio.Text.ToUpper()));
                    return;

                }
                if (!String.IsNullOrWhiteSpace(txtPropiedad.Text))
                {
                    dgvLiquidacion.DataSource = busquedaLiquidacionesViewDao.ObtenerDesdeFiltros(it => it.PROPIEDAD.ToUpper().Contains(txtPropiedad.Text.ToUpper()));
                    return;
                }
                if (cbUnidadInmobiliaria.SelectedValue != null)
                {
                    Int64 entidadInmobiliariaId = Int64.Parse(cbUnidadInmobiliaria.SelectedValue.ToString());
                    if (!String.IsNullOrWhiteSpace(txtPropiedad.Text))
                    {
                        dgvLiquidacion.DataSource = busquedaLiquidacionesViewDao.ObtenerDesdeFiltros(it => it.ENTIDAD_INMOBILIARIA_ID == entidadInmobiliariaId && it.PROPIEDAD.ToUpper().Contains(txtPropiedad.Text.ToUpper()));
                        return;
                    }
                    else
                    {
                        dgvLiquidacion.DataSource = busquedaLiquidacionesViewDao.ObtenerDesdeFiltros(it => it.ENTIDAD_INMOBILIARIA_ID == entidadInmobiliariaId);
                        return;
                    }
                }
                else
                {
                    dgvLiquidacion.DataSource = busquedaLiquidacionesViewDao.ObtenerLista();
                    return;
                }

            }
            
        }

        private void pbBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmBuscadorSociosNegocios frmBuscadorSociosNegocios = new FrmBuscadorSociosNegocios(FrmPrincipal, Constantes.TiposSociosNegocios.INQUILINO);
            if (DialogResult.OK.Equals(frmBuscadorSociosNegocios.ShowDialog()))
            {
                txtSocioNegocio.Text = frmBuscadorSociosNegocios.Entity.SOCIO_NEGOCIO;
                txtSocioNegocio.Tag = frmBuscadorSociosNegocios.Entity.SOCIO_NEGOCIO_ID;
                frmBuscadorSociosNegocios.Close();
            }
        }

        private void txtSocioNegocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                btnBuscar_Click(sender, e);
            }
        }

        private void FrmBusquedaLiquidaciones_Load(object sender, EventArgs e)
        {
            CargarUnidadesInmobiliarias();
        }
        private void CargarUnidadesInmobiliarias()
        {
            using (EntidadesInmobiliariasDao entidadesInmobiliariasDao = new EntidadesInmobiliariasDao())
            {
                cbUnidadInmobiliaria.DataSource = entidadesInmobiliariasDao.ObtenerLista();
                ControlesUtilidades.InicializarComboBox(cbUnidadInmobiliaria);
            }

        }

        private void dgvLiquidacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void dgvLiquidacion_MouseClick(object sender, MouseEventArgs e)
        {
            dgvLiquidacion_CellContentClick(sender, null);
        }

        private void txtPropiedad_TextChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void dgvLiquidacion_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvLiquidacion.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
