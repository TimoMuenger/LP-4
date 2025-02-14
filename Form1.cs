namespace LP_4
{
    public partial class Form1 : Form
    {
        private     uint cookieClicked = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Total.Text = cookieClicked.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cookieClicked++;
        }
    }
}
