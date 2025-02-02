using System;
using System.Drawing;
using System.Windows.Forms;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Presentacion.Mantenimiento.Sucursales;

namespace Inmobiliaria.Presentacion.Mantenimiento.Seleccionadores
{
    public partial class FrmSeleccionarSucursales : Inmobiliaria.Presentacion.Genericos.FrmMaestro
    {
        public FrmSeleccionarSucursales(Principal frmPrincipal):base(frmPrincipal)
        {
            InitializeComponent();
            ConfiguracionesGrid(dgvSucursales);
        }

        private void FrmSeleccionarSucursales_Load(object sender, EventArgs e)
        {
            ObtenerSucursales();
        }

        public void ObtenerSucursales()
        {
            Int64 empresaId = Int64.Parse(FrmPrincipal.Configuraciones
                .ObtenerValorVariableEntorno(Constantes.VariablesEntorno.EMPRESA_ID).VALOR);
            using (SucursalesDao sucursalesDao = new SucursalesDao())
            {
                dgvSucursales.DataSource = sucursalesDao.ObtenerDesdeFiltros(s => s.EMPRESA_ID == empresaId);
            }
        }
        public void Seleccionar()
        {
            if (dgvSucursales.CurrentRow != null)
            {
                Int64 sucursalId = Int64.Parse(dgvSucursales.CurrentRow.Cells[0].Value.ToString());
                using (SucursalesDao sucursalesDao = new SucursalesDao())
                {
                    SUCURSALES sucursalActual = sucursalesDao.ObtenerDesdePk(sucursalId);
                    FrmPrincipal.Configuraciones.CambiarSucursales(sucursalActual,FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO);
                    FrmPrincipal.Configuraciones.CargarVariablesEntorno(FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO);
                    DialogResult = DialogResult.OK;
                    Hide();
                }
                
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void dgvSucursales_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }

        private void dgvSucursales_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Seleccionar();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FrmSucursales frmSucursales = new FrmSucursales(FrmPrincipal,Constantes.Operaciones.NUEVO);
            if (DialogResult.OK.Equals(frmSucursales.ShowDialog()))
            {

            }
            ObtenerSucursales();
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
           btnClose_Click(sender,e);
        }

        private void dgvSucursales_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvSucursales.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
