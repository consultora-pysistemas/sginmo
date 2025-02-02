using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Dao.Usuarios;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Services.Usuarios;
using Inmobiliaria.Utilidades.Controles;
using Inmobiliaria.Utilidades.Seguridad;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Inmobiliaria.Presentacion.Mantenimiento.Usuarios
{
    public partial class FrmUsuarios : Genericos.FrmMaestro
    {
        public string Operacion { get; set; }
        public USUARIOS Entity { get; set; }


        public FrmUsuarios(Principal principal, String operacion) : base(principal)
        {
            InitializeComponent();
            Operacion = operacion;

            Entity = new USUARIOS();
            CargarDatos();
        }

        async void CargarDatos()
        {
            await CargarTiposPerfil();
        }

        async Task CargarTiposPerfil()
        {

            using (DominiosDao dominiosDao = new DominiosDao())
            {
                cbTipoPerfil.DataSource = dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.TIPOS_PERFILES));
                ControlesUtilidades.InicializarComboBox(cbTipoPerfil);
            }

            return;
        }

        protected override void LimpiarPantalla()
        {
            ControlesUtilidades.ClearComponents(gbDatosUsuarios);
            txtUsuario.Focus();

        }
        private bool VerificarDatosObligatorios()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) && string.IsNullOrWhiteSpace(txtPassword.Text)
                && string.IsNullOrWhiteSpace(txtPasswordConfirmacion.Text))
                return false;
            return true;
        }
        private bool VerificarUsuario(String Usuario)
        {
            String UsuarioTrimeado = Usuario.Trim();
            if (String.IsNullOrEmpty(UsuarioTrimeado))
            {
                PysistemasMensajes.ShowInfo("Por favor cargue el nombre del usuario.");
                txtUsuario.Focus();
                return false;
            }
            else
            {
                if (Constantes.Operaciones.NUEVO.Equals(Operacion))
                {
                    using (UsuariosDao userDao = new UsuariosDao())
                    {
                        Int64 contador = userDao.ObtenerDesdeFiltros(c => c.CODIGO_USUARIO == UsuarioTrimeado).Count();
                        if (contador > 0)
                        {
                            PysistemasMensajes.ShowInfo("Ya existe un usuario cargado con el nombre: " + UsuarioTrimeado + " por favor verifique.");
                            txtUsuario.Focus();
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private bool VerificarPassword(String Password, String Confirmacion)
        {
            
            if (String.IsNullOrEmpty(Password) || String.IsNullOrEmpty(Confirmacion))
            {
                PysistemasMensajes.ShowInfo("Por favor cargue la contraseña y la confirmacion.");
                txtUsuario.Focus();
                return false;
            }
            else
            {
                if (Password != Confirmacion)
                {
                    PysistemasMensajes.ShowInfo("La contraseña no es igual a la confirmacion, por favor verifique.");
                    txtPassword.Focus();
                    return false;
                }
            }
            return true;
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
        private void LimpiarFormulario()
        {
            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                lblTitulo.Text = "Crear Usuario";
                txtUsuario.Focus();
                checkBoxActivo.Checked = true;
                txtUsuario.ReadOnly = false;
                Entity = new USUARIOS();

            }
            else if (Constantes.Operaciones.EDITAR.Equals(Operacion))
            {                
                lblTitulo.Text = "Modificar Usuario";
                txtUsuario.ReadOnly = true;
                CargarDatosUsuarios();
            }
        }
        private void CargarDatosUsuarios()
        {
            if (Entity != null)
            {
                txtUsuario.Text = Entity.CODIGO_USUARIO;

                txtPassword.Text = PysistemasSeguridad.Desencriptar(Entity.PASSWORD);
                txtPasswordConfirmacion.Text = PysistemasSeguridad.Desencriptar(Entity.PASSWORD);
                checkBoxActivo.Checked = Entity.ACTIVO == "SI" ? true : false;
                cbTipoPerfil.SelectedValue = Entity.PERFIL;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!VerificarDatosObligatorios())
            {
                PysistemasMensajes.ShowInfo("Cargue los campos basicos por favor");
                txtUsuario.Focus();
                return;
            }
            
            else if (VerificarUsuario(txtUsuario.Text) && VerificarPassword(txtPassword.Text, txtPasswordConfirmacion.Text))
            {
                

                UsuariosService service = new UsuariosService();


                Entity.CODIGO_USUARIO = txtUsuario.Text;

                Entity.PASSWORD = PysistemasSeguridad.Encriptar(txtPassword.Text);                
                Entity.ACTIVO = checkBoxActivo.Checked == true ? "SI" : "NO";
                Entity.EMPRESA_ID = FrmPrincipal.Empresa.EMPRESA_ID;
                if (cbTipoPerfil.SelectedValue != null)
                {
                    Entity.PERFIL = cbTipoPerfil.SelectedValue.ToString();
                }
                else
                {
                    PysistemasMensajes.ShowInfo("Por favor asigne un perfil al usuario.");
                    cbTipoPerfil.Focus();
                    return;
                }


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

        private void checkBoxActivo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmUsuarios_Shown(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}
