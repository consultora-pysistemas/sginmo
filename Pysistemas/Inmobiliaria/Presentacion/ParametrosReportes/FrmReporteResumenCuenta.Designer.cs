namespace Inmobiliaria.Presentacion.ParametrosReportes
{
    partial class FrmReporteResumenCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteResumenCuenta));
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiarEntidad = new System.Windows.Forms.Button();
            this.btnBuscadorSocioNegocio = new System.Windows.Forms.Button();
            this.btnBuscarPropiedad = new System.Windows.Forms.Button();
            this.txtSocioNegocio = new System.Windows.Forms.TextBox();
            this.txtPropiedad = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.txtPropiedad);
            this.groupBox1.Controls.Add(this.txtSocioNegocio);
            this.groupBox1.Controls.Add(this.btnBuscarPropiedad);
            this.groupBox1.Controls.Add(this.btnBuscadorSocioNegocio);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnLimpiarEntidad);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.SetChildIndex(this.label18, 0);
            this.groupBox1.Controls.SetChildIndex(this.label17, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnLimpiarEntidad, 0);
            this.groupBox1.Controls.SetChildIndex(this.button1, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnBuscadorSocioNegocio, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnBuscarPropiedad, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnCancelar, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnGuardar, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtSocioNegocio, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtPropiedad, 0);
            // 
            // splitContainer1
            // 
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(24, 226);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(123, 226);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 134);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 15);
            this.label17.TabIndex = 109;
            this.label17.Text = "Dpto/Casa/Salón/Lote:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 15);
            this.label18.TabIndex = 108;
            this.label18.Text = "Clientes/Propietarios:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(188, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 111;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiarEntidad
            // 
            this.btnLimpiarEntidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarEntidad.BackgroundImage")));
            this.btnLimpiarEntidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarEntidad.Location = new System.Drawing.Point(188, 97);
            this.btnLimpiarEntidad.Name = "btnLimpiarEntidad";
            this.btnLimpiarEntidad.Size = new System.Drawing.Size(28, 28);
            this.btnLimpiarEntidad.TabIndex = 110;
            this.btnLimpiarEntidad.UseVisualStyleBackColor = true;
            this.btnLimpiarEntidad.Click += new System.EventHandler(this.btnLimpiarEntidad_Click);
            // 
            // btnBuscadorSocioNegocio
            // 
            this.btnBuscadorSocioNegocio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscadorSocioNegocio.BackgroundImage")));
            this.btnBuscadorSocioNegocio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscadorSocioNegocio.Location = new System.Drawing.Point(218, 97);
            this.btnBuscadorSocioNegocio.Name = "btnBuscadorSocioNegocio";
            this.btnBuscadorSocioNegocio.Size = new System.Drawing.Size(28, 28);
            this.btnBuscadorSocioNegocio.TabIndex = 112;
            this.btnBuscadorSocioNegocio.UseVisualStyleBackColor = true;
            this.btnBuscadorSocioNegocio.Click += new System.EventHandler(this.btnBuscadorSocioNegocio_Click);
            // 
            // btnBuscarPropiedad
            // 
            this.btnBuscarPropiedad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarPropiedad.BackgroundImage")));
            this.btnBuscarPropiedad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPropiedad.Location = new System.Drawing.Point(218, 151);
            this.btnBuscarPropiedad.Name = "btnBuscarPropiedad";
            this.btnBuscarPropiedad.Size = new System.Drawing.Size(28, 28);
            this.btnBuscarPropiedad.TabIndex = 113;
            this.btnBuscarPropiedad.UseVisualStyleBackColor = true;
            this.btnBuscarPropiedad.Click += new System.EventHandler(this.btnBuscarPropiedad_Click);
            // 
            // txtSocioNegocio
            // 
            this.txtSocioNegocio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSocioNegocio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSocioNegocio.Location = new System.Drawing.Point(8, 100);
            this.txtSocioNegocio.MaxLength = 180;
            this.txtSocioNegocio.Name = "txtSocioNegocio";
            this.txtSocioNegocio.Size = new System.Drawing.Size(176, 23);
            this.txtSocioNegocio.TabIndex = 114;
            // 
            // txtPropiedad
            // 
            this.txtPropiedad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPropiedad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropiedad.Location = new System.Drawing.Point(8, 154);
            this.txtPropiedad.MaxLength = 180;
            this.txtPropiedad.Name = "txtPropiedad";
            this.txtPropiedad.Size = new System.Drawing.Size(176, 23);
            this.txtPropiedad.TabIndex = 115;
            // 
            // FrmReporteResumenCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1338, 643);
            this.Name = "FrmReporteResumenCuenta";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.FrmReporteResumenCuenta_Load);
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

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpiarEntidad;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnBuscarPropiedad;
        private System.Windows.Forms.Button btnBuscadorSocioNegocio;
        private System.Windows.Forms.TextBox txtSocioNegocio;
        private System.Windows.Forms.TextBox txtPropiedad;
    }
}
