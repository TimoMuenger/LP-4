using System;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class Form1 : Form
    {
        public int cookies = 0;         
        public int cookiesPerClick = 1; 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCookie_Click(object sender, EventArgs e)
        {
            cookies += cookiesPerClick;
            UpdateCookieLabel();
        }

        public void UpdateCookieLabel()
        {
            lblCookies.Text = $"Cookies: {cookies}";
        }

        private void btnOpenUpgrade_Click(object sender, EventArgs e)
        {
            FormUpgrade upgradeForm = new FormUpgrade(this);
            upgradeForm.Show();
        }
    }
}
