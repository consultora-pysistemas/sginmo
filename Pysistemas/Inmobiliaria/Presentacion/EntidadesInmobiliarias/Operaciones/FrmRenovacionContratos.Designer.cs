namespace Inmobiliaria.Presentacion.EntidadesInmobiliarias.Operaciones
{
    partial class FrmRenovacionContratos
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFinalizarContrato = new System.Windows.Forms.Button();
            this.btnRenovarContrato = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvContratosVencidos = new System.Windows.Forms.DataGridView();
            this.oPERACIONESCONTRATOSVENCIDOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oPERACIONPROPIEDADIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAOPERACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAINICIOCONTRATODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAFINCONTRATODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDADNEGOCIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNMUEBLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAZONSOCIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROPIEDADIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCATARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratosVencidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERACIONESCONTRATOSVENCIDOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(943, 43);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(871, 43);
            this.lblTitulo.Text = "Renovación de contratos";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFinalizarContrato);
            this.panel2.Controls.Add(this.btnRenovarContrato);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 62);
            this.panel2.TabIndex = 10;
            // 
            // btnFinalizarContrato
            // 
            this.btnFinalizarContrato.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFinalizarContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.btnFinalizarContrato.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarContrato.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarContrato.Location = new System.Drawing.Point(201, 18);
            this.btnFinalizarContrato.Name = "btnFinalizarContrato";
            this.btnFinalizarContrato.Size = new System.Drawing.Size(112, 35);
            this.btnFinalizarContrato.TabIndex = 67;
            this.btnFinalizarContrato.Text = "Finalizar contrato";
            this.btnFinalizarContrato.UseVisualStyleBackColor = false;
            this.btnFinalizarContrato.Click += new System.EventHandler(this.btnFinalizarContrato_Click);
            // 
            // btnRenovarContrato
            // 
            this.btnRenovarContrato.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRenovarContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.btnRenovarContrato.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenovarContrato.ForeColor = System.Drawing.Color.White;
            this.btnRenovarContrato.Location = new System.Drawing.Point(83, 18);
            this.btnRenovarContrato.Name = "btnRenovarContrato";
            this.btnRenovarContrato.Size = new System.Drawing.Size(112, 35);
            this.btnRenovarContrato.TabIndex = 66;
            this.btnRenovarContrato.Text = "Renovar contrato";
            this.btnRenovarContrato.UseVisualStyleBackColor = false;
            this.btnRenovarContrato.Click += new System.EventHandler(this.btnRenovarContrato_Click);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.dgvContratosVencidos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 105);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(943, 423);
            this.panel4.TabIndex = 14;
            // 
            // dgvContratosVencidos
            // 
            this.dgvContratosVencidos.AllowUserToAddRows = false;
            this.dgvContratosVencidos.AllowUserToDeleteRows = false;
            this.dgvContratosVencidos.AutoGenerateColumns = false;
            this.dgvContratosVencidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContratosVencidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oPERACIONPROPIEDADIDDataGridViewTextBoxColumn,
            this.fECHAOPERACIONDataGridViewTextBoxColumn,
            this.fECHAINICIOCONTRATODataGridViewTextBoxColumn,
            this.fECHAFINCONTRATODataGridViewTextBoxColumn,
            this.uNIDADNEGOCIODataGridViewTextBoxColumn,
            this.iNMUEBLEDataGridViewTextBoxColumn,
            this.rAZONSOCIALDataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn,
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn,
            this.pROPIEDADIDDataGridViewTextBoxColumn,
            this.lOCATARIODataGridViewTextBoxColumn});
            this.dgvContratosVencidos.DataSource = this.oPERACIONESCONTRATOSVENCIDOSBindingSource;
            this.dgvContratosVencidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContratosVencidos.Location = new System.Drawing.Point(0, 0);
            this.dgvContratosVencidos.Name = "dgvContratosVencidos";
            this.dgvContratosVencidos.ReadOnly = true;
            this.dgvContratosVencidos.Size = new System.Drawing.Size(943, 423);
            this.dgvContratosVencidos.TabIndex = 0;
            // 
            // oPERACIONESCONTRATOSVENCIDOSBindingSource
            // 
            this.oPERACIONESCONTRATOSVENCIDOSBindingSource.DataSource = typeof(Inmobiliaria.Modelo.OPERACIONES_CONTRATOS_VENCIDOS);
            // 
            // oPERACIONPROPIEDADIDDataGridViewTextBoxColumn
            // 
            this.oPERACIONPROPIEDADIDDataGridViewTextBoxColumn.DataPropertyName = "OPERACION_PROPIEDAD_ID";
            this.oPERACIONPROPIEDADIDDataGridViewTextBoxColumn.HeaderText = "OPERACION_PROPIEDAD_ID";
            this.oPERACIONPROPIEDADIDDataGridViewTextBoxColumn.Name = "oPERACIONPROPIEDADIDDataGridViewTextBoxColumn";
            this.oPERACIONPROPIEDADIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oPERACIONPROPIEDADIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fECHAOPERACIONDataGridViewTextBoxColumn
            // 
            this.fECHAOPERACIONDataGridViewTextBoxColumn.DataPropertyName = "FECHA_OPERACION";
            this.fECHAOPERACIONDataGridViewTextBoxColumn.HeaderText = "Fec. op.";
            this.fECHAOPERACIONDataGridViewTextBoxColumn.Name = "fECHAOPERACIONDataGridViewTextBoxColumn";
            this.fECHAOPERACIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHAINICIOCONTRATODataGridViewTextBoxColumn
            // 
            this.fECHAINICIOCONTRATODataGridViewTextBoxColumn.DataPropertyName = "FECHA_INICIO_CONTRATO";
            this.fECHAINICIOCONTRATODataGridViewTextBoxColumn.HeaderText = "Inicio contrato";
            this.fECHAINICIOCONTRATODataGridViewTextBoxColumn.Name = "fECHAINICIOCONTRATODataGridViewTextBoxColumn";
            this.fECHAINICIOCONTRATODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHAFINCONTRATODataGridViewTextBoxColumn
            // 
            this.fECHAFINCONTRATODataGridViewTextBoxColumn.DataPropertyName = "FECHA_FIN_CONTRATO";
            this.fECHAFINCONTRATODataGridViewTextBoxColumn.HeaderText = "Fin contrato";
            this.fECHAFINCONTRATODataGridViewTextBoxColumn.Name = "fECHAFINCONTRATODataGridViewTextBoxColumn";
            this.fECHAFINCONTRATODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uNIDADNEGOCIODataGridViewTextBoxColumn
            // 
            this.uNIDADNEGOCIODataGridViewTextBoxColumn.DataPropertyName = "UNIDAD_NEGOCIO";
            this.uNIDADNEGOCIODataGridViewTextBoxColumn.HeaderText = "Unidad neg.";
            this.uNIDADNEGOCIODataGridViewTextBoxColumn.Name = "uNIDADNEGOCIODataGridViewTextBoxColumn";
            this.uNIDADNEGOCIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNMUEBLEDataGridViewTextBoxColumn
            // 
            this.iNMUEBLEDataGridViewTextBoxColumn.DataPropertyName = "INMUEBLE";
            this.iNMUEBLEDataGridViewTextBoxColumn.HeaderText = "Inmueble";
            this.iNMUEBLEDataGridViewTextBoxColumn.Name = "iNMUEBLEDataGridViewTextBoxColumn";
            this.iNMUEBLEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAZONSOCIALDataGridViewTextBoxColumn
            // 
            this.rAZONSOCIALDataGridViewTextBoxColumn.DataPropertyName = "RAZON_SOCIAL";
            this.rAZONSOCIALDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.rAZONSOCIALDataGridViewTextBoxColumn.Name = "rAZONSOCIALDataGridViewTextBoxColumn";
            this.rAZONSOCIALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "Estado";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            this.eSTADODataGridViewTextBoxColumn.ReadOnly = true;
            this.eSTADODataGridViewTextBoxColumn.Visible = false;
            // 
            // eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn
            // 
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn.DataPropertyName = "ENTIDAD_INMOBILIARIA_ID";
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn.HeaderText = "ENTIDAD_INMOBILIARIA_ID";
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn.Name = "eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn";
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pROPIEDADIDDataGridViewTextBoxColumn
            // 
            this.pROPIEDADIDDataGridViewTextBoxColumn.DataPropertyName = "PROPIEDAD_ID";
            this.pROPIEDADIDDataGridViewTextBoxColumn.HeaderText = "PROPIEDAD_ID";
            this.pROPIEDADIDDataGridViewTextBoxColumn.Name = "pROPIEDADIDDataGridViewTextBoxColumn";
            this.pROPIEDADIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pROPIEDADIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // lOCATARIODataGridViewTextBoxColumn
            // 
            this.lOCATARIODataGridViewTextBoxColumn.DataPropertyName = "LOCATARIO";
            this.lOCATARIODataGridViewTextBoxColumn.HeaderText = "LOCATARIO";
            this.lOCATARIODataGridViewTextBoxColumn.Name = "lOCATARIODataGridViewTextBoxColumn";
            this.lOCATARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.lOCATARIODataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmRenovacionContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(943, 528);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "FrmRenovacionContratos";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratosVencidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERACIONESCONTRATOSVENCIDOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Button btnRenovarContrato;
        protected System.Windows.Forms.Button btnFinalizarContrato;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvContratosVencidos;
        private System.Windows.Forms.BindingSource oPERACIONESCONTRATOSVENCIDOSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERACIONPROPIEDADIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAOPERACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAINICIOCONTRATODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAFINCONTRATODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDADNEGOCIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNMUEBLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAZONSOCIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTIDADINMOBILIARIAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROPIEDADIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCATARIODataGridViewTextBoxColumn;
    }
}
