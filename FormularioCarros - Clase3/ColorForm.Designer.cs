namespace FormularioCarros___Clase3
{
    partial class ColorForm
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
            this.lblNombreColor = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgDatosColor = new System.Windows.Forms.DataGridView();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.borrarFilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosColor)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreColor
            // 
            this.lblNombreColor.AutoSize = true;
            this.lblNombreColor.Location = new System.Drawing.Point(75, 108);
            this.lblNombreColor.Name = "lblNombreColor";
            this.lblNombreColor.Size = new System.Drawing.Size(51, 15);
            this.lblNombreColor.TabIndex = 31;
            this.lblNombreColor.Text = "Nombre";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(94, 69);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 15);
            this.lblId.TabIndex = 30;
            this.lblId.Text = "Id";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(28, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(152, 15);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "FORMULARIO DE COLORES";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(138, 61);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 23);
            this.txtId.TabIndex = 27;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 23);
            this.txtNombre.TabIndex = 26;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(329, 108);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 34);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LawnGreen;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(328, 54);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 34);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgDatosColor
            // 
            this.dgDatosColor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatosColor.Location = new System.Drawing.Point(12, 175);
            this.dgDatosColor.Name = "dgDatosColor";
            this.dgDatosColor.RowTemplate.Height = 25;
            this.dgDatosColor.Size = new System.Drawing.Size(497, 324);
            this.dgDatosColor.TabIndex = 34;
            this.dgDatosColor.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDatosColor_CellMouseUp);
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.Location = new System.Drawing.Point(138, 134);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(115, 19);
            this.chkVisible.TabIndex = 35;
            this.chkVisible.Text = "Visible al publico";
            this.chkVisible.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarFilaToolStripMenuItem,
            this.actualizarRegistroToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // borrarFilaToolStripMenuItem
            // 
            this.borrarFilaToolStripMenuItem.Name = "borrarFilaToolStripMenuItem";
            this.borrarFilaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrarFilaToolStripMenuItem.Text = "Borrar Registro";
            this.borrarFilaToolStripMenuItem.Click += new System.EventHandler(this.borrarFilaToolStripMenuItem_Click);
            // 
            // actualizarRegistroToolStripMenuItem
            // 
            this.actualizarRegistroToolStripMenuItem.Name = "actualizarRegistroToolStripMenuItem";
            this.actualizarRegistroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizarRegistroToolStripMenuItem.Text = "Actualizar Registro";
            this.actualizarRegistroToolStripMenuItem.Click += new System.EventHandler(this.actualizarRegistroToolStripMenuItem_Click);
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(521, 516);
            this.Controls.Add(this.chkVisible);
            this.Controls.Add(this.dgDatosColor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNombreColor);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNombre);
            this.MaximizeBox = false;
            this.Name = "ColorForm";
            this.Text = "ColorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosColor)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNombreColor;
        private Label lblId;
        private Label lblTitulo;
        private TextBox txtId;
        private TextBox txtNombre;
        private Button btnCancelar;
        private Button btnGuardar;
        private DataGridView dgDatosColor;
        private CheckBox chkVisible;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem borrarFilaToolStripMenuItem;
        private ToolStripMenuItem actualizarRegistroToolStripMenuItem;
    }
}