namespace Calculadora
{
    partial class Form1
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
            labelTitulo = new Label();
            txtBoxNumero1 = new TextBox();
            txtBoxNumero2 = new TextBox();
            txtBoxResultado = new TextBox();
            lblOperacion = new Label();
            lblSignoResultado = new Label();
            btnSuma = new Button();
            btnResta = new Button();
            btnMultiplicacion = new Button();
            btnDivision = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(129, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Padding = new Padding(50, 0, 50, 0);
            labelTitulo.Size = new Size(195, 24);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Calculadora";
            labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxNumero1
            // 
            txtBoxNumero1.Location = new Point(52, 64);
            txtBoxNumero1.Name = "txtBoxNumero1";
            txtBoxNumero1.Size = new Size(99, 23);
            txtBoxNumero1.TabIndex = 1;
            txtBoxNumero1.KeyPress += txtBoxNumeros_KeyPress;
            // 
            // txtBoxNumero2
            // 
            txtBoxNumero2.Location = new Point(180, 64);
            txtBoxNumero2.Name = "txtBoxNumero2";
            txtBoxNumero2.Size = new Size(99, 23);
            txtBoxNumero2.TabIndex = 2;
            txtBoxNumero2.KeyPress += txtBoxNumeros_KeyPress;
            // 
            // txtBoxResultado
            // 
            txtBoxResultado.Enabled = false;
            txtBoxResultado.Location = new Point(308, 64);
            txtBoxResultado.Name = "txtBoxResultado";
            txtBoxResultado.Size = new Size(99, 23);
            txtBoxResultado.TabIndex = 3;
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOperacion.Location = new Point(157, 64);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(0, 20);
            lblOperacion.TabIndex = 4;
            // 
            // lblSignoResultado
            // 
            lblSignoResultado.AutoSize = true;
            lblSignoResultado.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignoResultado.Location = new Point(285, 64);
            lblSignoResultado.Name = "lblSignoResultado";
            lblSignoResultado.Size = new Size(17, 20);
            lblSignoResultado.TabIndex = 5;
            lblSignoResultado.Text = "=";
            // 
            // btnSuma
            // 
            btnSuma.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSuma.Location = new Point(45, 117);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(85, 30);
            btnSuma.TabIndex = 6;
            btnSuma.Text = "Suma";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResta.Location = new Point(136, 117);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(85, 30);
            btnResta.TabIndex = 7;
            btnResta.Text = "Resta";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiplicacion.Location = new Point(227, 117);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(99, 30);
            btnMultiplicacion.TabIndex = 8;
            btnMultiplicacion.Text = "Multiplicacion";
            btnMultiplicacion.UseVisualStyleBackColor = true;
            btnMultiplicacion.Click += btnMultiplicacion_Click;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivision.Location = new Point(332, 117);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(85, 30);
            btnDivision.TabIndex = 9;
            btnDivision.Text = "Division";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(460, 174);
            Controls.Add(btnDivision);
            Controls.Add(btnMultiplicacion);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(lblSignoResultado);
            Controls.Add(lblOperacion);
            Controls.Add(txtBoxResultado);
            Controls.Add(txtBoxNumero2);
            Controls.Add(txtBoxNumero1);
            Controls.Add(labelTitulo);
            MaximizeBox = false;
            MaximumSize = new Size(476, 213);
            MinimumSize = new Size(470, 210);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private TextBox txtBoxNumero1;
        private TextBox txtBoxNumero2;
        private TextBox txtBoxResultado;
        private Label lblOperacion;
        private Label lblSignoResultado;
        private Button btnSuma;
        private Button btnResta;
        private Button btnMultiplicacion;
        private Button btnDivision;
    }
}
