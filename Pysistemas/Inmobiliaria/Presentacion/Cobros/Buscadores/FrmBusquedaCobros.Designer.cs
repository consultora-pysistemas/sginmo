namespace Inmobiliaria.Presentacion.Cobros.Buscadores
{
    partial class FrmBusquedaCobros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtSocioNegocio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCobros = new System.Windows.Forms.DataGridView();
            this.cOBROIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEROFACTURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOCIONEGOCIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rUCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMERODOCUMENTOCOBRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSERVACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOCREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHACREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOBROSVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.txtPropiedades = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbBusquedaPropiedad = new System.Windows.Forms.PictureBox();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDatos.SuspendLayout();
            this.pnlFiltrosBusqueda.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOBROSVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusquedaPropiedad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Size = new System.Drawing.Size(1347, 46);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.dgvCobros);
            this.pnlDatos.Size = new System.Drawing.Size(1347, 519);
            this.pnlDatos.Controls.SetChildIndex(this.pnlFiltrosBusqueda, 0);
            this.pnlDatos.Controls.SetChildIndex(this.dgvCobros, 0);
            // 
            // pnlFiltrosBusqueda
            // 
            this.pnlFiltrosBusqueda.Controls.Add(this.txtNumeroFactura);
            this.pnlFiltrosBusqueda.Controls.Add(this.label2);
            this.pnlFiltrosBusqueda.Controls.Add(this.pbBusquedaPropiedad);
            this.pnlFiltrosBusqueda.Controls.Add(this.txtPropiedades);
            this.pnlFiltrosBusqueda.Controls.Add(this.label1);
            this.pnlFiltrosBusqueda.Controls.Add(this.btnBuscar);
            this.pnlFiltrosBusqueda.Controls.Add(this.btnCancelar);
            this.pnlFiltrosBusqueda.Controls.Add(this.pbBuscar);
            this.pnlFiltrosBusqueda.Controls.Add(this.txtSocioNegocio);
            this.pnlFiltrosBusqueda.Controls.Add(this.label3);
            this.pnlFiltrosBusqueda.Size = new System.Drawing.Size(294, 517);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1347, 43);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(1275, 43);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(36, 217);
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
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(135, 217);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 35);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.Text = "Limpiar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtSocioNegocio
            // 
            this.txtSocioNegocio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSocioNegocio.Enabled = false;
            this.txtSocioNegocio.Location = new System.Drawing.Point(14, 120);
            this.txtSocioNegocio.MaxLength = 20;
            this.txtSocioNegocio.Name = "txtSocioNegocio";
            this.txtSocioNegocio.Size = new System.Drawing.Size(233, 22);
            this.txtSocioNegocio.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Clientes/Propietarios/Administradores";
            // 
            // dgvCobros
            // 
            this.dgvCobros.AllowUserToAddRows = false;
            this.dgvCobros.AllowUserToDeleteRows = false;
            this.dgvCobros.AllowUserToOrderColumns = true;
            this.dgvCobros.AutoGenerateColumns = false;
            this.dgvCobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCobros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cOBROIDDataGridViewTextBoxColumn,
            this.nUMEROFACTURADataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn,
            this.sOCIONEGOCIOIDDataGridViewTextBoxColumn,
            this.sOCIONEGOCIODataGridViewTextBoxColumn,
            this.rUCDataGridViewTextBoxColumn,
            this.nUMERODOCUMENTOCOBRODataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn,
            this.tOTALDataGridViewTextBoxColumn,
            this.oBSERVACIONDataGridViewTextBoxColumn,
            this.uSUARIOCREACIONDataGridViewTextBoxColumn,
            this.fECHACREACIONDataGridViewTextBoxColumn,
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn,
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn});
            this.dgvCobros.DataSource = this.cOBROSVIEWBindingSource;
            this.dgvCobros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCobros.Location = new System.Drawing.Point(294, 0);
            this.dgvCobros.Name = "dgvCobros";
            this.dgvCobros.ReadOnly = true;
            this.dgvCobros.Size = new System.Drawing.Size(1051, 517);
            this.dgvCobros.TabIndex = 14;
            this.dgvCobros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCobros_CellContentClick);
            this.dgvCobros.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCobros_RowPostPaint);
            this.dgvCobros.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvCobros_MouseClick);
            // 
            // cOBROIDDataGridViewTextBoxColumn
            // 
            this.cOBROIDDataGridViewTextBoxColumn.DataPropertyName = "COBRO_ID";
            this.cOBROIDDataGridViewTextBoxColumn.HeaderText = "COBRO_ID";
            this.cOBROIDDataGridViewTextBoxColumn.Name = "cOBROIDDataGridViewTextBoxColumn";
            this.cOBROIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOBROIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nUMEROFACTURADataGridViewTextBoxColumn
            // 
            this.nUMEROFACTURADataGridViewTextBoxColumn.DataPropertyName = "NUMERO_FACTURA";
            this.nUMEROFACTURADataGridViewTextBoxColumn.HeaderText = "Factura";
            this.nUMEROFACTURADataGridViewTextBoxColumn.Name = "nUMEROFACTURADataGridViewTextBoxColumn";
            this.nUMEROFACTURADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHADataGridViewTextBoxColumn
            // 
            this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
            this.fECHADataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
            this.fECHADataGridViewTextBoxColumn.ReadOnly = true;
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
            this.sOCIONEGOCIODataGridViewTextBoxColumn.DataPropertyName = "SOCIO_NEGOCIO";
            this.sOCIONEGOCIODataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.sOCIONEGOCIODataGridViewTextBoxColumn.Name = "sOCIONEGOCIODataGridViewTextBoxColumn";
            this.sOCIONEGOCIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rUCDataGridViewTextBoxColumn
            // 
            this.rUCDataGridViewTextBoxColumn.DataPropertyName = "RUC";
            this.rUCDataGridViewTextBoxColumn.HeaderText = "Ruc";
            this.rUCDataGridViewTextBoxColumn.Name = "rUCDataGridViewTextBoxColumn";
            this.rUCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nUMERODOCUMENTOCOBRODataGridViewTextBoxColumn
            // 
            this.nUMERODOCUMENTOCOBRODataGridViewTextBoxColumn.DataPropertyName = "NUMERO_DOCUMENTO_COBRO";
            this.nUMERODOCUMENTOCOBRODataGridViewTextBoxColumn.HeaderText = "NUMERO_DOCUMENTO_COBRO";
            this.nUMERODOCUMENTOCOBRODataGridViewTextBoxColumn.Name = "nUMERODOCUMENTOCOBRODataGridViewTextBoxColumn";
            this.nUMERODOCUMENTOCOBRODataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMERODOCUMENTOCOBRODataGridViewTextBoxColumn.Visible = false;
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "Estado";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            this.eSTADODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tOTALDataGridViewTextBoxColumn
            // 
            this.tOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.tOTALDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.tOTALDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.tOTALDataGridViewTextBoxColumn.Name = "tOTALDataGridViewTextBoxColumn";
            this.tOTALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oBSERVACIONDataGridViewTextBoxColumn
            // 
            this.oBSERVACIONDataGridViewTextBoxColumn.DataPropertyName = "OBSERVACION";
            this.oBSERVACIONDataGridViewTextBoxColumn.HeaderText = "OBSERVACION";
            this.oBSERVACIONDataGridViewTextBoxColumn.Name = "oBSERVACIONDataGridViewTextBoxColumn";
            this.oBSERVACIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.oBSERVACIONDataGridViewTextBoxColumn.Visible = false;
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
            // cOBROSVIEWBindingSource
            // 
            this.cOBROSVIEWBindingSource.DataSource = typeof(Inmobiliaria.Modelo.COBROS_VIEW);
            // 
            // pbBuscar
            // 
            this.pbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBuscar.ErrorImage = null;
            this.pbBuscar.Image = global::Inmobiliaria.Properties.Resources.if_Search_984754;
            this.pbBuscar.Location = new System.Drawing.Point(253, 118);
            this.pbBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(28, 26);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 49;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.Click += new System.EventHandler(this.pbBuscar_Click);
            // 
            // txtPropiedades
            // 
            this.txtPropiedades.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPropiedades.Enabled = false;
            this.txtPropiedades.Location = new System.Drawing.Point(10, 397);
            this.txtPropiedades.MaxLength = 20;
            this.txtPropiedades.Name = "txtPropiedades";
            this.txtPropiedades.Size = new System.Drawing.Size(233, 22);
            this.txtPropiedades.TabIndex = 52;
            this.txtPropiedades.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Dpto/Casa/Salón/Lote";
            this.label1.Visible = false;
            // 
            // pbBusquedaPropiedad
            // 
            this.pbBusquedaPropiedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBusquedaPropiedad.ErrorImage = null;
            this.pbBusquedaPropiedad.Image = global::Inmobiliaria.Properties.Resources.if_Search_984754;
            this.pbBusquedaPropiedad.Location = new System.Drawing.Point(249, 395);
            this.pbBusquedaPropiedad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBusquedaPropiedad.Name = "pbBusquedaPropiedad";
            this.pbBusquedaPropiedad.Size = new System.Drawing.Size(28, 26);
            this.pbBusquedaPropiedad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBusquedaPropiedad.TabIndex = 54;
            this.pbBusquedaPropiedad.TabStop = false;
            this.pbBusquedaPropiedad.Visible = false;
            this.pbBusquedaPropiedad.Click += new System.EventHandler(this.pbBusquedaPropiedad_Click);
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumeroFactura.Location = new System.Drawing.Point(14, 178);
            this.txtNumeroFactura.MaxLength = 20;
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(233, 22);
            this.txtNumeroFactura.TabIndex = 55;
            this.txtNumeroFactura.TextChanged += new System.EventHandler(this.txtNumeroFactura_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Número factura";
            // 
            // FrmBusquedaCobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 664);
            this.Name = "FrmBusquedaCobros";
            this.pnlDatos.ResumeLayout(false);
            this.pnlFiltrosBusqueda.ResumeLayout(false);
            this.pnlFiltrosBusqueda.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOBROSVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusquedaPropiedad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnBuscar;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.TextBox txtSocioNegocio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCobros;
        private System.Windows.Forms.PictureBox pbBusquedaPropiedad;
        private System.Windows.Forms.TextBox txtPropiedades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource cOBROSVIEWBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOBROIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEROFACTURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOCIONEGOCIOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOCIONEGOCIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMERODOCUMENTOCOBRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSERVACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOCREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHACREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOMODIFICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAMODIFICACIONDataGridViewTextBoxColumn;
    }
}