
namespace ConexionDB
{
    partial class Form2
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.cBoxArticulos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(124, 95);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // cBoxArticulos
            // 
            this.cBoxArticulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxArticulos.FormattingEnabled = true;
            this.cBoxArticulos.Items.AddRange(new object[] {
            "Playera 1",
            "Playera 2"});
            this.cBoxArticulos.Location = new System.Drawing.Point(62, 46);
            this.cBoxArticulos.Name = "cBoxArticulos";
            this.cBoxArticulos.Size = new System.Drawing.Size(199, 21);
            this.cBoxArticulos.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 152);
            this.Controls.Add(this.cBoxArticulos);
            this.Controls.Add(this.btnRegresar);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ComboBox cBoxArticulos;
    }
}