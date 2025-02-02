namespace Inmobiliaria.Presentacion.EntidadesInmobiliarias.Buscadores
{
    partial class FrmBusquedaEntidadesInmobiliarias
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
            this.dgvEntidadesInmobiliarias = new System.Windows.Forms.DataGridView();
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADUNIDADESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNOCONSTRUCCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2CONSTRUCCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDIDASLOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARACTERISTICASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAISIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTAMENTOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIUDADIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIUDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bARRIOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bARRIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOCREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHACREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTIDADESINMOBILIARIASVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCuentaCatastral = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroFinca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDatos.SuspendLayout();
            this.pnlFiltrosBusqueda.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidadesInmobiliarias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNTIDADESINMOBILIARIASVIEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Size = new System.Drawing.Size(1255, 46);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.dgvEntidadesInmobiliarias);
            this.pnlDatos.Size = new System.Drawing.Size(1255, 455);
            this.pnlDatos.Controls.SetChildIndex(this.pnlFiltrosBusqueda, 0);
            this.pnlDatos.Controls.SetChildIndex(this.dgvEntidadesInmobiliarias, 0);
            // 
            // pnlFiltrosBusqueda
            // 
            this.pnlFiltrosBusqueda.Controls.Add(this.txtNumeroFinca);
            this.pnlFiltrosBusqueda.Controls.Add(this.label2);
            this.pnlFiltrosBusqueda.Controls.Add(this.txtCuentaCatastral);
            this.pnlFiltrosBusqueda.Controls.Add(this.label1);
            this.pnlFiltrosBusqueda.Controls.Add(this.btnBuscar);
            this.pnlFiltrosBusqueda.Controls.Add(this.btnCancelar);
            this.pnlFiltrosBusqueda.Controls.Add(this.txtEntidad);
            this.pnlFiltrosBusqueda.Controls.Add(this.label3);
            this.pnlFiltrosBusqueda.Size = new System.Drawing.Size(309, 453);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1255, 43);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(1183, 43);
            // 
            // dgvEntidadesInmobiliarias
            // 
            this.dgvEntidadesInmobiliarias.AllowUserToAddRows = false;
            this.dgvEntidadesInmobiliarias.AllowUserToDeleteRows = false;
            this.dgvEntidadesInmobiliarias.AllowUserToOrderColumns = true;
            this.dgvEntidadesInmobiliarias.AutoGenerateColumns = false;
            this.dgvEntidadesInmobiliarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntidadesInmobiliarias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.tIPODataGridViewTextBoxColumn,
            this.cANTIDADUNIDADESDataGridViewTextBoxColumn,
            this.aNOCONSTRUCCIONDataGridViewTextBoxColumn,
            this.m2CONSTRUCCIONDataGridViewTextBoxColumn,
            this.mEDIDASLOTEDataGridViewTextBoxColumn,
            this.cARACTERISTICASDataGridViewTextBoxColumn,
            this.dIRECCIONDataGridViewTextBoxColumn,
            this.pAISIDDataGridViewTextBoxColumn,
            this.pAISDataGridViewTextBoxColumn,
            this.dEPARTAMENTOIDDataGridViewTextBoxColumn,
            this.dEPARTAMENTODataGridViewTextBoxColumn,
            this.cIUDADIDDataGridViewTextBoxColumn,
            this.cIUDADDataGridViewTextBoxColumn,
            this.bARRIOIDDataGridViewTextBoxColumn,
            this.bARRIODataGridViewTextBoxColumn,
            this.uSUARIOCREACIONDataGridViewTextBoxColumn,
            this.fECHACREACIONDataGridViewTextBoxColumn,
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn,
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn});
            this.dgvEntidadesInmobiliarias.DataSource = this.eNTIDADESINMOBILIARIASVIEWBindingSource;
            this.dgvEntidadesInmobiliarias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEntidadesInmobiliarias.Location = new System.Drawing.Point(309, 0);
            this.dgvEntidadesInmobiliarias.Name = "dgvEntidadesInmobiliarias";
            this.dgvEntidadesInmobiliarias.ReadOnly = true;
            this.dgvEntidadesInmobiliarias.Size = new System.Drawing.Size(944, 453);
            this.dgvEntidadesInmobiliarias.TabIndex = 14;
            this.dgvEntidadesInmobiliarias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntidadesInmobiliarias_CellContentClick);
            this.dgvEntidadesInmobiliarias.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvEntidadesInmobiliarias_RowPostPaint);
            this.dgvEntidadesInmobiliarias.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvEntidadesInmobiliarias_MouseClick);
            // 
            // eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn
            // 
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn.DataPropertyName = "ENTIDAD_INMOBILIARIA_ID";
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn.HeaderText = "ENTIDAD_INMOBILIARIA_ID";
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn.Name = "eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn";
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "Edificio/Loteamiento";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            this.nOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIPODataGridViewTextBoxColumn
            // 
            this.tIPODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tIPODataGridViewTextBoxColumn.DataPropertyName = "TIPO";
            this.tIPODataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tIPODataGridViewTextBoxColumn.Name = "tIPODataGridViewTextBoxColumn";
            this.tIPODataGridViewTextBoxColumn.ReadOnly = true;
            this.tIPODataGridViewTextBoxColumn.Width = 50;
            // 
            // cANTIDADUNIDADESDataGridViewTextBoxColumn
            // 
            this.cANTIDADUNIDADESDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD_UNIDADES";
            this.cANTIDADUNIDADESDataGridViewTextBoxColumn.HeaderText = "CANTIDAD_UNIDADES";
            this.cANTIDADUNIDADESDataGridViewTextBoxColumn.Name = "cANTIDADUNIDADESDataGridViewTextBoxColumn";
            this.cANTIDADUNIDADESDataGridViewTextBoxColumn.ReadOnly = true;
            this.cANTIDADUNIDADESDataGridViewTextBoxColumn.Visible = false;
            // 
            // aNOCONSTRUCCIONDataGridViewTextBoxColumn
            // 
            this.aNOCONSTRUCCIONDataGridViewTextBoxColumn.DataPropertyName = "ANO_CONSTRUCCION";
            this.aNOCONSTRUCCIONDataGridViewTextBoxColumn.HeaderText = "ANO_CONSTRUCCION";
            this.aNOCONSTRUCCIONDataGridViewTextBoxColumn.Name = "aNOCONSTRUCCIONDataGridViewTextBoxColumn";
            this.aNOCONSTRUCCIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.aNOCONSTRUCCIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // m2CONSTRUCCIONDataGridViewTextBoxColumn
            // 
            this.m2CONSTRUCCIONDataGridViewTextBoxColumn.DataPropertyName = "M2_CONSTRUCCION";
            this.m2CONSTRUCCIONDataGridViewTextBoxColumn.HeaderText = "M2_CONSTRUCCION";
            this.m2CONSTRUCCIONDataGridViewTextBoxColumn.Name = "m2CONSTRUCCIONDataGridViewTextBoxColumn";
            this.m2CONSTRUCCIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.m2CONSTRUCCIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // mEDIDASLOTEDataGridViewTextBoxColumn
            // 
            this.mEDIDASLOTEDataGridViewTextBoxColumn.DataPropertyName = "MEDIDAS_LOTE";
            this.mEDIDASLOTEDataGridViewTextBoxColumn.HeaderText = "MEDIDAS_LOTE";
            this.mEDIDASLOTEDataGridViewTextBoxColumn.Name = "mEDIDASLOTEDataGridViewTextBoxColumn";
            this.mEDIDASLOTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.mEDIDASLOTEDataGridViewTextBoxColumn.Visible = false;
            // 
            // cARACTERISTICASDataGridViewTextBoxColumn
            // 
            this.cARACTERISTICASDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cARACTERISTICASDataGridViewTextBoxColumn.DataPropertyName = "CARACTERISTICAS";
            this.cARACTERISTICASDataGridViewTextBoxColumn.HeaderText = "Caracteristicas";
            this.cARACTERISTICASDataGridViewTextBoxColumn.Name = "cARACTERISTICASDataGridViewTextBoxColumn";
            this.cARACTERISTICASDataGridViewTextBoxColumn.ReadOnly = true;
            this.cARACTERISTICASDataGridViewTextBoxColumn.Width = 300;
            // 
            // dIRECCIONDataGridViewTextBoxColumn
            // 
            this.dIRECCIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.dIRECCIONDataGridViewTextBoxColumn.Name = "dIRECCIONDataGridViewTextBoxColumn";
            this.dIRECCIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.dIRECCIONDataGridViewTextBoxColumn.Width = 300;
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
            // eNTIDADESINMOBILIARIASVIEWBindingSource
            // 
            this.eNTIDADESINMOBILIARIASVIEWBindingSource.DataSource = typeof(Inmobiliaria.Modelo.ENTIDADES_INMOBILIARIAS_VIEW);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(31, 208);
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
            this.btnCancelar.Location = new System.Drawing.Point(130, 208);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 35);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.Text = "Limpiar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtEntidad
            // 
            this.txtEntidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEntidad.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntidad.Location = new System.Drawing.Point(10, 59);
            this.txtEntidad.MaxLength = 20;
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(233, 22);
            this.txtEntidad.TabIndex = 47;
            this.txtEntidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntidad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Edificio/Loteamiento";
            // 
            // txtCuentaCatastral
            // 
            this.txtCuentaCatastral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCuentaCatastral.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaCatastral.Location = new System.Drawing.Point(10, 109);
            this.txtCuentaCatastral.MaxLength = 20;
            this.txtCuentaCatastral.Name = "txtCuentaCatastral";
            this.txtCuentaCatastral.Size = new System.Drawing.Size(233, 22);
            this.txtCuentaCatastral.TabIndex = 52;
            this.txtCuentaCatastral.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuentaCatastral_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nro Cta Catastral";
            // 
            // txtNumeroFinca
            // 
            this.txtNumeroFinca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumeroFinca.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroFinca.Location = new System.Drawing.Point(10, 164);
            this.txtNumeroFinca.MaxLength = 20;
            this.txtNumeroFinca.Name = "txtNumeroFinca";
            this.txtNumeroFinca.Size = new System.Drawing.Size(233, 22);
            this.txtNumeroFinca.TabIndex = 54;
            this.txtNumeroFinca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroFinca_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Nro finca";
            // 
            // FrmBusquedaEntidadesInmobiliarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 600);
            this.Name = "FrmBusquedaEntidadesInmobiliarias";
            this.Shown += new System.EventHandler(this.FrmBusquedaEntidadesInmobiliarias_Shown);
            this.pnlDatos.ResumeLayout(false);
            this.pnlFiltrosBusqueda.ResumeLayout(false);
            this.pnlFiltrosBusqueda.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidadesInmobiliarias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNTIDADESINMOBILIARIASVIEWBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEntidadesInmobiliarias;
        private System.Windows.Forms.BindingSource eNTIDADESINMOBILIARIASVIEWBindingSource;
        protected System.Windows.Forms.Button btnBuscar;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCuentaCatastral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroFinca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADUNIDADESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNOCONSTRUCCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2CONSTRUCCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDIDASLOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARACTERISTICASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAISIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTAMENTOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIUDADIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIUDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bARRIOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bARRIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOCREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHACREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOMODIFICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAMODIFICACIONDataGridViewTextBoxColumn;
    }
}