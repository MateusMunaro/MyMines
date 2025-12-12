using MyMines.Forms;

namespace MyMines
{
    public partial class Home : Form
    {
        private PanelForm? _panelView;
        private ServerList? _serverList;

        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_panelView == null || _panelView.IsDisposed)
            {
                _panelView = new PanelForm();
                _panelView.FormClosed += (s, args) => _panelView = null;
                _panelView.Show();
            }
            else
            {
                _panelView.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_serverList == null || _serverList.IsDisposed)
            {
                _serverList = new ServerList();
                _serverList.FormClosed += (s, args) => _serverList = null;
                _serverList.Show();
            }
            else
            {
                _serverList.Focus();
            }
        }
    }
}
