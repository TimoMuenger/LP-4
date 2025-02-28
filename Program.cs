using System;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class FormUpgrade : Form
    {
        private Form1 mainForm;
        private bool upgrade1Bought = false;
        private bool upgrade2Bought = false;
        private bool upgrade3Bought = false;

        public FormUpgrade(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
            UpdateLabels();
        }

        private void btnUpgrade1_Click(object sender, EventArgs e)
        {
            BuyUpgrade(10, 2, ref upgrade1Bought, btnUpgrade1, lblUpgrade1);
        }

        private void btnUpgrade2_Click(object sender, EventArgs e)
        {
            BuyUpgrade(50, 4, ref upgrade2Bought, btnUpgrade2, lblUpgrade2);
        }

        private void btnUpgrade3_Click(object sender, EventArgs e)
        {
            BuyUpgrade(200, 10, ref upgrade3Bought, btnUpgrade3, lblUpgrade3);
        }

        private void BuyUpgrade(int cost, int newClickValue, ref bool isBought, Button btn, Label lbl)
        {
            if (mainForm.cookies >= cost && !isBought)
            {
                mainForm.cookies -= cost;
                mainForm.cookiesPerClick = newClickValue;
                isBought = true;
                btn.Enabled = false;
                lbl.Text = $"Upgrade gekauft! Jetzt {newClickValue} Cookies pro Klick!";
                mainForm.UpdateCookieLabel();
            }
        }

        private void UpdateLabels()
        {
            lblUpgrade1.Text = "Upgrade 1: 2 Cookies pro Klick (10 Cookies)";
            lblUpgrade2.Text = "Upgrade 2: 4 Cookies pro Klick (50 Cookies)";
            lblUpgrade3.Text = "Upgrade 3: 10 Cookies pro Klick (200 Cookies)";
        }
    }
}

