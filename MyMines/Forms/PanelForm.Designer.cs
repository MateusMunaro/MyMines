namespace MyMines.Forms
{
    partial class PanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelForm));
            gbCreate = new GroupBox();
            cbNickPlayer = new ComboBox();
            label6 = new Label();
            radioButton2 = new RadioButton();
            rbTrue = new RadioButton();
            label5 = new Label();
            label4 = new Label();
            cbVersionMine = new ComboBox();
            label2 = new Label();
            cbDificult = new ComboBox();
            cbNumPlayer = new ComboBox();
            label3 = new Label();
            CreateButton = new Button();
            label1 = new Label();
            txtName = new TextBox();
            btInit = new Button();
            gbCreate.SuspendLayout();
            SuspendLayout();
            // 
            // gbCreate
            // 
            gbCreate.BackColor = SystemColors.ActiveCaptionText;
            gbCreate.Controls.Add(cbNickPlayer);
            gbCreate.Controls.Add(label6);
            gbCreate.Controls.Add(radioButton2);
            gbCreate.Controls.Add(rbTrue);
            gbCreate.Controls.Add(label5);
            gbCreate.Controls.Add(label4);
            gbCreate.Controls.Add(cbVersionMine);
            gbCreate.Controls.Add(label2);
            gbCreate.Controls.Add(cbDificult);
            gbCreate.Controls.Add(cbNumPlayer);
            gbCreate.Controls.Add(label3);
            gbCreate.Controls.Add(CreateButton);
            gbCreate.Controls.Add(label1);
            gbCreate.Controls.Add(txtName);
            gbCreate.Location = new Point(45, 45);
            gbCreate.Name = "gbCreate";
            gbCreate.Size = new Size(527, 259);
            gbCreate.TabIndex = 0;
            gbCreate.TabStop = false;
            // 
            // cbNickPlayer
            // 
            cbNickPlayer.FormattingEnabled = true;
            cbNickPlayer.Location = new Point(316, 120);
            cbNickPlayer.Name = "cbNickPlayer";
            cbNickPlayer.Size = new Size(188, 23);
            cbNickPlayer.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(218, 120);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 16;
            label6.Text = "Nick do jogador";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = SystemColors.ButtonFace;
            radioButton2.Location = new Point(457, 89);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(47, 19);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "Não";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbTrue
            // 
            rbTrue.AutoSize = true;
            rbTrue.ForeColor = SystemColors.ButtonFace;
            rbTrue.Location = new Point(406, 89);
            rbTrue.Name = "rbTrue";
            rbTrue.Size = new Size(45, 19);
            rbTrue.TabIndex = 14;
            rbTrue.TabStop = true;
            rbTrue.Text = "Sim";
            rbTrue.UseVisualStyleBackColor = true;
            rbTrue.CheckedChanged += rbTrue_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(218, 89);
            label5.Name = "label5";
            label5.Size = new Size(173, 15);
            label5.TabIndex = 13;
            label5.Text = "Somente jogadores autorizados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(300, 25);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 12;
            label4.Text = "Versão do Minecraft";
            // 
            // cbVersionMine
            // 
            cbVersionMine.FormattingEnabled = true;
            cbVersionMine.Location = new Point(418, 22);
            cbVersionMine.Name = "cbVersionMine";
            cbVersionMine.Size = new Size(103, 23);
            cbVersionMine.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(16, 123);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 10;
            label2.Text = "Dificuldade ";
            // 
            // cbDificult
            // 
            cbDificult.FormattingEnabled = true;
            cbDificult.Location = new Point(92, 120);
            cbDificult.Name = "cbDificult";
            cbDificult.Size = new Size(108, 23);
            cbDificult.TabIndex = 9;
            // 
            // cbNumPlayer
            // 
            cbNumPlayer.FormattingEnabled = true;
            cbNumPlayer.Location = new Point(145, 86);
            cbNumPlayer.Name = "cbNumPlayer";
            cbNumPlayer.Size = new Size(55, 23);
            cbNumPlayer.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(16, 89);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 7;
            label3.Text = "Numero de Jogadores";
            // 
            // CreateButton
            // 
            CreateButton.AutoSize = true;
            CreateButton.Font = new Font("Impact", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateButton.Location = new Point(16, 215);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(112, 28);
            CreateButton.TabIndex = 3;
            CreateButton.Text = "Criar Servidor";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(16, 25);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome do Servidor";
            // 
            // txtName
            // 
            txtName.Location = new Point(125, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(169, 23);
            txtName.TabIndex = 0;
            // 
            // btInit
            // 
            btInit.AutoSize = true;
            btInit.Font = new Font("Impact", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btInit.Location = new Point(482, 310);
            btInit.Name = "btInit";
            btInit.Size = new Size(123, 28);
            btInit.TabIndex = 8;
            btInit.Text = "Iniciar Servidor";
            btInit.UseVisualStyleBackColor = true;
            btInit.Click += btInit_Click;
            // 
            // PanelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(617, 350);
            Controls.Add(btInit);
            Controls.Add(gbCreate);
            Name = "PanelForm";
            Text = "Form1";
            Load += Panel_Load;
            gbCreate.ResumeLayout(false);
            gbCreate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbCreate;
        private TextBox txtName;
        private Label label1;
        private Button CreateButton;
        private Label label3;
        private Button btInit;
        private ComboBox cbNumPlayer;
        private Label label2;
        private ComboBox cbDificult;
        private Label label4;
        private ComboBox cbVersionMine;
        private ComboBox cbNickPlayer;
        private Label label6;
        private RadioButton radioButton2;
        private RadioButton rbTrue;
        private Label label5;
    }
}