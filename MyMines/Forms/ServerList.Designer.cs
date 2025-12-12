namespace MyMines.Forms
{
    partial class ServerList
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            label1 = new Label();
            btEdit = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label2 = new Label();
            btDelete = new Button();
            gbEdit = new GroupBox();
            btStart = new Button();
            panel1 = new Panel();
            label3 = new Label();
            gbEdit.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(20, 110);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(510, 25);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 85);
            label1.Name = "label1";
            label1.Size = new Size(147, 19);
            label1.TabIndex = 1;
            label1.Text = "📋 Selecione o Servidor";
            // 
            // btEdit
            // 
            btEdit.BackColor = Color.FromArgb(52, 152, 219);
            btEdit.FlatAppearance.BorderSize = 0;
            btEdit.FlatStyle = FlatStyle.Flat;
            btEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btEdit.ForeColor = Color.White;
            btEdit.Location = new Point(390, 160);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(100, 35);
            btEdit.TabIndex = 2;
            btEdit.Text = "✏ Editar";
            btEdit.UseVisualStyleBackColor = false;
            btEdit.Click += btEdit_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Enabled = false;
            radioButton1.Font = new Font("Segoe UI", 9F);
            radioButton1.ForeColor = Color.FromArgb(46, 204, 113);
            radioButton1.Location = new Point(140, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(77, 19);
            radioButton1.TabIndex = 3;
            radioButton1.Text = "✓ Ligado";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Enabled = false;
            radioButton2.Font = new Font("Segoe UI", 9F);
            radioButton2.ForeColor = Color.FromArgb(231, 76, 60);
            radioButton2.Location = new Point(20, 30);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(90, 19);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "⏹ Desligado";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(250, 32);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 5;
            label2.Text = "Status do Servidor";
            // 
            // btDelete
            // 
            btDelete.BackColor = Color.FromArgb(231, 76, 60);
            btDelete.FlatAppearance.BorderSize = 0;
            btDelete.FlatStyle = FlatStyle.Flat;
            btDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btDelete.ForeColor = Color.White;
            btDelete.Location = new Point(280, 160);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(100, 35);
            btDelete.TabIndex = 6;
            btDelete.Text = "🗑 Deletar";
            btDelete.UseVisualStyleBackColor = false;
            btDelete.Click += btDelete_Click;
            // 
            // gbEdit
            // 
            gbEdit.Controls.Add(btStart);
            gbEdit.Controls.Add(label2);
            gbEdit.Controls.Add(btDelete);
            gbEdit.Controls.Add(radioButton2);
            gbEdit.Controls.Add(btEdit);
            gbEdit.Controls.Add(radioButton1);
            gbEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbEdit.ForeColor = Color.White;
            gbEdit.Location = new Point(20, 150);
            gbEdit.Name = "gbEdit";
            gbEdit.Size = new Size(510, 210);
            gbEdit.TabIndex = 7;
            gbEdit.TabStop = false;
            gbEdit.Text = "Gerenciar Servidor";
            // 
            // btStart
            // 
            btStart.BackColor = Color.FromArgb(46, 204, 113);
            btStart.FlatAppearance.BorderSize = 0;
            btStart.FlatStyle = FlatStyle.Flat;
            btStart.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btStart.ForeColor = Color.White;
            btStart.Location = new Point(20, 75);
            btStart.Name = "btStart";
            btStart.Size = new Size(470, 70);
            btStart.TabIndex = 7;
            btStart.Text = "▶ Iniciar Servidor";
            btStart.UseVisualStyleBackColor = false;
            btStart.Click += btStart_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 73, 94);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 70);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 20);
            label3.Name = "label3";
            label3.Size = new Size(233, 32);
            label3.TabIndex = 0;
            label3.Text = "🖥 Lista de Servidores";
            // 
            // ServerList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(554, 381);
            Controls.Add(panel1);
            Controls.Add(gbEdit);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ServerList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyMines - Gerenciar Servidores";
            gbEdit.ResumeLayout(false);
            gbEdit.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private Label label2;
        private Button btEdit;
        private Button btDelete;
        private GroupBox gbEdit;
        private Button btStart;
        private Panel panel1;
        private Label label3;
    }
}