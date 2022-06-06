namespace FormularioCarros___Clase3
{
    partial class ModelForm
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
            this.dgDatosModelo = new System.Windows.Forms.DataGridView();
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
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosModelo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.Location = new System.Drawing.Point(305, 87);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(115, 19);
            this.chkVisible.TabIndex = 44;
            this.chkVisible.Text = "Visible al publico";
            this.chkVisible.UseVisualStyleBackColor = true;
            // 
            // dgDatosModelo
            // 
            this.dgDatosModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatosModelo.Location = new System.Drawing.Point(25, 196);
            this.dgDatosModelo.Name = "dgDatosModelo";
            this.dgDatosModelo.RowTemplate.Height = 25;
            this.dgDatosModelo.Size = new System.Drawing.Size(428, 324);
            this.dgDatosModelo.TabIndex = 43;
            this.dgDatosModelo.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDatosModelo_CellMouseUp);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(355, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 34);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LawnGreen;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(227, 145);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 34);
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // lblNombreColor
            // 
            this.lblNombreColor.AutoSize = true;
            this.lblNombreColor.Location = new System.Drawing.Point(12, 113);
            this.lblNombreColor.Name = "lblNombreColor";
            this.lblNombreColor.Size = new System.Drawing.Size(51, 15);
            this.lblNombreColor.TabIndex = 40;
            this.lblNombreColor.Text = "Nombre";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(46, 66);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 15);
            this.lblId.TabIndex = 39;
            this.lblId.Text = "Id";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(34, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(156, 15);
            this.lblTitulo.TabIndex = 38;
            this.lblTitulo.Text = "FORMULARIO DE MODELOS";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(74, 58);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 23);
            this.txtId.TabIndex = 37;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(74, 105);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 23);
            this.txtNombre.TabIndex = 36;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarRegistroToolStripMenuItem,
            this.actualizarRegistroToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 48);
            // 
            // borrarRegistroToolStripMenuItem
            // 
            this.borrarRegistroToolStripMenuItem.Name = "borrarRegistroToolStripMenuItem";
            this.borrarRegistroToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.borrarRegistroToolStripMenuItem.Text = "Borrar registro";
            this.borrarRegistroToolStripMenuItem.Click += new System.EventHandler(this.borrarRegistroToolStripMenuItem_Click);
            // 
            // actualizarRegistroToolStripMenuItem
            // 
            this.actualizarRegistroToolStripMenuItem.Name = "actualizarRegistroToolStripMenuItem";
            this.actualizarRegistroToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.actualizarRegistroToolStripMenuItem.Text = "Actualizar registro";
            this.actualizarRegistroToolStripMenuItem.Click += new System.EventHandler(this.actualizarRegistroToolStripMenuItem_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(74, 145);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 23);
            this.cbTipo.TabIndex = 48;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(34, 153);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(30, 15);
            this.lblTipo.TabIndex = 47;
            this.lblTipo.Text = "Tipo\n";
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(305, 55);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 23);
            this.cbMarca.TabIndex = 46;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(253, 58);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 45;
            this.lblMarca.Text = "Marca\r\n";
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(482, 541);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.chkVisible);
            this.Controls.Add(this.dgDatosModelo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNombreColor);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNombre);
            this.Name = "ModelForm";
            this.Text = "ModelForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosModelo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chkVisible;
        private DataGridView dgDatosModelo;
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
        private ComboBox cbTipo;
        private Label lblTipo;
        private ComboBox cbMarca;
        private Label lblMarca;
    }
}