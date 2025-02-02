namespace Inmobiliaria.Presentacion.Mantenimiento.Buscadores
{
    partial class FrmBuscadorSociosNegocios
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvSociosNegocios = new System.Windows.Forms.DataGridView();
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOCIONEGOCIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMERODOCUMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIGITOVERIFICADORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOPERSONERIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODOCUMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rUCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASIFICACIONFISCALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTIVODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSPROPIETARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSINQUILINODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSPORTERODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSADMINISTRADORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSPROVEEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSEMPRESADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOCREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHACREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOCIOSNEGOCIOSVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSociosNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOCIOSNEGOCIOSVIEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(719, 43);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(647, 43);
            this.lblTitulo.Text = "Buscar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtBusqueda);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 32);
            this.panel2.TabIndex = 9;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtBusqueda.Location = new System.Drawing.Point(0, 0);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(719, 24);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 366);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(719, 74);
            this.panel3.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(252, 20);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 35);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Seleccionar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(83)))), ((int)(((byte)(44)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(362, 20);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 35);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.dgvSociosNegocios);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(719, 291);
            this.panel4.TabIndex = 11;
            // 
            // dgvSociosNegocios
            // 
            this.dgvSociosNegocios.AllowUserToAddRows = false;
            this.dgvSociosNegocios.AllowUserToDeleteRows = false;
            this.dgvSociosNegocios.AllowUserToOrderColumns = true;
            this.dgvSociosNegocios.AutoGenerateColumns = false;
            this.dgvSociosNegocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSociosNegocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn,
            this.sOCIONEGOCIODataGridViewTextBoxColumn,
            this.nUMERODOCUMENTODataGridViewTextBoxColumn,
            this.dIGITOVERIFICADORDataGridViewTextBoxColumn,
            this.tIPOPERSONERIADataGridViewTextBoxColumn,
            this.tIPODOCUMENTODataGridViewTextBoxColumn,
            this.rUCDataGridViewTextBoxColumn,
            this.cLASIFICACIONFISCALDataGridViewTextBoxColumn,
            this.aCTIVODataGridViewTextBoxColumn,
            this.dIRECCIONDataGridViewTextBoxColumn,
            this.tELEFONODataGridViewTextBoxColumn,
            this.eSPROPIETARIODataGridViewTextBoxColumn,
            this.eSINQUILINODataGridViewTextBoxColumn,
            this.eSPORTERODataGridViewTextBoxColumn,
            this.eSADMINISTRADORDataGridViewTextBoxColumn,
            this.eSCLIENTEDataGridViewTextBoxColumn,
            this.eSPROVEEDORDataGridViewTextBoxColumn,
            this.eSEMPRESADataGridViewTextBoxColumn,
            this.uSUARIOCREACIONDataGridViewTextBoxColumn,
            this.fECHACREACIONDataGridViewTextBoxColumn,
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn,
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn});
            this.dgvSociosNegocios.DataSource = this.sOCIOSNEGOCIOSVIEWBindingSource;
            this.dgvSociosNegocios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSociosNegocios.Location = new System.Drawing.Point(0, 0);
            this.dgvSociosNegocios.Name = "dgvSociosNegocios";
            this.dgvSociosNegocios.ReadOnly = true;
            this.dgvSociosNegocios.Size = new System.Drawing.Size(719, 291);
            this.dgvSociosNegocios.TabIndex = 0;
            this.dgvSociosNegocios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSociosNegocios_CellContentDoubleClick);
            this.dgvSociosNegocios.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSociosNegocios_CellMouseDoubleClick);
            this.dgvSociosNegocios.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvSociosNegocios_RowPostPaint);
            // 
            // sOCIONEGOCIOIDDataGridViewTextBoxColumn
            // 
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn.DataPropertyName = "SOCIO_NEGOCIO_ID";
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn.HeaderText = "SOCIO_NEGOCIO_ID";
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn.Name = "sOCIONEGOCIOIDDataGridViewTextBoxColumn";
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sOCIONEGOCIODataGridViewTextBoxColumn
            // 
            this.sOCIONEGOCIODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sOCIONEGOCIODataGridViewTextBoxColumn.DataPropertyName = "SOCIO_NEGOCIO";
            this.sOCIONEGOCIODataGridViewTextBoxColumn.HeaderText = "Razón social";
            this.sOCIONEGOCIODataGridViewTextBoxColumn.Name = "sOCIONEGOCIODataGridViewTextBoxColumn";
            this.sOCIONEGOCIODataGridViewTextBoxColumn.ReadOnly = true;
            this.sOCIONEGOCIODataGridViewTextBoxColumn.Width = 96;
            // 
            // nUMERODOCUMENTODataGridViewTextBoxColumn
            // 
            this.nUMERODOCUMENTODataGridViewTextBoxColumn.DataPropertyName = "NUMERO_DOCUMENTO";
            this.nUMERODOCUMENTODataGridViewTextBoxColumn.HeaderText = "NUMERO_DOCUMENTO";
            this.nUMERODOCUMENTODataGridViewTextBoxColumn.Name = "nUMERODOCUMENTODataGridViewTextBoxColumn";
            this.nUMERODOCUMENTODataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMERODOCUMENTODataGridViewTextBoxColumn.Visible = false;
            // 
            // dIGITOVERIFICADORDataGridViewTextBoxColumn
            // 
            this.dIGITOVERIFICADORDataGridViewTextBoxColumn.DataPropertyName = "DIGITO_VERIFICADOR";
            this.dIGITOVERIFICADORDataGridViewTextBoxColumn.HeaderText = "DIGITO_VERIFICADOR";
            this.dIGITOVERIFICADORDataGridViewTextBoxColumn.Name = "dIGITOVERIFICADORDataGridViewTextBoxColumn";
            this.dIGITOVERIFICADORDataGridViewTextBoxColumn.ReadOnly = true;
            this.dIGITOVERIFICADORDataGridViewTextBoxColumn.Visible = false;
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
            // tIPODOCUMENTODataGridViewTextBoxColumn
            // 
            this.tIPODOCUMENTODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tIPODOCUMENTODataGridViewTextBoxColumn.DataPropertyName = "TIPO_DOCUMENTO";
            this.tIPODOCUMENTODataGridViewTextBoxColumn.HeaderText = "Tipo documento";
            this.tIPODOCUMENTODataGridViewTextBoxColumn.Name = "tIPODOCUMENTODataGridViewTextBoxColumn";
            this.tIPODOCUMENTODataGridViewTextBoxColumn.ReadOnly = true;
            this.tIPODOCUMENTODataGridViewTextBoxColumn.Width = 117;
            // 
            // rUCDataGridViewTextBoxColumn
            // 
            this.rUCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.rUCDataGridViewTextBoxColumn.DataPropertyName = "RUC";
            this.rUCDataGridViewTextBoxColumn.HeaderText = "Nro. documento";
            this.rUCDataGridViewTextBoxColumn.Name = "rUCDataGridViewTextBoxColumn";
            this.rUCDataGridViewTextBoxColumn.ReadOnly = true;
            this.rUCDataGridViewTextBoxColumn.Width = 116;
            // 
            // cLASIFICACIONFISCALDataGridViewTextBoxColumn
            // 
            this.cLASIFICACIONFISCALDataGridViewTextBoxColumn.DataPropertyName = "CLASIFICACION_FISCAL";
            this.cLASIFICACIONFISCALDataGridViewTextBoxColumn.HeaderText = "CLASIFICACION_FISCAL";
            this.cLASIFICACIONFISCALDataGridViewTextBoxColumn.Name = "cLASIFICACIONFISCALDataGridViewTextBoxColumn";
            this.cLASIFICACIONFISCALDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLASIFICACIONFISCALDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCTIVODataGridViewTextBoxColumn
            // 
            this.aCTIVODataGridViewTextBoxColumn.DataPropertyName = "ACTIVO";
            this.aCTIVODataGridViewTextBoxColumn.HeaderText = "ACTIVO";
            this.aCTIVODataGridViewTextBoxColumn.Name = "aCTIVODataGridViewTextBoxColumn";
            this.aCTIVODataGridViewTextBoxColumn.ReadOnly = true;
            this.aCTIVODataGridViewTextBoxColumn.Visible = false;
            // 
            // dIRECCIONDataGridViewTextBoxColumn
            // 
            this.dIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.dIRECCIONDataGridViewTextBoxColumn.Name = "dIRECCIONDataGridViewTextBoxColumn";
            this.dIRECCIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tELEFONODataGridViewTextBoxColumn
            // 
            this.tELEFONODataGridViewTextBoxColumn.DataPropertyName = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.tELEFONODataGridViewTextBoxColumn.Name = "tELEFONODataGridViewTextBoxColumn";
            this.tELEFONODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eSPROPIETARIODataGridViewTextBoxColumn
            // 
            this.eSPROPIETARIODataGridViewTextBoxColumn.DataPropertyName = "ES_PROPIETARIO";
            this.eSPROPIETARIODataGridViewTextBoxColumn.HeaderText = "ES_PROPIETARIO";
            this.eSPROPIETARIODataGridViewTextBoxColumn.Name = "eSPROPIETARIODataGridViewTextBoxColumn";
            this.eSPROPIETARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.eSPROPIETARIODataGridViewTextBoxColumn.Visible = false;
            // 
            // eSINQUILINODataGridViewTextBoxColumn
            // 
            this.eSINQUILINODataGridViewTextBoxColumn.DataPropertyName = "ES_INQUILINO";
            this.eSINQUILINODataGridViewTextBoxColumn.HeaderText = "ES_INQUILINO";
            this.eSINQUILINODataGridViewTextBoxColumn.Name = "eSINQUILINODataGridViewTextBoxColumn";
            this.eSINQUILINODataGridViewTextBoxColumn.ReadOnly = true;
            this.eSINQUILINODataGridViewTextBoxColumn.Visible = false;
            // 
            // eSPORTERODataGridViewTextBoxColumn
            // 
            this.eSPORTERODataGridViewTextBoxColumn.DataPropertyName = "ES_PORTERO";
            this.eSPORTERODataGridViewTextBoxColumn.HeaderText = "ES_PORTERO";
            this.eSPORTERODataGridViewTextBoxColumn.Name = "eSPORTERODataGridViewTextBoxColumn";
            this.eSPORTERODataGridViewTextBoxColumn.ReadOnly = true;
            this.eSPORTERODataGridViewTextBoxColumn.Visible = false;
            // 
            // eSADMINISTRADORDataGridViewTextBoxColumn
            // 
            this.eSADMINISTRADORDataGridViewTextBoxColumn.DataPropertyName = "ES_ADMINISTRADOR";
            this.eSADMINISTRADORDataGridViewTextBoxColumn.HeaderText = "ES_ADMINISTRADOR";
            this.eSADMINISTRADORDataGridViewTextBoxColumn.Name = "eSADMINISTRADORDataGridViewTextBoxColumn";
            this.eSADMINISTRADORDataGridViewTextBoxColumn.ReadOnly = true;
            this.eSADMINISTRADORDataGridViewTextBoxColumn.Visible = false;
            // 
            // eSCLIENTEDataGridViewTextBoxColumn
            // 
            this.eSCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "ES_CLIENTE";
            this.eSCLIENTEDataGridViewTextBoxColumn.HeaderText = "ES_CLIENTE";
            this.eSCLIENTEDataGridViewTextBoxColumn.Name = "eSCLIENTEDataGridViewTextBoxColumn";
            this.eSCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.eSCLIENTEDataGridViewTextBoxColumn.Visible = false;
            // 
            // eSPROVEEDORDataGridViewTextBoxColumn
            // 
            this.eSPROVEEDORDataGridViewTextBoxColumn.DataPropertyName = "ES_PROVEEDOR";
            this.eSPROVEEDORDataGridViewTextBoxColumn.HeaderText = "ES_PROVEEDOR";
            this.eSPROVEEDORDataGridViewTextBoxColumn.Name = "eSPROVEEDORDataGridViewTextBoxColumn";
            this.eSPROVEEDORDataGridViewTextBoxColumn.ReadOnly = true;
            this.eSPROVEEDORDataGridViewTextBoxColumn.Visible = false;
            // 
            // eSEMPRESADataGridViewTextBoxColumn
            // 
            this.eSEMPRESADataGridViewTextBoxColumn.DataPropertyName = "ES_EMPRESA";
            this.eSEMPRESADataGridViewTextBoxColumn.HeaderText = "ES_EMPRESA";
            this.eSEMPRESADataGridViewTextBoxColumn.Name = "eSEMPRESADataGridViewTextBoxColumn";
            this.eSEMPRESADataGridViewTextBoxColumn.ReadOnly = true;
            this.eSEMPRESADataGridViewTextBoxColumn.Visible = false;
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
            // sOCIOSNEGOCIOSVIEWBindingSource
            // 
            this.sOCIOSNEGOCIOSVIEWBindingSource.DataSource = typeof(Inmobiliaria.Modelo.SOCIOS_NEGOCIOS_VIEW);
            // 
            // FrmBuscadorSociosNegocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 440);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FrmBuscadorSociosNegocios";
            this.Load += new System.EventHandler(this.FrmBuscadorSociosNegocios_Load);
            this.Shown += new System.EventHandler(this.FrmBuscadorSociosNegocios_Shown);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSociosNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOCIOSNEGOCIOSVIEWBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dgvSociosNegocios;
        private System.Windows.Forms.BindingSource sOCIOSNEGOCIOSVIEWBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOCIONEGOCIOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOCIONEGOCIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMERODOCUMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIGITOVERIFICADORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOPERSONERIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODOCUMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLASIFICACIONFISCALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTIVODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSPROPIETARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSINQUILINODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSPORTERODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSADMINISTRADORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSPROVEEDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSEMPRESADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOCREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHACREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOMODIFICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAMODIFICACIONDataGridViewTextBoxColumn;
        protected System.Windows.Forms.Button btnGuardar;
        protected System.Windows.Forms.Button btnCancelar;
    }
}