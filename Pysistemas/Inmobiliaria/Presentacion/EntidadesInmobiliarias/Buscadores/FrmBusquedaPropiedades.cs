using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.EntidadesInmobiliarias.Propiedades;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.EntidadesInmobiliarias.Buscadores
{
    public partial class FrmBusquedaPropiedades : Genericos.FrmBuscadorGenerico
    {
        public string TipoPropiedad { get; set; }
        public string TipoLotePropiedad { get; set; }

        public FrmBusquedaPropiedades(String Tipo, Principal frmPrincipal):base(frmPrincipal)
        {
            InitializeComponent();
            lblTitulo.Text = string.Empty;
            TipoPropiedad = Tipo;

            //lblBusqueda.Text = "Búsqueda de Dpto/Casa/Salón/Lote";
            TipoLotePropiedad = "Lote";
            EstablecerTextoTitulo(TipoPropiedad);
            ConfiguracionesGrid(dgvPropiedades);
        }
        private void EstablecerTextoTitulo(String Tipo)
        {
            /*if (Constantes.TiposEntidades.EDIFICIO.Equals(Tipo))
            {
                lblBusqueda.Text = "Búsqueda de Dpto/Casa/Salón";
                lblPropiedad.Text = "Dpto/Casa/Salón:";
                lblTipoEntidad.Text = "Edificio:";
                //TipoLotePropiedad = "DEPARTAMENTO";

            }
            else*/ if (Constantes.TiposEntidades.LOTEAMIENTO.Equals(Tipo))
            {
                lblBusqueda.Text = "Búsqueda de Lotes";
                lblPropiedad.Text = "Lote:";
                lblTipoEntidad.Text = "Loteamiento:";
                //TipoLotePropiedad = "LOTE";
            }
            else
            {
                lblBusqueda.Text = "Búsqueda de Inmuebles";
                //TipoLotePropiedad = "DEPARTAMENTO";
            }
        }
        protected override void Nuevo()
        {
            
            FrmPropiedades frmPropiedades = new FrmPropiedades(FrmPrincipal, Constantes.Operaciones.NUEVO);

            if (DialogResult.OK.Equals(frmPropiedades.ShowDialog()))
            {
                
                PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
            }
            btnCancelar_Click(null, null);

        }

        protected override void Editar()
        {
            
            if (dgvPropiedades.CurrentRow != null)
            {
                FrmPropiedades frmPropiedades = new FrmPropiedades(FrmPrincipal, Constantes.Operaciones.EDITAR);
                
                frmPropiedades.Entity = ObtenerEntity();
                if (Constantes.TiposPropiedades.LOTE.Equals(frmPropiedades.Entity.TIPO))
                {
                    FrmLotes frmLotes = new FrmLotes(FrmPrincipal, Constantes.Operaciones.EDITAR);
                    frmLotes.Entity = frmPropiedades.Entity;
                    if (DialogResult.OK.Equals(frmLotes.ShowDialog()))
                    {

                        PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
                    }
                }
                else
                {
                    if (DialogResult.OK.Equals(frmPropiedades.ShowDialog()))
                    {

                        PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
                    }
                }
                
                btnCancelar_Click(null, null);
            }
            
        }

        private PROPIEDADES ObtenerEntity()
        {
            Int64 id = Int64.Parse(dgvPropiedades.CurrentRow.Cells[0].Value.ToString());
            using (PropiedadesDao propiedadesDao = new PropiedadesDao())
            {
                return propiedadesDao.ObtenerDesdePk(id);
            }

        }

        private void dgvPropiedades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();

        }

        private void dgvPropiedades_MouseClick(object sender, MouseEventArgs e)
        {
            dgvPropiedades_CellContentClick(sender, null);
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(txtPropiedad.Text) && cbUnidadInmobiliaria.SelectedValue == null && String.IsNullOrWhiteSpace(txtCuentaCatastral.Text))
            //    return;
            using (BusquedaPropiedasViewDao propiedadesView = new BusquedaPropiedasViewDao())
            {
                if (!String.IsNullOrEmpty(txtPropiedad.Text))
                {                    
                    dgvPropiedades.DataSource = propiedadesView.ObtenerDesdeFiltros(it => it.PROPIEDAD.ToUpper().Contains(txtPropiedad.Text.ToUpper())).OrderBy(it=>it.PROPIEDAD).ToList();
                    return;
                }
                if(cbUnidadInmobiliaria.SelectedValue != null)
                {
                    Int64 entidadInmobiliariaId = Int64.Parse(cbUnidadInmobiliaria.SelectedValue.ToString());
                    dgvPropiedades.DataSource = propiedadesView.ObtenerDesdeFiltros(it => it.ENTIDAD_INMOBILIARIA_ID == entidadInmobiliariaId).OrderBy(it => it.PROPIEDAD).ToList();
                    return;
                }
                if (!String.IsNullOrEmpty(txtCuentaCatastral.Text))
                {
                    dgvPropiedades.DataSource = propiedadesView.ObtenerDesdeFiltros(it => it.CUENTA_CATASTRAL.ToUpper().Contains(txtCuentaCatastral.Text.ToUpper())).OrderBy(it => it.PROPIEDAD).ToList();
                    return;
                }
                else
                {
                    if (Constantes.TiposEntidades.LOTEAMIENTO.Equals(TipoPropiedad))
                    {
                        dgvPropiedades.DataSource = propiedadesView.ObtenerDesdeFiltros(it => it.TIPO.Equals(TipoLotePropiedad)).OrderBy(it => it.NUMERO_MANZANA).OrderBy(it => it.NUMERO_LOTE).ToList();
                        return;
                    }
                    else
                    {
                        dgvPropiedades.DataSource = propiedadesView.ObtenerDesdeFiltros(it => !it.TIPO.Equals(TipoLotePropiedad)).OrderBy(it=>it.NUMERO_MANZANA).OrderBy(it=>it.NUMERO_LOTE).ToList();
                        return;
                    }
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPropiedad.Text = txtCuentaCatastral.Text = String.Empty;
            ControlesUtilidades.InicializarComboBox(cbUnidadInmobiliaria);
            dgvPropiedades.DataSource = null;
            dgvPropiedades.Rows.Clear();
            cbUnidadInmobiliaria.Focus();

        }

        private void FrmBusquedaPropiedades_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            CargarUnidadesInmobiliarias();
            
        }

        private void CargarUnidadesInmobiliarias()
        {
            using(EntidadesInmobiliariasDao entidadesInmobiliariasDao = new EntidadesInmobiliariasDao())
            {
                if (Constantes.TiposEntidades.LOTEAMIENTO.Equals(TipoPropiedad))
                {
                    cbUnidadInmobiliaria.DataSource = entidadesInmobiliariasDao.ObtenerDesdeFiltros(e => e.TIPO == TipoPropiedad);
                }
                else
                {
                    cbUnidadInmobiliaria.DataSource = entidadesInmobiliariasDao.ObtenerDesdeFiltros(e => e.TIPO != Constantes.TiposEntidades.LOTEAMIENTO);
                }
                
                ControlesUtilidades.InicializarComboBox(cbUnidadInmobiliaria);
            }
            
        }

        private void cbUnidadInmobiliaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                btnBuscar_Click(sender, e);
            }
        }

        private void dgvPropiedades_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == NroItem.Index)
            {
                e.Value = e.RowIndex + 1;
            }
            
        }

        private void dgvPropiedades_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvPropiedades.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }

        private void dgvPropiedades_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvPropiedades.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
