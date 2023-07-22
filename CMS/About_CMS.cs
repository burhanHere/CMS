namespace CMS
{
    public partial class About_CMS : Form
    {
        public About_CMS()
        {
            InitializeComponent();
        }
        private void About_CMS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
