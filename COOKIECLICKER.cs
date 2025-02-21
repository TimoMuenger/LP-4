namespace LP_4
{
    public partial class COOKIECLICKER : Form
    {
        private uint cookieClicked = 0;
        public COOKIECLICKER()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cookieClicked++;
            COOKIES.Text = $"COOKIES:{cookieClicked}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Shop().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
