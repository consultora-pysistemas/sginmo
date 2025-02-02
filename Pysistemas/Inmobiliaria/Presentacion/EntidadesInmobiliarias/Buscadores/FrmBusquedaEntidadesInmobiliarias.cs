using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.EntidadesInmobiliarias.Entidades;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.EntidadesInmobiliarias.Buscadores
{
    public partial class FrmBusquedaEntidadesInmobiliarias : Genericos.FrmBuscadorGenerico
    {
       
        public FrmBusquedaEntidadesInmobiliarias(Principal principal):base(principal)
        {
            InitializeComponent();
            lblTitulo.Text = string.Empty;
            lblBusqueda.Text = "Búsqueda de Edificios/Loteamientos";
            ConfiguracionesGrid(dgvEntidadesInmobiliarias);
            
        }

        protected override void Nuevo()
        {
            
            FrmEntidadesInmobiliarias frmEntidadInmobiliaria = new FrmEntidadesInmobiliarias(FrmPrincipal, Constantes.Operaciones.NUEVO);

            if (DialogResult.OK.Equals(frmEntidadInmobiliaria.ShowDialog()))
            {
                
                PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
                //frmEntidadInmobiliaria.Close();
                //btnCancelar_Click(null, null);
                //Activate();
            }

            btnCancelar_Click(null, null);
        }

        protected override void Editar()
        {
            
            if (dgvEntidadesInmobiliarias.CurrentRow != null)
            {
                FrmEntidadesInmobiliarias frmEntidadesInmobiliarias = new FrmEntidadesInmobiliarias(FrmPrincipal, Constantes.Operaciones.EDITAR);
                frmEntidadesInmobiliarias.Entity = ObtenerEntity();
                if (DialogResult.OK.Equals(frmEntidadesInmobiliarias.ShowDialog()))
                {

                    PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
                    
                    //frmEntidadesInmobiliarias.Close();
                    //Activate();
                }
                btnCancelar_Click(null, null);
            }
            
        }

        private ENTIDADES_INMOBILIARIAS ObtenerEntity()
        {
            Int64 id = Int64.Parse(dgvEntidadesInmobiliarias.CurrentRow.Cells[0].Value.ToString());
            using (EntidadesInmobiliariasDao entidadInmobiliariaDao = new EntidadesInmobiliariasDao())
            {
                return entidadInmobiliariaDao.ObtenerDesdePk(id);
            }
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }
        protected override void Buscar()
        {
            btnBuscar_Click(null, null);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(txtEntidad.Text) && String.IsNullOrEmpty(txtCuentaCatastral.Text) && String.IsNullOrEmpty(txtNumeroFinca.Text))
            //    return;

            using (BusquedaEntidadesInmobiliariasViewDao entidadInmobiliariaDao = new BusquedaEntidadesInmobiliariasViewDao())
            {
                if (!String.IsNullOrEmpty(txtEntidad.Text))
                {

                    dgvEntidadesInmobiliarias.DataSource = entidadInmobiliariaDao.ObtenerDesdeFiltros(it => it.NOMBRE.ToUpper().Contains(txtEntidad.Text.ToUpper())).OrderBy(it=>it.NOMBRE).ToList();
                    return;
                }

                if (!String.IsNullOrEmpty(txtEntidad.Text) && !String.IsNullOrEmpty(txtNumeroFinca.Text))
                {

                    dgvEntidadesInmobiliarias.DataSource = entidadInmobiliariaDao.ObtenerDesdeFiltros(it => it.NOMBRE.ToUpper().Contains(txtEntidad.Text.ToUpper())
                                                            && it.NUMERO_FINCA.ToUpper().Contains(txtNumeroFinca.Text)).OrderBy(it => it.NOMBRE).ToList();
                    return;
                }

                if (!String.IsNullOrEmpty(txtNumeroFinca.Text))
                {
                    dgvEntidadesInmobiliarias.DataSource = entidadInmobiliariaDao.ObtenerDesdeFiltros(it => it.NUMERO_FINCA.ToUpper().Contains(txtNumeroFinca.Text.ToUpper())).OrderBy(it => it.NOMBRE).ToList();
                    return;

                }
                if (!String.IsNullOrEmpty(txtCuentaCatastral.Text))
                {
                    dgvEntidadesInmobiliarias.DataSource = entidadInmobiliariaDao.ObtenerDesdeFiltros(it => it.CUENTA_CATASTRAL.ToUpper().Contains(txtCuentaCatastral.Text.ToUpper())).OrderBy(it => it.NOMBRE).ToList();
                    return;

                }else
                {
                    dgvEntidadesInmobiliarias.DataSource = entidadInmobiliariaDao.ObtenerLista();
                }

            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtEntidad.Text = txtEntidad.Text = String.Empty;
            txtCuentaCatastral.Text = txtCuentaCatastral.Text = String.Empty;
            dgvEntidadesInmobiliarias.DataSource = null;
            dgvEntidadesInmobiliarias.Rows.Clear();
            txtEntidad.Focus();
        }

        private void dgvEntidadesInmobiliarias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void dgvEntidadesInmobiliarias_MouseClick(object sender, MouseEventArgs e)
        {
            dgvEntidadesInmobiliarias_CellContentClick(sender, null);
        }

        private void pbBuscarPropietario_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCuentaCatastral.Text))
                return;
            using (SociosNegociosDao propietarioDao = new SociosNegociosDao())
            {
                if (!String.IsNullOrEmpty(txtCuentaCatastral.Text))
                {
                    txtCuentaCatastral.Text = 
                        propietarioDao.ObtenerDesdeFiltros(it => it.RAZON_SOCIAL.ToUpper().Contains(txtCuentaCatastral.Text.ToUpper())).ToString();
                }                                
            }
        }

        private void txtNumeroFinca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                Buscar();
            }
        }

        private void FrmBusquedaEntidadesInmobiliarias_Shown(object sender, EventArgs e)
        {
            txtEntidad.Focus();
        }

        private void txtEntidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                btnBuscar_Click(sender, e);
            }
        }

        private void txtCuentaCatastral_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                btnBuscar_Click(sender, e);
            }
        }

        private void txtNumeroFinca_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                btnBuscar_Click(sender, e);
            }
        }

        private void dgvEntidadesInmobiliarias_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvEntidadesInmobiliarias.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
