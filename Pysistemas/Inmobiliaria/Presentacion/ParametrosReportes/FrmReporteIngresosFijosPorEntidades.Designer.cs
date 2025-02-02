namespace Inmobiliaria.Presentacion.ParametrosReportes
{
    partial class FrmReporteIngresosFijosPorEntidades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteIngresosFijosPorEntidades));            
            this.btnLimpiarEntidad = new System.Windows.Forms.Button();
            this.cbEntidades = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnEntidadesTodos = new System.Windows.Forms.Button();
            this.btnLimpiarTipoOperacion = new System.Windows.Forms.Button();
            this.cbTipoOperacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTipoOperacionTodos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crViewer
            // 
            this.crViewer.ActiveViewIndex = -1;
            this.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crViewer.EnableDrillDown = false;
            this.crViewer.Location = new System.Drawing.Point(0, 0);
            this.crViewer.Name = "crViewer";
            this.crViewer.ShowCopyButton = false;
            this.crViewer.ShowExportButton = false;
            this.crViewer.ShowGroupTreeButton = false;
            this.crViewer.ShowLogo = false;
            this.crViewer.ShowParameterPanelButton = false;
            this.crViewer.ShowRefreshButton = false;
            this.crViewer.Size = new System.Drawing.Size(1039, 600);
            this.crViewer.TabIndex = 0;
            this.crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTipoOperacionTodos);
            this.groupBox1.Controls.Add(this.btnLimpiarTipoOperacion);
            this.groupBox1.Controls.Add(this.cbTipoOperacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEntidadesTodos);
            this.groupBox1.Controls.Add(this.btnLimpiarEntidad);
            this.groupBox1.Controls.Add(this.cbEntidades);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Size = new System.Drawing.Size(295, 600);
            this.groupBox1.Controls.SetChildIndex(this.btnCancelar, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnGuardar, 0);
            this.groupBox1.Controls.SetChildIndex(this.label18, 0);
            this.groupBox1.Controls.SetChildIndex(this.cbEntidades, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnLimpiarEntidad, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnEntidadesTodos, 0);
            this.groupBox1.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.Controls.SetChildIndex(this.cbTipoOperacion, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnLimpiarTipoOperacion, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnTipoOperacionTodos, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(295, 600);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1039, 600);
            // 
            // splitContainer1
            // 
            this.splitContainer1.SplitterDistance = 295;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(18, 165);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(118, 165);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiarEntidad
            // 
            this.btnLimpiarEntidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarEntidad.BackgroundImage")));
            this.btnLimpiarEntidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarEntidad.Location = new System.Drawing.Point(192, 108);
            this.btnLimpiarEntidad.Name = "btnLimpiarEntidad";
            this.btnLimpiarEntidad.Size = new System.Drawing.Size(28, 28);
            this.btnLimpiarEntidad.TabIndex = 92;
            this.btnLimpiarEntidad.UseVisualStyleBackColor = true;
            this.btnLimpiarEntidad.Click += new System.EventHandler(this.btnLimpiarEntidad_Click);
            // 
            // cbEntidades
            // 
            this.cbEntidades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbEntidades.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEntidades.DisplayMember = "NOMBRE";
            this.cbEntidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEntidades.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEntidades.FormattingEnabled = true;
            this.cbEntidades.Location = new System.Drawing.Point(12, 111);
            this.cbEntidades.Name = "cbEntidades";
            this.cbEntidades.Size = new System.Drawing.Size(176, 23);
            this.cbEntidades.TabIndex = 90;
            this.cbEntidades.ValueMember = "ENTIDAD_INMOBILIARIA_ID";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(16, 89);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(121, 15);
            this.label18.TabIndex = 91;
            this.label18.Text = "Edificio/Loteamiento:";
            // 
            // btnEntidadesTodos
            // 
            this.btnEntidadesTodos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEntidadesTodos.Location = new System.Drawing.Point(225, 109);
            this.btnEntidadesTodos.Name = "btnEntidadesTodos";
            this.btnEntidadesTodos.Size = new System.Drawing.Size(47, 28);
            this.btnEntidadesTodos.TabIndex = 93;
            this.btnEntidadesTodos.Text = "Todos";
            this.btnEntidadesTodos.UseVisualStyleBackColor = true;
            this.btnEntidadesTodos.Click += new System.EventHandler(this.btnEntidadesTodos_Click);
            // 
            // btnLimpiarTipoOperacion
            // 
            this.btnLimpiarTipoOperacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarTipoOperacion.BackgroundImage")));
            this.btnLimpiarTipoOperacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarTipoOperacion.Location = new System.Drawing.Point(192, 50);
            this.btnLimpiarTipoOperacion.Name = "btnLimpiarTipoOperacion";
            this.btnLimpiarTipoOperacion.Size = new System.Drawing.Size(28, 28);
            this.btnLimpiarTipoOperacion.TabIndex = 96;
            this.btnLimpiarTipoOperacion.UseVisualStyleBackColor = true;
            this.btnLimpiarTipoOperacion.Click += new System.EventHandler(this.btnLimpiarTipoOperacion_Click);
            // 
            // cbTipoOperacion
            // 
            this.cbTipoOperacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbTipoOperacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTipoOperacion.DisplayMember = "VALOR_DOMINIO";
            this.cbTipoOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoOperacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoOperacion.FormattingEnabled = true;
            this.cbTipoOperacion.Location = new System.Drawing.Point(12, 53);
            this.cbTipoOperacion.Name = "cbTipoOperacion";
            this.cbTipoOperacion.Size = new System.Drawing.Size(176, 23);
            this.cbTipoOperacion.TabIndex = 94;
            this.cbTipoOperacion.ValueMember = "CODIGO_DOMINIO";
            this.cbTipoOperacion.SelectedValueChanged += new System.EventHandler(this.cbTipoOperacion_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 95;
            this.label1.Text = "Tipo Operación:";
            // 
            // btnTipoOperacionTodos
            // 
            this.btnTipoOperacionTodos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTipoOperacionTodos.Location = new System.Drawing.Point(226, 50);
            this.btnTipoOperacionTodos.Name = "btnTipoOperacionTodos";
            this.btnTipoOperacionTodos.Size = new System.Drawing.Size(47, 28);
            this.btnTipoOperacionTodos.TabIndex = 97;
            this.btnTipoOperacionTodos.Text = "Todos";
            this.btnTipoOperacionTodos.UseVisualStyleBackColor = true;
            this.btnTipoOperacionTodos.Click += new System.EventHandler(this.btnTipoOperacionTodos_Click);
            // 
            // FrmReporteIngresosFijosPorEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 643);
            this.Name = "FrmReporteIngresosFijosPorEntidades";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.FrmReporteIngresosFijosPorEntidades_Load);
            this.Shown += new System.EventHandler(this.FrmReporteIngresosFijosPorEntidades_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.Button btnLimpiarEntidad;
        private System.Windows.Forms.ComboBox cbEntidades;
        private System.Windows.Forms.Label label18;        
        private System.Windows.Forms.Button btnEntidadesTodos;        
        private System.Windows.Forms.Button btnLimpiarTipoOperacion;
        private System.Windows.Forms.ComboBox cbTipoOperacion;
        private System.Windows.Forms.Label label1; 
        private System.Windows.Forms.Button btnTipoOperacionTodos;        
    }
}