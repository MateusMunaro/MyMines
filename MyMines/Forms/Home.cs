using MyMines.Forms;

namespace MyMines
{
    public partial class Home : Form
    {
        private PanelForm panelview;

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
    }
}
