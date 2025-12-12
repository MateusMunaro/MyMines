namespace MyMines.Forms
{
    partial class ServerConnectionModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerConnectionModal));
            panel1 = new Panel();
            lblServerName = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnCopyLocal = new Button();
            lblLocalIP = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            btnCopyPublic = new Button();
            lblPublicIP = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            lblPort = new Label();
            label6 = new Label();
            btnClose = new Button();
            label2 = new Label();
            txtConnectionString = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 73, 94);
            panel1.Controls.Add(lblServerName);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 80);
            panel1.TabIndex = 0;
            // 
            // lblServerName
            // 
            lblServerName.AutoSize = true;
            lblServerName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblServerName.ForeColor = Color.White;
            lblServerName.Location = new Point(20, 40);
            lblServerName.Name = "lblServerName";
            lblServerName.Size = new Size(169, 30);
            lblServerName.TabIndex = 1;
            lblServerName.Text = "Server Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(189, 195, 199);
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(176, 21);
            label1.TabIndex = 0;
            label1.Text = "? Servidor Iniciado!";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCopyLocal);
            groupBox1.Controls.Add(lblLocalIP);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(20, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 90);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Conexão Local (Rede)";
            // 
            // btnCopyLocal
            // 
            btnCopyLocal.BackColor = Color.FromArgb(46, 204, 113);
            btnCopyLocal.FlatAppearance.BorderSize = 0;
            btnCopyLocal.FlatStyle = FlatStyle.Flat;
            btnCopyLocal.ForeColor = Color.White;
            btnCopyLocal.Location = new Point(350, 45);
            btnCopyLocal.Name = "btnCopyLocal";
            btnCopyLocal.Size = new Size(90, 30);
            btnCopyLocal.TabIndex = 2;
            btnCopyLocal.Text = "?? Copiar";
            btnCopyLocal.UseVisualStyleBackColor = false;
            btnCopyLocal.Click += btnCopyLocal_Click;
            // 
            // lblLocalIP
            // 
            lblLocalIP.AutoSize = true;
            lblLocalIP.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lblLocalIP.ForeColor = Color.FromArgb(52, 152, 219);
            lblLocalIP.Location = new Point(20, 50);
            lblLocalIP.Name = "lblLocalIP";
            lblLocalIP.Size = new Size(162, 19);
            lblLocalIP.TabIndex = 1;
            lblLocalIP.Text = "192.168.1.1:25565";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(189, 195, 199);
            label3.Location = new Point(20, 30);
            label3.Name = "label3";
            label3.Size = new Size(285, 15);
            label3.TabIndex = 0;
            label3.Text = "Use este endereço para conexão em rede local (LAN)";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCopyPublic);
            groupBox2.Controls.Add(lblPublicIP);
            groupBox2.Controls.Add(label5);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(20, 200);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(460, 90);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Conexão Local (Mesma Máquina)";
            // 
            // btnCopyPublic
            // 
            btnCopyPublic.BackColor = Color.FromArgb(46, 204, 113);
            btnCopyPublic.FlatAppearance.BorderSize = 0;
            btnCopyPublic.FlatStyle = FlatStyle.Flat;
            btnCopyPublic.ForeColor = Color.White;
            btnCopyPublic.Location = new Point(350, 45);
            btnCopyPublic.Name = "btnCopyPublic";
            btnCopyPublic.Size = new Size(90, 30);
            btnCopyPublic.TabIndex = 2;
            btnCopyPublic.Text = "?? Copiar";
            btnCopyPublic.UseVisualStyleBackColor = false;
            btnCopyPublic.Click += btnCopyPublic_Click;
            // 
            // lblPublicIP
            // 
            lblPublicIP.AutoSize = true;
            lblPublicIP.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lblPublicIP.ForeColor = Color.FromArgb(52, 152, 219);
            lblPublicIP.Location = new Point(20, 50);
            lblPublicIP.Name = "lblPublicIP";
            lblPublicIP.Size = new Size(153, 19);
            lblPublicIP.TabIndex = 1;
            lblPublicIP.Text = "localhost:25565";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(189, 195, 199);
            label5.Location = new Point(20, 30);
            label5.Name = "label5";
            label5.Size = new Size(240, 15);
            label5.TabIndex = 0;
            label5.Text = "Use este endereço na mesma máquina local";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblPort);
            groupBox3.Controls.Add(label6);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(20, 300);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(460, 70);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informações";
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Font = new Font("Consolas", 10F, FontStyle.Bold);
            lblPort.ForeColor = Color.FromArgb(241, 196, 15);
            lblPort.Location = new Point(80, 35);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(48, 17);
            lblPort.TabIndex = 1;
            lblPort.Text = "25565";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(189, 195, 199);
            label6.Location = new Point(20, 35);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 0;
            label6.Text = "Porta:";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(231, 76, 60);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(370, 400);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(110, 35);
            btnClose.TabIndex = 4;
            btnClose.Text = "Fechar";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(189, 195, 199);
            label2.Location = new Point(20, 380);
            label2.Name = "label2";
            label2.Size = new Size(338, 15);
            label2.TabIndex = 5;
            label2.Text = "?? Dica: Compartilhe o endereço de rede com seus amigos!";
            // 
            // txtConnectionString
            // 
            txtConnectionString.Location = new Point(20, 410);
            txtConnectionString.Name = "txtConnectionString";
            txtConnectionString.ReadOnly = true;
            txtConnectionString.Size = new Size(340, 23);
            txtConnectionString.TabIndex = 6;
            txtConnectionString.Visible = false;
            // 
            // ServerConnectionModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(500, 450);
            Controls.Add(txtConnectionString);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ServerConnectionModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Informações de Conexão";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblServerName;
        private GroupBox groupBox1;
        private Button btnCopyLocal;
        private Label lblLocalIP;
        private Label label3;
        private GroupBox groupBox2;
        private Button btnCopyPublic;
        private Label lblPublicIP;
        private Label label5;
        private GroupBox groupBox3;
        private Label lblPort;
        private Label label6;
        private Button btnClose;
        private Label label2;
        private TextBox txtConnectionString;
    }
}
