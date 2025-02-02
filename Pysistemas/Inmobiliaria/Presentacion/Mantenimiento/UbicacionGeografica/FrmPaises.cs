using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Services.Mantenimientos;
using Inmobiliaria.Utilidades.Controles;
using System;

namespace Inmobiliaria.Presentacion.Mantenimiento.UbicacionGeografica
{
    public partial class FrmPaises : Genericos.FrmMaestro
    {
        public string Operacion { get; set; }
        public PAISES Entity { get; set; }        


        public FrmPaises(Principal principal, String operacion) : base(principal)
        {
            InitializeComponent();
            Operacion = operacion;
            
            Entity = new PAISES();
        }        

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            PaisesService service = new PaisesService();
            /*
            if (Constantes.Operaciones.EDITAR.Equals(Operacion))
            {
                using (PaisDao paisDao = new PaisDao())
                {
                    Entity = paisDao.ObtenerDesdePk(Entity.PAIS_ID);
                }
            }
            */
            Entity.PAIS = txtPais.Text;
            Entity.CODIGO_ISO_2 = txtCodigoIso2.Text;
            Entity.CODIGO_ISO_3 = txtCodigoIso3.Text;
            Entity.NACIONALIDAD = txtNacionalidad.Text;

            service.Guardar(Operacion, Entity, FrmPrincipal.UsuarioLogueado);
            PysistemasMensajes.ShowInfo("Los datos se guardarón con éxito");
            Close();
        }
        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            btnClose_Click(sender, e);
        }

        private void FrmPaises_Load(object sender, EventArgs e)
        {

            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                lblTitulo.Text = "Crear Pais";


            }
            else
            {
                lblTitulo.Text = "Modificar Pais";
                CargarDatosPais();
            }
        }

        private void CargarDatosPais()
        {
            txtPais.Text = Entity.PAIS;
            txtCodigoIso2.Text = Entity.CODIGO_ISO_2;
            txtCodigoIso3.Text = Entity.CODIGO_ISO_3;
            txtNacionalidad.Text = Entity.NACIONALIDAD;

        }

        private void FrmPaises_Shown(object sender, EventArgs e)
        {
            txtPais.Focus();
        }
    }
}
