namespace Calculadora
{
    partial class FrmTarefas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTarefas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.LblItem = new System.Windows.Forms.Label();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.MskDataHorario = new System.Windows.Forms.MaskedTextBox();
            this.TxtComplemento = new System.Windows.Forms.TextBox();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Agenda = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.novoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AtualizarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExluirToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblStatus);
            this.groupBox1.Controls.Add(this.LblItem);
            this.groupBox1.Controls.Add(this.CmbTipo);
            this.groupBox1.Controls.Add(this.MskDataHorario);
            this.groupBox1.Controls.Add(this.TxtComplemento);
            this.groupBox1.Controls.Add(this.TxtDescricao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(252, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LblStatus
            // 
            this.LblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblStatus.Location = new System.Drawing.Point(153, 195);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(325, 24);
            this.LblStatus.TabIndex = 10;
            this.LblStatus.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LblItem
            // 
            this.LblItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblItem.Location = new System.Drawing.Point(153, 54);
            this.LblItem.Name = "LblItem";
            this.LblItem.Size = new System.Drawing.Size(63, 15);
            this.LblItem.TabIndex = 9;
            this.LblItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbTipo
            // 
            this.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Items.AddRange(new object[] {
            "1- Mostrar uma mensagem de aviso",
            "2- Executar uma tarefa"});
            this.CmbTipo.Location = new System.Drawing.Point(147, 136);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(331, 21);
            this.CmbTipo.TabIndex = 1;
            // 
            // MskDataHorario
            // 
            this.MskDataHorario.Location = new System.Drawing.Point(153, 110);
            this.MskDataHorario.Mask = "00/00/0000 00:00";
            this.MskDataHorario.Name = "MskDataHorario";
            this.MskDataHorario.Size = new System.Drawing.Size(126, 20);
            this.MskDataHorario.TabIndex = 8;
            // 
            // TxtComplemento
            // 
            this.TxtComplemento.Location = new System.Drawing.Point(147, 163);
            this.TxtComplemento.MaxLength = 60;
            this.TxtComplemento.Name = "TxtComplemento";
            this.TxtComplemento.Size = new System.Drawing.Size(331, 20);
            this.TxtComplemento.TabIndex = 7;
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(153, 82);
            this.TxtDescricao.MaxLength = 60;
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(325, 20);
            this.TxtDescricao.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Complemento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data e Horario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // Agenda
            // 
            this.Agenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Agenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agenda.Image = ((System.Drawing.Image)(resources.GetObject("Agenda.Image")));
            this.Agenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Agenda.Location = new System.Drawing.Point(77, 30);
            this.Agenda.Name = "Agenda";
            this.Agenda.Size = new System.Drawing.Size(147, 64);
            this.Agenda.TabIndex = 1;
            this.Agenda.Text = "Agenda";
            this.Agenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Agenda.Click += new System.EventHandler(this.Agenda_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripButton,
            this.toolStripSeparator1,
            this.AtualizarToolStripButton,
            this.toolStripSeparator,
            this.ExluirToolStripButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(99, 94);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(111, 170);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // novoToolStripButton
            // 
            this.novoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripButton.Image")));
            this.novoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripButton.Name = "novoToolStripButton";
            this.novoToolStripButton.Size = new System.Drawing.Size(109, 35);
            this.novoToolStripButton.Text = "&Novo";
            this.novoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.novoToolStripButton.ToolTipText = "Nova Trefa";
            // 
            // AtualizarToolStripButton
            // 
            this.AtualizarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AtualizarToolStripButton.Image")));
            this.AtualizarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AtualizarToolStripButton.Name = "AtualizarToolStripButton";
            this.AtualizarToolStripButton.Size = new System.Drawing.Size(109, 35);
            this.AtualizarToolStripButton.Text = "&Atualizar";
            this.AtualizarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AtualizarToolStripButton.ToolTipText = "Atualizar Lista";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(109, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // ExluirToolStripButton1
            // 
            this.ExluirToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ExluirToolStripButton1.Image")));
            this.ExluirToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExluirToolStripButton1.Name = "ExluirToolStripButton1";
            this.ExluirToolStripButton1.Size = new System.Drawing.Size(109, 35);
            this.ExluirToolStripButton1.Text = "&Excluir";
            this.ExluirToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExluirToolStripButton1.ToolTipText = "Excluir Tarefa";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5,
            this.ColumnHeader6});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(104, 278);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(626, 134);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Item";
            this.ColumnHeader1.Width = 40;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Descrição da Terefa";
            this.ColumnHeader2.Width = 200;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Data e Horario";
            this.ColumnHeader3.Width = 110;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Tipo";
            this.ColumnHeader4.Width = 45;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "Complemento";
            this.ColumnHeader5.Width = 120;
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "Status";
            this.ColumnHeader6.Width = 100;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel1.Text = "Mensagem";
            // 
            // FrmTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Agenda);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTarefas";
            this.Text = "FrmTarefas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskDataHorario;
        private System.Windows.Forms.TextBox TxtComplemento;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label LblItem;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label Agenda;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton novoToolStripButton;
        private System.Windows.Forms.ToolStripButton AtualizarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ExluirToolStripButton1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader ColumnHeader2;
        private System.Windows.Forms.ColumnHeader ColumnHeader3;
        private System.Windows.Forms.ColumnHeader ColumnHeader4;
        private System.Windows.Forms.ColumnHeader ColumnHeader5;
        private System.Windows.Forms.ColumnHeader ColumnHeader6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}