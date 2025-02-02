namespace Inmobiliaria.Presentacion.Genericos
{
    partial class FrmBuscadorGenerico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscadorGenerico));
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.pnlFiltrosBusqueda = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(865, 43);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(793, 43);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.BackColor = System.Drawing.Color.White;
            this.lblBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBusqueda.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(0, 43);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(865, 46);
            this.lblBusqueda.TabIndex = 11;
            this.lblBusqueda.Text = "Buscar";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnNuevo,
            this.tsBtnEditar,
            this.tsbtnEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 89);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(865, 56);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnNuevo
            // 
            this.tsbtnNuevo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNuevo.Image")));
            this.tsbtnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNuevo.Name = "tsbtnNuevo";
            this.tsbtnNuevo.Size = new System.Drawing.Size(50, 53);
            this.tsbtnNuevo.Text = "Nuevo";
            this.tsbtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnNuevo.Click += new System.EventHandler(this.tsbtnNuevo_Click);
            // 
            // tsBtnEditar
            // 
            this.tsBtnEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnEditar.Image")));
            this.tsBtnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEditar.Name = "tsBtnEditar";
            this.tsBtnEditar.Size = new System.Drawing.Size(46, 53);
            this.tsBtnEditar.Text = "Editar";
            this.tsBtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnEditar.Click += new System.EventHandler(this.tsBtnEditar_Click);
            // 
            // tsbtnEliminar
            // 
            this.tsbtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tsbtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEliminar.Image")));
            this.tsbtnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEliminar.Name = "tsbtnEliminar";
            this.tsbtnEliminar.Size = new System.Drawing.Size(60, 53);
            this.tsbtnEliminar.Text = "Eliminar";
            this.tsbtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnEliminar.Visible = false;
            this.tsbtnEliminar.Click += new System.EventHandler(this.tsbtnEliminar_Click);
            // 
            // pnlDatos
            // 
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatos.Controls.Add(this.pnlFiltrosBusqueda);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Location = new System.Drawing.Point(0, 145);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(865, 421);
            this.pnlDatos.TabIndex = 14;
            // 
            // pnlFiltrosBusqueda
            // 
            this.pnlFiltrosBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiltrosBusqueda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFiltrosBusqueda.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltrosBusqueda.Name = "pnlFiltrosBusqueda";
            this.pnlFiltrosBusqueda.Size = new System.Drawing.Size(201, 419);
            this.pnlFiltrosBusqueda.TabIndex = 13;
            // 
            // FrmBuscadorGenerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 566);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblBusqueda);
            this.Name = "FrmBuscadorGenerico";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lblBusqueda, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.pnlDatos, 0);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlDatos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblBusqueda;
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnNuevo;
        private System.Windows.Forms.ToolStripButton tsBtnEditar;
        public System.Windows.Forms.Panel pnlDatos;
        public System.Windows.Forms.Panel pnlFiltrosBusqueda;
        public System.Windows.Forms.ToolStripButton tsbtnEliminar;
    }
}