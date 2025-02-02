using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Services.Mantenimientos;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Threading.Tasks;

namespace Inmobiliaria.Presentacion.Mantenimiento.UbicacionGeografica
{
    public partial class FrmBarrios : Genericos.FrmMaestro
    {
        public string Operacion { get; set; }
        public BARRIOS Entity { get; set; }
        public BARRIOS_CIUDADES BarrioCiudad { get; set; }
 
        public Int64 ciudadId;
        public Int64 departamentoId;
        public Int64 paisId;


        public FrmBarrios(Principal principal, String operacion) : base(principal)
        {
            InitializeComponent();
            Operacion = operacion;

            CargarDatos();
            Entity = new BARRIOS();
            BarrioCiudad = new BARRIOS_CIUDADES();
    
        }
        async void CargarDatos()
        {
            await CargarPaises();

        }
        async Task CargarPaises()
        {
            Int64 paisId;

            using (PaisDao paisDao = new PaisDao())
            {
                cbPais.DataSource = paisDao.ObtenerLista();
                paisId = Int64.Parse(cbPais.SelectedValue.ToString());
            }
            await CargarDepartamentosPaises(paisId);
            return;
        }

        async Task<int> CargarDepartamentosPaises(Int64 paisId)
        {
            using (BusquedaDepartamentosPaisesViewDao busquedaDepartamentosPaisesView = new BusquedaDepartamentosPaisesViewDao())
            {
                if (cbPais.SelectedValue != null)
                {
                    cbDepartamento.DataSource = busquedaDepartamentosPaisesView.ObtenerDesdeFiltros(d => d.PAIS_ID == paisId);
                    ControlesUtilidades.InicializarComboBox(cbDepartamento);
                }
            }
            return 1;
        }
        async void CargarDepartamentosPaisesAsync(Int64 paisId)
        {
            await CargarDepartamentosPaises(paisId);
        }

        async void CargarCiudadesDepartamentosAsync(Int64 departamentoId)
        {
            await CargarCiudadesDepartamentos(departamentoId);
        }
        async Task CargarCiudadesDepartamentos(Int64 departamentoId)
        {
            using (BusquedaCiudadesDepartamentosViewDao busquedaCiudadesDepartamentosView = new BusquedaCiudadesDepartamentosViewDao())
            {
                cbCiudad.DataSource = busquedaCiudadesDepartamentosView.ObtenerDesdeFiltros(c => c.DEPARTAMENTO_ID == departamentoId);
                ControlesUtilidades.InicializarComboBox(cbCiudad);
            }
            cbCiudad.Focus();
            return;
        }

        private void cbDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbDepartamento.SelectedValue != null)
            {
                Int64 departamentoId = Int64.Parse(cbDepartamento.SelectedValue.ToString());
                CargarCiudadesDepartamentosAsync(departamentoId);
                ControlesUtilidades.InicializarComboBox(cbCiudad);
                
            }
        }
        private void cbPaís_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbPais.SelectedValue != null)
            {
                Int64 paisId = Int64.Parse(cbPais.SelectedValue.ToString());
                CargarDepartamentosPaisesAsync(paisId);
                ControlesUtilidades.InicializarComboBox(cbDepartamento);
                ControlesUtilidades.InicializarComboBox(cbCiudad);
            }
        }
        private void FrmBarrios_Load(object sender, EventArgs e)
        {
            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                lblTitulo.Text = "Crear Barrio";
            }
            else
            {
                lblTitulo.Text = "Modificar Barrio";
                // recibir los datos para cargar el form
                CargarDatosBarrios();
            }
        }

        private void CargarDatosBarrios()
        {
         
            txtBarrio.Text = Entity.BARRIO;                                 
            CargarValorCombosUbicacionesGeograficas();
        }

        private void CargarValorCombosUbicacionesGeograficas()
        {
           cbPais.SelectedValue = paisId;
            CargarDepartamentosPaisesAsync(paisId);
            cbDepartamento.SelectedValue = departamentoId;
            CargarCiudadesDepartamentosAsync(departamentoId);
            cbCiudad.SelectedValue = ciudadId;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {            
            BarriosService service = new BarriosService();

            Entity.BARRIO = txtBarrio.Text;
            BarrioCiudad.CIUDAD_ID = Int64.Parse(cbCiudad.SelectedValue.ToString());
                                    
            service.Guardar(Operacion, Entity, BarrioCiudad, FrmPrincipal.UsuarioLogueado);
            
            PysistemasMensajes.ShowInfo("Los datos se guardarón con éxito");
            Close();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }

        private void FrmBarrios_Shown(object sender, EventArgs e)
        {
            txtBarrio.Focus();
        }
    }
}
