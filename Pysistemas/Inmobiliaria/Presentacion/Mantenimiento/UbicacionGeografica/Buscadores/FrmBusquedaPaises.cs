using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.Mantenimiento.UbicacionGeografica.Buscadores
{
    public partial class FrmBusquedaPaises : Genericos.FrmBuscadorGenerico
    {
        public FrmBusquedaPaises(Principal principal) : base(principal)
        {
            lblTitulo.Text = string.Empty;
            lblBusqueda.Text = "Búsqueda de Paises";
            ConfiguracionesGrid(dgvPaises);
            InitializeComponent();
        }
        protected override void Nuevo()
        {
            FrmPaises frmPaises = new FrmPaises(FrmPrincipal, Constantes.Operaciones.NUEVO);

            if (DialogResult.OK.Equals(frmPaises.ShowDialog()))
            {
                PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
                //frmPaises.Close();
                //btnCancelar_Click(null, null);
                //Activate();
            }
            btnCancelar_Click(null, null);
        }

        protected override void Editar()
        {
            if (dgvPaises.CurrentRow != null)
            {
                FrmPaises frmPaises = new FrmPaises(FrmPrincipal, Constantes.Operaciones.EDITAR);
                frmPaises.Entity = ObtenerEntity();

                if (DialogResult.OK.Equals(frmPaises.ShowDialog()))
                {

                    PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
                    //btnCancelar_Click(null, null);
                    //frmPaises.Close();
                    //Activate();
                }
                btnCancelar_Click(null, null);
            }
        }
        protected override void Buscar()
        {
            btnBuscar_Click(null, null);
        }
        private PAISES ObtenerEntity()
        {
            Int64 id = Int64.Parse(dgvPaises.CurrentRow.Cells[0].Value.ToString());

            using (PaisDao paisDao = new PaisDao())
            {
                return paisDao.ObtenerDesdePk(id);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPais.Text = txtPais.Text = String.Empty;
            dgvPaises.DataSource = null;
            dgvPaises.Rows.Clear();
            txtPais.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(txtPais.Text))
            //    return;
            using (BusquedaPaisesViewDao barrioView = new BusquedaPaisesViewDao())
            {
                if (!String.IsNullOrEmpty(txtPais.Text))
                {
                    dgvPaises.DataSource = barrioView.ObtenerDesdeFiltros(it => it.PAIS.ToUpper().Contains(txtPais.Text.ToUpper()));
                }
                else
                {
                    dgvPaises.DataSource = barrioView.ObtenerLista();
                }
            }
        }

        private void FrmBusquedaPaises_Load(object sender, EventArgs e)
        {
            txtPais.Focus();
        }

        private void FrmBusquedaPaises_Shown(object sender, EventArgs e)
        {
            txtPais.Focus();
        }

        private void txtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                btnBuscar_Click(sender, e);
            }
        }

        private void dgvPaises_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void dgvPaises_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void dgvPaises_MouseClick(object sender, MouseEventArgs e)
        {
            Editar();
        }
    }
}
