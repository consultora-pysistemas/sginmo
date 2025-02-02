using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using System;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Services.Mantenimientos;
using Inmobiliaria.Utilidades.Controles;

namespace Inmobiliaria.Presentacion.Mantenimiento.Sucursales
{
    public partial class FrmSucursales : Genericos.FrmMaestro
    {
        public string Operacion { get; set; }
        public SUCURSALES Entity { get; set; }
        public FrmSucursales(Principal principal,string operacion):base(principal)
        {
            InitializeComponent();
            Operacion = operacion;
            Entity = new SUCURSALES();
        }
        public FrmSucursales() 
        {
            InitializeComponent();
        }
        private void FrmSucursales_Load(object sender, System.EventArgs e)
        {
            if (Operacion != null && Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                lblTitulo.Text = "Crear nueva sucursal";
            }
            else
            {
                lblTitulo.Text = "Modificar sucursal";
                using (SucursalesDao sucursalesDao = new SucursalesDao())
                {
                    Entity = sucursalesDao.ObtenerDesdePk(Entity.SUCURSAL_ID);
                    txtSucursal.Text = Entity.SUCURSAL;
                    txtTelefono.Text = Entity.TELEFONO;
                    txtDireccion.Text = Entity.DIRECCION;

                }
            }
            lblEmpresa.Text = FrmPrincipal.Configuraciones
                .ObtenerValorVariableEntorno(Constantes.VariablesEntorno.EMPRESA).VALOR;
            lblEmpresa.Tag = Int64.Parse(FrmPrincipal.Configuraciones
                .ObtenerValorVariableEntorno(Constantes.VariablesEntorno.EMPRESA_ID).VALOR);
        }

        private void FrmSucursales_Shown(object sender, System.EventArgs e)
        {
            txtSucursal.Focus();
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            btnClose_Click(sender,null);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ObtenerEntity();
            SucursalesService service = new SucursalesService();
            service.Guardar(Entity, Operacion);
            PysistemasMensajes.ShowInfo("Los datos se han guardado con éxito");
            if (PysistemasMensajes.AskConfirmation("Desea seguir cargando registros?"))
            {
                ControlesUtilidades.ClearComponents(gbDatosEmpresa);
                Operacion = Constantes.Operaciones.NUEVO;
                txtSucursal.Focus();

            }
            else
            {
                btnClose_Click(null,null);
            }
        }

        private void ObtenerEntity()
        {
            Entity.SUCURSAL = txtSucursal.Text;
            Entity.DIRECCION = txtDireccion.Text;
            Entity.TELEFONO = txtTelefono.Text;
            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                Entity.POR_DEFECTO = Constantes.Booleano.NO;
                Entity.USUARIO_CREACION = FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO;
                Entity.FECHA_CREACION = DateTime.Now;
                Entity.EMPRESA_ID = Int64.Parse(lblEmpresa.Tag.ToString());
                
            }
            else
            {
                
                Entity.USUARIO_MODIFICACION = FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO;
                Entity.FECHA_MODIFICACION = DateTime.Now;
                Entity.EMPRESA_ID = Int64.Parse(lblEmpresa.Tag.ToString());
                
            }
        }
    }
}
