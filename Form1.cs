using System;
using System.Windows.Forms;
using System.Timers;
using CookieClicker;

namespace CookieClicker
{
    public partial class Form1 : Form
    {
        public int cookies = 0;
        public int cookiesPerClick = 1;
        private int clickPowerCost = 20;
        private int autoClickers = 0;
        private int autoClickerCost = 50;
        private System.Windows.Forms.Timer autoClickerTimer;


        public Form1()
        {
            InitializeComponent();
            SetupAutoClicker();
        }

        private void SetupAutoClicker()
        {
            autoClickerTimer = new System.Windows.Forms.Timer();
            autoClickerTimer.Interval = 1000;
            autoClickerTimer.Tick += (s, e) =>
            {
                cookies += autoClickers;
                UpdateCookieLabel();
            };
            autoClickerTimer.Start();
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
            if (cookies >= clickPowerCost)
            {
                cookies -= clickPowerCost;
                cookiesPerClick++;
                clickPowerCost += 15;
                UpdateCookieLabel();
            }
        }

        private void btnAutoclicker_Click(object sender, EventArgs e)
        {
            if (cookies >= autoClickerCost)
            {
                cookies -= autoClickerCost;
                autoClickers++;
                autoClickerCost += 10;
                UpdateCookieLabel();
            }
        }
    }
}