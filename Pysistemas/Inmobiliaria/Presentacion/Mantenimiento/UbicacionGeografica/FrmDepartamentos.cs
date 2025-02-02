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
    public partial class FrmDepartamentos : Genericos.FrmMaestro
    {
        public string Operacion { get; set; }
        public DEPARTAMENTOS Entity { get; set; }
        public DEPARTAMENTOS_PAISES DepartamentoPaisEntity { get; set; }

        public Int64 paisId { get; set; }
        //public Int64 departamentoId { get; set; }

        public FrmDepartamentos(Principal principal, String operacion) : base(principal)
        {
            InitializeComponent();
            Operacion = operacion;
            CargarDatos();
            Entity = new DEPARTAMENTOS();
            DepartamentoPaisEntity = new DEPARTAMENTOS_PAISES();
        }

        async void CargarDatos()
        {
            await CargarPaises();
        }

        async Task CargarPaises()
        {
            using (PaisDao paisDao = new PaisDao())
            {
                cbPais.DataSource = paisDao.ObtenerLista();

            }
            
            return;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DepartamentosService service = new DepartamentosService();

            Entity.DEPARTAMENTO = txtDepartamento.Text;

            DepartamentoPaisEntity.PAIS_ID = Int64.Parse(cbPais.SelectedValue.ToString());

            service.Guardar(Operacion, Entity, DepartamentoPaisEntity, FrmPrincipal.UsuarioLogueado);
            PysistemasMensajes.ShowInfo("Los datos se guardarón con éxito");
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }

        private void FrmDepartamentos_Load(object sender, EventArgs e)
        {

            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                lblTitulo.Text = "Crear Departamento";


            }
            else
            {
                lblTitulo.Text = "Modificar Departamento";
                CargarDatosPais();
            }
        }

        private void CargarDatosPais()
        {
            txtDepartamento.Text = Entity.DEPARTAMENTO;
            cbPais.SelectedValue = paisId;
            
        }

        private void FrmDepartamentos_Shown(object sender, EventArgs e)
        {
            txtDepartamento.Focus();
        }
    }
}
