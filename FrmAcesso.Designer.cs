namespace Calculadora
{
    partial class FrmAcesso
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
            this.BtnCalculadora = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Calculadora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCalculadora
            // 
            this.BtnCalculadora.Location = new System.Drawing.Point(204, 155);
            this.BtnCalculadora.Name = "BtnCalculadora";
            this.BtnCalculadora.Size = new System.Drawing.Size(83, 42);
            this.BtnCalculadora.TabIndex = 0;
            this.BtnCalculadora.Text = "Entrar";
            this.BtnCalculadora.UseVisualStyleBackColor = true;
            this.BtnCalculadora.Click += new System.EventHandler(this.BtnCalculadora_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(495, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(277, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(426, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 42);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Calculadora
            // 
            this.Calculadora.AutoSize = true;
            this.Calculadora.Location = new System.Drawing.Point(212, 139);
            this.Calculadora.Name = "Calculadora";
            this.Calculadora.Size = new System.Drawing.Size(63, 13);
            this.Calculadora.TabIndex = 5;
            this.Calculadora.Text = "Calculadora";
            // 
            // FrmAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calculadora);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnCalculadora);
            this.Name = "FrmAcesso";
            this.Text = "FrmAcesso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalculadora;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label Calculadora;
    }
}