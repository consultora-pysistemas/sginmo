using System;
using System.Drawing;
using System.Windows.Forms;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Utilidades.Controles;

namespace Inmobiliaria.Presentacion.Genericos
{
    public partial class FrmMaestro : Form
    {
        protected Principal FrmPrincipal { get; set; }
        protected FrmMaestro(Principal principal)
        {
            FrmPrincipal = principal;
            InitializeComponent();
           
        }

        protected FrmMaestro()
        {
            InitializeComponent();
        }

        protected void ConfiguracionesGrid(DataGridView dgv)
        {
            if (dgv != null)
            {
                DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
                dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGridViewCellStyle1.BackColor = SystemColors.Control;
                dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
                dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
                dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
                dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
                dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
                foreach(DataGridViewColumn colum in dgv.Columns)
                {
                    colum.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
            
        }
        protected virtual void LimpiarPantalla() {
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            Cerrar();

        }

        protected virtual void Cerrar()
        {
            if (PysistemasMensajes.AskConfirmation(
                "Está seguro que desea cerrar la ventana?. Se perderán los datos que no haya guardado"))
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }


}
