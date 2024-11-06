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
            CreateButton = new Button();
            label5 = new Label();
            cbNumber = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            textIp = new TextBox();
            textName = new TextBox();
            gbCreate.SuspendLayout();
            SuspendLayout();
            // 
            // gbCreate
            // 
            gbCreate.BackColor = SystemColors.ActiveCaptionText;
            gbCreate.Controls.Add(CreateButton);
            gbCreate.Controls.Add(label5);
            gbCreate.Controls.Add(cbNumber);
            gbCreate.Controls.Add(label4);
            gbCreate.Controls.Add(label2);
            gbCreate.Controls.Add(label1);
            gbCreate.Controls.Add(textIp);
            gbCreate.Controls.Add(textName);
            gbCreate.Location = new Point(64, 75);
            gbCreate.Margin = new Padding(4, 5, 4, 5);
            gbCreate.Name = "gbCreate";
            gbCreate.Padding = new Padding(4, 5, 4, 5);
            gbCreate.Size = new Size(753, 417);
            gbCreate.TabIndex = 0;
            gbCreate.TabStop = false;
            // 
            // CreateButton
            // 
            CreateButton.AutoSize = true;
            CreateButton.Font = new Font("Impact", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateButton.Location = new Point(47, 332);
            CreateButton.Margin = new Padding(4, 5, 4, 5);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(150, 35);
            CreateButton.TabIndex = 3;
            CreateButton.Text = "Cirar Servidor";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(23, 252);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(187, 25);
            label5.TabIndex = 9;
            label5.Text = "Numero de jogadores";
            // 
            // cbNumber
            // 
            cbNumber.FormattingEnabled = true;
            cbNumber.Location = new Point(229, 249);
            cbNumber.Margin = new Padding(4, 5, 4, 5);
            cbNumber.Name = "cbNumber";
            cbNumber.Size = new Size(59, 33);
            cbNumber.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(47, 191);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(135, 25);
            label4.TabIndex = 7;
            label4.Text = "Permitir cheats?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(56, 125);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 3;
            label2.Text = "Ip do Servidor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(23, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 2;
            label1.Text = "Nome do Servidor";
            // 
            // textIp
            // 
            textIp.Location = new Point(179, 120);
            textIp.Margin = new Padding(4, 5, 4, 5);
            textIp.Name = "textIp";
            textIp.Size = new Size(204, 31);
            textIp.TabIndex = 1;
            // 
            // textName
            // 
            textName.Location = new Point(179, 37);
            textName.Margin = new Padding(4, 5, 4, 5);
            textName.Name = "textName";
            textName.Size = new Size(523, 31);
            textName.TabIndex = 0;
            // 
            // Panel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(881, 547);
            Controls.Add(gbCreate);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Panel";
            Text = "Form1";
            Load += Panel_Load;
            gbCreate.ResumeLayout(false);
            gbCreate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCreate;
        private TextBox textIp;
        private TextBox textName;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private ComboBox cbNumber;
        private Button CreateButton;
    }
}