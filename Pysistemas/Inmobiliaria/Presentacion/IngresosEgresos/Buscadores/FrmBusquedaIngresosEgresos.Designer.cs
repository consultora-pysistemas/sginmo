namespace Inmobiliaria.Presentacion.IngresosEgresos.Buscadores
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
            this.dgvIngresosEgresos = new System.Windows.Forms.DataGridView();
            this.iNGRESOEGRESOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOCIONEGOCIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROPIEDADIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMINGRESOEGRESOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEROFACTURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAFACTURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOCREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHACREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNGRESOSEGRESOSVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtSocioNegocio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.pnlDatos.SuspendLayout();
            this.pnlFiltrosBusqueda.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresosEgresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNGRESOSEGRESOSVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Size = new System.Drawing.Size(925, 46);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.dgvIngresosEgresos);
            this.pnlDatos.Size = new System.Drawing.Size(925, 305);
            this.pnlDatos.Controls.SetChildIndex(this.pnlFiltrosBusqueda, 0);
            this.pnlDatos.Controls.SetChildIndex(this.dgvIngresosEgresos, 0);
            // 
            // pnlFiltrosBusqueda
            // 
            this.pnlFiltrosBusqueda.Controls.Add(this.btnBuscar);
            this.pnlFiltrosBusqueda.Controls.Add(this.btnCancelar);
            this.pnlFiltrosBusqueda.Controls.Add(this.pbBuscar);
            this.pnlFiltrosBusqueda.Controls.Add(this.txtSocioNegocio);
            this.pnlFiltrosBusqueda.Controls.Add(this.label3);
            this.pnlFiltrosBusqueda.Size = new System.Drawing.Size(303, 303);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(925, 43);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(853, 43);
            // 
            // dgvIngresosEgresos
            // 
            this.dgvIngresosEgresos.AllowUserToAddRows = false;
            this.dgvIngresosEgresos.AllowUserToDeleteRows = false;
            this.dgvIngresosEgresos.AllowUserToOrderColumns = true;
            this.dgvIngresosEgresos.AutoGenerateColumns = false;
            this.dgvIngresosEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresosEgresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNGRESOEGRESOIDDataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn,
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn,
            this.sOCIONEGOCIODataGridViewTextBoxColumn,
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn,
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn,
            this.tIPODataGridViewTextBoxColumn,
            this.pROPIEDADIDDataGridViewTextBoxColumn,
            this.iTEMINGRESOEGRESOIDDataGridViewTextBoxColumn,
            this.iTEMDataGridViewTextBoxColumn,
            this.mONTODataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn,
            this.nUMEROFACTURADataGridViewTextBoxColumn,
            this.fECHAFACTURADataGridViewTextBoxColumn,
            this.sALDODataGridViewTextBoxColumn,
            this.uSUARIOCREACIONDataGridViewTextBoxColumn,
            this.fECHACREACIONDataGridViewTextBoxColumn,
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn,
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn});
            this.dgvIngresosEgresos.DataSource = this.iNGRESOSEGRESOSVIEWBindingSource;
            this.dgvIngresosEgresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIngresosEgresos.Location = new System.Drawing.Point(303, 0);
            this.dgvIngresosEgresos.Name = "dgvIngresosEgresos";
            this.dgvIngresosEgresos.ReadOnly = true;
            this.dgvIngresosEgresos.Size = new System.Drawing.Size(620, 303);
            this.dgvIngresosEgresos.TabIndex = 14;
            this.dgvIngresosEgresos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngresosEgresos_CellContentClick);
            this.dgvIngresosEgresos.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvIngresosEgresos_RowPostPaint);
            this.dgvIngresosEgresos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvIngresosEgresos_MouseClick);
            // 
            // iNGRESOEGRESOIDDataGridViewTextBoxColumn
            // 
            this.iNGRESOEGRESOIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iNGRESOEGRESOIDDataGridViewTextBoxColumn.DataPropertyName = "INGRESO_EGRESO_ID";
            this.iNGRESOEGRESOIDDataGridViewTextBoxColumn.HeaderText = "Id";
            this.iNGRESOEGRESOIDDataGridViewTextBoxColumn.Name = "iNGRESOEGRESOIDDataGridViewTextBoxColumn";
            this.iNGRESOEGRESOIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNGRESOEGRESOIDDataGridViewTextBoxColumn.Width = 40;
            // 
            // fECHADataGridViewTextBoxColumn
            // 
            this.fECHADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
            this.fECHADataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
            this.fECHADataGridViewTextBoxColumn.ReadOnly = true;
            this.fECHADataGridViewTextBoxColumn.Width = 80;
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
            this.sOCIONEGOCIODataGridViewTextBoxColumn.Width = 150;
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
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn.DataPropertyName = "ENTIDAD_INMOBILIARIA";
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn.HeaderText = "Entidad Inmobiliaria";
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn.Name = "eNTIDADINMOBILIARIADataGridViewTextBoxColumn";
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn.ReadOnly = true;
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn.Width = 150;
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
            // iTEMDataGridViewTextBoxColumn
            // 
            this.iTEMDataGridViewTextBoxColumn.DataPropertyName = "ITEM";
            this.iTEMDataGridViewTextBoxColumn.HeaderText = "ITEM";
            this.iTEMDataGridViewTextBoxColumn.Name = "iTEMDataGridViewTextBoxColumn";
            this.iTEMDataGridViewTextBoxColumn.ReadOnly = true;
            this.iTEMDataGridViewTextBoxColumn.Visible = false;
            // 
            // mONTODataGridViewTextBoxColumn
            // 
            this.mONTODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.mONTODataGridViewTextBoxColumn.DataPropertyName = "MONTO";
            this.mONTODataGridViewTextBoxColumn.HeaderText = "Monto";
            this.mONTODataGridViewTextBoxColumn.Name = "mONTODataGridViewTextBoxColumn";
            this.mONTODataGridViewTextBoxColumn.ReadOnly = true;
            this.mONTODataGridViewTextBoxColumn.Width = 80;
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "Estado";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            this.eSTADODataGridViewTextBoxColumn.ReadOnly = true;
            this.eSTADODataGridViewTextBoxColumn.Width = 60;
            // 
            // nUMEROFACTURADataGridViewTextBoxColumn
            // 
            this.nUMEROFACTURADataGridViewTextBoxColumn.DataPropertyName = "NUMERO_FACTURA";
            this.nUMEROFACTURADataGridViewTextBoxColumn.HeaderText = "NUMERO_FACTURA";
            this.nUMEROFACTURADataGridViewTextBoxColumn.Name = "nUMEROFACTURADataGridViewTextBoxColumn";
            this.nUMEROFACTURADataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMEROFACTURADataGridViewTextBoxColumn.Visible = false;
            // 
            // fECHAFACTURADataGridViewTextBoxColumn
            // 
            this.fECHAFACTURADataGridViewTextBoxColumn.DataPropertyName = "FECHA_FACTURA";
            this.fECHAFACTURADataGridViewTextBoxColumn.HeaderText = "FECHA_FACTURA";
            this.fECHAFACTURADataGridViewTextBoxColumn.Name = "fECHAFACTURADataGridViewTextBoxColumn";
            this.fECHAFACTURADataGridViewTextBoxColumn.ReadOnly = true;
            this.fECHAFACTURADataGridViewTextBoxColumn.Visible = false;
            // 
            // sALDODataGridViewTextBoxColumn
            // 
            this.sALDODataGridViewTextBoxColumn.DataPropertyName = "SALDO";
            this.sALDODataGridViewTextBoxColumn.HeaderText = "SALDO";
            this.sALDODataGridViewTextBoxColumn.Name = "sALDODataGridViewTextBoxColumn";
            this.sALDODataGridViewTextBoxColumn.ReadOnly = true;
            this.sALDODataGridViewTextBoxColumn.Visible = false;
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
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(41, 166);
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
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(140, 166);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 35);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "Limpiar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtSocioNegocio
            // 
            this.txtSocioNegocio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSocioNegocio.Enabled = false;
            this.txtSocioNegocio.Location = new System.Drawing.Point(18, 116);
            this.txtSocioNegocio.MaxLength = 20;
            this.txtSocioNegocio.Name = "txtSocioNegocio";
            this.txtSocioNegocio.Size = new System.Drawing.Size(233, 22);
            this.txtSocioNegocio.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Cliente";
            // 
            // pbBuscar
            // 
            this.pbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBuscar.ErrorImage = null;
            this.pbBuscar.Image = global::Inmobiliaria.Properties.Resources.if_Search_984754;
            this.pbBuscar.Location = new System.Drawing.Point(257, 113);
            this.pbBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(28, 26);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 54;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.Click += new System.EventHandler(this.pbBuscar_Click);
            // 
            // FrmBusquedaIngresosEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Name = "FrmBusquedaIngresosEgresos";
            this.pnlDatos.ResumeLayout(false);
            this.pnlFiltrosBusqueda.ResumeLayout(false);
            this.pnlFiltrosBusqueda.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresosEgresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNGRESOSEGRESOSVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIngresosEgresos;
        private System.Windows.Forms.BindingSource iNGRESOSEGRESOSVIEWBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNGRESOEGRESOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOCIONEGOCIOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOCIONEGOCIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTIDADINMOBILIARIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROPIEDADIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROPIETARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMINGRESOEGRESOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mONTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEROFACTURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAFACTURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOCREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHACREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOMODIFICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAMODIFICACIONDataGridViewTextBoxColumn;
        protected System.Windows.Forms.Button btnBuscar;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.TextBox txtSocioNegocio;
        private System.Windows.Forms.Label label3;
    }
}