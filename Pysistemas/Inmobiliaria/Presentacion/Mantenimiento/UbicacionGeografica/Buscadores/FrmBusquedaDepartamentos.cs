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
    public partial class FrmBusquedaDepartamentos : Genericos.FrmBuscadorGenerico
    {
        public FrmBusquedaDepartamentos(Principal principal) : base(principal)
        {
            lblTitulo.Text = string.Empty;
            lblBusqueda.Text = "Búsqueda de Departamentos";
            ConfiguracionesGrid(dgvDepartamentos);
            InitializeComponent();
        }
        protected override void Nuevo()
        {
            FrmDepartamentos frmDepto = new FrmDepartamentos(FrmPrincipal, Constantes.Operaciones.NUEVO);

            if (DialogResult.OK.Equals(frmDepto.ShowDialog()))
            {
                PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");                                
                frmDepto.Close();
                //LimpiarBuscador();
                //Activate();
            }
            LimpiarBuscador();

        }

        protected override void Editar()
        {
            if (dgvDepartamentos.CurrentRow != null)
            {
                FrmDepartamentos frmDepto = new FrmDepartamentos(FrmPrincipal, Constantes.Operaciones.EDITAR);

                frmDepto.Entity = ObtenerEntity();
                frmDepto.DepartamentoPaisEntity = ObtenerDeptoPais(frmDepto.Entity.DEPARTAMENTO_ID);
                
                                                 
                frmDepto.paisId = ObtenerIdPais(frmDepto.Entity.DEPARTAMENTO_ID);

                if (DialogResult.OK.Equals(frmDepto.ShowDialog()))
                {

                    PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");                    
                }
                LimpiarBuscador();

            }
        }

        private DEPARTAMENTOS_PAISES ObtenerDeptoPais(Int64 departamentoId)
        {
            using (DepartamentosPaisesDao deptoPaisDao = new DepartamentosPaisesDao())
            {
                return deptoPaisDao.ObtenerDesdeFiltros(c => c.DEPARTAMENTO_ID == departamentoId).First();
            }
        }

        protected override void Buscar()
        {
            btnBuscar_Click(null, null);
        }
        private Int64 ObtenerIdPais(Int64 departamentoId)
        {
            using (DepartamentosPaisesDao departamentoPaisDao = new DepartamentosPaisesDao())
            {
                return departamentoPaisDao.ObtenerDesdeFiltros(c => c.DEPARTAMENTO_ID == departamentoId).First().PAIS_ID;
            }
        }

        private DEPARTAMENTOS ObtenerEntity()
        {
            Int64 id = Int64.Parse(dgvDepartamentos.CurrentRow.Cells[8].Value.ToString());
            using (DepartamentosDao deptoDao = new DepartamentosDao())
            {
                return deptoDao.ObtenerDesdePk(id);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(txtDepartamento.Text))
            //    return;
            using (BusquedaDepartamentosPaisesViewDao deptoPaisView = new BusquedaDepartamentosPaisesViewDao())
            {
                if (!String.IsNullOrEmpty(txtDepartamento.Text))
                {
                    dgvDepartamentos.DataSource = deptoPaisView.ObtenerDesdeFiltros(it => it.DEPARTAMENTO.ToUpper().Contains(txtDepartamento.Text.ToUpper()));
                }else
                {
                    dgvDepartamentos.DataSource = deptoPaisView.ObtenerLista();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarBuscador();
        }

        private void LimpiarBuscador()
        {
            txtDepartamento.Text = txtDepartamento.Text = String.Empty;
            dgvDepartamentos.DataSource = null;
            dgvDepartamentos.Rows.Clear();
            txtDepartamento.Focus();
            //btnBuscar_Click(null,null);
        }

        private void FrmBusquedaDepartamentos_Load(object sender, EventArgs e)
        {
            txtDepartamento.Focus();
        }

        private void FrmBusquedaDepartamentos_Shown(object sender, EventArgs e)
        {
            txtDepartamento.Focus();
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void dgvDepartamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void txtDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                btnBuscar_Click(sender, e);
            }
        }

        private void dgvDepartamentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void dgvDepartamentos_MouseClick(object sender, MouseEventArgs e)
        {
            Editar();
        }
    }
}
