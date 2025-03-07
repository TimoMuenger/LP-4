using System;
using System.Windows.Forms;
using CookieClicker;

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (cookies >= 20)
            {
                cookies -= 20;
                cookiesPerClick++;
                 UpdateCookieLabel();
            }
        }
    }
}
