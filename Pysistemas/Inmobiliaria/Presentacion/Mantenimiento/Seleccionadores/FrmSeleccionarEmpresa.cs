using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Mantenimiento.Empresa;

namespace Inmobiliaria.Presentacion.Mantenimiento.Seleccionadores
{
    public partial class FrmSeleccionarEmpresa : Inmobiliaria.Presentacion.Genericos.FrmMaestro
    {
        public FrmSeleccionarEmpresa(Principal frmPrincipal):base(frmPrincipal)
        {
            InitializeComponent();
            ConfiguracionesGrid(dgvEmpresas);
        }

        public FrmSeleccionarEmpresa()
        {
            InitializeComponent();
        }

        async void FrmSeleccionarEmpresa_Load(object sender, EventArgs e)
        {
            await ObtenerEmpresas();
        }

        async Task ObtenerEmpresas()
        {
            using (EmpresasDao empresasDao = new EmpresasDao())
            {
                dgvEmpresas.DataSource = empresasDao.ObtenerLista();
            }
        }

        private void dgvEmpresas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEmpresas_CellMouseDoubleClick(sender,null);
        }

        private void dgvEmpresas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Seleccionar();
        }

        private void Seleccionar()
        {
            if (dgvEmpresas.CurrentRow != null)
            {
                EMPRESAS empresaActual = null;
                using (EmpresasDao empresasDao = new EmpresasDao())
                {
                    Int64 empresaId = Int64.Parse(dgvEmpresas.CurrentRow.Cells[0].Value.ToString());
                    empresaActual = empresasDao.ObtenerDesdePk(empresaId);
                    FrmPrincipal.Configuraciones.CambiarVariablesEntorno(empresaActual,FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO);
                }

                FrmPrincipal.Configuraciones.CargarVariablesEntorno(FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO);
                
                DialogResult = DialogResult.OK;
                Hide();

                /* using (VariablesEntornosDao variablesEntornosDao = new VariablesEntornosDao())
                 {
                     string codigoUsuarioLogueado = FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO;
                     IList<VARIABLES_ENTORNOS> variable = variablesEntornosDao.ObtenerDesdeFiltros(v => v.CLAVE.Equals(Constantes.VariablesEntorno.EMPRESA_ID) && v.CODIGO_USUARIO.Equals(codigoUsuarioLogueado));
                     if (variable != null && variable.Count > 0)
                     {
                         variable[0].VALOR = empresaActual.EMPRESA_ID.ToString();
                         variablesEntornosDao.Actualizar(variable[0]);
                         variablesEntornosDao.Guardar();
                         IList<VARIABLES_ENTORNOS> variableEmpresaId = variablesEntornosDao.ObtenerDesdeFiltros(v => v.CLAVE.Equals(Constantes.VariablesEntorno.EMPRESA) && v.CODIGO_USUARIO.Equals(codigoUsuarioLogueado));
                         if (variableEmpresaId.Count > 0)
                         {

                             variable[0].VALOR = empresaActual.RAZON_SOCIAL;
                             variablesEntornosDao.Actualizar(variable[0]);
                             variablesEntornosDao.Guardar();

                         }
                     }
                     variable.Clear();


                 }


     */
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Hide();
        }

        async void btnCrear_Click(object sender, EventArgs e)
        {
            FrmEmpresa frmEmpresa = new FrmEmpresa(FrmPrincipal,Constantes.Operaciones.NUEVO);
            if (DialogResult.OK.Equals(frmEmpresa.ShowDialog()))
            {
                
            }
            await ObtenerEmpresas();
        }

        private void dgvEmpresas_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvEmpresas.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
