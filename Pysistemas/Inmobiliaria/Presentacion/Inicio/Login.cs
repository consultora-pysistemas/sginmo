using System;
using System.Windows.Forms;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Services.Configuraciones;
using Inmobiliaria.Services.Seguridad;
using Inmobiliaria.Utilidades.Controles;

namespace Inmobiliaria.Presentacion.Inicio
{
    public partial class Login : Form
    {
        public USUARIOS UsuarioLogueado { get; set; }
        public PysistemasConfiguraciones Configuraciones { get; set; }
        public Login()
        {
            InitializeComponent();
            UsuarioLogueado = new USUARIOS();
            Configuraciones = new PysistemasConfiguraciones();
            txtUsuario.Text = Configuraciones.Read("Usuario", "Login");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            IngresoSistemaService ingresoSistemaService = new IngresoSistemaService();
            
            Respuesta respuestaIngresoSistema = ingresoSistemaService.IngresoSistema(txtUsuario.Text, txtPassword.Text);
            if (Constantes.TipoRespuesta.OK.Equals(respuestaIngresoSistema.Status))
            {
                UsuarioLogueado = (USUARIOS)respuestaIngresoSistema.Entity;

                Configuraciones.Write("Usuario",UsuarioLogueado.CODIGO_USUARIO,"Login");
                DialogResult = DialogResult.OK;
                Hide();
            }
            else
            {
                PysistemasMensajes.ShowInfo(respuestaIngresoSistema.Mensaje);
                txtUsuario.Focus();
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnSalir_Click(null,null);
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }
    }
}
