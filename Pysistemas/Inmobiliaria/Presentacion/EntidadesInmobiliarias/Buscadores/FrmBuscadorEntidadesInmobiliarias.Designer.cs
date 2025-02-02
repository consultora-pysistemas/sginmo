namespace Inmobiliaria.Presentacion.EntidadesInmobiliarias.Buscadores
{
    partial class FrmBuscadorEntidadesInmobiliarias
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvSociosNegocios = new System.Windows.Forms.DataGridView();
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADUNIDADESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNOCONSTRUCCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2CONSTRUCCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDIDASLOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARACTERISTICASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.nUMEROFINCADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUENTACATASTRALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTIDADESINMOBILIARIASVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSociosNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNTIDADESINMOBILIARIASVIEWBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(822, 43);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(750, 43);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 498);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(822, 74);
            this.panel3.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(304, 20);
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
            this.btnCancelar.Location = new System.Drawing.Point(414, 20);
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
            this.panel4.Location = new System.Drawing.Point(0, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(819, 484);
            this.panel4.TabIndex = 12;
            // 
            // dgvSociosNegocios
            // 
            this.dgvSociosNegocios.AllowUserToAddRows = false;
            this.dgvSociosNegocios.AllowUserToDeleteRows = false;
            this.dgvSociosNegocios.AllowUserToOrderColumns = true;
            this.dgvSociosNegocios.AutoGenerateColumns = false;
            this.dgvSociosNegocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSociosNegocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.tIPODataGridViewTextBoxColumn,
            this.cANTIDADUNIDADESDataGridViewTextBoxColumn,
            this.dIRECCIONDataGridViewTextBoxColumn,
            this.aNOCONSTRUCCIONDataGridViewTextBoxColumn,
            this.m2CONSTRUCCIONDataGridViewTextBoxColumn,
            this.mEDIDASLOTEDataGridViewTextBoxColumn,
            this.cARACTERISTICASDataGridViewTextBoxColumn,
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
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn,
            this.nUMEROFINCADataGridViewTextBoxColumn,
            this.cUENTACATASTRALDataGridViewTextBoxColumn});
            this.dgvSociosNegocios.DataSource = this.eNTIDADESINMOBILIARIASVIEWBindingSource;
            this.dgvSociosNegocios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSociosNegocios.Location = new System.Drawing.Point(0, 0);
            this.dgvSociosNegocios.Name = "dgvSociosNegocios";
            this.dgvSociosNegocios.ReadOnly = true;
            this.dgvSociosNegocios.Size = new System.Drawing.Size(819, 484);
            this.dgvSociosNegocios.TabIndex = 0;
            this.dgvSociosNegocios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSociosNegocios_CellContentDoubleClick);
            this.dgvSociosNegocios.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSociosNegocios_CellMouseDoubleClick);
            this.dgvSociosNegocios.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvSociosNegocios_CellValueNeeded);
            this.dgvSociosNegocios.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvSociosNegocios_RowPostPaint);
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
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "Edificio/Loteamiento";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            this.nOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIPODataGridViewTextBoxColumn
            // 
            this.tIPODataGridViewTextBoxColumn.DataPropertyName = "TIPO";
            this.tIPODataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tIPODataGridViewTextBoxColumn.Name = "tIPODataGridViewTextBoxColumn";
            this.tIPODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cANTIDADUNIDADESDataGridViewTextBoxColumn
            // 
            this.cANTIDADUNIDADESDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD_UNIDADES";
            this.cANTIDADUNIDADESDataGridViewTextBoxColumn.HeaderText = "Nro.  unidades";
            this.cANTIDADUNIDADESDataGridViewTextBoxColumn.Name = "cANTIDADUNIDADESDataGridViewTextBoxColumn";
            this.cANTIDADUNIDADESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIRECCIONDataGridViewTextBoxColumn
            // 
            this.dIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.dIRECCIONDataGridViewTextBoxColumn.Name = "dIRECCIONDataGridViewTextBoxColumn";
            this.dIRECCIONDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.cARACTERISTICASDataGridViewTextBoxColumn.DataPropertyName = "CARACTERISTICAS";
            this.cARACTERISTICASDataGridViewTextBoxColumn.HeaderText = "CARACTERISTICAS";
            this.cARACTERISTICASDataGridViewTextBoxColumn.Name = "cARACTERISTICASDataGridViewTextBoxColumn";
            this.cARACTERISTICASDataGridViewTextBoxColumn.ReadOnly = true;
            this.cARACTERISTICASDataGridViewTextBoxColumn.Visible = false;
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
            // nUMEROFINCADataGridViewTextBoxColumn
            // 
            this.nUMEROFINCADataGridViewTextBoxColumn.DataPropertyName = "NUMERO_FINCA";
            this.nUMEROFINCADataGridViewTextBoxColumn.HeaderText = "NUMERO_FINCA";
            this.nUMEROFINCADataGridViewTextBoxColumn.Name = "nUMEROFINCADataGridViewTextBoxColumn";
            this.nUMEROFINCADataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMEROFINCADataGridViewTextBoxColumn.Visible = false;
            // 
            // cUENTACATASTRALDataGridViewTextBoxColumn
            // 
            this.cUENTACATASTRALDataGridViewTextBoxColumn.DataPropertyName = "CUENTA_CATASTRAL";
            this.cUENTACATASTRALDataGridViewTextBoxColumn.HeaderText = "CUENTA_CATASTRAL";
            this.cUENTACATASTRALDataGridViewTextBoxColumn.Name = "cUENTACATASTRALDataGridViewTextBoxColumn";
            this.cUENTACATASTRALDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUENTACATASTRALDataGridViewTextBoxColumn.Visible = false;
            // 
            // eNTIDADESINMOBILIARIASVIEWBindingSource
            // 
            this.eNTIDADESINMOBILIARIASVIEWBindingSource.DataSource = typeof(Inmobiliaria.Modelo.ENTIDADES_INMOBILIARIAS_VIEW);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtBusqueda);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 36);
            this.panel2.TabIndex = 13;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtBusqueda.Location = new System.Drawing.Point(0, 0);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(822, 24);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            this.txtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyDown);
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // FrmBuscadorEntidadesInmobiliarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(822, 572);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "FrmBuscadorEntidadesInmobiliarias";
            this.Load += new System.EventHandler(this.FrmBuscadorEntidadesInmobiliarias_Load);
            this.Shown += new System.EventHandler(this.FrmBuscadorEntidadesInmobiliarias_Shown);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSociosNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNTIDADESINMOBILIARIASVIEWBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Button btnGuardar;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvSociosNegocios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.BindingSource eNTIDADESINMOBILIARIASVIEWBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADUNIDADESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNOCONSTRUCCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2CONSTRUCCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDIDASLOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARACTERISTICASDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEROFINCADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUENTACATASTRALDataGridViewTextBoxColumn;
    }
}
