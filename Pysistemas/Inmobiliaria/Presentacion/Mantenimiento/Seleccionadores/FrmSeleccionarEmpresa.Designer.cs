namespace Inmobiliaria.Presentacion.Mantenimiento.Seleccionadores
{
    partial class FrmSeleccionarEmpresa
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvEmpresas = new System.Windows.Forms.DataGridView();
            this.eMPRESAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAZONSOCIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRECORTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODOCUMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOPERSONERIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMERODOCUMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIGITOVERIFICADORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTIVODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOCREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHACREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOCIOSNEGOCIOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUCURSALESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPRESASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Text = "Seleccione empresa";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCrear);
            this.panel3.Controls.Add(this.btnCerrar);
            this.panel3.Controls.Add(this.btnSeleccionar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 326);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 75);
            this.panel3.TabIndex = 10;
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(375, 23);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(93, 35);
            this.btnCrear.TabIndex = 21;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(83)))), ((int)(((byte)(44)))));
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(474, 23);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(93, 35);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(233, 23);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(136, 35);
            this.btnSeleccionar.TabIndex = 19;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvEmpresas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 283);
            this.panel2.TabIndex = 11;
            // 
            // dgvEmpresas
            // 
            this.dgvEmpresas.AllowUserToAddRows = false;
            this.dgvEmpresas.AllowUserToDeleteRows = false;
            this.dgvEmpresas.AutoGenerateColumns = false;
            this.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPRESAIDDataGridViewTextBoxColumn,
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn,
            this.rAZONSOCIALDataGridViewTextBoxColumn,
            this.nOMBRECORTODataGridViewTextBoxColumn,
            this.tIPODOCUMENTODataGridViewTextBoxColumn,
            this.tIPOPERSONERIADataGridViewTextBoxColumn,
            this.nUMERODOCUMENTODataGridViewTextBoxColumn,
            this.dIGITOVERIFICADORDataGridViewTextBoxColumn,
            this.dIRECCIONDataGridViewTextBoxColumn,
            this.tELEFONODataGridViewTextBoxColumn,
            this.aCTIVODataGridViewTextBoxColumn,
            this.uSUARIOCREACIONDataGridViewTextBoxColumn,
            this.fECHACREACIONDataGridViewTextBoxColumn,
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn,
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn,
            this.sOCIOSNEGOCIOSDataGridViewTextBoxColumn,
            this.sUCURSALESDataGridViewTextBoxColumn,
            this.uSUARIOSDataGridViewTextBoxColumn});
            this.dgvEmpresas.DataSource = this.eMPRESASBindingSource;
            this.dgvEmpresas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpresas.Location = new System.Drawing.Point(0, 0);
            this.dgvEmpresas.Name = "dgvEmpresas";
            this.dgvEmpresas.ReadOnly = true;
            this.dgvEmpresas.Size = new System.Drawing.Size(800, 283);
            this.dgvEmpresas.TabIndex = 0;
            this.dgvEmpresas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpresas_CellContentDoubleClick);
            this.dgvEmpresas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmpresas_CellMouseDoubleClick);
            this.dgvEmpresas.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvEmpresas_RowPostPaint);
            // 
            // eMPRESAIDDataGridViewTextBoxColumn
            // 
            this.eMPRESAIDDataGridViewTextBoxColumn.DataPropertyName = "EMPRESA_ID";
            this.eMPRESAIDDataGridViewTextBoxColumn.HeaderText = "EMPRESA_ID";
            this.eMPRESAIDDataGridViewTextBoxColumn.Name = "eMPRESAIDDataGridViewTextBoxColumn";
            this.eMPRESAIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMPRESAIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sOCIONEGOCIOIDDataGridViewTextBoxColumn
            // 
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn.DataPropertyName = "SOCIO_NEGOCIO_ID";
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn.HeaderText = "SOCIO_NEGOCIO_ID";
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn.Name = "sOCIONEGOCIOIDDataGridViewTextBoxColumn";
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // rAZONSOCIALDataGridViewTextBoxColumn
            // 
            this.rAZONSOCIALDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.rAZONSOCIALDataGridViewTextBoxColumn.DataPropertyName = "RAZON_SOCIAL";
            this.rAZONSOCIALDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.rAZONSOCIALDataGridViewTextBoxColumn.Name = "rAZONSOCIALDataGridViewTextBoxColumn";
            this.rAZONSOCIALDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAZONSOCIALDataGridViewTextBoxColumn.Width = 75;
            // 
            // nOMBRECORTODataGridViewTextBoxColumn
            // 
            this.nOMBRECORTODataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_CORTO";
            this.nOMBRECORTODataGridViewTextBoxColumn.HeaderText = "NOMBRE_CORTO";
            this.nOMBRECORTODataGridViewTextBoxColumn.Name = "nOMBRECORTODataGridViewTextBoxColumn";
            this.nOMBRECORTODataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMBRECORTODataGridViewTextBoxColumn.Visible = false;
            // 
            // tIPODOCUMENTODataGridViewTextBoxColumn
            // 
            this.tIPODOCUMENTODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tIPODOCUMENTODataGridViewTextBoxColumn.DataPropertyName = "TIPO_DOCUMENTO";
            this.tIPODOCUMENTODataGridViewTextBoxColumn.HeaderText = "Tipo documento";
            this.tIPODOCUMENTODataGridViewTextBoxColumn.Name = "tIPODOCUMENTODataGridViewTextBoxColumn";
            this.tIPODOCUMENTODataGridViewTextBoxColumn.ReadOnly = true;
            this.tIPODOCUMENTODataGridViewTextBoxColumn.Width = 117;
            // 
            // tIPOPERSONERIADataGridViewTextBoxColumn
            // 
            this.tIPOPERSONERIADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tIPOPERSONERIADataGridViewTextBoxColumn.DataPropertyName = "TIPO_PERSONERIA";
            this.tIPOPERSONERIADataGridViewTextBoxColumn.HeaderText = "Personería";
            this.tIPOPERSONERIADataGridViewTextBoxColumn.Name = "tIPOPERSONERIADataGridViewTextBoxColumn";
            this.tIPOPERSONERIADataGridViewTextBoxColumn.ReadOnly = true;
            this.tIPOPERSONERIADataGridViewTextBoxColumn.Width = 86;
            // 
            // nUMERODOCUMENTODataGridViewTextBoxColumn
            // 
            this.nUMERODOCUMENTODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nUMERODOCUMENTODataGridViewTextBoxColumn.DataPropertyName = "NUMERO_DOCUMENTO";
            this.nUMERODOCUMENTODataGridViewTextBoxColumn.HeaderText = "RUC";
            this.nUMERODOCUMENTODataGridViewTextBoxColumn.Name = "nUMERODOCUMENTODataGridViewTextBoxColumn";
            this.nUMERODOCUMENTODataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMERODOCUMENTODataGridViewTextBoxColumn.Width = 54;
            // 
            // dIGITOVERIFICADORDataGridViewTextBoxColumn
            // 
            this.dIGITOVERIFICADORDataGridViewTextBoxColumn.DataPropertyName = "DIGITO_VERIFICADOR";
            this.dIGITOVERIFICADORDataGridViewTextBoxColumn.HeaderText = "DIGITO_VERIFICADOR";
            this.dIGITOVERIFICADORDataGridViewTextBoxColumn.Name = "dIGITOVERIFICADORDataGridViewTextBoxColumn";
            this.dIGITOVERIFICADORDataGridViewTextBoxColumn.ReadOnly = true;
            this.dIGITOVERIFICADORDataGridViewTextBoxColumn.Visible = false;
            // 
            // dIRECCIONDataGridViewTextBoxColumn
            // 
            this.dIRECCIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.dIRECCIONDataGridViewTextBoxColumn.Name = "dIRECCIONDataGridViewTextBoxColumn";
            this.dIRECCIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.dIRECCIONDataGridViewTextBoxColumn.Width = 80;
            // 
            // tELEFONODataGridViewTextBoxColumn
            // 
            this.tELEFONODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tELEFONODataGridViewTextBoxColumn.DataPropertyName = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.tELEFONODataGridViewTextBoxColumn.Name = "tELEFONODataGridViewTextBoxColumn";
            this.tELEFONODataGridViewTextBoxColumn.ReadOnly = true;
            this.tELEFONODataGridViewTextBoxColumn.Width = 77;
            // 
            // aCTIVODataGridViewTextBoxColumn
            // 
            this.aCTIVODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.aCTIVODataGridViewTextBoxColumn.DataPropertyName = "ACTIVO";
            this.aCTIVODataGridViewTextBoxColumn.HeaderText = "Activo";
            this.aCTIVODataGridViewTextBoxColumn.Name = "aCTIVODataGridViewTextBoxColumn";
            this.aCTIVODataGridViewTextBoxColumn.ReadOnly = true;
            this.aCTIVODataGridViewTextBoxColumn.Width = 63;
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
            // sOCIOSNEGOCIOSDataGridViewTextBoxColumn
            // 
            this.sOCIOSNEGOCIOSDataGridViewTextBoxColumn.DataPropertyName = "SOCIOS_NEGOCIOS";
            this.sOCIOSNEGOCIOSDataGridViewTextBoxColumn.HeaderText = "SOCIOS_NEGOCIOS";
            this.sOCIOSNEGOCIOSDataGridViewTextBoxColumn.Name = "sOCIOSNEGOCIOSDataGridViewTextBoxColumn";
            this.sOCIOSNEGOCIOSDataGridViewTextBoxColumn.ReadOnly = true;
            this.sOCIOSNEGOCIOSDataGridViewTextBoxColumn.Visible = false;
            // 
            // sUCURSALESDataGridViewTextBoxColumn
            // 
            this.sUCURSALESDataGridViewTextBoxColumn.DataPropertyName = "SUCURSALES";
            this.sUCURSALESDataGridViewTextBoxColumn.HeaderText = "SUCURSALES";
            this.sUCURSALESDataGridViewTextBoxColumn.Name = "sUCURSALESDataGridViewTextBoxColumn";
            this.sUCURSALESDataGridViewTextBoxColumn.ReadOnly = true;
            this.sUCURSALESDataGridViewTextBoxColumn.Visible = false;
            // 
            // uSUARIOSDataGridViewTextBoxColumn
            // 
            this.uSUARIOSDataGridViewTextBoxColumn.DataPropertyName = "USUARIOS";
            this.uSUARIOSDataGridViewTextBoxColumn.HeaderText = "USUARIOS";
            this.uSUARIOSDataGridViewTextBoxColumn.Name = "uSUARIOSDataGridViewTextBoxColumn";
            this.uSUARIOSDataGridViewTextBoxColumn.ReadOnly = true;
            this.uSUARIOSDataGridViewTextBoxColumn.Visible = false;
            // 
            // eMPRESASBindingSource
            // 
            this.eMPRESASBindingSource.DataSource = typeof(Inmobiliaria.Modelo.EMPRESAS);
            // 
            // FrmSeleccionarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FrmSeleccionarEmpresa";
            this.Load += new System.EventHandler(this.FrmSeleccionarEmpresa_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvEmpresas;
        private System.Windows.Forms.BindingSource eMPRESASBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPRESAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOCIONEGOCIOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAZONSOCIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRECORTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODOCUMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOPERSONERIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMERODOCUMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIGITOVERIFICADORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTIVODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOCREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHACREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOMODIFICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAMODIFICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOCIOSNEGOCIOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUCURSALESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOSDataGridViewTextBoxColumn;
    }
}
