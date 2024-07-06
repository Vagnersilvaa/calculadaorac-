namespace Calculadora
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTexto = new System.Windows.Forms.Label();
            this.labelHistorico = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonDividir = new System.Windows.Forms.Button();
            this.buttonMultiplicar = new System.Windows.Forms.Button();
            this.buttonSubtrair = new System.Windows.Forms.Button();
            this.buttonSomar = new System.Windows.Forms.Button();
            this.buttonResultado = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonVirgula = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.históricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTexto
            // 
            this.labelTexto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTexto.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTexto.Location = new System.Drawing.Point(19, 109);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(230, 35);
            this.labelTexto.TabIndex = 0;
            this.labelTexto.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelHistorico
            // 
            this.labelHistorico.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHistorico.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHistorico.Location = new System.Drawing.Point(19, 20);
            this.labelHistorico.Name = "labelHistorico";
            this.labelHistorico.Size = new System.Drawing.Size(230, 89);
            this.labelHistorico.TabIndex = 1;
            this.labelHistorico.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonLimpar.Location = new System.Drawing.Point(23, 175);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(112, 31);
            this.buttonLimpar.TabIndex = 2;
            this.buttonLimpar.Text = "C";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonDividir
            // 
            this.buttonDividir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDividir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDividir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDividir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonDividir.Location = new System.Drawing.Point(197, 175);
            this.buttonDividir.Name = "buttonDividir";
            this.buttonDividir.Size = new System.Drawing.Size(52, 31);
            this.buttonDividir.TabIndex = 5;
            this.buttonDividir.Text = "/";
            this.buttonDividir.UseVisualStyleBackColor = false;
            this.buttonDividir.Click += new System.EventHandler(this.buttonDividir_Click);
            // 
            // buttonMultiplicar
            // 
            this.buttonMultiplicar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMultiplicar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiplicar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplicar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonMultiplicar.Location = new System.Drawing.Point(197, 212);
            this.buttonMultiplicar.Name = "buttonMultiplicar";
            this.buttonMultiplicar.Size = new System.Drawing.Size(52, 31);
            this.buttonMultiplicar.TabIndex = 6;
            this.buttonMultiplicar.Text = "x";
            this.buttonMultiplicar.UseVisualStyleBackColor = false;
            this.buttonMultiplicar.Click += new System.EventHandler(this.buttonMultiplicar_Click);
            // 
            // buttonSubtrair
            // 
            this.buttonSubtrair.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSubtrair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubtrair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubtrair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSubtrair.Location = new System.Drawing.Point(197, 249);
            this.buttonSubtrair.Name = "buttonSubtrair";
            this.buttonSubtrair.Size = new System.Drawing.Size(52, 31);
            this.buttonSubtrair.TabIndex = 7;
            this.buttonSubtrair.Text = "-";
            this.buttonSubtrair.UseVisualStyleBackColor = false;
            this.buttonSubtrair.Click += new System.EventHandler(this.buttonSubtrair_Click);
            // 
            // buttonSomar
            // 
            this.buttonSomar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSomar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSomar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSomar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSomar.Location = new System.Drawing.Point(197, 286);
            this.buttonSomar.Name = "buttonSomar";
            this.buttonSomar.Size = new System.Drawing.Size(52, 31);
            this.buttonSomar.TabIndex = 8;
            this.buttonSomar.Text = "+";
            this.buttonSomar.UseVisualStyleBackColor = false;
            this.buttonSomar.Click += new System.EventHandler(this.buttonSomar_Click);
            // 
            // buttonResultado
            // 
            this.buttonResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonResultado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResultado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResultado.ForeColor = System.Drawing.Color.White;
            this.buttonResultado.Location = new System.Drawing.Point(197, 323);
            this.buttonResultado.Name = "buttonResultado";
            this.buttonResultado.Size = new System.Drawing.Size(52, 31);
            this.buttonResultado.TabIndex = 9;
            this.buttonResultado.Text = "=";
            this.buttonResultado.UseVisualStyleBackColor = false;
            this.buttonResultado.Click += new System.EventHandler(this.buttonResultado_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(25, 212);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(52, 31);
            this.button7.TabIndex = 10;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(81, 212);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(52, 31);
            this.button8.TabIndex = 11;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(139, 212);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(52, 31);
            this.button9.TabIndex = 12;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(139, 249);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 31);
            this.button6.TabIndex = 13;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(25, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 31);
            this.button4.TabIndex = 14;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(81, 249);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 31);
            this.button5.TabIndex = 15;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(25, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(83, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 31);
            this.button2.TabIndex = 17;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(139, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 31);
            this.button3.TabIndex = 18;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.ForeColor = System.Drawing.Color.Black;
            this.button0.Location = new System.Drawing.Point(23, 323);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(110, 31);
            this.button0.TabIndex = 19;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonVirgula
            // 
            this.buttonVirgula.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonVirgula.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonVirgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVirgula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVirgula.ForeColor = System.Drawing.Color.Black;
            this.buttonVirgula.Location = new System.Drawing.Point(139, 323);
            this.buttonVirgula.Name = "buttonVirgula";
            this.buttonVirgula.Size = new System.Drawing.Size(52, 31);
            this.buttonVirgula.TabIndex = 20;
            this.buttonVirgula.Text = ",";
            this.buttonVirgula.UseVisualStyleBackColor = false;
            this.buttonVirgula.Click += new System.EventHandler(this.buttonVirgula_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 378);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(273, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtnVoltar.Location = new System.Drawing.Point(209, 378);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(52, 23);
            this.BtnVoltar.TabIndex = 22;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.históricoToolStripMenuItem});
            this.toolStripSplitButton2.Image = global::Calculadora.Properties.Resources.BotAtu;
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // históricoToolStripMenuItem
            // 
            this.históricoToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            this.históricoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.históricoToolStripMenuItem.Text = "Histórico";
            this.históricoToolStripMenuItem.Click += new System.EventHandler(this.históricoToolStripMenuItem_Click_1);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonVoltar.BackgroundImage = global::Calculadora.Properties.Resources.BotApag1;
            this.buttonVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVoltar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoltar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonVoltar.Location = new System.Drawing.Point(139, 175);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(52, 31);
            this.buttonVoltar.TabIndex = 3;
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 400);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonVirgula);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonResultado);
            this.Controls.Add(this.buttonSomar);
            this.Controls.Add(this.buttonSubtrair);
            this.Controls.Add(this.buttonMultiplicar);
            this.Controls.Add(this.buttonDividir);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.labelHistorico);
            this.Controls.Add(this.labelTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caculadora";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.Label labelHistorico;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonDividir;
        private System.Windows.Forms.Button buttonMultiplicar;
        private System.Windows.Forms.Button buttonSubtrair;
        private System.Windows.Forms.Button buttonSomar;
        private System.Windows.Forms.Button buttonResultado;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonVirgula;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem históricoToolStripMenuItem;
        private System.Windows.Forms.Button BtnVoltar;
    }
}

