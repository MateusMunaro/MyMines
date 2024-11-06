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

        }

        private void Panel_Load(object sender, EventArgs e)
        {
            this.serverManager = new ServerManager();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string serverName = textName.Text;
            string serverIp = textIp.Text;
            int.TryParse(cbNumber.SelectedItem?.ToString(), out int playerCount);
            short port = 8080;

            var environment = new Dictionary<string, string> { { "ENVIRONMENT", "PRODUCTION" } };

            // Crie o servidor através do ServerManager
            serverManager.CreateServer(serverName, serverIp, environment, port, "defaultVolume");

            MessageBox.Show("Servidor criado com sucesso!");

            // Se desejar iniciar automaticamente o servidor
            serverManager.StartServer(serverName);


        }
    }
}
