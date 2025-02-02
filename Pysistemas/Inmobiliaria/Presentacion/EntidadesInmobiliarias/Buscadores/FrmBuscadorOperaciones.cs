using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Presentacion.Procesos;
using Inmobiliaria.Utilidades.Controles;

namespace Inmobiliaria.Presentacion.EntidadesInmobiliarias.Buscadores
{
    public partial class FrmBuscadorOperaciones : Inmobiliaria.Presentacion.Genericos.FrmMaestro
    {
        public OPERACIONES_PROPIEDADES Entity { get; set; }
        public String Tipo { get; set; } // para definir desde donde le llamo

        public FrmBuscadorOperaciones(Principal principal, String tipo) : base(principal)        
        {
            InitializeComponent();
            CargarDatos();
            ConfiguracionesGrid(dataGridView1);
            Entity = new OPERACIONES_PROPIEDADES();
            Tipo = tipo;
        }

        async void CargarDatos()
        {
            await CargarEntidadesInmobiliarias();
            dataGridView1.DataSource = null;
        }

        async Task CargarEntidadesInmobiliarias()
        {
            using (EntidadesInmobiliariasDao entidadesInmobiliariasDao = new EntidadesInmobiliariasDao())
            {
                cbEntidades.DataSource = entidadesInmobiliariasDao.ObtenerLista();
                ControlesUtilidades.InicializarComboBox(cbEntidades);
                
            }
        }

        private void FrmBuscadorOperaciones_Load(object sender, EventArgs e)
        {
            
        }

        private void Buscar()
        {
            Int64 entidadId = 0;
            Int64 propiedadId = 0;
            using (BusquedaOperacionesPropiedadesViewDao busquedaOperacionesPropiedadesViewDao = new BusquedaOperacionesPropiedadesViewDao())
            {
                if (cbEntidades.SelectedValue != null)
                {
                    entidadId = Int64.Parse(cbEntidades.SelectedValue.ToString());
                }

                if (cbPropiedades.SelectedValue != null)
                {
                    propiedadId = Int64.Parse(cbPropiedades.SelectedValue.ToString());
                }

                if (entidadId != 0 && propiedadId != 0)
                {
                    dataGridView1.DataSource = busquedaOperacionesPropiedadesViewDao.ObtenerDesdeFiltros(b =>
                        b.ENTIDAD_INMOBILIARIA_ID == entidadId && b.PROPIEDAD_ID == propiedadId && b.ESTADO.Equals(Constantes.EstadosUnidadesInmobiliarias.VIGENTE));
                    return;
                }
                else if (entidadId != 0)
                {
                    dataGridView1.DataSource = busquedaOperacionesPropiedadesViewDao.ObtenerDesdeFiltros(b =>
                        b.ENTIDAD_INMOBILIARIA_ID == entidadId && b.ESTADO.Equals(Constantes.EstadosUnidadesInmobiliarias.VIGENTE));
                    return;
                }
                else if (propiedadId != 0)
                {
                    dataGridView1.DataSource = busquedaOperacionesPropiedadesViewDao.ObtenerDesdeFiltros(b =>
                         b.PROPIEDAD_ID == propiedadId && b.ESTADO.Equals(Constantes.EstadosUnidadesInmobiliarias.VIGENTE));
                    return;
                }
                else
                {
                    dataGridView1.DataSource = null;

                } 
            }
        }

        private void cbEntidades_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbEntidades.SelectedValue != null)
            {
                Buscar();
                Int64 entidadId = Int64.Parse(cbEntidades.SelectedValue.ToString());
                CargarPropiedadesEntidad(entidadId);
            }
        }

        private void CargarPropiedadesEntidad(Int64 entidadId)
        {
            using (PropiedadesDao propiedadesDao = new PropiedadesDao())
            {
                cbPropiedades.DataSource =
                    propiedadesDao.ObtenerDesdeFiltros(p => p.ENTIDAD_INMOBILIARIA_ID == entidadId);
                ControlesUtilidades.InicializarComboBox(cbPropiedades);
            }
        }

        private void cbPropiedades_SelectedValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void Seleccionar()
        {
            if (dataGridView1.CurrentRow != null)
            {
                using (OperacionesPropiedadesDao operacionesPropiedadesDao = new OperacionesPropiedadesDao())
                {
                    Int64 operacionId = Int64.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    Entity = operacionesPropiedadesDao.ObtenerDesdePk(operacionId);
                    
                    if (Tipo == "R")
                    {
                        FrmRegenerarCuotas frmRegenerarCuotas = new FrmRegenerarCuotas(FrmPrincipal, "E");
                        frmRegenerarCuotas.OperacionPropiedad = Entity;

                        frmRegenerarCuotas.ShowDialog();
                        DialogResult = DialogResult.OK;
                        Hide();
                    }
                    else
                    {
                        DialogResult = DialogResult.OK;
                        Hide();
                    }


                    
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
