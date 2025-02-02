namespace Inmobiliaria.Presentacion.ParametrosReportes
{
    partial class FrmReporteDatosPropiedades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteDatosPropiedades));            
            this.btnLimpiarEntidad = new System.Windows.Forms.Button();
            this.cbPropiedades = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbEntidades = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnLimpiarPropiedad = new System.Windows.Forms.Button();
            this.btnEntidadesTodos = new System.Windows.Forms.Button();
            this.btnPropiedadesTodos = new System.Windows.Forms.Button();
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
            this.crViewer.Size = new System.Drawing.Size(951, 600);
            this.crViewer.TabIndex = 0;
            this.crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPropiedadesTodos);
            this.groupBox1.Controls.Add(this.btnEntidadesTodos);
            this.groupBox1.Controls.Add(this.btnLimpiarPropiedad);
            this.groupBox1.Controls.Add(this.btnLimpiarEntidad);
            this.groupBox1.Controls.Add(this.cbPropiedades);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cbEntidades);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Size = new System.Drawing.Size(309, 600);
            this.groupBox1.Controls.SetChildIndex(this.btnCancelar, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnGuardar, 0);
            this.groupBox1.Controls.SetChildIndex(this.label18, 0);
            this.groupBox1.Controls.SetChildIndex(this.cbEntidades, 0);
            this.groupBox1.Controls.SetChildIndex(this.label17, 0);
            this.groupBox1.Controls.SetChildIndex(this.cbPropiedades, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnLimpiarEntidad, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnLimpiarPropiedad, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnEntidadesTodos, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnPropiedadesTodos, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(309, 600);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Size = new System.Drawing.Size(951, 600);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Size = new System.Drawing.Size(1264, 600);
            this.splitContainer1.SplitterDistance = 309;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(6, 145);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(103, 145);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1264, 43);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(1192, 43);
            // 
            // btnLimpiarEntidad
            // 
            this.btnLimpiarEntidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarEntidad.BackgroundImage")));
            this.btnLimpiarEntidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarEntidad.Location = new System.Drawing.Point(223, 49);
            this.btnLimpiarEntidad.Name = "btnLimpiarEntidad";
            this.btnLimpiarEntidad.Size = new System.Drawing.Size(28, 28);
            this.btnLimpiarEntidad.TabIndex = 89;
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
            this.cbPropiedades.Location = new System.Drawing.Point(7, 104);
            this.cbPropiedades.Name = "cbPropiedades";
            this.cbPropiedades.Size = new System.Drawing.Size(211, 23);
            this.cbPropiedades.TabIndex = 85;
            this.cbPropiedades.ValueMember = "PROPIEDAD_ID";
            this.cbPropiedades.SelectedIndexChanged += new System.EventHandler(this.cbPropiedades_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(7, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 15);
            this.label17.TabIndex = 88;
            this.label17.Text = "Dpto/Casa/Salón/Lote:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // cbEntidades
            // 
            this.cbEntidades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbEntidades.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEntidades.DisplayMember = "NOMBRE";
            this.cbEntidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEntidades.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEntidades.FormattingEnabled = true;
            this.cbEntidades.Location = new System.Drawing.Point(7, 52);
            this.cbEntidades.Name = "cbEntidades";
            this.cbEntidades.Size = new System.Drawing.Size(211, 23);
            this.cbEntidades.TabIndex = 84;
            this.cbEntidades.ValueMember = "ENTIDAD_INMOBILIARIA_ID";
            this.cbEntidades.SelectedIndexChanged += new System.EventHandler(this.cbEntidades_SelectedIndexChanged);
            this.cbEntidades.SelectedValueChanged += new System.EventHandler(this.cbEntidades_SelectedValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(7, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(121, 15);
            this.label18.TabIndex = 87;
            this.label18.Text = "Edificio/Loteamiento:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // btnLimpiarPropiedad
            // 
            this.btnLimpiarPropiedad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarPropiedad.BackgroundImage")));
            this.btnLimpiarPropiedad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarPropiedad.Location = new System.Drawing.Point(223, 101);
            this.btnLimpiarPropiedad.Name = "btnLimpiarPropiedad";
            this.btnLimpiarPropiedad.Size = new System.Drawing.Size(28, 28);
            this.btnLimpiarPropiedad.TabIndex = 90;
            this.btnLimpiarPropiedad.UseVisualStyleBackColor = true;
            this.btnLimpiarPropiedad.Click += new System.EventHandler(this.btnLimpiarPropiedad_Click);
            // 
            // btnEntidadesTodos
            // 
            this.btnEntidadesTodos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEntidadesTodos.Location = new System.Drawing.Point(258, 49);
            this.btnEntidadesTodos.Name = "btnEntidadesTodos";
            this.btnEntidadesTodos.Size = new System.Drawing.Size(47, 28);
            this.btnEntidadesTodos.TabIndex = 91;
            this.btnEntidadesTodos.Text = "Todos";
            this.btnEntidadesTodos.UseVisualStyleBackColor = true;
            this.btnEntidadesTodos.Click += new System.EventHandler(this.btnEntidadesTodos_Click);
            // 
            // btnPropiedadesTodos
            // 
            this.btnPropiedadesTodos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPropiedadesTodos.Location = new System.Drawing.Point(258, 101);
            this.btnPropiedadesTodos.Name = "btnPropiedadesTodos";
            this.btnPropiedadesTodos.Size = new System.Drawing.Size(47, 28);
            this.btnPropiedadesTodos.TabIndex = 92;
            this.btnPropiedadesTodos.Text = "Todos";
            this.btnPropiedadesTodos.UseVisualStyleBackColor = true;
            this.btnPropiedadesTodos.Click += new System.EventHandler(this.btnPropiedadesTodos_Click);
            // 
            // FrmReporteDatosPropiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1264, 643);
            this.Name = "FrmReporteDatosPropiedades";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.FrmReporteDatosPropiedades_Load);
            this.Shown += new System.EventHandler(this.FrmReporteDatosPropiedades_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiarEntidad;
        private System.Windows.Forms.ComboBox cbPropiedades;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbEntidades;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnLimpiarPropiedad;
        private System.Windows.Forms.Button btnEntidadesTodos;
        private System.Windows.Forms.Button btnPropiedadesTodos;        
    }
}
