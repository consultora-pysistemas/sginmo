namespace Inmobiliaria.Presentacion.EntidadesInmobiliarias.Buscadores
{
    partial class FrmBusquedaPropiedades
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
            this.dgvPropiedades = new System.Windows.Forms.DataGridView();
            this.pROPIEDADESVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtPropiedad = new System.Windows.Forms.TextBox();
            this.lblPropiedad = new System.Windows.Forms.Label();
            this.cbUnidadInmobiliaria = new System.Windows.Forms.ComboBox();
            this.lblTipoEntidad = new System.Windows.Forms.Label();
            this.txtCuentaCatastral = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pROPIEDADIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROPIEDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUENTACATASTRALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAISIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTAMENTOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIUDADIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIUDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bARRIOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bARRIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARACTERISTICASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIENECOCHERADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADCOCHERADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2CONSTRUCCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNOCONSTRUCCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDIDALOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIOVENTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMISIONVENTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIOALQUILERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMISIONALQUILERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLQUILADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENDIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOCREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHACREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDatos.SuspendLayout();
            this.pnlFiltrosBusqueda.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPIEDADESVIEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Size = new System.Drawing.Size(1324, 46);
            // 
            // pnlDatos
            // 
            this.pnlDatos.AutoScroll = true;
            this.pnlDatos.Controls.Add(this.dgvPropiedades);
            this.pnlDatos.Size = new System.Drawing.Size(1324, 509);
            this.pnlDatos.Controls.SetChildIndex(this.pnlFiltrosBusqueda, 0);
            this.pnlDatos.Controls.SetChildIndex(this.dgvPropiedades, 0);
            // 
            // pnlFiltrosBusqueda
            // 
            this.pnlFiltrosBusqueda.Controls.Add(this.txtCuentaCatastral);
            this.pnlFiltrosBusqueda.Controls.Add(this.label2);
            this.pnlFiltrosBusqueda.Controls.Add(this.lblTipoEntidad);
            this.pnlFiltrosBusqueda.Controls.Add(this.cbUnidadInmobiliaria);
            this.pnlFiltrosBusqueda.Controls.Add(this.btnBuscar);
            this.pnlFiltrosBusqueda.Controls.Add(this.btnCancelar);
            this.pnlFiltrosBusqueda.Controls.Add(this.txtPropiedad);
            this.pnlFiltrosBusqueda.Controls.Add(this.lblPropiedad);
            this.pnlFiltrosBusqueda.Size = new System.Drawing.Size(255, 507);
            this.pnlFiltrosBusqueda.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1324, 43);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(1252, 43);
            // 
            // dgvPropiedades
            // 
            this.dgvPropiedades.AllowUserToAddRows = false;
            this.dgvPropiedades.AllowUserToDeleteRows = false;
            this.dgvPropiedades.AllowUserToOrderColumns = true;
            this.dgvPropiedades.AutoGenerateColumns = false;
            this.dgvPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropiedades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pROPIEDADIDDataGridViewTextBoxColumn,
            this.NroItem,
            this.pROPIEDADDataGridViewTextBoxColumn,
            this.tIPODataGridViewTextBoxColumn,
            this.cUENTACATASTRALDataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn,
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn,
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn,
            this.pAISIDDataGridViewTextBoxColumn,
            this.pAISDataGridViewTextBoxColumn,
            this.dEPARTAMENTOIDDataGridViewTextBoxColumn,
            this.dEPARTAMENTODataGridViewTextBoxColumn,
            this.cIUDADIDDataGridViewTextBoxColumn,
            this.cIUDADDataGridViewTextBoxColumn,
            this.bARRIOIDDataGridViewTextBoxColumn,
            this.bARRIODataGridViewTextBoxColumn,
            this.dIRECCIONDataGridViewTextBoxColumn,
            this.cARACTERISTICASDataGridViewTextBoxColumn,
            this.tIENECOCHERADataGridViewTextBoxColumn,
            this.cANTIDADCOCHERADataGridViewTextBoxColumn,
            this.m2CONSTRUCCIONDataGridViewTextBoxColumn,
            this.aNOCONSTRUCCIONDataGridViewTextBoxColumn,
            this.mEDIDALOTEDataGridViewTextBoxColumn,
            this.pRECIOVENTADataGridViewTextBoxColumn,
            this.cOMISIONVENTADataGridViewTextBoxColumn,
            this.pRECIOALQUILERDataGridViewTextBoxColumn,
            this.cOMISIONALQUILERDataGridViewTextBoxColumn,
            this.aLQUILADADataGridViewTextBoxColumn,
            this.vENDIDADataGridViewTextBoxColumn,
            this.uSUARIOCREACIONDataGridViewTextBoxColumn,
            this.fECHACREACIONDataGridViewTextBoxColumn,
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn,
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn});
            this.dgvPropiedades.DataSource = this.pROPIEDADESVIEWBindingSource;
            this.dgvPropiedades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPropiedades.Location = new System.Drawing.Point(255, 0);
            this.dgvPropiedades.Name = "dgvPropiedades";
            this.dgvPropiedades.ReadOnly = true;
            this.dgvPropiedades.Size = new System.Drawing.Size(1067, 507);
            this.dgvPropiedades.TabIndex = 1;
            this.dgvPropiedades.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPropiedades_CellContentClick);
            this.dgvPropiedades.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvPropiedades_CellValueNeeded);
            this.dgvPropiedades.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvPropiedades_RowPostPaint);
            this.dgvPropiedades.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPropiedades_MouseClick);
            // 
            // pROPIEDADESVIEWBindingSource
            // 
            this.pROPIEDADESVIEWBindingSource.DataSource = typeof(Inmobiliaria.Modelo.PROPIEDADES_VIEW);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(19, 258);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 35);
            this.btnBuscar.TabIndex = 3;
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
            this.btnCancelar.Location = new System.Drawing.Point(118, 258);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 35);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Limpiar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtPropiedad
            // 
            this.txtPropiedad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPropiedad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropiedad.Location = new System.Drawing.Point(10, 161);
            this.txtPropiedad.MaxLength = 20;
            this.txtPropiedad.Name = "txtPropiedad";
            this.txtPropiedad.Size = new System.Drawing.Size(233, 23);
            this.txtPropiedad.TabIndex = 1;
            this.txtPropiedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbUnidadInmobiliaria_KeyPress);
            // 
            // lblPropiedad
            // 
            this.lblPropiedad.AutoSize = true;
            this.lblPropiedad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropiedad.Location = new System.Drawing.Point(10, 138);
            this.lblPropiedad.Name = "lblPropiedad";
            this.lblPropiedad.Size = new System.Drawing.Size(110, 15);
            this.lblPropiedad.TabIndex = 48;
            this.lblPropiedad.Text = "Dpto/Lote/Dúplex";
            // 
            // cbUnidadInmobiliaria
            // 
            this.cbUnidadInmobiliaria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbUnidadInmobiliaria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbUnidadInmobiliaria.DisplayMember = "NOMBRE";
            this.cbUnidadInmobiliaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidadInmobiliaria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnidadInmobiliaria.FormattingEnabled = true;
            this.cbUnidadInmobiliaria.Location = new System.Drawing.Point(10, 106);
            this.cbUnidadInmobiliaria.Name = "cbUnidadInmobiliaria";
            this.cbUnidadInmobiliaria.Size = new System.Drawing.Size(233, 23);
            this.cbUnidadInmobiliaria.TabIndex = 0;
            this.cbUnidadInmobiliaria.ValueMember = "ENTIDAD_INMOBILIARIA_ID";
            this.cbUnidadInmobiliaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbUnidadInmobiliaria_KeyPress);
            // 
            // lblTipoEntidad
            // 
            this.lblTipoEntidad.AutoSize = true;
            this.lblTipoEntidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEntidad.Location = new System.Drawing.Point(10, 81);
            this.lblTipoEntidad.Name = "lblTipoEntidad";
            this.lblTipoEntidad.Size = new System.Drawing.Size(170, 15);
            this.lblTipoEntidad.TabIndex = 57;
            this.lblTipoEntidad.Text = "Edificio/Loteamiento/Salones";
            // 
            // txtCuentaCatastral
            // 
            this.txtCuentaCatastral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCuentaCatastral.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaCatastral.Location = new System.Drawing.Point(10, 213);
            this.txtCuentaCatastral.MaxLength = 20;
            this.txtCuentaCatastral.Name = "txtCuentaCatastral";
            this.txtCuentaCatastral.Size = new System.Drawing.Size(233, 23);
            this.txtCuentaCatastral.TabIndex = 2;
            this.txtCuentaCatastral.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbUnidadInmobiliaria_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 59;
            this.label2.Text = "Cuenta catastral";
            // 
            // pROPIEDADIDDataGridViewTextBoxColumn
            // 
            this.pROPIEDADIDDataGridViewTextBoxColumn.DataPropertyName = "PROPIEDAD_ID";
            this.pROPIEDADIDDataGridViewTextBoxColumn.HeaderText = "PROPIEDAD_ID";
            this.pROPIEDADIDDataGridViewTextBoxColumn.Name = "pROPIEDADIDDataGridViewTextBoxColumn";
            this.pROPIEDADIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pROPIEDADIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // NroItem
            // 
            this.NroItem.HeaderText = "Nro. Orden";
            this.NroItem.Name = "NroItem";
            this.NroItem.ReadOnly = true;
            this.NroItem.Visible = false;
            // 
            // pROPIEDADDataGridViewTextBoxColumn
            // 
            this.pROPIEDADDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pROPIEDADDataGridViewTextBoxColumn.DataPropertyName = "PROPIEDAD";
            this.pROPIEDADDataGridViewTextBoxColumn.HeaderText = "Dpto/Lote/Dúplex";
            this.pROPIEDADDataGridViewTextBoxColumn.Name = "pROPIEDADDataGridViewTextBoxColumn";
            this.pROPIEDADDataGridViewTextBoxColumn.ReadOnly = true;
            this.pROPIEDADDataGridViewTextBoxColumn.Width = 124;
            // 
            // tIPODataGridViewTextBoxColumn
            // 
            this.tIPODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tIPODataGridViewTextBoxColumn.DataPropertyName = "TIPO";
            this.tIPODataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tIPODataGridViewTextBoxColumn.Name = "tIPODataGridViewTextBoxColumn";
            this.tIPODataGridViewTextBoxColumn.ReadOnly = true;
            this.tIPODataGridViewTextBoxColumn.Width = 55;
            // 
            // cUENTACATASTRALDataGridViewTextBoxColumn
            // 
            this.cUENTACATASTRALDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cUENTACATASTRALDataGridViewTextBoxColumn.DataPropertyName = "CUENTA_CATASTRAL";
            this.cUENTACATASTRALDataGridViewTextBoxColumn.HeaderText = "Cta.Ctral.";
            this.cUENTACATASTRALDataGridViewTextBoxColumn.Name = "cUENTACATASTRALDataGridViewTextBoxColumn";
            this.cUENTACATASTRALDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUENTACATASTRALDataGridViewTextBoxColumn.Width = 79;
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "Estado";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            this.eSTADODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn
            // 
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn.DataPropertyName = "ENTIDAD_INMOBILIARIA_ID";
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn.HeaderText = "ENTIDAD_INMOBILIARIA_ID";
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn.Name = "eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn";
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // eNTIDADINMOBILIARIADataGridViewTextBoxColumn
            // 
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn.DataPropertyName = "ENTIDAD_INMOBILIARIA";
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn.HeaderText = "ENTIDAD_INMOBILIARIA";
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn.Name = "eNTIDADINMOBILIARIADataGridViewTextBoxColumn";
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn.ReadOnly = true;
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn.Visible = false;
            // 
            // pAISIDDataGridViewTextBoxColumn
            // 
            this.pAISIDDataGridViewTextBoxColumn.DataPropertyName = "PAIS_ID";
            this.pAISIDDataGridViewTextBoxColumn.HeaderText = "PAIS_ID";
            this.pAISIDDataGridViewTextBoxColumn.Name = "pAISIDDataGridViewTextBoxColumn";
            this.pAISIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pAISIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pAISDataGridViewTextBoxColumn
            // 
            this.pAISDataGridViewTextBoxColumn.DataPropertyName = "PAIS";
            this.pAISDataGridViewTextBoxColumn.HeaderText = "PAIS";
            this.pAISDataGridViewTextBoxColumn.Name = "pAISDataGridViewTextBoxColumn";
            this.pAISDataGridViewTextBoxColumn.ReadOnly = true;
            this.pAISDataGridViewTextBoxColumn.Visible = false;
            // 
            // dEPARTAMENTOIDDataGridViewTextBoxColumn
            // 
            this.dEPARTAMENTOIDDataGridViewTextBoxColumn.DataPropertyName = "DEPARTAMENTO_ID";
            this.dEPARTAMENTOIDDataGridViewTextBoxColumn.HeaderText = "DEPARTAMENTO_ID";
            this.dEPARTAMENTOIDDataGridViewTextBoxColumn.Name = "dEPARTAMENTOIDDataGridViewTextBoxColumn";
            this.dEPARTAMENTOIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dEPARTAMENTOIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dEPARTAMENTODataGridViewTextBoxColumn
            // 
            this.dEPARTAMENTODataGridViewTextBoxColumn.DataPropertyName = "DEPARTAMENTO";
            this.dEPARTAMENTODataGridViewTextBoxColumn.HeaderText = "DEPARTAMENTO";
            this.dEPARTAMENTODataGridViewTextBoxColumn.Name = "dEPARTAMENTODataGridViewTextBoxColumn";
            this.dEPARTAMENTODataGridViewTextBoxColumn.ReadOnly = true;
            this.dEPARTAMENTODataGridViewTextBoxColumn.Visible = false;
            // 
            // cIUDADIDDataGridViewTextBoxColumn
            // 
            this.cIUDADIDDataGridViewTextBoxColumn.DataPropertyName = "CIUDAD_ID";
            this.cIUDADIDDataGridViewTextBoxColumn.HeaderText = "CIUDAD_ID";
            this.cIUDADIDDataGridViewTextBoxColumn.Name = "cIUDADIDDataGridViewTextBoxColumn";
            this.cIUDADIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIUDADIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cIUDADDataGridViewTextBoxColumn
            // 
            this.cIUDADDataGridViewTextBoxColumn.DataPropertyName = "CIUDAD";
            this.cIUDADDataGridViewTextBoxColumn.HeaderText = "CIUDAD";
            this.cIUDADDataGridViewTextBoxColumn.Name = "cIUDADDataGridViewTextBoxColumn";
            this.cIUDADDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIUDADDataGridViewTextBoxColumn.Visible = false;
            // 
            // bARRIOIDDataGridViewTextBoxColumn
            // 
            this.bARRIOIDDataGridViewTextBoxColumn.DataPropertyName = "BARRIO_ID";
            this.bARRIOIDDataGridViewTextBoxColumn.HeaderText = "BARRIO_ID";
            this.bARRIOIDDataGridViewTextBoxColumn.Name = "bARRIOIDDataGridViewTextBoxColumn";
            this.bARRIOIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bARRIOIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bARRIODataGridViewTextBoxColumn
            // 
            this.bARRIODataGridViewTextBoxColumn.DataPropertyName = "BARRIO";
            this.bARRIODataGridViewTextBoxColumn.HeaderText = "BARRIO";
            this.bARRIODataGridViewTextBoxColumn.Name = "bARRIODataGridViewTextBoxColumn";
            this.bARRIODataGridViewTextBoxColumn.ReadOnly = true;
            this.bARRIODataGridViewTextBoxColumn.Visible = false;
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
            // cARACTERISTICASDataGridViewTextBoxColumn
            // 
            this.cARACTERISTICASDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cARACTERISTICASDataGridViewTextBoxColumn.DataPropertyName = "CARACTERISTICAS";
            this.cARACTERISTICASDataGridViewTextBoxColumn.HeaderText = "Caracteristicas";
            this.cARACTERISTICASDataGridViewTextBoxColumn.Name = "cARACTERISTICASDataGridViewTextBoxColumn";
            this.cARACTERISTICASDataGridViewTextBoxColumn.ReadOnly = true;
            this.cARACTERISTICASDataGridViewTextBoxColumn.Width = 105;
            // 
            // tIENECOCHERADataGridViewTextBoxColumn
            // 
            this.tIENECOCHERADataGridViewTextBoxColumn.DataPropertyName = "TIENE_COCHERA";
            this.tIENECOCHERADataGridViewTextBoxColumn.HeaderText = "TIENE_COCHERA";
            this.tIENECOCHERADataGridViewTextBoxColumn.Name = "tIENECOCHERADataGridViewTextBoxColumn";
            this.tIENECOCHERADataGridViewTextBoxColumn.ReadOnly = true;
            this.tIENECOCHERADataGridViewTextBoxColumn.Visible = false;
            // 
            // cANTIDADCOCHERADataGridViewTextBoxColumn
            // 
            this.cANTIDADCOCHERADataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD_COCHERA";
            this.cANTIDADCOCHERADataGridViewTextBoxColumn.HeaderText = "CANTIDAD_COCHERA";
            this.cANTIDADCOCHERADataGridViewTextBoxColumn.Name = "cANTIDADCOCHERADataGridViewTextBoxColumn";
            this.cANTIDADCOCHERADataGridViewTextBoxColumn.ReadOnly = true;
            this.cANTIDADCOCHERADataGridViewTextBoxColumn.Visible = false;
            // 
            // m2CONSTRUCCIONDataGridViewTextBoxColumn
            // 
            this.m2CONSTRUCCIONDataGridViewTextBoxColumn.DataPropertyName = "M2_CONSTRUCCION";
            this.m2CONSTRUCCIONDataGridViewTextBoxColumn.HeaderText = "M2_CONSTRUCCION";
            this.m2CONSTRUCCIONDataGridViewTextBoxColumn.Name = "m2CONSTRUCCIONDataGridViewTextBoxColumn";
            this.m2CONSTRUCCIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.m2CONSTRUCCIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // aNOCONSTRUCCIONDataGridViewTextBoxColumn
            // 
            this.aNOCONSTRUCCIONDataGridViewTextBoxColumn.DataPropertyName = "ANO_CONSTRUCCION";
            this.aNOCONSTRUCCIONDataGridViewTextBoxColumn.HeaderText = "ANO_CONSTRUCCION";
            this.aNOCONSTRUCCIONDataGridViewTextBoxColumn.Name = "aNOCONSTRUCCIONDataGridViewTextBoxColumn";
            this.aNOCONSTRUCCIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.aNOCONSTRUCCIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // mEDIDALOTEDataGridViewTextBoxColumn
            // 
            this.mEDIDALOTEDataGridViewTextBoxColumn.DataPropertyName = "MEDIDA_LOTE";
            this.mEDIDALOTEDataGridViewTextBoxColumn.HeaderText = "MEDIDA_LOTE";
            this.mEDIDALOTEDataGridViewTextBoxColumn.Name = "mEDIDALOTEDataGridViewTextBoxColumn";
            this.mEDIDALOTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.mEDIDALOTEDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRECIOVENTADataGridViewTextBoxColumn
            // 
            this.pRECIOVENTADataGridViewTextBoxColumn.DataPropertyName = "PRECIO_VENTA";
            this.pRECIOVENTADataGridViewTextBoxColumn.HeaderText = "PRECIO_VENTA";
            this.pRECIOVENTADataGridViewTextBoxColumn.Name = "pRECIOVENTADataGridViewTextBoxColumn";
            this.pRECIOVENTADataGridViewTextBoxColumn.ReadOnly = true;
            this.pRECIOVENTADataGridViewTextBoxColumn.Visible = false;
            // 
            // cOMISIONVENTADataGridViewTextBoxColumn
            // 
            this.cOMISIONVENTADataGridViewTextBoxColumn.DataPropertyName = "COMISION_VENTA";
            this.cOMISIONVENTADataGridViewTextBoxColumn.HeaderText = "COMISION_VENTA";
            this.cOMISIONVENTADataGridViewTextBoxColumn.Name = "cOMISIONVENTADataGridViewTextBoxColumn";
            this.cOMISIONVENTADataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMISIONVENTADataGridViewTextBoxColumn.Visible = false;
            // 
            // pRECIOALQUILERDataGridViewTextBoxColumn
            // 
            this.pRECIOALQUILERDataGridViewTextBoxColumn.DataPropertyName = "PRECIO_ALQUILER";
            this.pRECIOALQUILERDataGridViewTextBoxColumn.HeaderText = "PRECIO_ALQUILER";
            this.pRECIOALQUILERDataGridViewTextBoxColumn.Name = "pRECIOALQUILERDataGridViewTextBoxColumn";
            this.pRECIOALQUILERDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRECIOALQUILERDataGridViewTextBoxColumn.Visible = false;
            // 
            // cOMISIONALQUILERDataGridViewTextBoxColumn
            // 
            this.cOMISIONALQUILERDataGridViewTextBoxColumn.DataPropertyName = "COMISION_ALQUILER";
            this.cOMISIONALQUILERDataGridViewTextBoxColumn.HeaderText = "COMISION_ALQUILER";
            this.cOMISIONALQUILERDataGridViewTextBoxColumn.Name = "cOMISIONALQUILERDataGridViewTextBoxColumn";
            this.cOMISIONALQUILERDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMISIONALQUILERDataGridViewTextBoxColumn.Visible = false;
            // 
            // aLQUILADADataGridViewTextBoxColumn
            // 
            this.aLQUILADADataGridViewTextBoxColumn.DataPropertyName = "ALQUILADA";
            this.aLQUILADADataGridViewTextBoxColumn.HeaderText = "ALQUILADA";
            this.aLQUILADADataGridViewTextBoxColumn.Name = "aLQUILADADataGridViewTextBoxColumn";
            this.aLQUILADADataGridViewTextBoxColumn.ReadOnly = true;
            this.aLQUILADADataGridViewTextBoxColumn.Visible = false;
            // 
            // vENDIDADataGridViewTextBoxColumn
            // 
            this.vENDIDADataGridViewTextBoxColumn.DataPropertyName = "VENDIDA";
            this.vENDIDADataGridViewTextBoxColumn.HeaderText = "VENDIDA";
            this.vENDIDADataGridViewTextBoxColumn.Name = "vENDIDADataGridViewTextBoxColumn";
            this.vENDIDADataGridViewTextBoxColumn.ReadOnly = true;
            this.vENDIDADataGridViewTextBoxColumn.Visible = false;
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
            // FrmBusquedaPropiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1324, 654);
            this.Name = "FrmBusquedaPropiedades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmBusquedaPropiedades_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlFiltrosBusqueda.ResumeLayout(false);
            this.pnlFiltrosBusqueda.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPIEDADESVIEWBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPropiedades;
        private System.Windows.Forms.BindingSource pROPIEDADESVIEWBindingSource;
        protected System.Windows.Forms.Button btnBuscar;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtPropiedad;
        private System.Windows.Forms.Label lblPropiedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROPIETARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTipoEntidad;
        private System.Windows.Forms.ComboBox cbUnidadInmobiliaria;
        private System.Windows.Forms.TextBox txtCuentaCatastral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROPIEDADIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROPIEDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUENTACATASTRALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTIDADINMOBILIARIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAISIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTAMENTOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIUDADIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIUDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bARRIOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bARRIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARACTERISTICASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIENECOCHERADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADCOCHERADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2CONSTRUCCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNOCONSTRUCCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDIDALOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIOVENTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMISIONVENTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIOALQUILERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMISIONALQUILERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLQUILADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vENDIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOCREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHACREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOMODIFICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAMODIFICACIONDataGridViewTextBoxColumn;
    }
}