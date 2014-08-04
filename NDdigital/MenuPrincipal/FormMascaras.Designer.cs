namespace MenuPrincipal
{
    partial class FormMascaras
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lb_fone = new System.Windows.Forms.Label();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(151, 39);
            this.maskedTextBox1.Mask = "(99)0000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(86, 20);
            this.maskedTextBox1.TabIndex = 0;
            // 
            // lb_fone
            // 
            this.lb_fone.AutoSize = true;
            this.lb_fone.Location = new System.Drawing.Point(85, 46);
            this.lb_fone.Name = "lb_fone";
            this.lb_fone.Size = new System.Drawing.Size(49, 13);
            this.lb_fone.TabIndex = 1;
            this.lb_fone.Text = "Telefone";
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Location = new System.Drawing.Point(85, 74);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(27, 13);
            this.lb_cpf.TabIndex = 2;
            this.lb_cpf.Text = "CPF";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(151, 67);
            this.maskedTextBox2.Mask = "000.000.000-00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 3;
            // 
            // FormMascaras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 261);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.lb_cpf);
            this.Controls.Add(this.lb_fone);
            this.Controls.Add(this.maskedTextBox1);
            this.Name = "FormMascaras";
            this.Text = "FormMascaras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lb_fone;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    }
}