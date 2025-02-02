using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.Mantenimiento.UbicacionGeografica.Buscadores
{
    public partial class FrmBusquedaCiudades : Genericos.FrmBuscadorGenerico
    {
        public FrmBusquedaCiudades(Principal principal) : base(principal)
        {
            lblTitulo.Text = string.Empty;
            lblBusqueda.Text = "Búsqueda de Ciudades";
            ConfiguracionesGrid(dgvCiudades);
            InitializeComponent();
        }

        protected override void Nuevo()
        {
            FrmCiudades frmCiudad = new FrmCiudades(FrmPrincipal, Constantes.Operaciones.NUEVO);

            if (DialogResult.OK.Equals(frmCiudad.ShowDialog()))
            {
                PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
             //   frmCiudad.Close();
                
               // Activate();
            }
            btnCancelar_Click(null, null);
        }

        protected override void Editar()
        {
            if (dgvCiudades.CurrentRow != null)
            {
                FrmCiudades frmCiudad = new FrmCiudades(FrmPrincipal, Constantes.Operaciones.EDITAR);

                frmCiudad.Entity = ObtenerEntity();
                frmCiudad.CiudadDepartamento = ObtenerCiudadDepartamentoEntity(frmCiudad.Entity.CIUDAD_ID);
                frmCiudad.departamentoId = frmCiudad.CiudadDepartamento.DEPARTAMENTO_ID;
                frmCiudad.paisId = ObtenerIdPais(frmCiudad.departamentoId);

                if (DialogResult.OK.Equals(frmCiudad.ShowDialog()))
                {

                    PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
                    //btnCancelar_Click(null, null);
                    //frmCiudad.Close();
                    //Activate();
                }
                btnCancelar_Click(null, null);
            }
        }
        protected override void Buscar()
        {
            btnBuscar_Click(null, null);
        }
        private CIUDADES ObtenerEntity()
        {
            Int64 id = Int64.Parse(dgvCiudades.CurrentRow.Cells[2].Value.ToString());
            using (CiudadesDao ciudadDao = new CiudadesDao())
            {
                return ciudadDao.ObtenerDesdePk(id);
            }
        }

        private Int64 ObtenerIdPais(Int64 departamentoId)
        {
            using (DepartamentosPaisesDao departamentoPaisDao = new DepartamentosPaisesDao())
            {
                return departamentoPaisDao.ObtenerDesdeFiltros(c => c.DEPARTAMENTO_ID == departamentoId).First().PAIS_ID;
            }
        }

        private Int64 ObtenerIdDepartamento(Int64 ciudadId)
        {
            using (CiudadesDepartamentosDao ciudadDepartamentoDao = new CiudadesDepartamentosDao())
            {
                return ciudadDepartamentoDao.ObtenerDesdeFiltros(c => c.CIUDAD_ID == ciudadId).First().DEPARTAMENTO_ID;
            }
        }
        private CIUDADES_DEPARTAMENTOS ObtenerCiudadDepartamentoEntity(Int64 ciudadId)
        {
            using (CiudadesDepartamentosDao ciudadDepartamentoDao = new CiudadesDepartamentosDao())
            {
                return ciudadDepartamentoDao.ObtenerDesdeFiltros(c => c.CIUDAD_ID == ciudadId).First();
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(txtCiudad.Text))
            //    return;
            using (BusquedaCiudadesDepartamentosViewDao ciudadView = new BusquedaCiudadesDepartamentosViewDao())
            {
                if (!String.IsNullOrEmpty(txtCiudad.Text))
                {
                    dgvCiudades.DataSource = ciudadView.ObtenerDesdeFiltros(it => it.CIUDAD.ToUpper().Contains(txtCiudad.Text.ToUpper()));
                }else
                {
                    dgvCiudades.DataSource = ciudadView.ObtenerLista();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCiudad.Text = txtCiudad.Text = String.Empty;
            dgvCiudades.DataSource = null;
            dgvCiudades.Rows.Clear();
            txtCiudad.Focus();
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void dgvCiudades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                btnBuscar_Click(sender, e);
            }
        }

        private void FrmBusquedaCiudades_Load(object sender, EventArgs e)
        {
            txtCiudad.Focus();
        }

        private void FrmBusquedaCiudades_Shown(object sender, EventArgs e)
        {
            txtCiudad.Focus();
        }

        private void dgvCiudades_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void dgvCiudades_MouseClick(object sender, MouseEventArgs e)
        {
            Editar();
        }
    }
}
