using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Services.IngresosEgresos;
using Inmobiliaria.Utilidades.Controles;

namespace Inmobiliaria.Presentacion.Gastos.Gastos
{
    public partial class FrmItemIngresoEgreso : Genericos.FrmMaestro
    {
        public string Operacion { get; set; }
        public ITEMS_INGRESOS_EGRESOS Entity { get; set; }
        public FrmItemIngresoEgreso(Principal frmPrincipal,String operacion):base(frmPrincipal)
        {
            InitializeComponent();
            Operacion = operacion;
            CargarDatos();
            Entity = new ITEMS_INGRESOS_EGRESOS();
        }

        async void CargarDatos()
        {
            await CargarTiposItems();
            await CargarTiposIngresosEgresos();
        }

        async Task CargarTiposIngresosEgresos()
        {
            using (DominiosDao dominiosDao = new DominiosDao())
            {
                cbTipo.DataSource =
                    dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.TIPOS_GASTOS));
                
            }
            ControlesUtilidades.InicializarComboBox(cbTipo);
        }

        async Task CargarTiposItems()
        {
            using (DominiosDao dominiosDao = new DominiosDao())
            {
                cbTipoItem.DataSource = dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.TIPO_ITEM_INGR_EGR));

            }
            ControlesUtilidades.InicializarComboBox(cbTipoItem);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender,e);
        }

        private void FrmItemIngresoEgreso_Load(object sender, EventArgs e)
        {
            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                lblTitulo.Text = "Crear item de ingreso/egreso";
            }
            else
            {
                lblTitulo.Text = "Editar item ingreso/egreso";
                txtItem.Text = Entity.ITEM;
                cbTipoItem.SelectedValue = Entity.TIPO_ITEM;
                cbTipo.SelectedValue = Entity.TIPO;
            }
        }

        private void FrmItemIngresoEgreso_Shown(object sender, EventArgs e)
        {
            txtItem.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ItemsIngresosEgresosService service = new ItemsIngresosEgresosService();
            try
            {
                if (String.IsNullOrWhiteSpace(txtItem.Text))
                {
                    PysistemasMensajes.ShowInfo("El nombre del item es requerido");
                    return;
                }
                if (cbTipoItem.SelectedValue == null)
                {
                    PysistemasMensajes.ShowInfo("El tipo de item es requerido");
                    return;
                }
                if (cbTipo.SelectedValue == null)
                {
                    PysistemasMensajes.ShowInfo("El tipo es requerido");
                    return;
                }
                Entity.ITEM = txtItem.Text;
                Entity.TIPO = cbTipo.SelectedValue.ToString();
                Entity.TIPO_ITEM = cbTipoItem.SelectedValue.ToString();
                Entity.MODIFICA_ESTADO = Constantes.Booleano.SI;
                service.Guardar(Entity,Operacion,FrmPrincipal.UsuarioLogueado);
                PysistemasMensajes.ShowInfo("Los datos se han guardado con éxito");

                if (PysistemasMensajes.AskConfirmation("Desea cargar otro registro?"))
                {
                    LimpiarPantalla();                    
                    Operacion = Constantes.Operaciones.NUEVO;
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }

                //DialogResult = DialogResult.OK;
                //Hide();
            }
            catch (Exception exception)
            {
                PysistemasMensajes.ShowError(exception.Message);
            }
        }
        protected override void LimpiarPantalla()
        {
            txtItem.Text = String.Empty;

            ControlesUtilidades.ClearComponents(cbTipo);
            ControlesUtilidades.ClearComponents(cbTipoItem);
            txtItem.Focus();

        }
    }
}
