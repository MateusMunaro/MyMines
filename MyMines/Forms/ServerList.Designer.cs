namespace MyMines.Forms
{
    partial class ServerList
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            btEdit = new Button();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label2 = new Label();
            btDelete = new Button();
            txtServerName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtPorts = new TextBox();
            txtVolumes = new TextBox();
            label5 = new Label();
            gbEdit = new GroupBox();
            gbEdit.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(123, 21);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(298, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(8, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 3;
            label1.Text = "Lista de servidores";
            // 
            // btEdit
            // 
            btEdit.Location = new Point(432, 20);
            btEdit.Margin = new Padding(2);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(78, 20);
            btEdit.TabIndex = 5;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // button1
            // 
            button1.Location = new Point(432, 212);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 13;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = SystemColors.Control;
            radioButton1.Location = new Point(463, 28);
            radioButton1.Margin = new Padding(2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(41, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "On";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = SystemColors.Control;
            radioButton2.Location = new Point(414, 28);
            radioButton2.Margin = new Padding(2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(42, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Off";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(355, 29);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Status";
            // 
            // btDelete
            // 
            btDelete.Location = new Point(424, 91);
            btDelete.Margin = new Padding(2);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(78, 20);
            btDelete.TabIndex = 6;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // txtServerName
            // 
            txtServerName.Location = new Point(121, 28);
            txtServerName.Name = "txtServerName";
            txtServerName.Size = new Size(229, 23);
            txtServerName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(4, 27);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 8;
            label3.Text = "Nome do Servidor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(6, 61);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 9;
            label4.Text = "Porta do servidor";
            // 
            // txtPorts
            // 
            txtPorts.Location = new Point(120, 61);
            txtPorts.Name = "txtPorts";
            txtPorts.Size = new Size(106, 23);
            txtPorts.TabIndex = 10;
            // 
            // txtVolumes
            // 
            txtVolumes.Location = new Point(120, 91);
            txtVolumes.Name = "txtVolumes";
            txtVolumes.Size = new Size(45, 23);
            txtVolumes.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(1, 92);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 12;
            label5.Text = "Numero de players";
            // 
            // gbEdit
            // 
            gbEdit.Controls.Add(label5);
            gbEdit.Controls.Add(txtVolumes);
            gbEdit.Controls.Add(txtPorts);
            gbEdit.Controls.Add(label4);
            gbEdit.Controls.Add(label3);
            gbEdit.Controls.Add(txtServerName);
            gbEdit.Controls.Add(btDelete);
            gbEdit.Controls.Add(label2);
            gbEdit.Controls.Add(radioButton2);
            gbEdit.Controls.Add(radioButton1);
            gbEdit.Location = new Point(8, 67);
            gbEdit.Margin = new Padding(2);
            gbEdit.Name = "gbEdit";
            gbEdit.Padding = new Padding(2);
            gbEdit.Size = new Size(517, 125);
            gbEdit.TabIndex = 7;
            gbEdit.TabStop = false;
            // 
            // ServerList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(553, 254);
            Controls.Add(button1);
            Controls.Add(gbEdit);
            Controls.Add(label1);
            Controls.Add(btEdit);
            Controls.Add(comboBox1);
            Margin = new Padding(2);
            Name = "ServerList";
            Text = "ServerList";
            gbEdit.ResumeLayout(false);
            gbEdit.PerformLayout();
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
        private Label label3;
        private TextBox txtServerName;
        private Label label4;
        private Label label5;
        private TextBox txtVolumes;
        private TextBox txtPorts;
        private Button button1;
    }
}