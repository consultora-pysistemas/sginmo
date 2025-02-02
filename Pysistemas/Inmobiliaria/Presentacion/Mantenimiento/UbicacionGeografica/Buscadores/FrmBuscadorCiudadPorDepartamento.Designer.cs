namespace Inmobiliaria.Presentacion.Mantenimiento.UbicacionGeografica.Buscadores
{
    partial class FrmBuscadorCiudadPorDepartamento
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
            this.dgvCiudadesDepartamentos = new System.Windows.Forms.DataGridView();
            this.cIUDADDEPARTAMENTOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTAMENTOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIUDADIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIUDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOCREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHACREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIUDADESDEPARTAMENTOSVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCiudadDepartamento = new System.Windows.Forms.TextBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudadesDepartamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADESDEPARTAMENTOSVIEWBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(734, 43);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(662, 43);
            this.lblTitulo.Text = "";
            // 
            // dgvCiudadesDepartamentos
            // 
            this.dgvCiudadesDepartamentos.AllowUserToAddRows = false;
            this.dgvCiudadesDepartamentos.AllowUserToDeleteRows = false;
            this.dgvCiudadesDepartamentos.AllowUserToOrderColumns = true;
            this.dgvCiudadesDepartamentos.AutoGenerateColumns = false;
            this.dgvCiudadesDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiudadesDepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIUDADDEPARTAMENTOIDDataGridViewTextBoxColumn,
            this.dEPARTAMENTOIDDataGridViewTextBoxColumn,
            this.cODIGODataGridViewTextBoxColumn,
            this.cIUDADIDDataGridViewTextBoxColumn,
            this.cIUDADDataGridViewTextBoxColumn,
            this.dEPARTAMENTODataGridViewTextBoxColumn,
            this.uSUARIOCREACIONDataGridViewTextBoxColumn,
            this.fECHACREACIONDataGridViewTextBoxColumn,
            this.uSUARIOMODIFICACIONDataGridViewTextBoxColumn,
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn});
            this.dgvCiudadesDepartamentos.DataSource = this.cIUDADESDEPARTAMENTOSVIEWBindingSource;
            this.dgvCiudadesDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCiudadesDepartamentos.Location = new System.Drawing.Point(0, 75);
            this.dgvCiudadesDepartamentos.Name = "dgvCiudadesDepartamentos";
            this.dgvCiudadesDepartamentos.ReadOnly = true;
            this.dgvCiudadesDepartamentos.Size = new System.Drawing.Size(734, 235);
            this.dgvCiudadesDepartamentos.TabIndex = 13;
            this.dgvCiudadesDepartamentos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCiudadesDepartamentos_CellContentDoubleClick);
            this.dgvCiudadesDepartamentos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvCiudadesDepartamentos_MouseClick);
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
            // cODIGODataGridViewTextBoxColumn
            // 
            this.cODIGODataGridViewTextBoxColumn.DataPropertyName = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.HeaderText = "Código";
            this.cODIGODataGridViewTextBoxColumn.Name = "cODIGODataGridViewTextBoxColumn";
            this.cODIGODataGridViewTextBoxColumn.ReadOnly = true;
            this.cODIGODataGridViewTextBoxColumn.Visible = false;
            // 
            // cIUDADIDDataGridViewTextBoxColumn
            // 
            this.cIUDADIDDataGridViewTextBoxColumn.DataPropertyName = "CIUDAD_ID";
            this.cIUDADIDDataGridViewTextBoxColumn.HeaderText = "Id";
            this.cIUDADIDDataGridViewTextBoxColumn.Name = "cIUDADIDDataGridViewTextBoxColumn";
            this.cIUDADIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cIUDADDataGridViewTextBoxColumn
            // 
            this.cIUDADDataGridViewTextBoxColumn.DataPropertyName = "CIUDAD";
            this.cIUDADDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.cIUDADDataGridViewTextBoxColumn.Name = "cIUDADDataGridViewTextBoxColumn";
            this.cIUDADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dEPARTAMENTODataGridViewTextBoxColumn
            // 
            this.dEPARTAMENTODataGridViewTextBoxColumn.DataPropertyName = "DEPARTAMENTO";
            this.dEPARTAMENTODataGridViewTextBoxColumn.HeaderText = "Departamento";
            this.dEPARTAMENTODataGridViewTextBoxColumn.Name = "dEPARTAMENTODataGridViewTextBoxColumn";
            this.dEPARTAMENTODataGridViewTextBoxColumn.ReadOnly = true;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 310);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(734, 74);
            this.panel3.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(260, 20);
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
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(370, 20);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 35);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.txtBusqueda);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 32);
            this.panel2.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtCiudadDepartamento);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(734, 32);
            this.panel4.TabIndex = 11;
            // 
            // txtCiudadDepartamento
            // 
            this.txtCiudadDepartamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCiudadDepartamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCiudadDepartamento.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtCiudadDepartamento.Location = new System.Drawing.Point(0, 0);
            this.txtCiudadDepartamento.Name = "txtCiudadDepartamento";
            this.txtCiudadDepartamento.Size = new System.Drawing.Size(734, 24);
            this.txtCiudadDepartamento.TabIndex = 0;
            this.txtCiudadDepartamento.TextChanged += new System.EventHandler(this.txtCiudadDepartamento_TextChanged);
            this.txtCiudadDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiudadDepartamento_KeyPress);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtBusqueda.Location = new System.Drawing.Point(0, 0);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(734, 24);
            this.txtBusqueda.TabIndex = 0;
            // 
            // FrmBuscadorCiudadPorDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 384);
            this.Controls.Add(this.dgvCiudadesDepartamentos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FrmBuscadorCiudadPorDepartamento";
            this.Shown += new System.EventHandler(this.FrmBuscadorBarrioPorCiudad_Shown);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.dgvCiudadesDepartamentos, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudadesDepartamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADESDEPARTAMENTOSVIEWBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCiudadesDepartamentos;
        private System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Button btnGuardar;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCiudadDepartamento;
        private System.Windows.Forms.BindingSource cIUDADESDEPARTAMENTOSVIEWBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIUDADDEPARTAMENTOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTAMENTOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIUDADIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIUDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOCREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHACREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOMODIFICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAMODIFICACIONDataGridViewTextBoxColumn;
    }
}