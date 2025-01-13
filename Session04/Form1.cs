using Session04.UI;

namespace Session04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            var frm = new FormUser();
            frm.ShowDialog();
        }
    }
}
