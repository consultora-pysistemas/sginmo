namespace Inmobiliaria.Presentacion.Mantenimiento.Buscadores
{
    partial class FrmBusquedaEmpresas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvEmpresas = new System.Windows.Forms.DataGridView();
            this.eMPRESAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPRESADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOCIONEGOCIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMERODOCUMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIGITOVERIFICADORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rUCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOPERSONERIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODOCUMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTIVODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOCREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHACREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPRESASVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlDatos.SuspendLayout();
            this.pnlFiltrosBusqueda.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESASVIEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Size = new System.Drawing.Size(1049, 46);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.dgvEmpresas);
            this.pnlDatos.Size = new System.Drawing.Size(1049, 421);
            this.pnlDatos.Controls.SetChildIndex(this.pnlFiltrosBusqueda, 0);
            this.pnlDatos.Controls.SetChildIndex(this.dgvEmpresas, 0);
            // 
            // pnlFiltrosBusqueda
            // 
            this.pnlFiltrosBusqueda.Controls.Add(this.btnBuscar);
            this.pnlFiltrosBusqueda.Controls.Add(this.btnCancelar);
            this.pnlFiltrosBusqueda.Controls.Add(this.txtEmpresa);
            this.pnlFiltrosBusqueda.Controls.Add(this.label3);
            this.pnlFiltrosBusqueda.Size = new System.Drawing.Size(284, 419);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1049, 43);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(977, 43);
            // 
            // dgvEmpresas
            // 
            this.dgvEmpresas.AllowUserToAddRows = false;
            this.dgvEmpresas.AutoGenerateColumns = false;
            this.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPRESAIDDataGridViewTextBoxColumn,
            this.eMPRESADataGridViewTextBoxColumn,
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn,
            this.sOCIONEGOCIODataGridViewTextBoxColumn,
            this.nUMERODOCUMENTODataGridViewTextBoxColumn,
            this.dIGITOVERIFICADORDataGridViewTextBoxColumn,
            this.rUCDataGridViewTextBoxColumn,
            this.tIPOPERSONERIADataGridViewTextBoxColumn,
            this.tIPODOCUMENTODataGridViewTextBoxColumn,
            this.dIRECCIONDataGridViewTextBoxColumn,
            this.tELEFONODataGridViewTextBoxColumn,
            this.aCTIVODataGridViewTextBoxColumn,
            this.uSUARIOCREACIONDataGridViewTextBoxColumn,
            this.fECHACREACIONDataGridViewTextBoxColumn,
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn,
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn});
            this.dgvEmpresas.DataSource = this.eMPRESASVIEWBindingSource;
            this.dgvEmpresas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpresas.Location = new System.Drawing.Point(284, 0);
            this.dgvEmpresas.Name = "dgvEmpresas";
            this.dgvEmpresas.Size = new System.Drawing.Size(763, 419);
            this.dgvEmpresas.TabIndex = 14;
            this.dgvEmpresas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpresas_CellContentClick);
            this.dgvEmpresas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmpresas_CellMouseDoubleClick);
            this.dgvEmpresas.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvEmpresas_RowPostPaint);
            this.dgvEmpresas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvEmpresas_MouseClick);
            // 
            // eMPRESAIDDataGridViewTextBoxColumn
            // 
            this.eMPRESAIDDataGridViewTextBoxColumn.DataPropertyName = "EMPRESA_ID";
            this.eMPRESAIDDataGridViewTextBoxColumn.HeaderText = "EMPRESA_ID";
            this.eMPRESAIDDataGridViewTextBoxColumn.Name = "eMPRESAIDDataGridViewTextBoxColumn";
            this.eMPRESAIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // eMPRESADataGridViewTextBoxColumn
            // 
            this.eMPRESADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.eMPRESADataGridViewTextBoxColumn.DataPropertyName = "EMPRESA";
            this.eMPRESADataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.eMPRESADataGridViewTextBoxColumn.Name = "eMPRESADataGridViewTextBoxColumn";
            this.eMPRESADataGridViewTextBoxColumn.Width = 250;
            // 
            // sOCIONEGOCIOIDDataGridViewTextBoxColumn
            // 
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn.DataPropertyName = "SOCIO_NEGOCIO_ID";
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn.HeaderText = "SOCIO_NEGOCIO_ID";
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn.Name = "sOCIONEGOCIOIDDataGridViewTextBoxColumn";
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sOCIONEGOCIODataGridViewTextBoxColumn
            // 
            this.sOCIONEGOCIODataGridViewTextBoxColumn.DataPropertyName = "SOCIO_NEGOCIO";
            this.sOCIONEGOCIODataGridViewTextBoxColumn.HeaderText = "SOCIO_NEGOCIO";
            this.sOCIONEGOCIODataGridViewTextBoxColumn.Name = "sOCIONEGOCIODataGridViewTextBoxColumn";
            this.sOCIONEGOCIODataGridViewTextBoxColumn.Visible = false;
            // 
            // nUMERODOCUMENTODataGridViewTextBoxColumn
            // 
            this.nUMERODOCUMENTODataGridViewTextBoxColumn.DataPropertyName = "NUMERO_DOCUMENTO";
            this.nUMERODOCUMENTODataGridViewTextBoxColumn.HeaderText = "NUMERO_DOCUMENTO";
            this.nUMERODOCUMENTODataGridViewTextBoxColumn.Name = "nUMERODOCUMENTODataGridViewTextBoxColumn";
            this.nUMERODOCUMENTODataGridViewTextBoxColumn.Visible = false;
            // 
            // dIGITOVERIFICADORDataGridViewTextBoxColumn
            // 
            this.dIGITOVERIFICADORDataGridViewTextBoxColumn.DataPropertyName = "DIGITO_VERIFICADOR";
            this.dIGITOVERIFICADORDataGridViewTextBoxColumn.HeaderText = "DIGITO_VERIFICADOR";
            this.dIGITOVERIFICADORDataGridViewTextBoxColumn.Name = "dIGITOVERIFICADORDataGridViewTextBoxColumn";
            this.dIGITOVERIFICADORDataGridViewTextBoxColumn.Visible = false;
            // 
            // rUCDataGridViewTextBoxColumn
            // 
            this.rUCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rUCDataGridViewTextBoxColumn.DataPropertyName = "RUC";
            this.rUCDataGridViewTextBoxColumn.HeaderText = "Ruc";
            this.rUCDataGridViewTextBoxColumn.Name = "rUCDataGridViewTextBoxColumn";
            this.rUCDataGridViewTextBoxColumn.Width = 80;
            // 
            // tIPOPERSONERIADataGridViewTextBoxColumn
            // 
            this.tIPOPERSONERIADataGridViewTextBoxColumn.DataPropertyName = "TIPO_PERSONERIA";
            this.tIPOPERSONERIADataGridViewTextBoxColumn.HeaderText = "TIPO_PERSONERIA";
            this.tIPOPERSONERIADataGridViewTextBoxColumn.Name = "tIPOPERSONERIADataGridViewTextBoxColumn";
            this.tIPOPERSONERIADataGridViewTextBoxColumn.Visible = false;
            // 
            // tIPODOCUMENTODataGridViewTextBoxColumn
            // 
            this.tIPODOCUMENTODataGridViewTextBoxColumn.DataPropertyName = "TIPO_DOCUMENTO";
            this.tIPODOCUMENTODataGridViewTextBoxColumn.HeaderText = "TIPO_DOCUMENTO";
            this.tIPODOCUMENTODataGridViewTextBoxColumn.Name = "tIPODOCUMENTODataGridViewTextBoxColumn";
            this.tIPODOCUMENTODataGridViewTextBoxColumn.Visible = false;
            // 
            // dIRECCIONDataGridViewTextBoxColumn
            // 
            this.dIRECCIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.dIRECCIONDataGridViewTextBoxColumn.Name = "dIRECCIONDataGridViewTextBoxColumn";
            this.dIRECCIONDataGridViewTextBoxColumn.Width = 250;
            // 
            // tELEFONODataGridViewTextBoxColumn
            // 
            this.tELEFONODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tELEFONODataGridViewTextBoxColumn.DataPropertyName = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.tELEFONODataGridViewTextBoxColumn.Name = "tELEFONODataGridViewTextBoxColumn";
            this.tELEFONODataGridViewTextBoxColumn.Width = 80;
            // 
            // aCTIVODataGridViewTextBoxColumn
            // 
            this.aCTIVODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.aCTIVODataGridViewTextBoxColumn.DataPropertyName = "ACTIVO";
            this.aCTIVODataGridViewTextBoxColumn.HeaderText = "Activo";
            this.aCTIVODataGridViewTextBoxColumn.Name = "aCTIVODataGridViewTextBoxColumn";
            this.aCTIVODataGridViewTextBoxColumn.Width = 50;
            // 
            // uSUARIOCREACIONDataGridViewTextBoxColumn
            // 
            this.uSUARIOCREACIONDataGridViewTextBoxColumn.DataPropertyName = "USUARIO_CREACION";
            this.uSUARIOCREACIONDataGridViewTextBoxColumn.HeaderText = "USUARIO_CREACION";
            this.uSUARIOCREACIONDataGridViewTextBoxColumn.Name = "uSUARIOCREACIONDataGridViewTextBoxColumn";
            this.uSUARIOCREACIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // fECHACREACIONDataGridViewTextBoxColumn
            // 
            this.fECHACREACIONDataGridViewTextBoxColumn.DataPropertyName = "FECHA_CREACION";
            this.fECHACREACIONDataGridViewTextBoxColumn.HeaderText = "FECHA_CREACION";
            this.fECHACREACIONDataGridViewTextBoxColumn.Name = "fECHACREACIONDataGridViewTextBoxColumn";
            this.fECHACREACIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // uSUARIOMODIFICACIONDataGridViewTextBoxColumn
            // 
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn.DataPropertyName = "USUARIO_MODIFICACION";
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn.HeaderText = "USUARIO_MODIFICACION";
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn.Name = "uSUARIOMODIFICACIONDataGridViewTextBoxColumn";
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // fECHAMODIFICACIONDataGridViewTextBoxColumn
            // 
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn.DataPropertyName = "FECHA_MODIFICACION";
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn.HeaderText = "FECHA_MODIFICACION";
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn.Name = "fECHAMODIFICACIONDataGridViewTextBoxColumn";
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // eMPRESASVIEWBindingSource
            // 
            this.eMPRESASVIEWBindingSource.DataSource = typeof(Inmobiliaria.Modelo.EMPRESAS_VIEW);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(32, 224);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 35);
            this.btnBuscar.TabIndex = 51;
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
            this.btnCancelar.Location = new System.Drawing.Point(131, 224);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 35);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.Text = "Limpiar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmpresa.Location = new System.Drawing.Point(9, 174);
            this.txtEmpresa.MaxLength = 20;
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(233, 22);
            this.txtEmpresa.TabIndex = 47;
            this.txtEmpresa.TextChanged += new System.EventHandler(this.txtEmpresa_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Empresa";
            // 
            // FrmBusquedaEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1049, 566);
            this.Name = "FrmBusquedaEmpresas";
            this.Load += new System.EventHandler(this.FrmBusquedaEmpresas_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlFiltrosBusqueda.ResumeLayout(false);
            this.pnlFiltrosBusqueda.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESASVIEWBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpresas;
        private System.Windows.Forms.BindingSource eMPRESASVIEWBindingSource;
        protected System.Windows.Forms.Button btnBuscar;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPRESAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPRESADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOCIONEGOCIOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOCIONEGOCIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMERODOCUMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIGITOVERIFICADORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOPERSONERIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODOCUMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTIVODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOCREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHACREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOMODIFICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAMODIFICACIONDataGridViewTextBoxColumn;
    }
}
