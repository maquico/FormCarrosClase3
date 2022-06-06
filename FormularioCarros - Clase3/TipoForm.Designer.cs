namespace FormularioCarros___Clase3
{
    partial class TipoForm
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
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.dgDatosTipo = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNombreColor = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.borrarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosTipo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.Location = new System.Drawing.Point(147, 125);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(115, 19);
            this.chkVisible.TabIndex = 62;
            this.chkVisible.Text = "Visible al publico";
            this.chkVisible.UseVisualStyleBackColor = true;
            // 
            // dgDatosTipo
            // 
            this.dgDatosTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatosTipo.Location = new System.Drawing.Point(28, 195);
            this.dgDatosTipo.Name = "dgDatosTipo";
            this.dgDatosTipo.RowTemplate.Height = 25;
            this.dgDatosTipo.Size = new System.Drawing.Size(428, 324);
            this.dgDatosTipo.TabIndex = 61;
            this.dgDatosTipo.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDatosTipo_CellMouseUp);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(329, 94);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 34);
            this.btnCancelar.TabIndex = 60;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LawnGreen;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(328, 50);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 34);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNombreColor
            // 
            this.lblNombreColor.AutoSize = true;
            this.lblNombreColor.Location = new System.Drawing.Point(84, 104);
            this.lblNombreColor.Name = "lblNombreColor";
            this.lblNombreColor.Size = new System.Drawing.Size(51, 15);
            this.lblNombreColor.TabIndex = 58;
            this.lblNombreColor.Text = "Nombre";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(103, 65);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 15);
            this.lblId.TabIndex = 57;
            this.lblId.Text = "Id";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(37, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(214, 15);
            this.lblTitulo.TabIndex = 56;
            this.lblTitulo.Text = "FORMULARIO DE TIPOS DE VEHÍCULOS";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(147, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 23);
            this.txtId.TabIndex = 55;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 23);
            this.txtNombre.TabIndex = 54;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarRegistroToolStripMenuItem,
            this.actualizarRegistroToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // borrarRegistroToolStripMenuItem
            // 
            this.borrarRegistroToolStripMenuItem.Name = "borrarRegistroToolStripMenuItem";
            this.borrarRegistroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrarRegistroToolStripMenuItem.Text = "Borrar registro";
            this.borrarRegistroToolStripMenuItem.Click += new System.EventHandler(this.borrarRegistroToolStripMenuItem_Click);
            // 
            // actualizarRegistroToolStripMenuItem
            // 
            this.actualizarRegistroToolStripMenuItem.Name = "actualizarRegistroToolStripMenuItem";
            this.actualizarRegistroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizarRegistroToolStripMenuItem.Text = "Actualizar registro";
            this.actualizarRegistroToolStripMenuItem.Click += new System.EventHandler(this.actualizarRegistroToolStripMenuItem_Click);
            // 
            // TipoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 528);
            this.Controls.Add(this.chkVisible);
            this.Controls.Add(this.dgDatosTipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNombreColor);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNombre);
            this.Name = "TipoForm";
            this.Text = "TipoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosTipo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chkVisible;
        private DataGridView dgDatosTipo;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label lblNombreColor;
        private Label lblId;
        private Label lblTitulo;
        private TextBox txtId;
        private TextBox txtNombre;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem borrarRegistroToolStripMenuItem;
        private ToolStripMenuItem actualizarRegistroToolStripMenuItem;
    }
}