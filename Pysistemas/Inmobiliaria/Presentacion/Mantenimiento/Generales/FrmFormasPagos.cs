using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Services.Generales;
using Inmobiliaria.Utilidades.Controles;
using System;

namespace Inmobiliaria.Presentacion.Mantenimiento.Generales
{
    public partial class FrmFormasPagos : Genericos.FrmMaestro
    {
        public string Operacion { get; set; }
        public FORMAS_PAGOS Entity { get; set; }

        public FrmFormasPagos(Principal principal, String operacion) : base(principal)
        {
            InitializeComponent();
            Operacion = operacion;
            Entity = new FORMAS_PAGOS();            
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {

            if (!VerificarDatosObligatorios())
            {
                PysistemasMensajes.ShowInfo("Cargue los campos basicos por favor");
                txtFormaPago.Focus();
                return;
            }
            else
            {
                FormasPagosService service = new FormasPagosService();
                Entity.FORMA_PAGO = txtFormaPago.Text;
                Entity.CODIGO = txtCodigo.Text;
                Entity.DIAS = int.Parse(txtDias.Text);
                Entity.POR_DEFECTO = checkBoxPorDefecto.Checked == true ? "SI" : "NO";
                Entity.REQUERE_BANCO = checkBoxRequiereBanco.Checked == true ? "SI" : "NO";

                

                service.Guardar(Operacion, Entity, FrmPrincipal.UsuarioLogueado);
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

                //Close();
            }
        }
        protected override void LimpiarPantalla()
        {
            ControlesUtilidades.ClearComponents(gbDatosFormasPagos);
            txtCodigo.Focus();

        }
        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            //Entity = null;
            btnClose_Click(sender, e);            
            
        }

        private void txtDias_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private bool VerificarDatosObligatorios()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) && string.IsNullOrWhiteSpace(txtFormaPago.Text))
                return false;            
            return true;
        }

        private void checkBoxPorDefecto_CheckedChanged(object sender, EventArgs e)
        {

            // si setea la forma de pago por defecto y si existe ya uno, cambiar el que estaba por defecto
            // y dejar el nuevo por defecto 
            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                using (FormasPagosDao formaPagoDao = new FormasPagosDao())
                {
                    FORMAS_PAGOS formaPagoPorDefectoActual = formaPagoDao.ObtenerDesdeFiltros(d => d.POR_DEFECTO.Equals("SI"))[0];
                    formaPagoPorDefectoActual.POR_DEFECTO = "NO";
                    formaPagoDao.Actualizar(formaPagoPorDefectoActual);
                    /*
                    if (Cantidad > 1 && checkBoxPorDefecto.Checked)
                    {
                        PysistemasMensajes.ShowInfo("Solo puede haber una sola forma de pago por defecto.");                    
                        return;
                    }
                    */


                }
            }
            
        }

        private void FrmFormasPagos_Load(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
        private void LimpiarFormulario()
        {
            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                lblTitulo.Text = "Crear Forma de Pago";
                txtCodigo.Focus();


            }
            else if (Constantes.Operaciones.EDITAR.Equals(Operacion))
            {
                lblTitulo.Text = "Modificar Forma de Pago";
                CargarDatosFormasPagos();
            }
        }
        private void CargarDatosFormasPagos()
        {
            if (Entity != null)
            {
                txtCodigo.Text = Entity.CODIGO;
                txtDias.Text = Entity.DIAS.ToString();
                txtFormaPago.Text = Entity.FORMA_PAGO;
                checkBoxPorDefecto.Checked = Entity.POR_DEFECTO == "SI" ? true : false;
                checkBoxRequiereBanco.Checked = Entity.REQUERE_BANCO == "SI" ? true : false;
            }

        }

        private void FrmFormasPagos_Shown(object sender, EventArgs e)
        {
            txtCodigo.Focus();
        }
    }
}
