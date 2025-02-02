using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Services.Mantenimientos;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.Mantenimiento.UbicacionGeografica
{
    public partial class FrmCiudades : Genericos.FrmMaestro
    {
        public string Operacion { get; set; }
        public CIUDADES Entity { get; set; }
        public CIUDADES_DEPARTAMENTOS CiudadDepartamento { get; set; }

        public Int64 departamentoId;
        public Int64 paisId;

        public FrmCiudades(Principal principal, String operacion) : base(principal)
        {
            InitializeComponent();
            Operacion = operacion;
            CargarDatos();
            Entity = new CIUDADES();
            CiudadDepartamento = new CIUDADES_DEPARTAMENTOS();
            
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CiudadesService service = new CiudadesService();

            Entity.CIUDAD = txtCiudad.Text;



            CiudadDepartamento.DEPARTAMENTO_ID = Int64.Parse(cbDepartamento.SelectedValue.ToString());


            service.Guardar(Operacion, Entity, CiudadDepartamento,FrmPrincipal.UsuarioLogueado);
            PysistemasMensajes.ShowInfo("Los datos se guardarón con éxito");
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }

        private void FrmCiudades_Load(object sender, EventArgs e)
        {
            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                lblTitulo.Text = "Crear Ciudad";


            }
            else
            {
                lblTitulo.Text = "Modificar Ciudad";
                CargarDatosCiudad();
            }
        }

        private void CargarDatosCiudad()
        {
            txtCiudad.Text = Entity.CIUDAD;
            CargarValorCombosUbicacionesGeograficas();
        }

        private void CargarValorCombosUbicacionesGeograficas()
        {
            cbPais.SelectedValue = paisId;
            CargarDepartamentosPaisesAsync(paisId);
            cbDepartamento.SelectedValue = departamentoId;
           
        }

        private void cbPaís_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (cbPais.SelectedValue != null)
            {
                Int64 paisId = Int64.Parse(cbPais.SelectedValue.ToString());
                CargarDepartamentosPaisesAsync(paisId);
                ControlesUtilidades.InicializarComboBox(cbDepartamento);
                
            }
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                btnGuardar_Click(sender, e);
            }
        }

        private void FrmCiudades_Shown(object sender, EventArgs e)
        {
            txtCiudad.Focus();
        }
    }


}
