namespace Inmobiliaria.Presentacion.Mantenimiento.Generales
{
    partial class FrmMonedas
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSimboloSet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipoMoneda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecision = new System.Windows.Forms.TextBox();
            this.txtSimbolo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCamposObligatorios = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbDatosMonedas.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(534, 43);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(462, 43);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gbDatosMonedas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(534, 286);
            this.panel3.TabIndex = 11;
            // 
            // gbDatosMonedas
            // 
            this.gbDatosMonedas.AutoSize = true;
            this.gbDatosMonedas.Controls.Add(this.label7);
            this.gbDatosMonedas.Controls.Add(this.label5);
            this.gbDatosMonedas.Controls.Add(this.label13);
            this.gbDatosMonedas.Controls.Add(this.label3);
            this.gbDatosMonedas.Controls.Add(this.txtSimboloSet);
            this.gbDatosMonedas.Controls.Add(this.label6);
            this.gbDatosMonedas.Controls.Add(this.cbTipoMoneda);
            this.gbDatosMonedas.Controls.Add(this.label4);
            this.gbDatosMonedas.Controls.Add(this.txtPrecision);
            this.gbDatosMonedas.Controls.Add(this.txtSimbolo);
            this.gbDatosMonedas.Controls.Add(this.label2);
            this.gbDatosMonedas.Controls.Add(this.txtMoneda);
            this.gbDatosMonedas.Controls.Add(this.label1);
            this.gbDatosMonedas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosMonedas.Location = new System.Drawing.Point(5, 50);
            this.gbDatosMonedas.Name = "gbDatosMonedas";
            this.gbDatosMonedas.Size = new System.Drawing.Size(526, 233);
            this.gbDatosMonedas.TabIndex = 0;
            this.gbDatosMonedas.TabStop = false;
            this.gbDatosMonedas.Text = "Datos Monedas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Precision:";
            // 
            // txtSimboloSet
            // 
            this.txtSimboloSet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSimboloSet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSimboloSet.Location = new System.Drawing.Point(309, 130);
            this.txtSimboloSet.MaxLength = 120;
            this.txtSimboloSet.Name = "txtSimboloSet";
            this.txtSimboloSet.Size = new System.Drawing.Size(86, 23);
            this.txtSimboloSet.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(228, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Simbolo SET:";
            // 
            // cbTipoMoneda
            // 
            this.cbTipoMoneda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbTipoMoneda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTipoMoneda.DisplayMember = "VALOR_DOMINIO";
            this.cbTipoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoMoneda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoMoneda.FormattingEnabled = true;
            this.cbTipoMoneda.Location = new System.Drawing.Point(118, 92);
            this.cbTipoMoneda.Name = "cbTipoMoneda";
            this.cbTipoMoneda.Size = new System.Drawing.Size(278, 23);
            this.cbTipoMoneda.TabIndex = 1;
            this.cbTipoMoneda.ValueMember = "CODIGO_DOMINIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo moneda:";
            // 
            // txtPrecision
            // 
            this.txtPrecision.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecision.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecision.Location = new System.Drawing.Point(118, 169);
            this.txtPrecision.MaxLength = 1;
            this.txtPrecision.Name = "txtPrecision";
            this.txtPrecision.Size = new System.Drawing.Size(30, 23);
            this.txtPrecision.TabIndex = 4;
            this.txtPrecision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecision_KeyPress);
            // 
            // txtSimbolo
            // 
            this.txtSimbolo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSimbolo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSimbolo.Location = new System.Drawing.Point(118, 130);
            this.txtSimbolo.MaxLength = 20;
            this.txtSimbolo.Name = "txtSimbolo";
            this.txtSimbolo.Size = new System.Drawing.Size(86, 23);
            this.txtSimbolo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Simbolo:";
            // 
            // txtMoneda
            // 
            this.txtMoneda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMoneda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneda.Location = new System.Drawing.Point(118, 54);
            this.txtMoneda.MaxLength = 180;
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(278, 23);
            this.txtMoneda.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Moneda:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCamposObligatorios);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 52);
            this.panel2.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(171, 9);
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
            this.btnCancelar.Location = new System.Drawing.Point(270, 9);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 35);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCamposObligatorios
            // 
            this.lblCamposObligatorios.AutoSize = true;
            this.lblCamposObligatorios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCamposObligatorios.ForeColor = System.Drawing.Color.Red;
            this.lblCamposObligatorios.Location = new System.Drawing.Point(16, 20);
            this.lblCamposObligatorios.Name = "lblCamposObligatorios";
            this.lblCamposObligatorios.Size = new System.Drawing.Size(126, 15);
            this.lblCamposObligatorios.TabIndex = 12;
            this.lblCamposObligatorios.Text = "(*) Campos requeridos";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(46, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 20);
            this.label13.TabIndex = 95;
            this.label13.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(17, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 96;
            this.label5.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(43, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 20);
            this.label7.TabIndex = 97;
            this.label7.Text = "*";
            // 
            // FrmMonedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 338);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FrmMonedas";
            this.Load += new System.EventHandler(this.FrmMonedas_Load);
            this.Shown += new System.EventHandler(this.FrmMonedas_Shown);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbDatosMonedas.ResumeLayout(false);
            this.gbDatosMonedas.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbDatosMonedas;
        private System.Windows.Forms.TextBox txtSimboloSet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTipoMoneda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecision;
        private System.Windows.Forms.TextBox txtSimbolo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Button btnGuardar;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCamposObligatorios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
    }
}