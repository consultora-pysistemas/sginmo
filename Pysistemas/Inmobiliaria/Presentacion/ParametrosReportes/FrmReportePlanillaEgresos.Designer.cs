namespace Inmobiliaria.Presentacion.ParametrosReportes
{
    partial class FrmReportePlanillaEgresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportePlanillaEgresos));            
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPropiedadesTodos = new System.Windows.Forms.Button();
            this.btnEntidadesTodos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiarEntidad = new System.Windows.Forms.Button();
            this.cbPropiedades = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbEntidades = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
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
            this.crViewer.Size = new System.Drawing.Size(1058, 600);
            this.crViewer.TabIndex = 0;
            this.crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaHasta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFechaDesde);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPropiedadesTodos);
            this.groupBox1.Controls.Add(this.btnEntidadesTodos);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnLimpiarEntidad);
            this.groupBox1.Controls.Add(this.cbPropiedades);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cbEntidades);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.SetChildIndex(this.btnCancelar, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnGuardar, 0);
            this.groupBox1.Controls.SetChildIndex(this.label18, 0);
            this.groupBox1.Controls.SetChildIndex(this.cbEntidades, 0);
            this.groupBox1.Controls.SetChildIndex(this.label17, 0);
            this.groupBox1.Controls.SetChildIndex(this.cbPropiedades, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnLimpiarEntidad, 0);
            this.groupBox1.Controls.SetChildIndex(this.button1, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnEntidadesTodos, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnPropiedadesTodos, 0);
            this.groupBox1.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.Controls.SetChildIndex(this.dtpFechaDesde, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.dtpFechaHasta, 0);
            // 
            // splitContainer1
            // 
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(42, 293);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(141, 293);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(5, 222);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(130, 27);
            this.dtpFechaHasta.TabIndex = 123;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 122;
            this.label2.Text = "Fecha hasta:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(6, 161);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(130, 27);
            this.dtpFechaDesde.TabIndex = 121;
            this.dtpFechaDesde.Value = new System.DateTime(2018, 1, 1, 23, 10, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 120;
            this.label1.Text = "Fecha desde:";
            // 
            // btnPropiedadesTodos
            // 
            this.btnPropiedadesTodos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPropiedadesTodos.Location = new System.Drawing.Point(222, 109);
            this.btnPropiedadesTodos.Name = "btnPropiedadesTodos";
            this.btnPropiedadesTodos.Size = new System.Drawing.Size(47, 28);
            this.btnPropiedadesTodos.TabIndex = 119;
            this.btnPropiedadesTodos.Text = "Todos";
            this.btnPropiedadesTodos.UseVisualStyleBackColor = true;
            this.btnPropiedadesTodos.Click += new System.EventHandler(this.btnPropiedadesTodos_Click);
            // 
            // btnEntidadesTodos
            // 
            this.btnEntidadesTodos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEntidadesTodos.Location = new System.Drawing.Point(222, 57);
            this.btnEntidadesTodos.Name = "btnEntidadesTodos";
            this.btnEntidadesTodos.Size = new System.Drawing.Size(47, 28);
            this.btnEntidadesTodos.TabIndex = 118;
            this.btnEntidadesTodos.Text = "Todos";
            this.btnEntidadesTodos.UseVisualStyleBackColor = true;
            this.btnEntidadesTodos.Click += new System.EventHandler(this.btnEntidadesTodos_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(188, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 117;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiarEntidad
            // 
            this.btnLimpiarEntidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarEntidad.BackgroundImage")));
            this.btnLimpiarEntidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarEntidad.Location = new System.Drawing.Point(188, 56);
            this.btnLimpiarEntidad.Name = "btnLimpiarEntidad";
            this.btnLimpiarEntidad.Size = new System.Drawing.Size(28, 28);
            this.btnLimpiarEntidad.TabIndex = 116;
            this.btnLimpiarEntidad.UseVisualStyleBackColor = true;
            this.btnLimpiarEntidad.Click += new System.EventHandler(this.btnLimpiarEntidad_Click);
            // 
            // cbPropiedades
            // 
            this.cbPropiedades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbPropiedades.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbPropiedades.DisplayMember = "NOMBRE";
            this.cbPropiedades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPropiedades.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPropiedades.FormattingEnabled = true;
            this.cbPropiedades.Location = new System.Drawing.Point(6, 111);
            this.cbPropiedades.Name = "cbPropiedades";
            this.cbPropiedades.Size = new System.Drawing.Size(178, 23);
            this.cbPropiedades.TabIndex = 113;
            this.cbPropiedades.ValueMember = "PROPIEDAD_ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 93);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 15);
            this.label17.TabIndex = 115;
            this.label17.Text = "Dpto/Casa/Salón/Lote:";
            // 
            // cbEntidades
            // 
            this.cbEntidades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbEntidades.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEntidades.DisplayMember = "NOMBRE";
            this.cbEntidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEntidades.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEntidades.FormattingEnabled = true;
            this.cbEntidades.Location = new System.Drawing.Point(6, 59);
            this.cbEntidades.Name = "cbEntidades";
            this.cbEntidades.Size = new System.Drawing.Size(178, 23);
            this.cbEntidades.TabIndex = 112;
            this.cbEntidades.ValueMember = "ENTIDAD_INMOBILIARIA_ID";
            this.cbEntidades.SelectedValueChanged += new System.EventHandler(this.cbEntidades_SelectedValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(121, 15);
            this.label18.TabIndex = 114;
            this.label18.Text = "Edificio/Loteamiento:";
            // 
            // FrmReportePlanillaEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 643);
            this.Name = "FrmReportePlanillaEgresos";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.FrmReportePlanillaEgresos_Load);
            this.Shown += new System.EventHandler(this.FrmReportePlanillaEgresos_Shown);
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

        public System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPropiedadesTodos;
        private System.Windows.Forms.Button btnEntidadesTodos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpiarEntidad;
        private System.Windows.Forms.ComboBox cbPropiedades;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbEntidades;
        private System.Windows.Forms.Label label18;
    }
}