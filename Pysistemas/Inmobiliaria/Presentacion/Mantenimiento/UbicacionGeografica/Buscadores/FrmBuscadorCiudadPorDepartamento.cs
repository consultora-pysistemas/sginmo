using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Genericos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.Mantenimiento.UbicacionGeografica.Buscadores
{
    public partial class FrmBuscadorCiudadPorDepartamento : FrmMaestro
    {
        public CIUDADES_DEPARTAMENTOS_VIEW Entity { get; set; }
        public Int64 DepartamentoId;
        public Int64 CiudadId;
        public FrmBuscadorCiudadPorDepartamento(Int64 departamentoId)
        {
            InitializeComponent();
            lblTitulo.Text = "Búsqueda de Ciudades por Departamentos";
            DepartamentoId = departamentoId;

            Entity = new CIUDADES_DEPARTAMENTOS_VIEW();
            ConfiguracionesGrid(dgvCiudadesDepartamentos);
            Buscar();
        }

        private void FrmBuscadorBarrioPorCiudad_Shown(object sender, EventArgs e)
        {
            txtCiudadDepartamento.Focus();
        }

        private void txtCiudadDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                Buscar();
            }
        }

        private void Buscar()
        {
            using (BusquedaCiudadesDepartamentosViewDao busquedaCiudadesView = new BusquedaCiudadesDepartamentosViewDao())
            {
                if (!String.IsNullOrWhiteSpace(txtCiudadDepartamento.Text))
                {
                    dgvCiudadesDepartamentos.DataSource = busquedaCiudadesView.ObtenerDesdeFiltros(s => s.CIUDAD.ToUpper().Contains(txtCiudadDepartamento.Text.ToUpper()) && s.DEPARTAMENTO_ID == DepartamentoId);
                }
                
                else
                {
                    dgvCiudadesDepartamentos.DataSource = busquedaCiudadesView.ObtenerDesdeFiltros(s => s.DEPARTAMENTO_ID == DepartamentoId);
                }
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvCiudadesDepartamentos.CurrentRow != null)
            {

                CiudadId = Int64.Parse(dgvCiudadesDepartamentos.CurrentRow.Cells["cIUDADIDDataGridViewTextBoxColumn"].Value.ToString());
                using (BusquedaCiudadesDepartamentosViewDao busquedaCiudadesView = new BusquedaCiudadesDepartamentosViewDao())
                {
                    IList<CIUDADES_DEPARTAMENTOS_VIEW> lista = busquedaCiudadesView.ObtenerDesdeFiltros(s => s.CIUDAD_ID.Equals(CiudadId));
                    Entity = lista[0];
                }
                DialogResult = DialogResult.OK;
                Hide();
            }
        }

        private void dgvCiudadesDepartamentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGuardar_Click(null, null);
        }

        private void dgvCiudadesDepartamentos_MouseClick(object sender, MouseEventArgs e)
        {
            btnGuardar_Click(sender, e);
        }

        private void txtCiudadDepartamento_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
