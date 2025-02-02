namespace Inmobiliaria.Presentacion.ParametrosReportes
{
    partial class FrmReportePlanillaRecaudacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportePlanillaRecaudacion));            
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnho = new System.Windows.Forms.TextBox();
            this.cbMeses = new System.Windows.Forms.ComboBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnTipoOperacionTodos = new System.Windows.Forms.Button();
            this.btnLimpiarTipoOperacion = new System.Windows.Forms.Button();
            this.cbTipoOperacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.crViewer.Size = new System.Drawing.Size(1062, 600);
            this.crViewer.TabIndex = 0;
            this.crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTipoOperacionTodos);
            this.groupBox1.Controls.Add(this.btnLimpiarTipoOperacion);
            this.groupBox1.Controls.Add(this.cbTipoOperacion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFechaHasta);
            this.groupBox1.Controls.Add(this.dtpFechaDesde);
            this.groupBox1.Controls.Add(this.cbMeses);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAnho);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Size = new System.Drawing.Size(272, 600);
            this.groupBox1.Controls.SetChildIndex(this.btnCancelar, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnGuardar, 0);
            this.groupBox1.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtAnho, 0);
            this.groupBox1.Controls.SetChildIndex(this.label3, 0);
            this.groupBox1.Controls.SetChildIndex(this.cbMeses, 0);
            this.groupBox1.Controls.SetChildIndex(this.dtpFechaDesde, 0);
            this.groupBox1.Controls.SetChildIndex(this.dtpFechaHasta, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.cbTipoOperacion, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnLimpiarTipoOperacion, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnTipoOperacionTodos, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(272, 600);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1062, 600);
            // 
            // splitContainer1
            // 
            this.splitContainer1.SplitterDistance = 272;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(23, 166);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(122, 166);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 112;
            this.label1.Text = "Mes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 118;
            this.label3.Text = "Año:";
            // 
            // txtAnho
            // 
            this.txtAnho.Location = new System.Drawing.Point(164, 119);
            this.txtAnho.MaxLength = 4;
            this.txtAnho.Name = "txtAnho";
            this.txtAnho.Size = new System.Drawing.Size(64, 27);
            this.txtAnho.TabIndex = 1;
            this.txtAnho.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbMeses
            // 
            this.cbMeses.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbMeses.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbMeses.DisplayMember = "NOMBRE";
            this.cbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeses.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMeses.FormattingEnabled = true;
            this.cbMeses.Location = new System.Drawing.Point(10, 119);
            this.cbMeses.Name = "cbMeses";
            this.cbMeses.Size = new System.Drawing.Size(140, 28);
            this.cbMeses.TabIndex = 0;
            this.cbMeses.ValueMember = "VALOR";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(71, 317);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(130, 27);
            this.dtpFechaHasta.TabIndex = 140;
            this.dtpFechaHasta.Visible = false;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(72, 256);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(130, 27);
            this.dtpFechaDesde.TabIndex = 139;
            this.dtpFechaDesde.Value = new System.DateTime(2018, 1, 1, 23, 10, 0, 0);
            this.dtpFechaDesde.Visible = false;
            // 
            // btnTipoOperacionTodos
            // 
            this.btnTipoOperacionTodos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTipoOperacionTodos.Location = new System.Drawing.Point(195, 58);
            this.btnTipoOperacionTodos.Name = "btnTipoOperacionTodos";
            this.btnTipoOperacionTodos.Size = new System.Drawing.Size(47, 28);
            this.btnTipoOperacionTodos.TabIndex = 144;
            this.btnTipoOperacionTodos.Text = "Todos";
            this.btnTipoOperacionTodos.UseVisualStyleBackColor = true;
            this.btnTipoOperacionTodos.Click += new System.EventHandler(this.btnTipoOperacionTodos_Click);
            // 
            // btnLimpiarTipoOperacion
            // 
            this.btnLimpiarTipoOperacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarTipoOperacion.BackgroundImage")));
            this.btnLimpiarTipoOperacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarTipoOperacion.Location = new System.Drawing.Point(163, 58);
            this.btnLimpiarTipoOperacion.Name = "btnLimpiarTipoOperacion";
            this.btnLimpiarTipoOperacion.Size = new System.Drawing.Size(28, 28);
            this.btnLimpiarTipoOperacion.TabIndex = 143;
            this.btnLimpiarTipoOperacion.UseVisualStyleBackColor = true;
            this.btnLimpiarTipoOperacion.Click += new System.EventHandler(this.btnLimpiarTipoOperacion_Click);
            // 
            // cbTipoOperacion
            // 
            this.cbTipoOperacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbTipoOperacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTipoOperacion.DisplayMember = "VALOR_DOMINIO";
            this.cbTipoOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoOperacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoOperacion.FormattingEnabled = true;
            this.cbTipoOperacion.Location = new System.Drawing.Point(10, 58);
            this.cbTipoOperacion.Name = "cbTipoOperacion";
            this.cbTipoOperacion.Size = new System.Drawing.Size(150, 28);
            this.cbTipoOperacion.TabIndex = 141;
            this.cbTipoOperacion.ValueMember = "CODIGO_DOMINIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 142;
            this.label2.Text = "Tipo Operación:";
            // 
            // FrmReportePlanillaRecaudacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 643);
            this.Name = "FrmReportePlanillaRecaudacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.FrmReportePlanillaRecaudacion_Load);
            this.Shown += new System.EventHandler(this.FrmReportePlanillaRecaudacion_Shown);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnho;
        private System.Windows.Forms.ComboBox cbMeses;
        public System.Windows.Forms.DateTimePicker dtpFechaHasta;
        public System.Windows.Forms.DateTimePicker dtpFechaDesde;        
        private System.Windows.Forms.Button btnTipoOperacionTodos;
        private System.Windows.Forms.Button btnLimpiarTipoOperacion;
        private System.Windows.Forms.ComboBox cbTipoOperacion;
        private System.Windows.Forms.Label label2;
    }
}