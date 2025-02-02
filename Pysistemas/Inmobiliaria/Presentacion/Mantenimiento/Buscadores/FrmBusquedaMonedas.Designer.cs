namespace Inmobiliaria.Presentacion.Mantenimiento.Buscadores
{
    partial class FrmBusquedaMonedas
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
            this.components = new System.ComponentModel.Container();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMonedas = new System.Windows.Forms.DataGridView();
            this.mONEDAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONEDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIMBOLODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIMBOLOSETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOMONEDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECISIONDECIMALESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOCREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHACREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONEDASVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatos.SuspendLayout();
            this.pnlFiltrosBusqueda.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonedas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONEDASVIEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Size = new System.Drawing.Size(864, 46);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.dgvMonedas);
            this.pnlDatos.Size = new System.Drawing.Size(864, 439);
            this.pnlDatos.Controls.SetChildIndex(this.pnlFiltrosBusqueda, 0);
            this.pnlDatos.Controls.SetChildIndex(this.dgvMonedas, 0);
            // 
            // pnlFiltrosBusqueda
            // 
            this.pnlFiltrosBusqueda.Controls.Add(this.btnBuscar);
            this.pnlFiltrosBusqueda.Controls.Add(this.btnCancelar);
            this.pnlFiltrosBusqueda.Controls.Add(this.txtMoneda);
            this.pnlFiltrosBusqueda.Controls.Add(this.label3);
            this.pnlFiltrosBusqueda.Size = new System.Drawing.Size(260, 437);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(864, 43);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(792, 43);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(20, 166);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 35);
            this.btnBuscar.TabIndex = 56;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(83)))), ((int)(((byte)(44)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(119, 166);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 35);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "Limpiar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtMoneda
            // 
            this.txtMoneda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMoneda.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneda.Location = new System.Drawing.Point(11, 116);
            this.txtMoneda.MaxLength = 20;
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(233, 22);
            this.txtMoneda.TabIndex = 52;
            this.txtMoneda.TextChanged += new System.EventHandler(this.txtMoneda_TextChanged);
            this.txtMoneda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoneda_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Moneda";
            // 
            // dgvMonedas
            // 
            this.dgvMonedas.AllowUserToAddRows = false;
            this.dgvMonedas.AllowUserToDeleteRows = false;
            this.dgvMonedas.AllowUserToOrderColumns = true;
            this.dgvMonedas.AutoGenerateColumns = false;
            this.dgvMonedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonedas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mONEDAIDDataGridViewTextBoxColumn,
            this.mONEDADataGridViewTextBoxColumn,
            this.sIMBOLODataGridViewTextBoxColumn,
            this.sIMBOLOSETDataGridViewTextBoxColumn,
            this.tIPOMONEDADataGridViewTextBoxColumn,
            this.pRECISIONDECIMALESDataGridViewTextBoxColumn,
            this.uSUARIOCREACIONDataGridViewTextBoxColumn,
            this.fECHACREACIONDataGridViewTextBoxColumn,
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn,
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn});
            this.dgvMonedas.DataSource = this.mONEDASVIEWBindingSource;
            this.dgvMonedas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonedas.Location = new System.Drawing.Point(260, 0);
            this.dgvMonedas.Name = "dgvMonedas";
            this.dgvMonedas.ReadOnly = true;
            this.dgvMonedas.Size = new System.Drawing.Size(602, 437);
            this.dgvMonedas.TabIndex = 14;
            this.dgvMonedas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonedas_CellContentClick);
            this.dgvMonedas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonedas_CellContentDoubleClick);
            this.dgvMonedas.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvMonedas_RowPostPaint);
            this.dgvMonedas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvMonedas_MouseClick);
            // 
            // mONEDAIDDataGridViewTextBoxColumn
            // 
            this.mONEDAIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.mONEDAIDDataGridViewTextBoxColumn.DataPropertyName = "MONEDA_ID";
            this.mONEDAIDDataGridViewTextBoxColumn.FillWeight = 50F;
            this.mONEDAIDDataGridViewTextBoxColumn.HeaderText = "Id";
            this.mONEDAIDDataGridViewTextBoxColumn.Name = "mONEDAIDDataGridViewTextBoxColumn";
            this.mONEDAIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mONEDAIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // mONEDADataGridViewTextBoxColumn
            // 
            this.mONEDADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.mONEDADataGridViewTextBoxColumn.DataPropertyName = "MONEDA";
            this.mONEDADataGridViewTextBoxColumn.FillWeight = 150F;
            this.mONEDADataGridViewTextBoxColumn.HeaderText = "Moneda";
            this.mONEDADataGridViewTextBoxColumn.Name = "mONEDADataGridViewTextBoxColumn";
            this.mONEDADataGridViewTextBoxColumn.ReadOnly = true;
            this.mONEDADataGridViewTextBoxColumn.Width = 150;
            // 
            // sIMBOLODataGridViewTextBoxColumn
            // 
            this.sIMBOLODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sIMBOLODataGridViewTextBoxColumn.DataPropertyName = "SIMBOLO";
            this.sIMBOLODataGridViewTextBoxColumn.FillWeight = 80F;
            this.sIMBOLODataGridViewTextBoxColumn.HeaderText = "Simbolo";
            this.sIMBOLODataGridViewTextBoxColumn.Name = "sIMBOLODataGridViewTextBoxColumn";
            this.sIMBOLODataGridViewTextBoxColumn.ReadOnly = true;
            this.sIMBOLODataGridViewTextBoxColumn.Width = 80;
            // 
            // sIMBOLOSETDataGridViewTextBoxColumn
            // 
            this.sIMBOLOSETDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sIMBOLOSETDataGridViewTextBoxColumn.DataPropertyName = "SIMBOLO_SET";
            this.sIMBOLOSETDataGridViewTextBoxColumn.HeaderText = "Simbolo Set";
            this.sIMBOLOSETDataGridViewTextBoxColumn.Name = "sIMBOLOSETDataGridViewTextBoxColumn";
            this.sIMBOLOSETDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIPOMONEDADataGridViewTextBoxColumn
            // 
            this.tIPOMONEDADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tIPOMONEDADataGridViewTextBoxColumn.DataPropertyName = "TIPO_MONEDA";
            this.tIPOMONEDADataGridViewTextBoxColumn.FillWeight = 150F;
            this.tIPOMONEDADataGridViewTextBoxColumn.HeaderText = "Tipo Moneda";
            this.tIPOMONEDADataGridViewTextBoxColumn.Name = "tIPOMONEDADataGridViewTextBoxColumn";
            this.tIPOMONEDADataGridViewTextBoxColumn.ReadOnly = true;
            this.tIPOMONEDADataGridViewTextBoxColumn.Width = 150;
            // 
            // pRECISIONDECIMALESDataGridViewTextBoxColumn
            // 
            this.pRECISIONDECIMALESDataGridViewTextBoxColumn.DataPropertyName = "PRECISION_DECIMALES";
            this.pRECISIONDECIMALESDataGridViewTextBoxColumn.HeaderText = "PRECISION_DECIMALES";
            this.pRECISIONDECIMALESDataGridViewTextBoxColumn.Name = "pRECISIONDECIMALESDataGridViewTextBoxColumn";
            this.pRECISIONDECIMALESDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRECISIONDECIMALESDataGridViewTextBoxColumn.Visible = false;
            // 
            // uSUARIOCREACIONDataGridViewTextBoxColumn
            // 
            this.uSUARIOCREACIONDataGridViewTextBoxColumn.DataPropertyName = "USUARIO_CREACION";
            this.uSUARIOCREACIONDataGridViewTextBoxColumn.HeaderText = "USUARIO_CREACION";
            this.uSUARIOCREACIONDataGridViewTextBoxColumn.Name = "uSUARIOCREACIONDataGridViewTextBoxColumn";
            this.uSUARIOCREACIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.uSUARIOCREACIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // fECHACREACIONDataGridViewTextBoxColumn
            // 
            this.fECHACREACIONDataGridViewTextBoxColumn.DataPropertyName = "FECHA_CREACION";
            this.fECHACREACIONDataGridViewTextBoxColumn.HeaderText = "FECHA_CREACION";
            this.fECHACREACIONDataGridViewTextBoxColumn.Name = "fECHACREACIONDataGridViewTextBoxColumn";
            this.fECHACREACIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.fECHACREACIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // uSUARIOMODIFICACIONDataGridViewTextBoxColumn
            // 
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn.DataPropertyName = "USUARIO_MODIFICACION";
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn.HeaderText = "USUARIO_MODIFICACION";
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn.Name = "uSUARIOMODIFICACIONDataGridViewTextBoxColumn";
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // fECHAMODIFICACIONDataGridViewTextBoxColumn
            // 
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn.DataPropertyName = "FECHA_MODIFICACION";
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn.HeaderText = "FECHA_MODIFICACION";
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn.Name = "fECHAMODIFICACIONDataGridViewTextBoxColumn";
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // mONEDASVIEWBindingSource
            // 
            this.mONEDASVIEWBindingSource.DataSource = typeof(Inmobiliaria.Modelo.MONEDAS_VIEW);
            // 
            // FrmBusquedaMonedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 584);
            this.Name = "FrmBusquedaMonedas";
            this.Load += new System.EventHandler(this.FrmBusquedaMonedas_Load);
            this.Shown += new System.EventHandler(this.FrmBusquedaMonedas_Shown);
            this.pnlDatos.ResumeLayout(false);
            this.pnlFiltrosBusqueda.ResumeLayout(false);
            this.pnlFiltrosBusqueda.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonedas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONEDASVIEWBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnBuscar;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMonedas;
        private System.Windows.Forms.BindingSource mONEDASVIEWBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn mONEDAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mONEDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIMBOLODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIMBOLOSETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOMONEDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECISIONDECIMALESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOCREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHACREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOMODIFICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAMODIFICACIONDataGridViewTextBoxColumn;
    }
}