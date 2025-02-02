namespace Inmobiliaria.Presentacion.Mantenimiento.UbicacionGeografica.Buscadores
{
    partial class FrmBusquedaCiudades
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCiudades = new System.Windows.Forms.DataGridView();
            this.cIUDADDEPARTAMENTOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTAMENTOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIUDADIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIUDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOCREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHACREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIUDADESDEPARTAMENTOSVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatos.SuspendLayout();
            this.pnlFiltrosBusqueda.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADESDEPARTAMENTOSVIEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Size = new System.Drawing.Size(800, 46);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.dgvCiudades);
            this.pnlDatos.Size = new System.Drawing.Size(800, 439);
            this.pnlDatos.Controls.SetChildIndex(this.pnlFiltrosBusqueda, 0);
            this.pnlDatos.Controls.SetChildIndex(this.dgvCiudades, 0);
            // 
            // pnlFiltrosBusqueda
            // 
            this.pnlFiltrosBusqueda.Controls.Add(this.btnBuscar);
            this.pnlFiltrosBusqueda.Controls.Add(this.btnCancelar);
            this.pnlFiltrosBusqueda.Controls.Add(this.txtCiudad);
            this.pnlFiltrosBusqueda.Controls.Add(this.label3);
            this.pnlFiltrosBusqueda.Size = new System.Drawing.Size(260, 437);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(800, 43);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(728, 43);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(20, 166);
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
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(119, 166);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 35);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "Limpiar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCiudad
            // 
            this.txtCiudad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCiudad.Location = new System.Drawing.Point(13, 116);
            this.txtCiudad.MaxLength = 20;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(233, 22);
            this.txtCiudad.TabIndex = 52;
            this.txtCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiudad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Ciudad";
            // 
            // dgvCiudades
            // 
            this.dgvCiudades.AllowUserToAddRows = false;
            this.dgvCiudades.AllowUserToDeleteRows = false;
            this.dgvCiudades.AllowUserToOrderColumns = true;
            this.dgvCiudades.AutoGenerateColumns = false;
            this.dgvCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIUDADDEPARTAMENTOIDDataGridViewTextBoxColumn,
            this.dEPARTAMENTOIDDataGridViewTextBoxColumn,
            this.cIUDADIDDataGridViewTextBoxColumn,
            this.cODIGODataGridViewTextBoxColumn,
            this.cIUDADDataGridViewTextBoxColumn,
            this.dEPARTAMENTODataGridViewTextBoxColumn,
            this.uSUARIOCREACIONDataGridViewTextBoxColumn,
            this.fECHACREACIONDataGridViewTextBoxColumn,
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn,
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn});
            this.dgvCiudades.DataSource = this.cIUDADESDEPARTAMENTOSVIEWBindingSource;
            this.dgvCiudades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCiudades.Location = new System.Drawing.Point(260, 0);
            this.dgvCiudades.Name = "dgvCiudades";
            this.dgvCiudades.ReadOnly = true;
            this.dgvCiudades.Size = new System.Drawing.Size(538, 437);
            this.dgvCiudades.TabIndex = 14;
            this.dgvCiudades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCiudades_CellContentClick);
            this.dgvCiudades.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCiudades_CellContentDoubleClick);
            this.dgvCiudades.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvCiudades_MouseClick);
            // 
            // cIUDADDEPARTAMENTOIDDataGridViewTextBoxColumn
            // 
            this.cIUDADDEPARTAMENTOIDDataGridViewTextBoxColumn.DataPropertyName = "CIUDAD_DEPARTAMENTO_ID";
            this.cIUDADDEPARTAMENTOIDDataGridViewTextBoxColumn.HeaderText = "CIUDAD_DEPARTAMENTO_ID";
            this.cIUDADDEPARTAMENTOIDDataGridViewTextBoxColumn.Name = "cIUDADDEPARTAMENTOIDDataGridViewTextBoxColumn";
            this.cIUDADDEPARTAMENTOIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIUDADDEPARTAMENTOIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dEPARTAMENTOIDDataGridViewTextBoxColumn
            // 
            this.dEPARTAMENTOIDDataGridViewTextBoxColumn.DataPropertyName = "DEPARTAMENTO_ID";
            this.dEPARTAMENTOIDDataGridViewTextBoxColumn.HeaderText = "DEPARTAMENTO_ID";
            this.dEPARTAMENTOIDDataGridViewTextBoxColumn.Name = "dEPARTAMENTOIDDataGridViewTextBoxColumn";
            this.dEPARTAMENTOIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dEPARTAMENTOIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cIUDADIDDataGridViewTextBoxColumn
            // 
            this.cIUDADIDDataGridViewTextBoxColumn.DataPropertyName = "CIUDAD_ID";
            this.cIUDADIDDataGridViewTextBoxColumn.HeaderText = "CIUDAD_ID";
            this.cIUDADIDDataGridViewTextBoxColumn.Name = "cIUDADIDDataGridViewTextBoxColumn";
            this.cIUDADIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIUDADIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODIGODataGridViewTextBoxColumn
            // 
            this.cODIGODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cODIGODataGridViewTextBoxColumn.DataPropertyName = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.FillWeight = 50F;
            this.cODIGODataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.cODIGODataGridViewTextBoxColumn.Name = "cODIGODataGridViewTextBoxColumn";
            this.cODIGODataGridViewTextBoxColumn.ReadOnly = true;
            this.cODIGODataGridViewTextBoxColumn.Width = 50;
            // 
            // cIUDADDataGridViewTextBoxColumn
            // 
            this.cIUDADDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cIUDADDataGridViewTextBoxColumn.DataPropertyName = "CIUDAD";
            this.cIUDADDataGridViewTextBoxColumn.FillWeight = 200F;
            this.cIUDADDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.cIUDADDataGridViewTextBoxColumn.Name = "cIUDADDataGridViewTextBoxColumn";
            this.cIUDADDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIUDADDataGridViewTextBoxColumn.Width = 200;
            // 
            // dEPARTAMENTODataGridViewTextBoxColumn
            // 
            this.dEPARTAMENTODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dEPARTAMENTODataGridViewTextBoxColumn.DataPropertyName = "DEPARTAMENTO";
            this.dEPARTAMENTODataGridViewTextBoxColumn.FillWeight = 200F;
            this.dEPARTAMENTODataGridViewTextBoxColumn.HeaderText = "Departamento";
            this.dEPARTAMENTODataGridViewTextBoxColumn.Name = "dEPARTAMENTODataGridViewTextBoxColumn";
            this.dEPARTAMENTODataGridViewTextBoxColumn.ReadOnly = true;
            this.dEPARTAMENTODataGridViewTextBoxColumn.Width = 200;
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
            // cIUDADESDEPARTAMENTOSVIEWBindingSource
            // 
            this.cIUDADESDEPARTAMENTOSVIEWBindingSource.DataSource = typeof(Inmobiliaria.Modelo.CIUDADES_DEPARTAMENTOS_VIEW);
            // 
            // FrmBusquedaCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Name = "FrmBusquedaCiudades";
            this.Load += new System.EventHandler(this.FrmBusquedaCiudades_Load);
            this.Shown += new System.EventHandler(this.FrmBusquedaCiudades_Shown);
            this.pnlDatos.ResumeLayout(false);
            this.pnlFiltrosBusqueda.ResumeLayout(false);
            this.pnlFiltrosBusqueda.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADESDEPARTAMENTOSVIEWBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnBuscar;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCiudades;
        private System.Windows.Forms.BindingSource cIUDADESDEPARTAMENTOSVIEWBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIUDADDEPARTAMENTOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTAMENTOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIUDADIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIUDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOCREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHACREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOMODIFICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAMODIFICACIONDataGridViewTextBoxColumn;
    }
}