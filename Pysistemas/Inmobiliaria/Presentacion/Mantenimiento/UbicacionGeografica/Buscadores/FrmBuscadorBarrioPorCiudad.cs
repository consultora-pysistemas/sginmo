using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Genericos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.Mantenimiento.UbicacionGeografica.Buscadores
{
    public partial class FrmBuscadorBarrioPorCiudad : FrmMaestro
    {
        public BARRIOS_CIUDADES_VIEW Entity { get; set; }
        public Int64 CiudadId;
        public Int64 BarrioId;
        public FrmBuscadorBarrioPorCiudad(Int64 ciudadId)
        {
            InitializeComponent();
            lblTitulo.Text = "Búsqueda de Barrios por Ciudades";
            CiudadId = ciudadId;
            Entity = new BARRIOS_CIUDADES_VIEW();
            ConfiguracionesGrid(dgvBarriosCiudades);
            Buscar();
        }

        private void FrmBuscadorBarrioPorCiudad_Shown(object sender, EventArgs e)
        {
            txtBarrioCiudad.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvBarriosCiudades.CurrentRow != null)
            {

                BarrioId = Int64.Parse(dgvBarriosCiudades.CurrentRow.Cells["bARRIOIDDataGridViewTextBoxColumn"].Value.ToString());
                using (BusquedaBarriosCiudadesDao busquedaCiudadesView = new BusquedaBarriosCiudadesDao())
                {
                    IList<BARRIOS_CIUDADES_VIEW> lista = busquedaCiudadesView.ObtenerDesdeFiltros(s => s.BARRIO_ID.Equals(BarrioId));
                    Entity = lista[0];
                }
                DialogResult = DialogResult.OK;
                Hide();
            }
        }

        private void txtBarrioCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                Buscar();
            }
        }

        private void Buscar()
        {
            using (BusquedaBarriosCiudadesDao busquedaBarriosCiudadesView = new BusquedaBarriosCiudadesDao())
            {
                if (!String.IsNullOrWhiteSpace(txtBarrioCiudad.Text))
                {
                    dgvBarriosCiudades.DataSource = busquedaBarriosCiudadesView.ObtenerDesdeFiltros(s => s.BARRIO.ToUpper().Contains(txtBarrioCiudad.Text.ToUpper()) && s.CIUDAD_ID == CiudadId);
                }
                
                else
                {
                    dgvBarriosCiudades.DataSource = busquedaBarriosCiudadesView.ObtenerDesdeFiltros(s => s.CIUDAD_ID == CiudadId);
                }
                
            }
        }

        private void txtBarrioCiudad_TextChanged(object sender, EventArgs e)
        {
            //if (!String.IsNullOrEmpty(txtBarrioCiudad.Text))
            //{
                Buscar();
            //}
        }
    }
}
