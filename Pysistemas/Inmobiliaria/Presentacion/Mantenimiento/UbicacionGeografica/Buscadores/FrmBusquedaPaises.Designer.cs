namespace Inmobiliaria.Presentacion.Mantenimiento.UbicacionGeografica.Buscadores
{
    partial class FrmBusquedaPaises
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
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPaises = new System.Windows.Forms.DataGridView();
            this.pAISIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODIGOISO2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODIGOISO3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nACIONALIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOCREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHACREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAISESVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatos.SuspendLayout();
            this.pnlFiltrosBusqueda.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAISESVIEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Size = new System.Drawing.Size(800, 46);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.dgvPaises);
            this.pnlDatos.Size = new System.Drawing.Size(800, 439);
            this.pnlDatos.Controls.SetChildIndex(this.pnlFiltrosBusqueda, 0);
            this.pnlDatos.Controls.SetChildIndex(this.dgvPaises, 0);
            // 
            // pnlFiltrosBusqueda
            // 
            this.pnlFiltrosBusqueda.Controls.Add(this.btnBuscar);
            this.pnlFiltrosBusqueda.Controls.Add(this.btnCancelar);
            this.pnlFiltrosBusqueda.Controls.Add(this.txtPais);
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
            // txtPais
            // 
            this.txtPais.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPais.Location = new System.Drawing.Point(12, 116);
            this.txtPais.MaxLength = 20;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(233, 22);
            this.txtPais.TabIndex = 52;
            this.txtPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPais_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Pais";
            // 
            // dgvPaises
            // 
            this.dgvPaises.AllowUserToAddRows = false;
            this.dgvPaises.AllowUserToDeleteRows = false;
            this.dgvPaises.AllowUserToOrderColumns = true;
            this.dgvPaises.AutoGenerateColumns = false;
            this.dgvPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pAISIDDataGridViewTextBoxColumn,
            this.cODIGOISO2DataGridViewTextBoxColumn,
            this.pAISDataGridViewTextBoxColumn,
            this.cODIGOISO3DataGridViewTextBoxColumn,
            this.nACIONALIDADDataGridViewTextBoxColumn,
            this.uSUARIOCREACIONDataGridViewTextBoxColumn,
            this.fECHACREACIONDataGridViewTextBoxColumn,
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn,
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn});
            this.dgvPaises.DataSource = this.pAISESVIEWBindingSource;
            this.dgvPaises.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaises.Location = new System.Drawing.Point(260, 0);
            this.dgvPaises.Name = "dgvPaises";
            this.dgvPaises.ReadOnly = true;
            this.dgvPaises.Size = new System.Drawing.Size(538, 437);
            this.dgvPaises.TabIndex = 14;
            this.dgvPaises.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaises_CellContentClick);
            this.dgvPaises.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaises_CellContentDoubleClick);
            this.dgvPaises.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPaises_MouseClick);
            // 
            // pAISIDDataGridViewTextBoxColumn
            // 
            this.pAISIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pAISIDDataGridViewTextBoxColumn.DataPropertyName = "PAIS_ID";
            this.pAISIDDataGridViewTextBoxColumn.FillWeight = 50F;
            this.pAISIDDataGridViewTextBoxColumn.HeaderText = "Id";
            this.pAISIDDataGridViewTextBoxColumn.Name = "pAISIDDataGridViewTextBoxColumn";
            this.pAISIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pAISIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // cODIGOISO2DataGridViewTextBoxColumn
            // 
            this.cODIGOISO2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cODIGOISO2DataGridViewTextBoxColumn.DataPropertyName = "CODIGO_ISO_2";
            this.cODIGOISO2DataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.cODIGOISO2DataGridViewTextBoxColumn.Name = "cODIGOISO2DataGridViewTextBoxColumn";
            this.cODIGOISO2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pAISDataGridViewTextBoxColumn
            // 
            this.pAISDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pAISDataGridViewTextBoxColumn.DataPropertyName = "PAIS";
            this.pAISDataGridViewTextBoxColumn.FillWeight = 200F;
            this.pAISDataGridViewTextBoxColumn.HeaderText = "Pais";
            this.pAISDataGridViewTextBoxColumn.Name = "pAISDataGridViewTextBoxColumn";
            this.pAISDataGridViewTextBoxColumn.ReadOnly = true;
            this.pAISDataGridViewTextBoxColumn.Width = 200;
            // 
            // cODIGOISO3DataGridViewTextBoxColumn
            // 
            this.cODIGOISO3DataGridViewTextBoxColumn.DataPropertyName = "CODIGO_ISO_3";
            this.cODIGOISO3DataGridViewTextBoxColumn.HeaderText = "CODIGO_ISO_3";
            this.cODIGOISO3DataGridViewTextBoxColumn.Name = "cODIGOISO3DataGridViewTextBoxColumn";
            this.cODIGOISO3DataGridViewTextBoxColumn.ReadOnly = true;
            this.cODIGOISO3DataGridViewTextBoxColumn.Visible = false;
            // 
            // nACIONALIDADDataGridViewTextBoxColumn
            // 
            this.nACIONALIDADDataGridViewTextBoxColumn.DataPropertyName = "NACIONALIDAD";
            this.nACIONALIDADDataGridViewTextBoxColumn.HeaderText = "NACIONALIDAD";
            this.nACIONALIDADDataGridViewTextBoxColumn.Name = "nACIONALIDADDataGridViewTextBoxColumn";
            this.nACIONALIDADDataGridViewTextBoxColumn.ReadOnly = true;
            this.nACIONALIDADDataGridViewTextBoxColumn.Visible = false;
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
            // pAISESVIEWBindingSource
            // 
            this.pAISESVIEWBindingSource.DataSource = typeof(Inmobiliaria.Modelo.PAISES_VIEW);
            // 
            // FrmBusquedaPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Name = "FrmBusquedaPaises";
            this.Load += new System.EventHandler(this.FrmBusquedaPaises_Load);
            this.Shown += new System.EventHandler(this.FrmBusquedaPaises_Shown);
            this.pnlDatos.ResumeLayout(false);
            this.pnlFiltrosBusqueda.ResumeLayout(false);
            this.pnlFiltrosBusqueda.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAISESVIEWBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnBuscar;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPaises;
        private System.Windows.Forms.BindingSource pAISESVIEWBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAISIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGOISO2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGOISO3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nACIONALIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOCREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHACREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOMODIFICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAMODIFICACIONDataGridViewTextBoxColumn;
    }
}