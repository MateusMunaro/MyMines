using MyMines.Models;
using MyMines.Services;

namespace MyMines.Forms
{
    public partial class ServerList : Form
    {
        private Server? _selectedServer;
        private readonly ServerManager _serverManager;
        private bool _isLoading;

        public ServerList()
        {
            InitializeComponent();
            _serverManager = new ServerManager();
            this.Load += ServerList_Load;
            gbEdit.Enabled = false;
        }

        private async void ServerList_Load(object sender, EventArgs e)
        {
            await LoadServersAsync();
        }

        private async Task LoadServersAsync()
        {
            if (_isLoading)
                return;

            _isLoading = true;
            comboBox1.Enabled = false;

            try
            {
                Cursor = Cursors.WaitCursor;

                var servers = await _serverManager.GetServersAsync();

                comboBox1.Items.Clear();

                foreach (var server in servers)
                {
                    comboBox1.Items.Add(server.Name);
                }

                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Nenhum servidor encontrado.", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar servidores: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                comboBox1.Enabled = true;
                _isLoading = false;
            }
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string serverName = comboBox1.SelectedItem.ToString() ?? string.Empty;
                _selectedServer = new Server(serverName);
                
                await RefreshServerStatus();
                
                gbEdit.Enabled = true;
            }
            else
            {
                _selectedServer = null;
                gbEdit.Enabled = false;
            }
        }

        private async Task RefreshServerStatus()
        {
            if (_selectedServer == null)
                return;

            try
            {
                bool isRunning = await _serverManager.RefreshServerStatusAsync(_selectedServer);
                
                if (isRunning)
                {
                    radioButton1.Checked = true;
                    btStart.Text = "⏹ Parar";
                    btStart.BackColor = Color.FromArgb(231, 76, 60);
                }
                else
                {
                    radioButton2.Checked = true;
                    btStart.Text = "▶ Iniciar";
                    btStart.BackColor = Color.FromArgb(46, 204, 113);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar status: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (_selectedServer == null)
            {
                MessageBox.Show("Selecione um servidor para editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Funcionalidade de edição em desenvolvimento.", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btDelete_Click(object sender, EventArgs e)
        {
            if (_selectedServer == null)
            {
                MessageBox.Show("Selecione um servidor para deletar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Tem certeza que deseja deletar o servidor '{_selectedServer.Name}'?\n\nTodos os dados serão perdidos!",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                Cursor = Cursors.WaitCursor;
                btDelete.Enabled = false;

                var result = await _serverManager.DeleteAsync(_selectedServer);

                if (result.Success)
                {
                    MessageBox.Show("Servidor deletado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _selectedServer = null;
                    gbEdit.Enabled = false;

                    await LoadServersAsync();
                }
                else
                {
                    MessageBox.Show($"Erro ao deletar servidor: {result.Message}", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                btDelete.Enabled = true;
            }
        }

        private async void btStart_Click(object sender, EventArgs e)
        {
            if (_selectedServer == null)
            {
                MessageBox.Show("Selecione um servidor para iniciar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btStart.Enabled = false;
            
            try
            {
                Cursor = Cursors.WaitCursor;

                var result = await _serverManager.HandleAsync(_selectedServer);

                if (result.Success)
                {
                    await RefreshServerStatus();

                    if (_selectedServer.IsRunning)
                    {
                        var connectionModal = new ServerConnectionModal(_selectedServer);
                        connectionModal.ShowDialog(this);
                    }
                    else
                    {
                        MessageBox.Show("Servidor parado com sucesso!", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show($"Erro: {result.Message}", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                btStart.Enabled = true;
            }
        }
    }
}
