namespace Inmobiliaria.Presentacion.Mantenimiento.Parametricos
{
    partial class FrmParametrosSistema
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbDatosMonedas = new System.Windows.Forms.GroupBox();
            this.txtPorcentajeAlquiler = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJornalMinimo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPorcentajeVenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiasGracia = new System.Windows.Forms.TextBox();
            this.txtMontoMoraPorDia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaInicioVigencia = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbDatosMonedas.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(764, 43);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(692, 43);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gbDatosMonedas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 316);
            this.panel3.TabIndex = 12;
            // 
            // gbDatosMonedas
            // 
            this.gbDatosMonedas.AutoSize = true;
            this.gbDatosMonedas.Controls.Add(this.dtpFechaInicioVigencia);
            this.gbDatosMonedas.Controls.Add(this.label7);
            this.gbDatosMonedas.Controls.Add(this.txtPorcentajeAlquiler);
            this.gbDatosMonedas.Controls.Add(this.label5);
            this.gbDatosMonedas.Controls.Add(this.txtJornalMinimo);
            this.gbDatosMonedas.Controls.Add(this.label3);
            this.gbDatosMonedas.Controls.Add(this.txtPorcentajeVenta);
            this.gbDatosMonedas.Controls.Add(this.label6);
            this.gbDatosMonedas.Controls.Add(this.label4);
            this.gbDatosMonedas.Controls.Add(this.txtDiasGracia);
            this.gbDatosMonedas.Controls.Add(this.txtMontoMoraPorDia);
            this.gbDatosMonedas.Controls.Add(this.label2);
            this.gbDatosMonedas.Controls.Add(this.txtSalarioMinimo);
            this.gbDatosMonedas.Controls.Add(this.label1);
            this.gbDatosMonedas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosMonedas.Location = new System.Drawing.Point(5, 7);
            this.gbDatosMonedas.Name = "gbDatosMonedas";
            this.gbDatosMonedas.Size = new System.Drawing.Size(751, 247);
            this.gbDatosMonedas.TabIndex = 0;
            this.gbDatosMonedas.TabStop = false;
            this.gbDatosMonedas.Text = "Parámetros del Sistema";
            // 
            // txtPorcentajeAlquiler
            // 
            this.txtPorcentajeAlquiler.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPorcentajeAlquiler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentajeAlquiler.Location = new System.Drawing.Point(554, 171);
            this.txtPorcentajeAlquiler.MaxLength = 120;
            this.txtPorcentajeAlquiler.Name = "txtPorcentajeAlquiler";
            this.txtPorcentajeAlquiler.Size = new System.Drawing.Size(30, 23);
            this.txtPorcentajeAlquiler.TabIndex = 6;
            this.txtPorcentajeAlquiler.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcentajeAlquiler.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPorcentajeAlquiler_MouseClick);
            this.txtPorcentajeAlquiler.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentajeAlquiler_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Porcentaje de comision alquiler:";
            // 
            // txtJornalMinimo
            // 
            this.txtJornalMinimo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtJornalMinimo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJornalMinimo.Location = new System.Drawing.Point(406, 54);
            this.txtJornalMinimo.MaxLength = 180;
            this.txtJornalMinimo.Name = "txtJornalMinimo";
            this.txtJornalMinimo.Size = new System.Drawing.Size(86, 23);
            this.txtJornalMinimo.TabIndex = 1;
            this.txtJornalMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJornalMinimo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtJornalMinimo_MouseClick);
            this.txtJornalMinimo.TextChanged += new System.EventHandler(this.txtJornalMinimo_TextChanged);
            this.txtJornalMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJornalMinimo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dias de gracia despues del vencimiento:";
            // 
            // txtPorcentajeVenta
            // 
            this.txtPorcentajeVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPorcentajeVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentajeVenta.Location = new System.Drawing.Point(184, 170);
            this.txtPorcentajeVenta.MaxLength = 120;
            this.txtPorcentajeVenta.Name = "txtPorcentajeVenta";
            this.txtPorcentajeVenta.Size = new System.Drawing.Size(30, 23);
            this.txtPorcentajeVenta.TabIndex = 5;
            this.txtPorcentajeVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcentajeVenta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPorcentajeVenta_MouseClick);
            this.txtPorcentajeVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentajeVenta_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Porcentaje de comision venta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monto jornal diario:";
            // 
            // txtDiasGracia
            // 
            this.txtDiasGracia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDiasGracia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiasGracia.Location = new System.Drawing.Point(554, 115);
            this.txtDiasGracia.MaxLength = 1;
            this.txtDiasGracia.Name = "txtDiasGracia";
            this.txtDiasGracia.Size = new System.Drawing.Size(30, 23);
            this.txtDiasGracia.TabIndex = 4;
            this.txtDiasGracia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiasGracia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDiasGracia_MouseClick);
            this.txtDiasGracia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiasGracia_KeyPress);
            // 
            // txtMontoMoraPorDia
            // 
            this.txtMontoMoraPorDia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMontoMoraPorDia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoMoraPorDia.Location = new System.Drawing.Point(184, 115);
            this.txtMontoMoraPorDia.MaxLength = 20;
            this.txtMontoMoraPorDia.Name = "txtMontoMoraPorDia";
            this.txtMontoMoraPorDia.Size = new System.Drawing.Size(86, 23);
            this.txtMontoMoraPorDia.TabIndex = 3;
            this.txtMontoMoraPorDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMontoMoraPorDia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMontoMoraPorDia_MouseClick);
            this.txtMontoMoraPorDia.TextChanged += new System.EventHandler(this.txtMontoMoraPorDia_TextChanged);
            this.txtMontoMoraPorDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoMoraPorDia_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto de mora por día:";
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSalarioMinimo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioMinimo.Location = new System.Drawing.Point(184, 54);
            this.txtSalarioMinimo.MaxLength = 180;
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(86, 23);
            this.txtSalarioMinimo.TabIndex = 0;
            this.txtSalarioMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSalarioMinimo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSalarioMinimo_MouseClick);
            this.txtSalarioMinimo.TextChanged += new System.EventHandler(this.txtSalarioMinimo_TextChanged);
            this.txtSalarioMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalarioMinimo_KeyPress);
            this.txtSalarioMinimo.Leave += new System.EventHandler(this.txtSalarioMinimo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sueldo mínimo vigente:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 52);
            this.panel2.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(286, 9);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 35);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(83)))), ((int)(((byte)(44)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(385, 9);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 35);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(514, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fecha inicio vigencia:";
            // 
            // dtpFechaInicioVigencia
            // 
            this.dtpFechaInicioVigencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicioVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicioVigencia.Location = new System.Drawing.Point(646, 54);
            this.dtpFechaInicioVigencia.Name = "dtpFechaInicioVigencia";
            this.dtpFechaInicioVigencia.Size = new System.Drawing.Size(86, 23);
            this.dtpFechaInicioVigencia.TabIndex = 2;
            // 
            // FrmParametrosSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 359);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "FrmParametrosSistema";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbDatosMonedas.ResumeLayout(false);
            this.gbDatosMonedas.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbDatosMonedas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPorcentajeVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiasGracia;
        private System.Windows.Forms.TextBox txtMontoMoraPorDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalarioMinimo;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Button btnGuardar;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtJornalMinimo;
        private System.Windows.Forms.TextBox txtPorcentajeAlquiler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker dtpFechaInicioVigencia;
    }
}