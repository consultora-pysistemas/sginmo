using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Dao.Usuarios;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Presentacion.Mantenimiento.Usuarios;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.Mantenimiento.Buscadores
{
    public partial class FrmBusquedaUsuarios : Genericos.FrmBuscadorGenerico
    {
        public FrmBusquedaUsuarios(Principal principal) : base(principal)
        {
            InitializeComponent();
            lblTitulo.Text = string.Empty;
            lblBusqueda.Text = "Búsqueda de Usuarios";
            ConfiguracionesGrid(dgvUsuarios);

        }
        protected override void Nuevo()
        {

            FrmUsuarios frmUsuarios = new FrmUsuarios(FrmPrincipal, Constantes.Operaciones.NUEVO);

            if (DialogResult.OK.Equals(frmUsuarios.ShowDialog(this)))
            {

                PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
            }
            btnBuscar_Click(null, null);


        }

        protected override void Editar()
        {

            if (dgvUsuarios.CurrentRow != null)
            {
                FrmUsuarios frmUsuarios = new FrmUsuarios(FrmPrincipal, Constantes.Operaciones.EDITAR);
                frmUsuarios.Entity = ObtenerEntity();
                if (DialogResult.OK.Equals(frmUsuarios.ShowDialog()))
                {

                    PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");

                    
                }
                
                btnCancelar_Click(null, null);
                //btnBuscar_Click(null, null);
            }

        }

        private USUARIOS ObtenerEntity()
        {
            String codigoUsuario = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            using (UsuariosDao usuariosDao = new UsuariosDao())
            {
                return usuariosDao.ObtenerDesdePk(codigoUsuario);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = txtUsuario.Text = String.Empty;
            ControlesUtilidades.InicializarComboBox(cbTipoPerfil);
            dgvUsuarios.DataSource = null;
            dgvUsuarios.Rows.Clear();
            txtUsuario.Focus();
            btnBuscar_Click(null, null);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (BusquedaUsuariosViewDao usuarioViewDao = new BusquedaUsuariosViewDao())
            {
                if (!String.IsNullOrEmpty(txtUsuario.Text))
                {
                    dgvUsuarios.DataSource = usuarioViewDao.ObtenerDesdeFiltros(it => it.CODIGO_USUARIO.ToUpper().Contains(txtUsuario.Text.ToUpper()));
                    return;

                }
                if (cbTipoPerfil.SelectedValue != null)
                {
                    String perfil = cbTipoPerfil.SelectedValue.ToString();
                    dgvUsuarios.DataSource = usuarioViewDao.ObtenerDesdeFiltros(it => it.PERFIL == perfil);

                    return;
                }
                else
                {
                    dgvUsuarios.DataSource = usuarioViewDao.ObtenerLista();
                    return;
                }

            }
        }

        private void FrmBusquedaUsuarios_Load(object sender, EventArgs e)
        {
            CargarPerfilesUsuarios();
            btnBuscar_Click(null, null);
        }

        private void CargarPerfilesUsuarios()
        {
            using (DominiosDao dominiosDao = new DominiosDao())
            {
                cbTipoPerfil.DataSource = dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.TIPOS_PERFILES));
                ControlesUtilidades.InicializarComboBox(cbTipoPerfil);
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Editar();
        }

        private void dgvUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //dgvUsuarios_CellContentClick(sender, null);
            Editar();
        }

        private void cbTipoPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoPerfil.SelectedIndex != -1)
            {
                btnBuscar_Click(null, null);
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(null, null);
        }

        private void dgvUsuarios_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvUsuarios.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
