namespace Inmobiliaria.Presentacion.EntidadesInmobiliarias.Buscadores
{
    partial class FrmBusquedaLiquidaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbUnidadInmobiliaria = new System.Windows.Forms.ComboBox();
            this.txtPropiedad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbBuscarCliente = new System.Windows.Forms.PictureBox();
            this.txtSocioNegocio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLiquidacion = new System.Windows.Forms.DataGridView();
            this.lIQUIDACIONIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMERODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERACIONPROPIEDADIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROPIEDADIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROPIEDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lIQUIDACIONESVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatos.SuspendLayout();
            this.pnlFiltrosBusqueda.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiquidacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIQUIDACIONESVIEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Size = new System.Drawing.Size(1198, 46);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.dgvLiquidacion);
            this.pnlDatos.Size = new System.Drawing.Size(1198, 503);
            this.pnlDatos.Controls.SetChildIndex(this.pnlFiltrosBusqueda, 0);
            this.pnlDatos.Controls.SetChildIndex(this.dgvLiquidacion, 0);
            // 
            // pnlFiltrosBusqueda
            // 
            this.pnlFiltrosBusqueda.Controls.Add(this.label1);
            this.pnlFiltrosBusqueda.Controls.Add(this.cbUnidadInmobiliaria);
            this.pnlFiltrosBusqueda.Controls.Add(this.txtPropiedad);
            this.pnlFiltrosBusqueda.Controls.Add(this.label4);
            this.pnlFiltrosBusqueda.Controls.Add(this.btnBuscar);
            this.pnlFiltrosBusqueda.Controls.Add(this.btnCancelar);
            this.pnlFiltrosBusqueda.Controls.Add(this.pbBuscarCliente);
            this.pnlFiltrosBusqueda.Controls.Add(this.txtSocioNegocio);
            this.pnlFiltrosBusqueda.Controls.Add(this.label3);
            this.pnlFiltrosBusqueda.Size = new System.Drawing.Size(326, 501);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1198, 43);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(1126, 43);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Edificio/Loteamiento/Salones";
            // 
            // cbUnidadInmobiliaria
            // 
            this.cbUnidadInmobiliaria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbUnidadInmobiliaria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbUnidadInmobiliaria.DisplayMember = "NOMBRE";
            this.cbUnidadInmobiliaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidadInmobiliaria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnidadInmobiliaria.FormattingEnabled = true;
            this.cbUnidadInmobiliaria.Location = new System.Drawing.Point(22, 118);
            this.cbUnidadInmobiliaria.Name = "cbUnidadInmobiliaria";
            this.cbUnidadInmobiliaria.Size = new System.Drawing.Size(257, 23);
            this.cbUnidadInmobiliaria.TabIndex = 65;
            this.cbUnidadInmobiliaria.ValueMember = "ENTIDAD_INMOBILIARIA_ID";
            // 
            // txtPropiedad
            // 
            this.txtPropiedad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPropiedad.Location = new System.Drawing.Point(22, 173);
            this.txtPropiedad.MaxLength = 20;
            this.txtPropiedad.Name = "txtPropiedad";
            this.txtPropiedad.Size = new System.Drawing.Size(233, 22);
            this.txtPropiedad.TabIndex = 66;
            this.txtPropiedad.TextChanged += new System.EventHandler(this.txtPropiedad_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Dpto/Lote/Dúplex";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(62, 230);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 35);
            this.btnBuscar.TabIndex = 67;
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
            this.btnCancelar.Location = new System.Drawing.Point(161, 230);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 35);
            this.btnCancelar.TabIndex = 68;
            this.btnCancelar.Text = "Limpiar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbBuscarCliente
            // 
            this.pbBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBuscarCliente.ErrorImage = null;
            this.pbBuscarCliente.Image = global::Inmobiliaria.Properties.Resources.if_Search_984754;
            this.pbBuscarCliente.Location = new System.Drawing.Point(261, 61);
            this.pbBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBuscarCliente.Name = "pbBuscarCliente";
            this.pbBuscarCliente.Size = new System.Drawing.Size(28, 26);
            this.pbBuscarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarCliente.TabIndex = 70;
            this.pbBuscarCliente.TabStop = false;
            this.pbBuscarCliente.Click += new System.EventHandler(this.pbBuscarCliente_Click);
            // 
            // txtSocioNegocio
            // 
            this.txtSocioNegocio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSocioNegocio.Enabled = false;
            this.txtSocioNegocio.Location = new System.Drawing.Point(22, 64);
            this.txtSocioNegocio.MaxLength = 20;
            this.txtSocioNegocio.Name = "txtSocioNegocio";
            this.txtSocioNegocio.Size = new System.Drawing.Size(233, 22);
            this.txtSocioNegocio.TabIndex = 64;
            this.txtSocioNegocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSocioNegocio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Cliente";
            // 
            // dgvLiquidacion
            // 
            this.dgvLiquidacion.AllowUserToAddRows = false;
            this.dgvLiquidacion.AllowUserToDeleteRows = false;
            this.dgvLiquidacion.AllowUserToOrderColumns = true;
            this.dgvLiquidacion.AutoGenerateColumns = false;
            this.dgvLiquidacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLiquidacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lIQUIDACIONIDDataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn,
            this.nUMERODataGridViewTextBoxColumn,
            this.oPERACIONPROPIEDADIDDataGridViewTextBoxColumn,
            this.cLIENTEDataGridViewTextBoxColumn,
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn,
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn,
            this.pROPIEDADIDDataGridViewTextBoxColumn,
            this.pROPIEDADDataGridViewTextBoxColumn});
            this.dgvLiquidacion.DataSource = this.lIQUIDACIONESVIEWBindingSource;
            this.dgvLiquidacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLiquidacion.Location = new System.Drawing.Point(326, 0);
            this.dgvLiquidacion.Name = "dgvLiquidacion";
            this.dgvLiquidacion.Size = new System.Drawing.Size(870, 501);
            this.dgvLiquidacion.TabIndex = 14;
            this.dgvLiquidacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLiquidacion_CellContentClick);
            this.dgvLiquidacion.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvLiquidacion_RowPostPaint);
            this.dgvLiquidacion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvLiquidacion_MouseClick);
            // 
            // lIQUIDACIONIDDataGridViewTextBoxColumn
            // 
            this.lIQUIDACIONIDDataGridViewTextBoxColumn.DataPropertyName = "LIQUIDACION_ID";
            this.lIQUIDACIONIDDataGridViewTextBoxColumn.HeaderText = "LIQUIDACION_ID";
            this.lIQUIDACIONIDDataGridViewTextBoxColumn.Name = "lIQUIDACIONIDDataGridViewTextBoxColumn";
            this.lIQUIDACIONIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fECHADataGridViewTextBoxColumn
            // 
            this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
            this.fECHADataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
            // 
            // nUMERODataGridViewTextBoxColumn
            // 
            this.nUMERODataGridViewTextBoxColumn.DataPropertyName = "NUMERO";
            this.nUMERODataGridViewTextBoxColumn.HeaderText = "Número";
            this.nUMERODataGridViewTextBoxColumn.Name = "nUMERODataGridViewTextBoxColumn";
            // 
            // oPERACIONPROPIEDADIDDataGridViewTextBoxColumn
            // 
            this.oPERACIONPROPIEDADIDDataGridViewTextBoxColumn.DataPropertyName = "OPERACION_PROPIEDAD_ID";
            this.oPERACIONPROPIEDADIDDataGridViewTextBoxColumn.HeaderText = "OPERACION_PROPIEDAD_ID";
            this.oPERACIONPROPIEDADIDDataGridViewTextBoxColumn.Name = "oPERACIONPROPIEDADIDDataGridViewTextBoxColumn";
            this.oPERACIONPROPIEDADIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIENTEDataGridViewTextBoxColumn
            // 
            this.cLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE";
            this.cLIENTEDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.cLIENTEDataGridViewTextBoxColumn.Name = "cLIENTEDataGridViewTextBoxColumn";
            // 
            // eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn
            // 
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn.DataPropertyName = "ENTIDAD_INMOBILIARIA_ID";
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn.HeaderText = "ENTIDAD_INMOBILIARIA_ID";
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn.Name = "eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn";
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // eNTIDADINMOBILIARIADataGridViewTextBoxColumn
            // 
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn.DataPropertyName = "ENTIDAD_INMOBILIARIA";
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn.HeaderText = "Edificio/Loteamiento";
            this.eNTIDADINMOBILIARIADataGridViewTextBoxColumn.Name = "eNTIDADINMOBILIARIADataGridViewTextBoxColumn";
            // 
            // pROPIEDADIDDataGridViewTextBoxColumn
            // 
            this.pROPIEDADIDDataGridViewTextBoxColumn.DataPropertyName = "PROPIEDAD_ID";
            this.pROPIEDADIDDataGridViewTextBoxColumn.HeaderText = "PROPIEDAD_ID";
            this.pROPIEDADIDDataGridViewTextBoxColumn.Name = "pROPIEDADIDDataGridViewTextBoxColumn";
            this.pROPIEDADIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pROPIEDADDataGridViewTextBoxColumn
            // 
            this.pROPIEDADDataGridViewTextBoxColumn.DataPropertyName = "PROPIEDAD";
            this.pROPIEDADDataGridViewTextBoxColumn.HeaderText = "Depto/Lote";
            this.pROPIEDADDataGridViewTextBoxColumn.Name = "pROPIEDADDataGridViewTextBoxColumn";
            // 
            // lIQUIDACIONESVIEWBindingSource
            // 
            this.lIQUIDACIONESVIEWBindingSource.DataSource = typeof(Inmobiliaria.Modelo.LIQUIDACIONES_VIEW);
            // 
            // FrmBusquedaLiquidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 648);
            this.Name = "FrmBusquedaLiquidaciones";
            this.Load += new System.EventHandler(this.FrmBusquedaLiquidaciones_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlFiltrosBusqueda.ResumeLayout(false);
            this.pnlFiltrosBusqueda.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiquidacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIQUIDACIONESVIEWBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUnidadInmobiliaria;
        private System.Windows.Forms.TextBox txtPropiedad;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Button btnBuscar;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbBuscarCliente;
        private System.Windows.Forms.TextBox txtSocioNegocio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLiquidacion;
        private System.Windows.Forms.BindingSource lIQUIDACIONESVIEWBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn lIQUIDACIONIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMERODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERACIONPROPIEDADIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTIDADINMOBILIARIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROPIEDADIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROPIEDADDataGridViewTextBoxColumn;
    }
}