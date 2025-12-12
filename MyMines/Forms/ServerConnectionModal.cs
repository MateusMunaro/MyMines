using MyMines.Models;
using System.Net;

namespace MyMines.Forms
{
    public partial class ServerConnectionModal : Form
    {
        private readonly Server _server;

        public ServerConnectionModal(Server server)
        {
            _server = server ?? throw new ArgumentNullException(nameof(server));
            InitializeComponent();
            LoadServerInfo();
        }

        private void LoadServerInfo()
        {
            lblServerName.Text = _server.Name;
            lblPort.Text = _server.Port.ToString();
            
            string localIP = GetLocalIPAddress();
            lblLocalIP.Text = $"{localIP}:{_server.Port}";
            lblPublicIP.Text = $"localhost:{_server.Port}";
            
            txtConnectionString.Text = $"{localIP}:{_server.Port}";
        }

        private string GetLocalIPAddress()
        {
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
                return "127.0.0.1";
            }
            catch
            {
                return "127.0.0.1";
            }
        }

        private void btnCopyLocal_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(lblLocalIP.Text);
                MessageBox.Show("Endereço local copiado!", "Sucesso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao copiar: {ex.Message}", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopyPublic_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(lblPublicIP.Text);
                MessageBox.Show("Endereço público copiado!", "Sucesso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao copiar: {ex.Message}", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
