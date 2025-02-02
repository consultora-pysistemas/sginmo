using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.EntidadesInmobiliarias.Operaciones;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Presentacion.Mantenimiento.Buscadores;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.EntidadesInmobiliarias.Buscadores
{
    public partial class FrmBusquedaOperaciones : Genericos.FrmBuscadorGenerico
    {
        public FrmBusquedaOperaciones(Principal principal):base(principal)
        {
            InitializeComponent();            
            lblTitulo.Text = string.Empty;
            lblBusqueda.Text = "Búsqueda de Operaciones";
            ConfiguracionesGrid(dgvOperaciones);
            CargarDatos();
        }

        private void CargarDatos()
        {
            cargarComboEstado();
        }

        protected override void Nuevo()
        {
            
            FrmOperaciones frmOperacionesPropiedades = new FrmOperaciones(FrmPrincipal, Constantes.Operaciones.NUEVO);

            if (DialogResult.OK.Equals(frmOperacionesPropiedades.ShowDialog(this)))
            {
                
                PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
            }
            

        }

        protected override void Editar()
        {
            
            if (dgvOperaciones.CurrentRow != null)
            {
                FrmOperaciones frmOperacionesPropiedades = new FrmOperaciones(FrmPrincipal, Constantes.Operaciones.EDITAR);
                frmOperacionesPropiedades.Entity = ObtenerEntity();
                if (DialogResult.OK.Equals(frmOperacionesPropiedades.ShowDialog()))
                {

                    PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
                    
                    //frmOperacionesPropiedades.Close();
                    
                }
                /*
                else
                {
                    frmOperacionesPropiedades.Close();
                    btnCancelar_Click(null, null);
                }
                */
                btnCancelar_Click(null, null);
            }
            
        }

        private OPERACIONES_PROPIEDADES ObtenerEntity()
        {
            Int64 id = Int64.Parse(dgvOperaciones.CurrentRow.Cells[0].Value.ToString());
            using (OperacionesPropiedadesDao operacionesPropiedadesDao = new OperacionesPropiedadesDao())
            {
                return operacionesPropiedadesDao.ObtenerDesdePk(id);
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
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(txtSocioNegocio.Text) && cbUnidadInmobiliaria.SelectedValue == null && String.IsNullOrWhiteSpace(txtPropiedad.Text) )
            //    return;
            String Estado = cbEstadoOperaciones.SelectedValue.ToString();

            using (BusquedaOperacionesPropiedadesViewDao opView = new BusquedaOperacionesPropiedadesViewDao())
            {
                if (!String.IsNullOrEmpty(txtSocioNegocio.Text))
                {
                    if ("TODOS".Equals(Estado))
                    {
                        dgvOperaciones.DataSource = opView.ObtenerDesdeFiltros(it => it.SOCIO_NEGOCIO.ToUpper().Contains(txtSocioNegocio.Text.ToUpper())).OrderBy(it=>it.ENTIDAD_INMOBILIARIA).ThenBy(it=>it.PROPIEDAD).ToList();
                    }else
                    {
                        dgvOperaciones.DataSource = opView.ObtenerDesdeFiltros(it => it.SOCIO_NEGOCIO.ToUpper().Contains(txtSocioNegocio.Text.ToUpper()) 
                        && it.ESTADO == Estado).OrderBy(it => it.ENTIDAD_INMOBILIARIA).ThenBy(it => it.PROPIEDAD).ToList();
                    }
                    return;

                }
                if (!String.IsNullOrWhiteSpace(txtPropiedad.Text))
                {
                    if ("TODOS".Equals(Estado))
                    {
                        dgvOperaciones.DataSource = opView.ObtenerDesdeFiltros(it => it.PROPIEDAD.ToUpper().Contains(txtPropiedad.Text.ToUpper())).OrderBy(it => it.ENTIDAD_INMOBILIARIA).ThenBy(it => it.PROPIEDAD).ToList();
                    }
                    else
                    {
                        dgvOperaciones.DataSource = opView.ObtenerDesdeFiltros(it => it.PROPIEDAD.ToUpper().Contains(txtPropiedad.Text.ToUpper())
                        && it.ESTADO == Estado).OrderBy(it => it.ENTIDAD_INMOBILIARIA).ThenBy(it => it.PROPIEDAD).ToList();
                    }
                        return;
                }
                if(cbUnidadInmobiliaria.SelectedValue != null)
                {
                    Int64 entidadInmobiliariaId = Int64.Parse(cbUnidadInmobiliaria.SelectedValue.ToString());
                    if ("TODOS".Equals(Estado))
                    {
                        dgvOperaciones.DataSource = opView.ObtenerDesdeFiltros(it => it.ENTIDAD_INMOBILIARIA_ID == entidadInmobiliariaId).OrderBy(it => it.ENTIDAD_INMOBILIARIA).ThenBy(it => it.PROPIEDAD).ToList();
                    }
                    else
                    {
                        dgvOperaciones.DataSource = opView.ObtenerDesdeFiltros(it => it.ENTIDAD_INMOBILIARIA_ID == entidadInmobiliariaId
                        && it.ESTADO == Estado).OrderBy(it => it.ENTIDAD_INMOBILIARIA).ThenBy(it => it.PROPIEDAD).ToList();
                    }
                    return;
                }
                else
                {
                    if ("TODOS".Equals(Estado))
                    {

                        dgvOperaciones.DataSource = opView.ObtenerLista().OrderBy(it => it.ENTIDAD_INMOBILIARIA).OrderBy(it => it.PROPIEDAD).ToList(); 
                    }else
                    {
                        dgvOperaciones.DataSource = opView.ObtenerDesdeFiltros(it => it.ESTADO == Estado).OrderBy(it => it.ENTIDAD_INMOBILIARIA).ThenBy(it => it.PROPIEDAD).ToList();
                    }
                    return;
                }
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtSocioNegocio.Text = txtPropiedad.Text = String.Empty;
            ControlesUtilidades.InicializarComboBox(cbUnidadInmobiliaria);
            dgvOperaciones.DataSource = null;
            dgvOperaciones.Rows.Clear();
            txtSocioNegocio.Focus();
            cbEstadoOperaciones.SelectedIndex = 1;

        }

        private void dgvOperaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void dgvOperaciones_MouseClick(object sender, MouseEventArgs e)
        {
            dgvOperaciones_CellContentClick(sender, null);
        }

        private void txtSocioNegocio_KeyPress(object sender, KeyPressEventArgs e)
        {          
            if (e.KeyChar == (char)(Keys.Enter))
            {
                btnBuscar_Click(sender, e);
            }
        }

        private void FrmBusquedaOperaciones_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
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

        private void cbUnidadInmobiliaria_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbUnidadInmobiliaria.SelectedIndex > 0)
                btnBuscar_Click(null,null);
        }

        private void txtPropiedad_TextChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void dgvOperaciones_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
            if (dgvOperaciones.Rows.Count > 0 && dgvOperaciones.Columns.Count > 0)
            {
                foreach (DataGridViewRow r in dgvOperaciones.Rows)
                {
                    String Estado = r.Cells["dataGridViewTextBoxColumn15"].Value.ToString();
                    if ("FINALIZADO".Equals(Estado))
                    {
                        r.DefaultCellStyle.BackColor = Color.Red;
                        r.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
            
        }
        private void cargarComboEstado()
        {
            var itemsEstados = new[] {
            new { NOMBRE = "Todos", ESTADO = "TODOS" },
            new { NOMBRE = "Vigente", ESTADO = "VIGENTE" },
            new { NOMBRE = "Finalizado", ESTADO = "FINALIZADO" }
            };
            cbEstadoOperaciones.DataSource = itemsEstados;
            cbEstadoOperaciones.SelectedIndex = 1;
        }

        private void cbEstadoOperaciones_SelectedValueChanged(object sender, EventArgs e)
        {
            //btnBuscar_Click(sender, e);
        }

        private void dgvOperaciones_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvOperaciones.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
