using MyMines.Models;
using MyMines.Services;

namespace MyMines.Forms
{
    public partial class PanelForm : Form
    {
        private Server? _currentServer;
        private readonly ServerManager _serverManager;
        private bool _isProcessing;

        public PanelForm()
        {
            InitializeComponent();
            _serverManager = new ServerManager();
            gbCreate.Enabled = true;
            btInit.Enabled = false;
            cbNickPlayer.Enabled = false;
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            InitializeControls();
        }

        private void InitializeControls()
        {
            cbNumPlayer.Items.Clear();
            for (int i = 1; i <= 20; i++)
            {
                cbNumPlayer.Items.Add(i);
            }

            cbDificult.Items.Clear();
            cbDificult.Items.AddRange(new object[] { "PEACEFUL", "EASY", "NORMAL", "HARD" });

            cbVersionMine.Items.Clear();
            cbVersionMine.Items.AddRange(new object[] 
            { 
                "LATEST", 
                "1.20.4", 
                "1.20.2", 
                "1.19.4", 
                "1.18.2", 
                "1.16.5" 
            });

            cbVersionMine.Leave += cbVersionMine_Leave;

            if (cbNumPlayer.Items.Count > 0)
                cbNumPlayer.SelectedIndex = 4;

            if (cbDificult.Items.Count > 0)
                cbDificult.SelectedIndex = 2;

            if (cbVersionMine.Items.Count > 0)
                cbVersionMine.SelectedIndex = 0;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            if (_isProcessing)
                return;

            if (!ValidateInput(out string validationMessage))
            {
                MessageBox.Show(validationMessage, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _isProcessing = true;
            btInit.Enabled = false;
            
            try
            {
                Cursor = Cursors.WaitCursor;

                var configuration = new ServerConfiguration
                {
                    Version = cbVersionMine.Text,
                    Difficulty = cbDificult.SelectedItem?.ToString() ?? "NORMAL",
                    MaxPlayers = (int)(cbNumPlayer.SelectedItem ?? 10)
                };

                _currentServer = new Server
                {
                    Name = txtName.Text.Trim(),
                    Environment = configuration.ToEnvironmentVariables()
                };

                if (rbTrue.Checked && !string.IsNullOrWhiteSpace(cbNickPlayer.Text))
                {
                    _currentServer.Environment["DEFAULT_PLAYER"] = cbNickPlayer.Text.Trim();
                }

                var result = await _serverManager.CreateAsync(_currentServer, configuration);

                if (result.Success)
                {
                    btInit.Enabled = true;
                    MessageBox.Show("Servidor criado com sucesso!", "Sucesso", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Erro ao criar servidor: {result.Message}", "Erro", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _currentServer = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _currentServer = null;
            }
            finally
            {
                Cursor = Cursors.Default;
                _isProcessing = false;
            }
        }

        private bool ValidateInput(out string message)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                message = "O nome do servidor não pode estar vazio.";
                txtName.Focus();
                return false;
            }

            if (txtName.Text.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                message = "O nome do servidor contém caracteres inválidos.";
                txtName.Focus();
                return false;
            }

            if (cbNumPlayer.SelectedItem == null)
            {
                message = "Selecione o número de jogadores.";
                cbNumPlayer.Focus();
                return false;
            }

            if (cbDificult.SelectedItem == null)
            {
                message = "Selecione a dificuldade.";
                cbDificult.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbVersionMine.Text))
            {
                message = "Selecione ou digite a versão do Minecraft.";
                cbVersionMine.Focus();
                return false;
            }

            if (rbTrue.Checked && string.IsNullOrWhiteSpace(cbNickPlayer.Text))
            {
                message = "Digite o nickname do jogador padrão.";
                cbNickPlayer.Focus();
                return false;
            }

            message = string.Empty;
            return true;
        }

        private async void btInit_Click(object sender, EventArgs e)
        {
            if (_currentServer == null)
            {
                MessageBox.Show("Por favor, crie o servidor primeiro.", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_isProcessing)
                return;

            _isProcessing = true;
            btInit.Enabled = false;

            try
            {
                Cursor = Cursors.WaitCursor;

                var result = await _serverManager.HandleAsync(_currentServer);

                if (result.Success)
                {
                    btInit.Text = _currentServer.IsRunning ? "Parar Servidor" : "Iniciar Servidor";
                    
                    if (_currentServer.IsRunning)
                    {
                        var connectionModal = new ServerConnectionModal(_currentServer);
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
                btInit.Enabled = true;
                _isProcessing = false;
            }
        }

        private void cbVersionMine_Leave(object sender, EventArgs e)
        {
            string newVersion = cbVersionMine.Text.Trim();

            if (!string.IsNullOrEmpty(newVersion) && !cbVersionMine.Items.Contains(newVersion))
            {
                cbVersionMine.Items.Add(newVersion);
            }
        }

        private void rbTrue_CheckedChanged(object sender, EventArgs e)
        {
            cbNickPlayer.Enabled = rbTrue.Checked;
            if (!rbTrue.Checked)
            {
                cbNickPlayer.Text = string.Empty;
            }
        }
    }
}
