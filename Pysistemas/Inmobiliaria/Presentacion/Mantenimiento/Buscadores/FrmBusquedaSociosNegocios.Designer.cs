namespace Inmobiliaria.Presentacion.Mantenimiento.Buscadores
{
    partial class FrmBusquedaSociosNegocios
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
            this.dgvSociosNegocios = new System.Windows.Forms.DataGridView();
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOCIONEGOCIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMERODOCUMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIGITOVERIFICADORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rUCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASIFICACIONFISCALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODOCUMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOPERSONERIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtSocioNegocio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDatos.SuspendLayout();
            this.pnlFiltrosBusqueda.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSociosNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOCIOSNEGOCIOSVIEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Size = new System.Drawing.Size(1008, 46);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.dgvSociosNegocios);
            this.pnlDatos.Size = new System.Drawing.Size(1008, 439);
            this.pnlDatos.Controls.SetChildIndex(this.pnlFiltrosBusqueda, 0);
            this.pnlDatos.Controls.SetChildIndex(this.dgvSociosNegocios, 0);
            // 
            // pnlFiltrosBusqueda
            // 
            this.pnlFiltrosBusqueda.Controls.Add(this.txtNumeroDocumento);
            this.pnlFiltrosBusqueda.Controls.Add(this.label1);
            this.pnlFiltrosBusqueda.Controls.Add(this.btnBuscar);
            this.pnlFiltrosBusqueda.Controls.Add(this.btnCancelar);
            this.pnlFiltrosBusqueda.Controls.Add(this.txtSocioNegocio);
            this.pnlFiltrosBusqueda.Controls.Add(this.label3);
            this.pnlFiltrosBusqueda.Size = new System.Drawing.Size(297, 437);
            this.pnlFiltrosBusqueda.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1008, 43);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(936, 43);
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
            this.rUCDataGridViewTextBoxColumn,
            this.cLASIFICACIONFISCALDataGridViewTextBoxColumn,
            this.tIPODOCUMENTODataGridViewTextBoxColumn,
            this.tIPOPERSONERIADataGridViewTextBoxColumn,
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
            this.dgvSociosNegocios.Location = new System.Drawing.Point(297, 0);
            this.dgvSociosNegocios.MultiSelect = false;
            this.dgvSociosNegocios.Name = "dgvSociosNegocios";
            this.dgvSociosNegocios.ReadOnly = true;
            this.dgvSociosNegocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSociosNegocios.Size = new System.Drawing.Size(709, 437);
            this.dgvSociosNegocios.TabIndex = 1;
            this.dgvSociosNegocios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSociosNegocios_CellContentClick);
            this.dgvSociosNegocios.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvSociosNegocios_RowPostPaint);
            this.dgvSociosNegocios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvSociosNegocios_MouseClick);
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
            this.sOCIONEGOCIODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sOCIONEGOCIODataGridViewTextBoxColumn.DataPropertyName = "SOCIO_NEGOCIO";
            this.sOCIONEGOCIODataGridViewTextBoxColumn.HeaderText = "Socio Negocio";
            this.sOCIONEGOCIODataGridViewTextBoxColumn.Name = "sOCIONEGOCIODataGridViewTextBoxColumn";
            this.sOCIONEGOCIODataGridViewTextBoxColumn.ReadOnly = true;
            this.sOCIONEGOCIODataGridViewTextBoxColumn.Width = 250;
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
            // rUCDataGridViewTextBoxColumn
            // 
            this.rUCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rUCDataGridViewTextBoxColumn.DataPropertyName = "RUC";
            this.rUCDataGridViewTextBoxColumn.HeaderText = "Ruc";
            this.rUCDataGridViewTextBoxColumn.Name = "rUCDataGridViewTextBoxColumn";
            this.rUCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLASIFICACIONFISCALDataGridViewTextBoxColumn
            // 
            this.cLASIFICACIONFISCALDataGridViewTextBoxColumn.DataPropertyName = "CLASIFICACION_FISCAL";
            this.cLASIFICACIONFISCALDataGridViewTextBoxColumn.HeaderText = "CLASIFICACION_FISCAL";
            this.cLASIFICACIONFISCALDataGridViewTextBoxColumn.Name = "cLASIFICACIONFISCALDataGridViewTextBoxColumn";
            this.cLASIFICACIONFISCALDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLASIFICACIONFISCALDataGridViewTextBoxColumn.Visible = false;
            // 
            // tIPODOCUMENTODataGridViewTextBoxColumn
            // 
            this.tIPODOCUMENTODataGridViewTextBoxColumn.DataPropertyName = "TIPO_DOCUMENTO";
            this.tIPODOCUMENTODataGridViewTextBoxColumn.HeaderText = "TIPO_DOCUMENTO";
            this.tIPODOCUMENTODataGridViewTextBoxColumn.Name = "tIPODOCUMENTODataGridViewTextBoxColumn";
            this.tIPODOCUMENTODataGridViewTextBoxColumn.ReadOnly = true;
            this.tIPODOCUMENTODataGridViewTextBoxColumn.Visible = false;
            // 
            // tIPOPERSONERIADataGridViewTextBoxColumn
            // 
            this.tIPOPERSONERIADataGridViewTextBoxColumn.DataPropertyName = "TIPO_PERSONERIA";
            this.tIPOPERSONERIADataGridViewTextBoxColumn.HeaderText = "TIPO_PERSONERIA";
            this.tIPOPERSONERIADataGridViewTextBoxColumn.Name = "tIPOPERSONERIADataGridViewTextBoxColumn";
            this.tIPOPERSONERIADataGridViewTextBoxColumn.ReadOnly = true;
            this.tIPOPERSONERIADataGridViewTextBoxColumn.Visible = false;
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
            this.dIRECCIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.dIRECCIONDataGridViewTextBoxColumn.Name = "dIRECCIONDataGridViewTextBoxColumn";
            this.dIRECCIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.dIRECCIONDataGridViewTextBoxColumn.Width = 180;
            // 
            // tELEFONODataGridViewTextBoxColumn
            // 
            this.tELEFONODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tELEFONODataGridViewTextBoxColumn.DataPropertyName = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.tELEFONODataGridViewTextBoxColumn.Name = "tELEFONODataGridViewTextBoxColumn";
            this.tELEFONODataGridViewTextBoxColumn.ReadOnly = true;
            this.tELEFONODataGridViewTextBoxColumn.Width = 80;
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
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(34, 232);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 35);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(83)))), ((int)(((byte)(44)))));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(133, 232);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 35);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Limpiar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtSocioNegocio
            // 
            this.txtSocioNegocio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSocioNegocio.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtSocioNegocio.Location = new System.Drawing.Point(8, 115);
            this.txtSocioNegocio.MaxLength = 20;
            this.txtSocioNegocio.Name = "txtSocioNegocio";
            this.txtSocioNegocio.Size = new System.Drawing.Size(233, 22);
            this.txtSocioNegocio.TabIndex = 0;
            this.txtSocioNegocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSocioNegocio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Nombres/Apellidos";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumeroDocumento.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtNumeroDocumento.Location = new System.Drawing.Point(8, 166);
            this.txtNumeroDocumento.MaxLength = 20;
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(233, 22);
            this.txtNumeroDocumento.TabIndex = 1;
            this.txtNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSocioNegocio_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nro. documento";
            // 
            // FrmBusquedaSociosNegocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 584);
            this.Name = "FrmBusquedaSociosNegocios";
            this.Load += new System.EventHandler(this.FrmBusquedaSociosNegocios_Load);
            this.Shown += new System.EventHandler(this.FrmBusquedaSociosNegocios_Shown);
            this.pnlDatos.ResumeLayout(false);
            this.pnlFiltrosBusqueda.ResumeLayout(false);
            this.pnlFiltrosBusqueda.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSociosNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOCIOSNEGOCIOSVIEWBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSociosNegocios;
        private System.Windows.Forms.BindingSource sOCIOSNEGOCIOSVIEWBindingSource;
        protected System.Windows.Forms.Button btnBuscar;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtSocioNegocio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOCIONEGOCIOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOCIONEGOCIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMERODOCUMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIGITOVERIFICADORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLASIFICACIONFISCALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODOCUMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOPERSONERIADataGridViewTextBoxColumn;
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
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Label label1;
    }
}