using MyMines.Forms;

namespace MyMines
{
    public partial class Home : Form
    {
        private PanelForm panelview;
        private ServerList ServerList;

        public Home()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.panelview == null)
            {
                this.panelview = new PanelForm();
                this.panelview.Show();

            }
            else
            {
                this.panelview.Focus();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.ServerList == null)
            {
                this.ServerList = new ServerList(); 
                this.ServerList.Show();
            }
            else
            {
                this.ServerList.Focus();    
            }

        }
    }
}
