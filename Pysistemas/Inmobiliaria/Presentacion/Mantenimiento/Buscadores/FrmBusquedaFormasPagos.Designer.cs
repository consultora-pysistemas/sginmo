namespace Inmobiliaria.Presentacion.Mantenimiento.Buscadores
{
    partial class FrmBusquedaFormasPagos
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
            this.txtFormaPago = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvFormasPagos = new System.Windows.Forms.DataGridView();
            this.fORMAPAGOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORMAPAGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pORDEFECTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEQUEREBANCODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOCREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHACREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORMASPAGOSVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatos.SuspendLayout();
            this.pnlFiltrosBusqueda.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormasPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORMASPAGOSVIEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Size = new System.Drawing.Size(748, 46);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.dgvFormasPagos);
            this.pnlDatos.Size = new System.Drawing.Size(748, 353);
            this.pnlDatos.Controls.SetChildIndex(this.pnlFiltrosBusqueda, 0);
            this.pnlDatos.Controls.SetChildIndex(this.dgvFormasPagos, 0);
            // 
            // pnlFiltrosBusqueda
            // 
            this.pnlFiltrosBusqueda.Controls.Add(this.btnBuscar);
            this.pnlFiltrosBusqueda.Controls.Add(this.btnCancelar);
            this.pnlFiltrosBusqueda.Controls.Add(this.txtFormaPago);
            this.pnlFiltrosBusqueda.Controls.Add(this.label3);
            this.pnlFiltrosBusqueda.Size = new System.Drawing.Size(260, 351);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(748, 43);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(676, 43);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(20, 168);
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
            this.btnCancelar.Location = new System.Drawing.Point(119, 168);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 35);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "Limpiar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtFormaPago
            // 
            this.txtFormaPago.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFormaPago.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormaPago.Location = new System.Drawing.Point(13, 118);
            this.txtFormaPago.MaxLength = 20;
            this.txtFormaPago.Name = "txtFormaPago";
            this.txtFormaPago.Size = new System.Drawing.Size(233, 22);
            this.txtFormaPago.TabIndex = 52;
            this.txtFormaPago.TextChanged += new System.EventHandler(this.txtFormaPago_TextChanged);
            this.txtFormaPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFormaPago_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Forma de Pago";
            // 
            // dgvFormasPagos
            // 
            this.dgvFormasPagos.AllowUserToAddRows = false;
            this.dgvFormasPagos.AllowUserToDeleteRows = false;
            this.dgvFormasPagos.AllowUserToOrderColumns = true;
            this.dgvFormasPagos.AutoGenerateColumns = false;
            this.dgvFormasPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormasPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fORMAPAGOIDDataGridViewTextBoxColumn,
            this.cODIGODataGridViewTextBoxColumn,
            this.fORMAPAGODataGridViewTextBoxColumn,
            this.dIASDataGridViewTextBoxColumn,
            this.pORDEFECTODataGridViewTextBoxColumn,
            this.rEQUEREBANCODataGridViewTextBoxColumn,
            this.uSUARIOCREACIONDataGridViewTextBoxColumn,
            this.fECHACREACIONDataGridViewTextBoxColumn,
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn,
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn});
            this.dgvFormasPagos.DataSource = this.fORMASPAGOSVIEWBindingSource;
            this.dgvFormasPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFormasPagos.Location = new System.Drawing.Point(260, 0);
            this.dgvFormasPagos.Name = "dgvFormasPagos";
            this.dgvFormasPagos.ReadOnly = true;
            this.dgvFormasPagos.Size = new System.Drawing.Size(486, 351);
            this.dgvFormasPagos.TabIndex = 14;
            this.dgvFormasPagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormasPagos_CellContentClick);
            this.dgvFormasPagos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormasPagos_CellContentDoubleClick);
            this.dgvFormasPagos.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvFormasPagos_RowPostPaint);
            this.dgvFormasPagos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvFormasPagos_MouseClick);
            // 
            // fORMAPAGOIDDataGridViewTextBoxColumn
            // 
            this.fORMAPAGOIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fORMAPAGOIDDataGridViewTextBoxColumn.DataPropertyName = "FORMA_PAGO_ID";
            this.fORMAPAGOIDDataGridViewTextBoxColumn.FillWeight = 50F;
            this.fORMAPAGOIDDataGridViewTextBoxColumn.HeaderText = "Id";
            this.fORMAPAGOIDDataGridViewTextBoxColumn.Name = "fORMAPAGOIDDataGridViewTextBoxColumn";
            this.fORMAPAGOIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.fORMAPAGOIDDataGridViewTextBoxColumn.Visible = false;
            this.fORMAPAGOIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // cODIGODataGridViewTextBoxColumn
            // 
            this.cODIGODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cODIGODataGridViewTextBoxColumn.DataPropertyName = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.HeaderText = "Código";
            this.cODIGODataGridViewTextBoxColumn.Name = "cODIGODataGridViewTextBoxColumn";
            this.cODIGODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fORMAPAGODataGridViewTextBoxColumn
            // 
            this.fORMAPAGODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fORMAPAGODataGridViewTextBoxColumn.DataPropertyName = "FORMA_PAGO";
            this.fORMAPAGODataGridViewTextBoxColumn.FillWeight = 200F;
            this.fORMAPAGODataGridViewTextBoxColumn.HeaderText = "Forma Pago";
            this.fORMAPAGODataGridViewTextBoxColumn.Name = "fORMAPAGODataGridViewTextBoxColumn";
            this.fORMAPAGODataGridViewTextBoxColumn.ReadOnly = true;
            this.fORMAPAGODataGridViewTextBoxColumn.Width = 200;
            // 
            // dIASDataGridViewTextBoxColumn
            // 
            this.dIASDataGridViewTextBoxColumn.DataPropertyName = "DIAS";
            this.dIASDataGridViewTextBoxColumn.HeaderText = "DIAS";
            this.dIASDataGridViewTextBoxColumn.Name = "dIASDataGridViewTextBoxColumn";
            this.dIASDataGridViewTextBoxColumn.ReadOnly = true;
            this.dIASDataGridViewTextBoxColumn.Visible = false;
            // 
            // pORDEFECTODataGridViewTextBoxColumn
            // 
            this.pORDEFECTODataGridViewTextBoxColumn.DataPropertyName = "POR_DEFECTO";
            this.pORDEFECTODataGridViewTextBoxColumn.HeaderText = "POR_DEFECTO";
            this.pORDEFECTODataGridViewTextBoxColumn.Name = "pORDEFECTODataGridViewTextBoxColumn";
            this.pORDEFECTODataGridViewTextBoxColumn.ReadOnly = true;
            this.pORDEFECTODataGridViewTextBoxColumn.Visible = false;
            // 
            // rEQUEREBANCODataGridViewTextBoxColumn
            // 
            this.rEQUEREBANCODataGridViewTextBoxColumn.DataPropertyName = "REQUERE_BANCO";
            this.rEQUEREBANCODataGridViewTextBoxColumn.HeaderText = "REQUERE_BANCO";
            this.rEQUEREBANCODataGridViewTextBoxColumn.Name = "rEQUEREBANCODataGridViewTextBoxColumn";
            this.rEQUEREBANCODataGridViewTextBoxColumn.ReadOnly = true;
            this.rEQUEREBANCODataGridViewTextBoxColumn.Visible = false;
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
            // fORMASPAGOSVIEWBindingSource
            // 
            this.fORMASPAGOSVIEWBindingSource.DataSource = typeof(Inmobiliaria.Modelo.FORMAS_PAGOS_VIEW);
            // 
            // FrmBusquedaFormasPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 498);
            this.Name = "FrmBusquedaFormasPagos";
            this.Load += new System.EventHandler(this.FrmBusquedaFormasPagos_Load);
            this.Shown += new System.EventHandler(this.FrmBusquedaFormasPagos_Shown);
            this.pnlDatos.ResumeLayout(false);
            this.pnlFiltrosBusqueda.ResumeLayout(false);
            this.pnlFiltrosBusqueda.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormasPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORMASPAGOSVIEWBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnBuscar;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtFormaPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvFormasPagos;
        private System.Windows.Forms.BindingSource fORMASPAGOSVIEWBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORMAPAGOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORMAPAGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pORDEFECTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEQUEREBANCODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOCREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHACREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOMODIFICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAMODIFICACIONDataGridViewTextBoxColumn;
    }
}