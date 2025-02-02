using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Services.Generales;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.Mantenimiento.Generales
{
    public partial class FrmMonedas : Genericos.FrmMaestro
    {
        public string Operacion { get; set; }
        public MONEDAS Entity { get; set; }

        public FrmMonedas(Principal principal, String operacion) : base(principal)
        {
            InitializeComponent();
            Operacion = operacion;
            Entity = new MONEDAS();
            CargarDatos();
        }

        async void CargarDatos()
        { 
            await CargarTiposMonedas();
        }
        async Task CargarTiposMonedas()
        {

            using (DominiosDao dominiosDao = new DominiosDao())
            {
                cbTipoMoneda.DataSource = dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.TIPOS_MONEDAS));
                ControlesUtilidades.InicializarComboBox(cbTipoMoneda);
            }

            return;
        }
        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (!VerificarDatosObligatorios())
            {
                PysistemasMensajes.ShowInfo("Cargue los campos basicos por favor");
                txtMoneda.Focus();
                return;
            }else
            {
                MonedasService service = new MonedasService();
                Entity.MONEDA = txtMoneda.Text;

                Entity.TIPO_MONEDA = cbTipoMoneda.SelectedValue.ToString();
                

                Entity.SIMBOLO = txtSimbolo.Text;                
                Entity.SIMBOLO_SET = txtSimboloSet.Text;
                Entity.PRECISION_DECIMALES = int.Parse(txtPrecision.Text);

                service.Guardar(Operacion,Entity, FrmPrincipal.UsuarioLogueado);
                PysistemasMensajes.ShowInfo("Los datos se guardarón con éxito");

                if (PysistemasMensajes.AskConfirmation("Desea cargar otro registro?"))
                {
                    LimpiarPantalla();

                    Operacion = Constantes.Operaciones.NUEVO;
                    LimpiarFormulario();
                }
                else
                {
                    Entity = null;
                    Close();
                }


            }
        }
        private void LimpiarFormulario()
        {
            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                lblTitulo.Text = "Crear Moneda";
                txtMoneda.Focus();

            }
            else if (Constantes.Operaciones.EDITAR.Equals(Operacion))
            {
                lblTitulo.Text = "Modificar Monedas";
                CargarDatosMonedas();

            }
        }
        protected override void LimpiarPantalla()
        {
            ControlesUtilidades.ClearComponents(gbDatosMonedas);
            txtMoneda.Focus();

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }

        private void txtPrecision_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }
        private bool VerificarDatosObligatorios()
        {
            if (string.IsNullOrWhiteSpace(txtMoneda.Text) && string.IsNullOrWhiteSpace(txtSimbolo.Text)
                && string.IsNullOrWhiteSpace(txtSimboloSet.Text) && string.IsNullOrWhiteSpace(txtPrecision.Text))
                return false;
            if (cbTipoMoneda.SelectedValue == null)
                return false;            
            return true;
        }

        private void FrmMonedas_Load(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void CargarDatosMonedas()
        {
            if (Entity != null)
            {
                txtMoneda.Text = Entity.MONEDA;

                cbTipoMoneda.SelectedValue = Entity.TIPO_MONEDA;

                txtSimbolo.Text = Entity.SIMBOLO;
                txtSimboloSet.Text = Entity.SIMBOLO_SET;
                txtPrecision.Text = Entity.PRECISION_DECIMALES.ToString();
            }
        }

        private void FrmMonedas_Shown(object sender, EventArgs e)
        {
            txtMoneda.Focus();
        }
    }
}
