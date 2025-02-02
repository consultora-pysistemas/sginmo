using System;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Utilidades.Controles;
using System.Collections.Generic;
using System.Linq;
using Inmobiliaria.Services.Mantenimientos;

namespace Inmobiliaria.Presentacion.Mantenimiento.Empresa
{
    public partial class FrmEmpresa : Genericos.FrmMaestro
    {
        public EMPRESAS Entity { get; set; }
        public string Operacion { get; set; }
        public FrmEmpresa(Principal principal,String operacion):base(principal)
        {
            InitializeComponent();
            Entity = new EMPRESAS();
            Operacion = operacion;
            txtNumeroDocumento.LostFocus += TxtNumeroDocumento_LostFocus;
            CargarConfiguraciones();
            txtRazonSocial.LostFocus += TxtRazonSocial_LostFocus;
            
        }

       

        private void TxtRazonSocial_LostFocus(object sender, EventArgs e)
        {
            using (EmpresasDao empresasDao = new EmpresasDao())
            {
                EMPRESAS empresa = empresasDao
                    .ObtenerDesdeFiltros(em => em.RAZON_SOCIAL.ToUpper().Equals(txtRazonSocial.Text.ToUpper())).ToList()
                    .SingleOrDefault();
                if (empresa != null)
                {
                    PysistemasMensajes.ShowAlert("Ya existe una empresa con razón social "+txtRazonSocial.Text+". Favor ingrese un nombre válido para la empresa");
                    txtNumeroDocumento.Focus();
                }
            }
        }

        private void CargarConfiguraciones()
        {
            using (DominiosDao dominiosDao = new DominiosDao())
            {
                cbTipoPersoneria.DataSource = dominiosDao.ObtenerDesdeFiltros(d =>
                    d.DOMINIO.Equals(Constantes.Dominios.TIPOS_PERSONERIAS));
                cbTipoDocumento.DataSource = dominiosDao.ObtenerDesdeFiltros(d =>
                    d.DOMINIO.Equals(Constantes.Dominios.TIPOS_DOCUMENTOS_IDENTIDAD));
                ControlesUtilidades.InicializarComboBox(cbTipoDocumento);
                ControlesUtilidades.InicializarComboBox(cbTipoPersoneria);
            }
        }
        private void TxtNumeroDocumento_LostFocus(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNumeroDocumento.Text))
            {
                using (SociosNegociosDao sociosNegociosDao = new SociosNegociosDao())
                {
                    IList<SOCIOS_NEGOCIOS> sociosNegocios = sociosNegociosDao.ObtenerDesdeFiltros(s=>s.NUMERO_DOCUMENTO.Equals(txtNumeroDocumento.Text));
                    if (sociosNegocios.Count > 0)
                    {
                        SOCIOS_NEGOCIOS socioNegocioEmpresa = sociosNegocios[0];
                        txtNumeroDocumento.Text = socioNegocioEmpresa.NUMERO_DOCUMENTO;
                        txtDireccion.Text = socioNegocioEmpresa.DIRECCION;
                        txtRazonSocial.Text = socioNegocioEmpresa.RAZON_SOCIAL;
                        txtTelefono.Text = socioNegocioEmpresa.TELEFONO;
                        cbTipoPersoneria.SelectedValue = socioNegocioEmpresa.TIPO_PERSONERIA;
                        cbTipoDocumento.SelectedValue = socioNegocioEmpresa.TIPO_DOCUMENTO;
                        txtNumeroDocumento.Tag = socioNegocioEmpresa.SOCIO_NEGOCIO_ID;
                        
                    }
                }
            }
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            if (Operacion != null && Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                lblTitulo.Text = "Crear nueva empresa";
            }
            else
            {
                //Obtener el id de la empresa que se desea editar
                lblTitulo.Text = "Modificar empresa";
                ObtenerDatosEmpresa();
            }

            
        }

        private void ObtenerDatosEmpresa()
        {
            using (EmpresasDao empresaDao = new EmpresasDao())
            {
                Entity = empresaDao.ObtenerDesdePk(Entity.EMPRESA_ID);
                txtRazonSocial.Text = Entity.RAZON_SOCIAL;
                txtNumeroDocumento.Text = Entity.NUMERO_DOCUMENTO;
                txtDireccion.Text = Entity.DIRECCION;
                txtTelefono.Text = Entity.TELEFONO;
                cbTipoDocumento.SelectedValue = Entity.TIPO_DOCUMENTO;
                cbTipoPersoneria.SelectedValue = Entity.TIPO_PERSONERIA;
                txtNumeroDocumento.Tag = Entity.SOCIO_NEGOCIO_ID;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender,e);
        }

        private void FrmEmpresa_Shown(object sender, EventArgs e)
        {
            txtNumeroDocumento.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                CargarEntity();

                try
                {
                    EmpresasService service = new EmpresasService();
                    service.Guardar(Entity, Operacion);
                    PysistemasMensajes.ShowInfo("Se guardaron los datos con éxito");
                    if (PysistemasMensajes.AskConfirmation("Desea cargar otro registro?"))
                    {
                       LimpiarPantalla();
                    }
                    else
                    {
                        btnClose_Click(null, null);
                    }
                }
                catch (Exception ex)
                {
                    
                        
                        PysistemasMensajes.ShowError("Ha ocurrido un error al guardar los datos. Los datos no fueron guardados. Favor verifique que los campos obligatorios esten completados y que el nro de documento y/o razón social de la empresa no existe " );
                    
                    
                    
                }
            }
            
        }

        protected override void LimpiarPantalla()
        {
            ControlesUtilidades.ClearComponents(gbDatosEmpresa);
            txtNumeroDocumento.Focus();
            Operacion = Constantes.Operaciones.NUEVO;
        }

        private void CargarEntity()
        {
            if (txtNumeroDocumento.Tag != null)
                Entity.SOCIO_NEGOCIO_ID = Int64.Parse(txtNumeroDocumento.Tag.ToString());
            Entity.RAZON_SOCIAL = ControlesUtilidades.ToTitleCase(txtRazonSocial.Text);
            Entity.NUMERO_DOCUMENTO = txtNumeroDocumento.Text;
            Entity.DIRECCION = txtDireccion.Text;
            Entity.TELEFONO = txtTelefono.Text;
            Entity.TIPO_PERSONERIA = cbTipoPersoneria.SelectedValue.ToString();
            Entity.TIPO_DOCUMENTO = cbTipoDocumento.SelectedValue.ToString();
            Entity.DIGITO_VERIFICADOR =
                ControlesUtilidades.calcularDigitoVerificador(long.Parse(txtNumeroDocumento.Text)).ToString();
            Entity.ACTIVO = Constantes.Booleano.SI;
            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                Entity.FECHA_CREACION = DateTime.Now;
                Entity.USUARIO_CREACION = FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO;
            }
            else
            {
                Entity.FECHA_MODIFICACION = DateTime.Now;
                Entity.USUARIO_MODIFICACION = FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO;
            }
            
        }

        private bool ValidarDatos()
        {
            if (String.IsNullOrWhiteSpace(txtRazonSocial.Text))
            {
                PysistemasMensajes.ShowInfo("La razón social de la empresa es requerida");
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtNumeroDocumento.Text))
            {
                PysistemasMensajes.ShowInfo("El RUC de la empresa es requerido");
                return false;
            }

            if (cbTipoPersoneria.SelectedValue == null)
            {
                PysistemasMensajes.ShowInfo("El tipo de personería de la empresa es requerida");
                return false;

            }
            if (cbTipoDocumento.SelectedValue == null)
            {
                PysistemasMensajes.ShowInfo("El tipo de documento de la empresa es requerido");
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                PysistemasMensajes.ShowInfo("La dirección de la empresa es requerida");
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                PysistemasMensajes.ShowInfo("El teléfono de la empresa es requerido");
                return false;
            }

            return true;

        }

        private void txtNumeroDocumento_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }
    }
}
