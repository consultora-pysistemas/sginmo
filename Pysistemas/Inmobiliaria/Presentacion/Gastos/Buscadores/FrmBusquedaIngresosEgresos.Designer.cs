namespace Inmobiliaria.Presentacion.Gastos.Buscadores
{
    partial class FrmBusquedaIngresosEgresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusquedaIngresosEgresos));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblItemIngresoEgreso = new System.Windows.Forms.Label();
            this.lblEntidadPropiedadSocionegocio = new System.Windows.Forms.Label();
            this.txtEntidadPropiedad = new System.Windows.Forms.TextBox();
            this.cbTipoItem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoImputacion = new System.Windows.Forms.ComboBox();
            this.btnBuscadorEntidadPropiedad = new System.Windows.Forms.Button();
            this.dgvItemIngresoEgreso = new System.Windows.Forms.DataGridView();
            this.iNGRESOEGRESOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOCIONEGOCIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROPIEDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEROFACTURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAFACTURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROPIEDADIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMINGRESOEGRESOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOCREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHACREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNGRESOSEGRESOSVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatos.SuspendLayout();
            this.pnlFiltrosBusqueda.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemIngresoEgreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNGRESOSEGRESOSVIEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Size = new System.Drawing.Size(1278, 31);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.dgvItemIngresoEgreso);
            this.pnlDatos.Location = new System.Drawing.Point(0, 130);
            this.pnlDatos.Size = new System.Drawing.Size(1278, 544);
            this.pnlDatos.Controls.SetChildIndex(this.pnlFiltrosBusqueda, 0);
            this.pnlDatos.Controls.SetChildIndex(this.dgvItemIngresoEgreso, 0);
            // 
            // pnlFiltrosBusqueda
            // 
            this.pnlFiltrosBusqueda.Controls.Add(this.btnBuscadorEntidadPropiedad);
            this.pnlFiltrosBusqueda.Controls.Add(this.label3);
            this.pnlFiltrosBusqueda.Controls.Add(this.cbTipoImputacion);
            this.pnlFiltrosBusqueda.Controls.Add(this.btnBuscar);
            this.pnlFiltrosBusqueda.Controls.Add(this.btnCancelar);
            this.pnlFiltrosBusqueda.Controls.Add(this.lblItemIngresoEgreso);
            this.pnlFiltrosBusqueda.Controls.Add(this.lblEntidadPropiedadSocionegocio);
            this.pnlFiltrosBusqueda.Controls.Add(this.txtEntidadPropiedad);
            this.pnlFiltrosBusqueda.Controls.Add(this.cbTipoItem);
            this.pnlFiltrosBusqueda.Size = new System.Drawing.Size(235, 542);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1278, 43);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(1206, 43);
            this.lblTitulo.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(7, 271);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 35);
            this.btnBuscar.TabIndex = 70;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(83)))), ((int)(((byte)(44)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(108, 271);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 35);
            this.btnCancelar.TabIndex = 69;
            this.btnCancelar.Text = "Limpiar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblItemIngresoEgreso
            // 
            this.lblItemIngresoEgreso.AutoSize = true;
            this.lblItemIngresoEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemIngresoEgreso.Location = new System.Drawing.Point(12, 181);
            this.lblItemIngresoEgreso.Name = "lblItemIngresoEgreso";
            this.lblItemIngresoEgreso.Size = new System.Drawing.Size(120, 13);
            this.lblItemIngresoEgreso.TabIndex = 67;
            this.lblItemIngresoEgreso.Text = "Item ingreso/egreso";
            // 
            // lblEntidadPropiedadSocionegocio
            // 
            this.lblEntidadPropiedadSocionegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntidadPropiedadSocionegocio.Location = new System.Drawing.Point(12, 125);
            this.lblEntidadPropiedadSocionegocio.Name = "lblEntidadPropiedadSocionegocio";
            this.lblEntidadPropiedadSocionegocio.Size = new System.Drawing.Size(185, 13);
            this.lblEntidadPropiedadSocionegocio.TabIndex = 66;
            this.lblEntidadPropiedadSocionegocio.Text = "Edificio";
            // 
            // txtEntidadPropiedad
            // 
            this.txtEntidadPropiedad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEntidadPropiedad.Location = new System.Drawing.Point(7, 148);
            this.txtEntidadPropiedad.MaxLength = 20;
            this.txtEntidadPropiedad.Name = "txtEntidadPropiedad";
            this.txtEntidadPropiedad.Size = new System.Drawing.Size(185, 22);
            this.txtEntidadPropiedad.TabIndex = 63;
            // 
            // cbTipoItem
            // 
            this.cbTipoItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbTipoItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTipoItem.DisplayMember = "ITEM";
            this.cbTipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoItem.FormattingEnabled = true;
            this.cbTipoItem.Location = new System.Drawing.Point(7, 202);
            this.cbTipoItem.Name = "cbTipoItem";
            this.cbTipoItem.Size = new System.Drawing.Size(185, 23);
            this.cbTipoItem.TabIndex = 64;
            this.cbTipoItem.ValueMember = "ITEM_INGRESO_EGRESO_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Imputado a:";
            // 
            // cbTipoImputacion
            // 
            this.cbTipoImputacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbTipoImputacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTipoImputacion.DisplayMember = "VALOR_DOMINIO";
            this.cbTipoImputacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoImputacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoImputacion.FormattingEnabled = true;
            this.cbTipoImputacion.Location = new System.Drawing.Point(7, 95);
            this.cbTipoImputacion.Name = "cbTipoImputacion";
            this.cbTipoImputacion.Size = new System.Drawing.Size(185, 23);
            this.cbTipoImputacion.TabIndex = 71;
            this.cbTipoImputacion.ValueMember = "CODIGO_DOMINIO";
            this.cbTipoImputacion.SelectedValueChanged += new System.EventHandler(this.cbTipoImputacion_SelectedValueChanged);
            // 
            // btnBuscadorEntidadPropiedad
            // 
            this.btnBuscadorEntidadPropiedad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscadorEntidadPropiedad.BackgroundImage")));
            this.btnBuscadorEntidadPropiedad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscadorEntidadPropiedad.Location = new System.Drawing.Point(195, 145);
            this.btnBuscadorEntidadPropiedad.Name = "btnBuscadorEntidadPropiedad";
            this.btnBuscadorEntidadPropiedad.Size = new System.Drawing.Size(28, 28);
            this.btnBuscadorEntidadPropiedad.TabIndex = 73;
            this.btnBuscadorEntidadPropiedad.UseVisualStyleBackColor = true;
            this.btnBuscadorEntidadPropiedad.Click += new System.EventHandler(this.btnBuscadorEntidadPropiedad_Click);
            // 
            // dgvItemIngresoEgreso
            // 
            this.dgvItemIngresoEgreso.AllowUserToAddRows = false;
            this.dgvItemIngresoEgreso.AllowUserToDeleteRows = false;
            this.dgvItemIngresoEgreso.AllowUserToOrderColumns = true;
            this.dgvItemIngresoEgreso.AutoGenerateColumns = false;
            this.dgvItemIngresoEgreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemIngresoEgreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNGRESOEGRESOIDDataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn,
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn,
            this.sOCIONEGOCIODataGridViewTextBoxColumn,
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn,
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn,
            this.pROPIEDADDataGridViewTextBoxColumn,
            this.iTEMDataGridViewTextBoxColumn,
            this.nUMEROFACTURADataGridViewTextBoxColumn,
            this.fECHAFACTURADataGridViewTextBoxColumn,
            this.mONTODataGridViewTextBoxColumn,
            this.sALDODataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn,
            this.tIPODataGridViewTextBoxColumn,
            this.pROPIEDADIDDataGridViewTextBoxColumn,
            this.iTEMINGRESOEGRESOIDDataGridViewTextBoxColumn,
            this.uSUARIOCREACIONDataGridViewTextBoxColumn,
            this.fECHACREACIONDataGridViewTextBoxColumn,
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn,
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn});
            this.dgvItemIngresoEgreso.DataSource = this.iNGRESOSEGRESOSVIEWBindingSource;
            this.dgvItemIngresoEgreso.Location = new System.Drawing.Point(235, 0);
            this.dgvItemIngresoEgreso.Name = "dgvItemIngresoEgreso";
            this.dgvItemIngresoEgreso.ReadOnly = true;
            this.dgvItemIngresoEgreso.Size = new System.Drawing.Size(1041, 531);
            this.dgvItemIngresoEgreso.TabIndex = 16;
            this.dgvItemIngresoEgreso.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemIngresoEgreso_CellContentDoubleClick);
            this.dgvItemIngresoEgreso.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItemIngresoEgreso_CellMouseDoubleClick);
            this.dgvItemIngresoEgreso.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvItemIngresoEgreso_RowPostPaint);
            // 
            // iNGRESOEGRESOIDDataGridViewTextBoxColumn
            // 
            this.iNGRESOEGRESOIDDataGridViewTextBoxColumn.DataPropertyName = "INGRESO_EGRESO_ID";
            this.iNGRESOEGRESOIDDataGridViewTextBoxColumn.HeaderText = "INGRESO_EGRESO_ID";
            this.iNGRESOEGRESOIDDataGridViewTextBoxColumn.Name = "iNGRESOEGRESOIDDataGridViewTextBoxColumn";
            this.iNGRESOEGRESOIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNGRESOEGRESOIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fECHADataGridViewTextBoxColumn
            // 
            this.fECHADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
            this.fECHADataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fECHADataGridViewTextBoxColumn.MaxInputLength = 50;
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
            this.fECHADataGridViewTextBoxColumn.ReadOnly = true;
            this.fECHADataGridViewTextBoxColumn.Width = 62;
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
            this.sOCIONEGOCIODataGridViewTextBoxColumn.HeaderText = "Cliente/Prop./Admin.";
            this.sOCIONEGOCIODataGridViewTextBoxColumn.Name = "sOCIONEGOCIODataGridViewTextBoxColumn";
            this.sOCIONEGOCIODataGridViewTextBoxColumn.ReadOnly = true;
            this.sOCIONEGOCIODataGridViewTextBoxColumn.Width = 139;
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
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn.DataPropertyName = "ENTIDAD_INMOBILIARIA";
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn.HeaderText = "Edif./Loteamiento";
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn.Name = "eNTIDADINMOBILIARIADataGridViewTextBoxColumn";
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn.ReadOnly = true;
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn.Width = 123;
            // 
            // pROPIEDADDataGridViewTextBoxColumn
            // 
            this.pROPIEDADDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pROPIEDADDataGridViewTextBoxColumn.DataPropertyName = "PROPIEDAD";
            this.pROPIEDADDataGridViewTextBoxColumn.HeaderText = "Dpto./Casa/Dup.";
            this.pROPIEDADDataGridViewTextBoxColumn.Name = "pROPIEDADDataGridViewTextBoxColumn";
            this.pROPIEDADDataGridViewTextBoxColumn.ReadOnly = true;
            this.pROPIEDADDataGridViewTextBoxColumn.Width = 118;
            // 
            // iTEMDataGridViewTextBoxColumn
            // 
            this.iTEMDataGridViewTextBoxColumn.DataPropertyName = "ITEM";
            this.iTEMDataGridViewTextBoxColumn.HeaderText = "Concepto";
            this.iTEMDataGridViewTextBoxColumn.Name = "iTEMDataGridViewTextBoxColumn";
            this.iTEMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nUMEROFACTURADataGridViewTextBoxColumn
            // 
            this.nUMEROFACTURADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nUMEROFACTURADataGridViewTextBoxColumn.DataPropertyName = "NUMERO_FACTURA";
            this.nUMEROFACTURADataGridViewTextBoxColumn.HeaderText = "Nro. factura";
            this.nUMEROFACTURADataGridViewTextBoxColumn.MaxInputLength = 75;
            this.nUMEROFACTURADataGridViewTextBoxColumn.Name = "nUMEROFACTURADataGridViewTextBoxColumn";
            this.nUMEROFACTURADataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMEROFACTURADataGridViewTextBoxColumn.Width = 75;
            // 
            // fECHAFACTURADataGridViewTextBoxColumn
            // 
            this.fECHAFACTURADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fECHAFACTURADataGridViewTextBoxColumn.DataPropertyName = "FECHA_FACTURA";
            this.fECHAFACTURADataGridViewTextBoxColumn.HeaderText = "Fec. factura";
            this.fECHAFACTURADataGridViewTextBoxColumn.MaxInputLength = 75;
            this.fECHAFACTURADataGridViewTextBoxColumn.Name = "fECHAFACTURADataGridViewTextBoxColumn";
            this.fECHAFACTURADataGridViewTextBoxColumn.ReadOnly = true;
            this.fECHAFACTURADataGridViewTextBoxColumn.Width = 75;
            // 
            // mONTODataGridViewTextBoxColumn
            // 
            this.mONTODataGridViewTextBoxColumn.DataPropertyName = "MONTO";
            this.mONTODataGridViewTextBoxColumn.HeaderText = "Monto";
            this.mONTODataGridViewTextBoxColumn.Name = "mONTODataGridViewTextBoxColumn";
            this.mONTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sALDODataGridViewTextBoxColumn
            // 
            this.sALDODataGridViewTextBoxColumn.DataPropertyName = "SALDO";
            this.sALDODataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.sALDODataGridViewTextBoxColumn.Name = "sALDODataGridViewTextBoxColumn";
            this.sALDODataGridViewTextBoxColumn.ReadOnly = true;
            this.sALDODataGridViewTextBoxColumn.Visible = false;
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "Estado";
            this.eSTADODataGridViewTextBoxColumn.MaxInputLength = 75;
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            this.eSTADODataGridViewTextBoxColumn.ReadOnly = true;
            this.eSTADODataGridViewTextBoxColumn.Width = 75;
            // 
            // tIPODataGridViewTextBoxColumn
            // 
            this.tIPODataGridViewTextBoxColumn.DataPropertyName = "TIPO";
            this.tIPODataGridViewTextBoxColumn.HeaderText = "TIPO";
            this.tIPODataGridViewTextBoxColumn.Name = "tIPODataGridViewTextBoxColumn";
            this.tIPODataGridViewTextBoxColumn.ReadOnly = true;
            this.tIPODataGridViewTextBoxColumn.Visible = false;
            // 
            // pROPIEDADIDDataGridViewTextBoxColumn
            // 
            this.pROPIEDADIDDataGridViewTextBoxColumn.DataPropertyName = "PROPIEDAD_ID";
            this.pROPIEDADIDDataGridViewTextBoxColumn.HeaderText = "PROPIEDAD_ID";
            this.pROPIEDADIDDataGridViewTextBoxColumn.Name = "pROPIEDADIDDataGridViewTextBoxColumn";
            this.pROPIEDADIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pROPIEDADIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // iTEMINGRESOEGRESOIDDataGridViewTextBoxColumn
            // 
            this.iTEMINGRESOEGRESOIDDataGridViewTextBoxColumn.DataPropertyName = "ITEM_INGRESO_EGRESO_ID";
            this.iTEMINGRESOEGRESOIDDataGridViewTextBoxColumn.HeaderText = "ITEM_INGRESO_EGRESO_ID";
            this.iTEMINGRESOEGRESOIDDataGridViewTextBoxColumn.Name = "iTEMINGRESOEGRESOIDDataGridViewTextBoxColumn";
            this.iTEMINGRESOEGRESOIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iTEMINGRESOEGRESOIDDataGridViewTextBoxColumn.Visible = false;
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
            // iNGRESOSEGRESOSVIEWBindingSource
            // 
            this.iNGRESOSEGRESOSVIEWBindingSource.DataSource = typeof(Inmobiliaria.Modelo.INGRESOS_EGRESOS_VIEW);
            // 
            // FrmBusquedaIngresosEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1278, 674);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBusquedaIngresosEgresos";
            this.Load += new System.EventHandler(this.FrmBusquedaIngresosEgresos_Load);
            this.Shown += new System.EventHandler(this.FrmBusquedaIngresosEgresos_Shown);
            this.pnlDatos.ResumeLayout(false);
            this.pnlFiltrosBusqueda.ResumeLayout(false);
            this.pnlFiltrosBusqueda.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemIngresoEgreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNGRESOSEGRESOSVIEWBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoImputacion;
        protected System.Windows.Forms.Button btnBuscar;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblItemIngresoEgreso;
        private System.Windows.Forms.Label lblEntidadPropiedadSocionegocio;
        private System.Windows.Forms.TextBox txtEntidadPropiedad;
        private System.Windows.Forms.ComboBox cbTipoItem;
        private System.Windows.Forms.Button btnBuscadorEntidadPropiedad;
        private System.Windows.Forms.DataGridView dgvItemIngresoEgreso;
        private System.Windows.Forms.BindingSource iNGRESOSEGRESOSVIEWBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNGRESOEGRESOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOCIONEGOCIOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOCIONEGOCIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTIDADINMOBILIARIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROPIEDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEROFACTURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAFACTURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mONTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROPIEDADIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMINGRESOEGRESOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOCREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHACREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOMODIFICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAMODIFICACIONDataGridViewTextBoxColumn;
    }
}
