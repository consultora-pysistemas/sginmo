namespace Inmobiliaria.Presentacion.ParametrosReportes
{
    partial class FrmReporteCobroAlquileres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteCobroAlquileres));
            this.cbEntidades = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnLimpiarEntidad = new System.Windows.Forms.Button();
            this.txtAnho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.crViewer.Size = new System.Drawing.Size(1089, 600);
            this.crViewer.TabIndex = 0;
            this.crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAnho);
            this.groupBox1.Controls.Add(this.btnLimpiarEntidad);
            this.groupBox1.Controls.Add(this.cbEntidades);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Size = new System.Drawing.Size(245, 600);
            this.groupBox1.Controls.SetChildIndex(this.btnCancelar, 0);
            this.groupBox1.Controls.SetChildIndex(this.label18, 0);
            this.groupBox1.Controls.SetChildIndex(this.cbEntidades, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnGuardar, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnLimpiarEntidad, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtAnho, 0);
            this.groupBox1.Controls.SetChildIndex(this.label1, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(245, 600);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1089, 600);
            // 
            // splitContainer1
            // 
            this.splitContainer1.SplitterDistance = 245;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 171);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(111, 171);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbEntidades
            // 
            this.cbEntidades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbEntidades.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEntidades.DisplayMember = "NOMBRE";
            this.cbEntidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEntidades.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEntidades.FormattingEnabled = true;
            this.cbEntidades.Location = new System.Drawing.Point(12, 66);
            this.cbEntidades.Name = "cbEntidades";
            this.cbEntidades.Size = new System.Drawing.Size(176, 23);
            this.cbEntidades.TabIndex = 93;
            this.cbEntidades.ValueMember = "ENTIDAD_INMOBILIARIA_ID";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(15, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(121, 15);
            this.label18.TabIndex = 94;
            this.label18.Text = "Edificio/Loteamiento:";
            // 
            // btnLimpiarEntidad
            // 
            this.btnLimpiarEntidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarEntidad.BackgroundImage")));
            this.btnLimpiarEntidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarEntidad.Location = new System.Drawing.Point(192, 63);
            this.btnLimpiarEntidad.Name = "btnLimpiarEntidad";
            this.btnLimpiarEntidad.Size = new System.Drawing.Size(28, 28);
            this.btnLimpiarEntidad.TabIndex = 95;
            this.btnLimpiarEntidad.UseVisualStyleBackColor = true;
            this.btnLimpiarEntidad.Click += new System.EventHandler(this.btnLimpiarEntidad_Click);
            // 
            // txtAnho
            // 
            this.txtAnho.Location = new System.Drawing.Point(12, 125);
            this.txtAnho.MaxLength = 4;
            this.txtAnho.Name = "txtAnho";
            this.txtAnho.Size = new System.Drawing.Size(64, 27);
            this.txtAnho.TabIndex = 96;
            this.txtAnho.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAnho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnho_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 97;
            this.label1.Text = "Año:";
            // 
            // FrmReporteCobroAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 643);
            this.Name = "FrmReporteCobroAlquileres";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.FrmReporteCobroAlquileres_Load);
            this.Shown += new System.EventHandler(this.FrmReporteCobroAlquileres_Shown);
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
        private System.Windows.Forms.TextBox txtAnho;
        private System.Windows.Forms.Label label1;
        
    }
}