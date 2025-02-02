using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Genericos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.Mantenimiento.UbicacionGeografica.Buscadores
{
    public partial class FrmBuscadorCiudades : FrmMaestro
    {        
        public CIUDADES_DEPARTAMENTOS_VIEW Entity { get; set; }

        public FrmBuscadorCiudades()
        {
            InitializeComponent();
            lblTitulo.Text = "Búsqueda de Ciudades";
            Entity = new CIUDADES_DEPARTAMENTOS_VIEW();
            ConfiguracionesGrid(dgvCiudades);
        }

        private void FrmBuscadorCiudades_Shown(object sender, EventArgs e)
        {
            txtBusqueda.Focus();
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                Buscar();
            }
        }
        private void Buscar()
        {
            //if (String.IsNullOrWhiteSpace(txtBusqueda.Text))
                //return;
            using (BusquedaCiudadesDepartamentosViewDao busquedaCiudadesView = new BusquedaCiudadesDepartamentosViewDao())
            {
                if (!String.IsNullOrWhiteSpace(txtBusqueda.Text))
                {
                    dgvCiudades.DataSource = busquedaCiudadesView.ObtenerDesdeFiltros(s => s.CIUDAD.ToUpper().Contains(txtBusqueda.Text.ToUpper()) || s.DEPARTAMENTO.Contains(txtBusqueda.Text));
                }else
                {
                    dgvCiudades.DataSource = busquedaCiudadesView.ObtenerLista();
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
            if (dgvCiudades.CurrentRow != null)
            {
                
                Int64 ciudadId = Int64.Parse(dgvCiudades.CurrentRow.Cells["cIUDADIDDataGridViewTextBoxColumn"].Value.ToString());
                using (BusquedaCiudadesDepartamentosViewDao busquedaCiudadesView = new BusquedaCiudadesDepartamentosViewDao())
                {
                    IList<CIUDADES_DEPARTAMENTOS_VIEW> lista = busquedaCiudadesView.ObtenerDesdeFiltros(s => s.CIUDAD_ID.Equals(ciudadId));
                    Entity = lista[0];
                }
                DialogResult = DialogResult.OK;
                Hide();
            }
        }

        private void dgvCiudades_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGuardar_Click(null, null);
        }

        private void dgvCiudades_MouseClick(object sender, MouseEventArgs e)
        {
            btnGuardar_Click(sender, e);
        }
    }
    
}
