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
    public partial class ServerList : Form
    {
        Server server;
        private ServerManager serverManager = new ServerManager();
        public ServerList()
        {
            InitializeComponent();
            this.Load += ServerList_Load;
            gbEdit.Enabled = false;
        }


        //private void UpdateComboBoxWithServers()
        //{
        //    comboBox1.Items.Clear();
        //    foreach (var server in serverManager.GetServers())
        //    {
        //        comboBox1.Items.Add(server._name);
        //    }
        //}

        private void btEdit_Click(object sender, EventArgs e)
        {
            gbEdit.Enabled = true;

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (server != null)
            {
                serverManager.Delete(server);


                comboBox1.SelectedIndex = -1;


                gbEdit.Enabled = false;
            }
            else
            {
                MessageBox.Show("Selecione um servidor para deletar.");
            }

        }

        private void UpdateComboBoxWithServers()
        {
            comboBox1.Items.Clear(); // Limpa o ComboBox antes de adicionar novos itens

            // Percorre a lista de servidores do ServerManager e adiciona o nome no ComboBox
            foreach (var server in serverManager.GetServers())
            {
                comboBox1.Items.Add(server._name);
            }

            // Se houver pelo menos um servidor, seleciona o primeiro
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }



        private void ServerList_Load(object sender, EventArgs e)
        {
            UpdateComboBoxWithServers(); // Chama o método para preencher o ComboBox quando o formulário carregar
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}
