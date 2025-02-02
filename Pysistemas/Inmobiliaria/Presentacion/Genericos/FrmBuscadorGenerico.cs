using System;
using System.Windows.Forms;
using Inmobiliaria.Presentacion.Inicio;

namespace Inmobiliaria.Presentacion.Genericos
{
    public partial class FrmBuscadorGenerico : FrmMaestro
    {
        protected DataGridView Dgv { get; set; }
      
        protected FrmBuscadorGenerico(Principal principal) : base(principal)
        {
            InitializeComponent();
            ConfiguracionesGrid(Dgv);
        }

        protected FrmBuscadorGenerico() {
            InitializeComponent();
        }
        protected virtual void Nuevo() { }
        protected virtual void Editar() { }
        protected virtual void Eliminar() { }
        protected virtual void Buscar() { }

        private void tsbtnNuevo_Click(object sender, EventArgs e) => Nuevo();

        private void tsBtnEditar_Click(object sender, EventArgs e) => Editar();

        private void tsbtnEliminar_Click(object sender, EventArgs e) => Eliminar();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((Keys.Control | Keys.N).Equals(keyData))
            {
                Nuevo();
                return true;
            }
            if (Keys.F2.Equals(keyData))
            {
                Editar();

                return true;
            }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void Cerrar() => this.Close();
    }
}
