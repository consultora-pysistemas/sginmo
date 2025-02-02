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
    public partial class FrmBusquedaBarrios : Genericos.FrmBuscadorGenerico
    {
        public FrmBusquedaBarrios(Principal principal) : base(principal)
        {
            InitializeComponent();
            lblTitulo.Text = string.Empty;
            lblBusqueda.Text = "Búsqueda de Barrios";
            ConfiguracionesGrid(dgvBarrios);
        }
        protected override void Nuevo()
        {
            FrmBarrios frmBarrios = new FrmBarrios(FrmPrincipal, Constantes.Operaciones.NUEVO);

            if (DialogResult.OK.Equals(frmBarrios.ShowDialog()))
            {
                PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
                //frmBarrios.Close();                
                //Activate();
            }
            btnCancelar_Click(null, null);

        }

        protected override void Editar()
        {
            if (dgvBarrios.CurrentRow != null)
            {
                FrmBarrios frmBarrios = new FrmBarrios(FrmPrincipal, Constantes.Operaciones.EDITAR);

                frmBarrios.Entity = ObtenerEntity();
                frmBarrios.BarrioCiudad = ObtenerEntityBarrioCiudad(frmBarrios.Entity.BARRIO_ID);


                frmBarrios.ciudadId = frmBarrios.BarrioCiudad.CIUDAD_ID;
                frmBarrios.departamentoId = ObtenerIdDepartamento(frmBarrios.ciudadId);
                frmBarrios.paisId = ObtenerIdPais(frmBarrios.departamentoId);

                if (DialogResult.OK.Equals(frmBarrios.ShowDialog()))
                {
                    PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");                    
                    //frmBarrios.Close();
                    //Activate();
                }
                btnCancelar_Click(null, null);
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

        private BARRIOS_CIUDADES ObtenerEntityBarrioCiudad(Int64 barrioId)
        {
            Int64 id = Int64.Parse(dgvBarrios.CurrentRow.Cells[1].Value.ToString());
            using (BarriosCiudadesDao barrioCiudadDao = new BarriosCiudadesDao())
            {
                return barrioCiudadDao.ObtenerDesdeFiltros(c=> c.CIUDAD_ID == id && c.BARRIO_ID == barrioId).First();                
            }
            
        }

        private Int64 ObtenerIdDepartamento(Int64 ciudadId)
        {            
            using (CiudadesDepartamentosDao ciudadDepartamentoDao = new CiudadesDepartamentosDao())
            {
                return ciudadDepartamentoDao.ObtenerDesdeFiltros(c => c.CIUDAD_ID == ciudadId).First().DEPARTAMENTO_ID;
            }
        }       

        private BARRIOS ObtenerEntity()
        {
            Int64 id = Int64.Parse(dgvBarrios.CurrentRow.Cells[2].Value.ToString());
            using (BarriosDao barrioDao = new BarriosDao())
            {
                return barrioDao.ObtenerDesdePk(id);
            }
        }

        private void FrmBusquedaBarrios_Load(object sender, EventArgs e)
        {
            txtBarrio.Focus();
        }
        private void FrmBusquedaBarrios_Shown(object sender, EventArgs e)
        {
            txtBarrio.Focus();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(txtBarrio.Text))
            //    return;
            using (BusquedaBarriosCiudadesDao barrioView = new BusquedaBarriosCiudadesDao())
            {
                if (!String.IsNullOrEmpty(txtBarrio.Text))
                {
                    dgvBarrios.DataSource = barrioView.ObtenerDesdeFiltros(it => it.BARRIO.ToUpper().Contains(txtBarrio.Text.ToUpper()));
                }else
                {
                    dgvBarrios.DataSource = barrioView.ObtenerLista();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBarrio.Text = txtBarrio.Text = String.Empty;
            dgvBarrios.DataSource = null;
            dgvBarrios.Rows.Clear();
            txtBarrio.Focus();
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void dgvBarrios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void dgvBarrios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void txtBarrio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                btnBuscar_Click(sender, e);
            }
        }

        private void dgvBarrios_MouseClick(object sender, MouseEventArgs e)
        {
            Editar();
        }
    }
}
