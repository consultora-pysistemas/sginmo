using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Presentacion.Genericos;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.Procesos
{
    public partial class FrmGenerarLotes : FrmMaestro
    {
        public FrmGenerarLotes()
        {
            InitializeComponent();
            lblTitulo.Text = "Generación de Lotes";
            CargarDatos();

        }
        async void CargarDatos()
        {
           
            await CargarEntidadesInmobiliarias();           

        }

        async Task CargarEntidadesInmobiliarias()
        {
            using (EntidadesInmobiliariasDao entidadesInmobiliariasDao = new EntidadesInmobiliariasDao())
            {
                cbLoteamiento.DataSource = entidadesInmobiliariasDao.ObtenerDesdeFiltros(c => "LOTEAMIENTO".Equals(c.TIPO));
                ControlesUtilidades.InicializarComboBox(cbLoteamiento);
               
            }


            return;
        }

        private void FrmGenerarLotes_Shown(object sender, EventArgs e)
        {
            cbLoteamiento.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // controlar que ya no exista el numero de manzana y los numeros de lotes cargados antes de generar


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtManzana_MouseClick(object sender, MouseEventArgs e)
        {
            txtManzana.SelectAll();
        }

        private void txtLoteDesde_MouseClick(object sender, MouseEventArgs e)
        {
            txtLoteDesde.SelectAll();
        }

        private void txtLoteHasta_MouseClick(object sender, MouseEventArgs e)
        {
            txtLoteHasta.SelectAll();
        }

        private void txtManzana_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void txtLoteDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void txtLoteHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }
    }
}
