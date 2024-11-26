using MyMines.Models;
using MyMines.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMines.Forms
{
    public partial class PanelForm : Form
    {
        Server server;
        private ServerManager serverManager;


        public PanelForm()
        {
            InitializeComponent();
            gbCreate.Enabled = true;
            btInit.Enabled = false;
            cbNickPlayer.Enabled = false;

        }

        private void Panel_Load(object sender, EventArgs e)
        {
            this.serverManager = new ServerManager();

            for (int i = 1; i <= 10; i++)
            {
                cbNumPlayer.Items.Add(i);
            }

            cbDificult.Items.Add("Easy");
            cbDificult.Items.Add("Medium");
            cbDificult.Items.Add("Hard");

            cbVersionMine.Leave += cbVersionMine_Leave;

            if (cbNumPlayer.Items.Count > 0)
            {
                cbNumPlayer.SelectedIndex = 0;
            }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string serverName = txtName.Text;

            var environment = new Dictionary<string, string>{{ "EULA", "true" }};
         
            if (cbNumPlayer.SelectedItem != null)
            {
                environment.Add("MAX_PLAYERS", cbNumPlayer.SelectedItem.ToString());
            }

            if (cbDificult.SelectedItem != null)
            {
                environment.Add("DIFFICULTY", cbDificult.SelectedItem.ToString());
            }

            if (!string.IsNullOrEmpty(cbVersionMine.Text))
            {
                environment.Add("VERSION", cbVersionMine.Text);
            }

            if (rbTrue.Checked && !string.IsNullOrEmpty(cbNickPlayer.Text))
            {
                environment.Add("DEFAULT_PLAYER", cbNickPlayer.Text);
            }

            Server server = new Server
            {
                _name = serverName,
                _environment = environment,
            };

            serverManager.Create(server);

            // Habilita o botão para iniciar/parar o servidor
            btInit.Enabled = true;

            // Exibe uma mensagem de sucesso
            MessageBox.Show("Servidor criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btInit_Click(object sender, EventArgs e)
        {
            if (server != null)
            {
                serverManager.Handle(server);


                if (server._state)
                {
                    btInit.Text = "Parar Servidor";
                }
                else
                {
                    btInit.Text = "Iniciar Servidor";
                }
            }
            else
            {
                MessageBox.Show("Por favor, crie o servidor primeiro.");
            }
        }

        private void cbVersionMine_Leave(object sender, EventArgs e)
        {
            string newVersion = cbVersionMine.Text.Trim();

            if (!string.IsNullOrEmpty(newVersion) && !cbVersionMine.Items.Contains(newVersion))
            {
                cbVersionMine.Items.Add(newVersion);
                MessageBox.Show($"Versão '{newVersion}' adicionada às opções.", "Nova Versão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rbTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTrue.Checked)
            {
                cbNickPlayer.Enabled = true; 
            }
            else
            {
                cbNickPlayer.Enabled = false; 
            }
        }
    }
}
