namespace FormularioCarros___Clase3
{
    partial class CarForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbFotoCarro = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSubirFoto = new System.Windows.Forms.Button();
            this.btnColorForm = new System.Windows.Forms.Button();
            this.btnMarcaForm = new System.Windows.Forms.Button();
            this.btnModelForm = new System.Windows.Forms.Button();
            this.dgDatosVehiculos = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoCarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosVehiculos)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LawnGreen;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(120, 563);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 34);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(285, 563);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 34);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbFotoCarro
            // 
            this.pbFotoCarro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbFotoCarro.Location = new System.Drawing.Point(273, 77);
            this.pbFotoCarro.Name = "pbFotoCarro";
            this.pbFotoCarro.Size = new System.Drawing.Size(238, 247);
            this.pbFotoCarro.TabIndex = 2;
            this.pbFotoCarro.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 23);
            this.textBox1.TabIndex = 3;
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(95, 251);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(121, 23);
            this.cbColor.TabIndex = 4;
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(95, 118);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 23);
            this.textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(95, 75);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 23);
            this.textBox6.TabIndex = 9;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(146, 15);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "FORMULARIO DE CARROS";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(30, 212);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 11;
            this.lblMarca.Text = "Marca\r\n";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(49, 83);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 15);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "Id";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(30, 254);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(36, 15);
            this.lblColor.TabIndex = 13;
            this.lblColor.Text = "Color";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(25, 168);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(57, 15);
            this.lblMatricula.TabIndex = 14;
            this.lblMatricula.Text = "Matricula";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(30, 300);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(48, 15);
            this.lblModelo.TabIndex = 15;
            this.lblModelo.Text = "Modelo";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(37, 126);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(29, 15);
            this.lblAño.TabIndex = 16;
            this.lblAño.Text = "Año";
            // 
            // cbModelo
            // 
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(95, 297);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(121, 23);
            this.cbModelo.TabIndex = 17;
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(95, 209);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 23);
            this.cbMarca.TabIndex = 18;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(273, 59);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(31, 15);
            this.lblFoto.TabIndex = 19;
            this.lblFoto.Text = "Foto";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(49, 365);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(69, 15);
            this.lblDesc.TabIndex = 20;
            this.lblDesc.Text = "Descripcion";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(49, 390);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(431, 131);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.Location = new System.Drawing.Point(318, 330);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.Size = new System.Drawing.Size(149, 23);
            this.btnSubirFoto.TabIndex = 22;
            this.btnSubirFoto.Text = "Subir Foto";
            this.btnSubirFoto.UseVisualStyleBackColor = true;
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click);
            // 
            // btnColorForm
            // 
            this.btnColorForm.Location = new System.Drawing.Point(222, 250);
            this.btnColorForm.Name = "btnColorForm";
            this.btnColorForm.Size = new System.Drawing.Size(27, 23);
            this.btnColorForm.TabIndex = 23;
            this.btnColorForm.Text = "...";
            this.btnColorForm.UseVisualStyleBackColor = true;
            this.btnColorForm.Click += new System.EventHandler(this.btnColorForm_Click);
            // 
            // btnMarcaForm
            // 
            this.btnMarcaForm.Location = new System.Drawing.Point(222, 209);
            this.btnMarcaForm.Name = "btnMarcaForm";
            this.btnMarcaForm.Size = new System.Drawing.Size(27, 23);
            this.btnMarcaForm.TabIndex = 24;
            this.btnMarcaForm.Text = "...";
            this.btnMarcaForm.UseVisualStyleBackColor = true;
            this.btnMarcaForm.Click += new System.EventHandler(this.btnMarcaForm_Click);
            // 
            // btnModelForm
            // 
            this.btnModelForm.Location = new System.Drawing.Point(222, 297);
            this.btnModelForm.Name = "btnModelForm";
            this.btnModelForm.Size = new System.Drawing.Size(27, 23);
            this.btnModelForm.TabIndex = 25;
            this.btnModelForm.Text = "...";
            this.btnModelForm.UseVisualStyleBackColor = true;
            this.btnModelForm.Click += new System.EventHandler(this.btnModelForm_Click);
            // 
            // dgDatosVehiculos
            // 
            this.dgDatosVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatosVehiculos.Location = new System.Drawing.Point(546, 32);
            this.dgDatosVehiculos.Name = "dgDatosVehiculos";
            this.dgDatosVehiculos.RowTemplate.Height = 25;
            this.dgDatosVehiculos.Size = new System.Drawing.Size(642, 565);
            this.dgDatosVehiculos.TabIndex = 26;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 645);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1200, 22);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMsg
            // 
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(118, 17);
            this.lblMsg.Text = "toolStripStatusLabel1";
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 667);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgDatosVehiculos);
            this.Controls.Add(this.btnModelForm);
            this.Controls.Add(this.btnMarcaForm);
            this.Controls.Add(this.btnColorForm);
            this.Controls.Add(this.btnSubirFoto);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pbFotoCarro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "CarForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoCarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosVehiculos)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGuardar;
        private Button btnCancelar;
        private PictureBox pbFotoCarro;
        private TextBox textBox1;
        private ComboBox cbColor;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label lblTitulo;
        private Label lblMarca;
        private Label lblId;
        private Label lblColor;
        private Label lblMatricula;
        private Label lblModelo;
        private Label lblAño;
        private ComboBox cbModelo;
        private ComboBox cbMarca;
        private Label lblFoto;
        private Label lblDesc;
        private RichTextBox richTextBox1;
        private Button btnSubirFoto;
        private Button btnColorForm;
        private Button btnMarcaForm;
        private Button btnModelForm;
        private DataGridView dgDatosVehiculos;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblMsg;
    }
}