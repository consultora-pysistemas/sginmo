namespace Inmobiliaria.Presentacion.Mantenimiento.UbicacionGeografica.Buscadores
{
    partial class FrmBusquedaBarrios
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
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBarrios = new System.Windows.Forms.DataGridView();
            this.bARRIOCIUDADIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIUDADIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bARRIOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bARRIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIUDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOCREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHACREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bARRIOSCIUDADESVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatos.SuspendLayout();
            this.pnlFiltrosBusqueda.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarrios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bARRIOSCIUDADESVIEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Size = new System.Drawing.Size(800, 46);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.dgvBarrios);
            this.pnlDatos.Size = new System.Drawing.Size(800, 439);
            this.pnlDatos.Controls.SetChildIndex(this.pnlFiltrosBusqueda, 0);
            this.pnlDatos.Controls.SetChildIndex(this.dgvBarrios, 0);
            // 
            // pnlFiltrosBusqueda
            // 
            this.pnlFiltrosBusqueda.Controls.Add(this.btnBuscar);
            this.pnlFiltrosBusqueda.Controls.Add(this.btnCancelar);
            this.pnlFiltrosBusqueda.Controls.Add(this.txtBarrio);
            this.pnlFiltrosBusqueda.Controls.Add(this.label3);
            this.pnlFiltrosBusqueda.Size = new System.Drawing.Size(260, 437);
            this.pnlFiltrosBusqueda.TabIndex = 0;
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
            this.btnBuscar.TabIndex = 1;
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
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Limpiar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtBarrio
            // 
            this.txtBarrio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBarrio.Location = new System.Drawing.Point(15, 116);
            this.txtBarrio.MaxLength = 20;
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(233, 22);
            this.txtBarrio.TabIndex = 0;
            this.txtBarrio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarrio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Barrio";
            // 
            // dgvBarrios
            // 
            this.dgvBarrios.AllowUserToAddRows = false;
            this.dgvBarrios.AllowUserToDeleteRows = false;
            this.dgvBarrios.AllowUserToOrderColumns = true;
            this.dgvBarrios.AutoGenerateColumns = false;
            this.dgvBarrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarrios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bARRIOCIUDADIDDataGridViewTextBoxColumn,
            this.cIUDADIDDataGridViewTextBoxColumn,
            this.bARRIOIDDataGridViewTextBoxColumn,
            this.cODIGODataGridViewTextBoxColumn,
            this.bARRIODataGridViewTextBoxColumn,
            this.cIUDADDataGridViewTextBoxColumn,
            this.uSUARIOCREACIONDataGridViewTextBoxColumn,
            this.fECHACREACIONDataGridViewTextBoxColumn,
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn,
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn});
            this.dgvBarrios.DataSource = this.bARRIOSCIUDADESVIEWBindingSource;
            this.dgvBarrios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBarrios.Location = new System.Drawing.Point(260, 0);
            this.dgvBarrios.Name = "dgvBarrios";
            this.dgvBarrios.ReadOnly = true;
            this.dgvBarrios.Size = new System.Drawing.Size(538, 437);
            this.dgvBarrios.TabIndex = 14;
            this.dgvBarrios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarrios_CellContentClick);
            this.dgvBarrios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarrios_CellContentDoubleClick);
            this.dgvBarrios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvBarrios_MouseClick);
            // 
            // bARRIOCIUDADIDDataGridViewTextBoxColumn
            // 
            this.bARRIOCIUDADIDDataGridViewTextBoxColumn.DataPropertyName = "BARRIO_CIUDAD_ID";
            this.bARRIOCIUDADIDDataGridViewTextBoxColumn.HeaderText = "BARRIO_CIUDAD_ID";
            this.bARRIOCIUDADIDDataGridViewTextBoxColumn.Name = "bARRIOCIUDADIDDataGridViewTextBoxColumn";
            this.bARRIOCIUDADIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bARRIOCIUDADIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cIUDADIDDataGridViewTextBoxColumn
            // 
            this.cIUDADIDDataGridViewTextBoxColumn.DataPropertyName = "CIUDAD_ID";
            this.cIUDADIDDataGridViewTextBoxColumn.HeaderText = "CIUDAD_ID";
            this.cIUDADIDDataGridViewTextBoxColumn.Name = "cIUDADIDDataGridViewTextBoxColumn";
            this.cIUDADIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIUDADIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bARRIOIDDataGridViewTextBoxColumn
            // 
            this.bARRIOIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.bARRIOIDDataGridViewTextBoxColumn.DataPropertyName = "BARRIO_ID";
            this.bARRIOIDDataGridViewTextBoxColumn.FillWeight = 50F;
            this.bARRIOIDDataGridViewTextBoxColumn.HeaderText = "Id";
            this.bARRIOIDDataGridViewTextBoxColumn.Name = "bARRIOIDDataGridViewTextBoxColumn";
            this.bARRIOIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bARRIOIDDataGridViewTextBoxColumn.Width = 50;
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
            // bARRIODataGridViewTextBoxColumn
            // 
            this.bARRIODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.bARRIODataGridViewTextBoxColumn.DataPropertyName = "BARRIO";
            this.bARRIODataGridViewTextBoxColumn.FillWeight = 150F;
            this.bARRIODataGridViewTextBoxColumn.HeaderText = "Barrio";
            this.bARRIODataGridViewTextBoxColumn.Name = "bARRIODataGridViewTextBoxColumn";
            this.bARRIODataGridViewTextBoxColumn.ReadOnly = true;
            this.bARRIODataGridViewTextBoxColumn.Width = 150;
            // 
            // cIUDADDataGridViewTextBoxColumn
            // 
            this.cIUDADDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cIUDADDataGridViewTextBoxColumn.DataPropertyName = "CIUDAD";
            this.cIUDADDataGridViewTextBoxColumn.FillWeight = 150F;
            this.cIUDADDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.cIUDADDataGridViewTextBoxColumn.Name = "cIUDADDataGridViewTextBoxColumn";
            this.cIUDADDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIUDADDataGridViewTextBoxColumn.Width = 150;
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
            // bARRIOSCIUDADESVIEWBindingSource
            // 
            this.bARRIOSCIUDADESVIEWBindingSource.DataSource = typeof(Inmobiliaria.Modelo.BARRIOS_CIUDADES_VIEW);
            // 
            // FrmBusquedaBarrios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Name = "FrmBusquedaBarrios";
            this.Load += new System.EventHandler(this.FrmBusquedaBarrios_Load);
            this.Shown += new System.EventHandler(this.FrmBusquedaBarrios_Shown);
            this.pnlDatos.ResumeLayout(false);
            this.pnlFiltrosBusqueda.ResumeLayout(false);
            this.pnlFiltrosBusqueda.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarrios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bARRIOSCIUDADESVIEWBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnBuscar;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBarrios;
        private System.Windows.Forms.BindingSource bARRIOSCIUDADESVIEWBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn bARRIOCIUDADIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIUDADIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bARRIOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bARRIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIUDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOCREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHACREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOMODIFICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAMODIFICACIONDataGridViewTextBoxColumn;
    }
}