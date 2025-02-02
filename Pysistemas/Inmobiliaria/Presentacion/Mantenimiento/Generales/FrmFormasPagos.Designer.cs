namespace Inmobiliaria.Presentacion.Mantenimiento.Generales
{
    partial class FrmFormasPagos
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
            this.gbDatosFormasPagos = new System.Windows.Forms.GroupBox();
            this.checkBoxPorDefecto = new System.Windows.Forms.CheckBox();
            this.checkBoxRequiereBanco = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFormaPago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCamposObligatorios = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbDatosFormasPagos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(518, 43);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(446, 43);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gbDatosFormasPagos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(518, 251);
            this.panel3.TabIndex = 12;
            // 
            // gbDatosFormasPagos
            // 
            this.gbDatosFormasPagos.AutoSize = true;
            this.gbDatosFormasPagos.Controls.Add(this.label5);
            this.gbDatosFormasPagos.Controls.Add(this.label4);
            this.gbDatosFormasPagos.Controls.Add(this.label13);
            this.gbDatosFormasPagos.Controls.Add(this.checkBoxPorDefecto);
            this.gbDatosFormasPagos.Controls.Add(this.checkBoxRequiereBanco);
            this.gbDatosFormasPagos.Controls.Add(this.label3);
            this.gbDatosFormasPagos.Controls.Add(this.txtDias);
            this.gbDatosFormasPagos.Controls.Add(this.txtCodigo);
            this.gbDatosFormasPagos.Controls.Add(this.label2);
            this.gbDatosFormasPagos.Controls.Add(this.txtFormaPago);
            this.gbDatosFormasPagos.Controls.Add(this.label1);
            this.gbDatosFormasPagos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosFormasPagos.Location = new System.Drawing.Point(5, 51);
            this.gbDatosFormasPagos.Name = "gbDatosFormasPagos";
            this.gbDatosFormasPagos.Size = new System.Drawing.Size(501, 213);
            this.gbDatosFormasPagos.TabIndex = 0;
            this.gbDatosFormasPagos.TabStop = false;
            this.gbDatosFormasPagos.Text = "Datos Formas de Pagos";
            // 
            // checkBoxPorDefecto
            // 
            this.checkBoxPorDefecto.AutoSize = true;
            this.checkBoxPorDefecto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.checkBoxPorDefecto.Location = new System.Drawing.Point(44, 163);
            this.checkBoxPorDefecto.Name = "checkBoxPorDefecto";
            this.checkBoxPorDefecto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxPorDefecto.Size = new System.Drawing.Size(89, 19);
            this.checkBoxPorDefecto.TabIndex = 4;
            this.checkBoxPorDefecto.Text = "Por Defecto";
            this.checkBoxPorDefecto.UseVisualStyleBackColor = true;
            this.checkBoxPorDefecto.CheckedChanged += new System.EventHandler(this.checkBoxPorDefecto_CheckedChanged);
            // 
            // checkBoxRequiereBanco
            // 
            this.checkBoxRequiereBanco.AutoSize = true;
            this.checkBoxRequiereBanco.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.checkBoxRequiereBanco.Location = new System.Drawing.Point(288, 126);
            this.checkBoxRequiereBanco.Name = "checkBoxRequiereBanco";
            this.checkBoxRequiereBanco.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxRequiereBanco.Size = new System.Drawing.Size(108, 19);
            this.checkBoxRequiereBanco.TabIndex = 3;
            this.checkBoxRequiereBanco.Text = "Requiere Banco";
            this.checkBoxRequiereBanco.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Días:";
            // 
            // txtDias
            // 
            this.txtDias.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDias.Location = new System.Drawing.Point(118, 121);
            this.txtDias.MaxLength = 3;
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(30, 23);
            this.txtDias.TabIndex = 2;
            this.txtDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDias_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(118, 37);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(86, 23);
            this.txtCodigo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo:";
            // 
            // txtFormaPago
            // 
            this.txtFormaPago.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFormaPago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormaPago.Location = new System.Drawing.Point(118, 79);
            this.txtFormaPago.MaxLength = 180;
            this.txtFormaPago.Name = "txtFormaPago";
            this.txtFormaPago.Size = new System.Drawing.Size(278, 23);
            this.txtFormaPago.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forma de Pago:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCamposObligatorios);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 52);
            this.panel2.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(163, 9);
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
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(262, 9);
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
            this.lblCamposObligatorios.Location = new System.Drawing.Point(13, 16);
            this.lblCamposObligatorios.Name = "lblCamposObligatorios";
            this.lblCamposObligatorios.Size = new System.Drawing.Size(126, 15);
            this.lblCamposObligatorios.TabIndex = 5;
            this.lblCamposObligatorios.Text = "(*) Campos requeridos";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(49, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 20);
            this.label13.TabIndex = 94;
            this.label13.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(7, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 95;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(66, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 96;
            this.label5.Text = "*";
            // 
            // FrmFormasPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 303);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FrmFormasPagos";
            this.Load += new System.EventHandler(this.FrmFormasPagos_Load);
            this.Shown += new System.EventHandler(this.FrmFormasPagos_Shown);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbDatosFormasPagos.ResumeLayout(false);
            this.gbDatosFormasPagos.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbDatosFormasPagos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFormaPago;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Button btnGuardar;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox checkBoxRequiereBanco;
        private System.Windows.Forms.CheckBox checkBoxPorDefecto;
        private System.Windows.Forms.Label lblCamposObligatorios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
    }
}