using System.Drawing;
using System.Windows.Forms;

namespace CookieClicker
{
    partial class Form1
    {
        private Label lblCookies;
        private Button btnUpgradeClickpower;
        private Button btnAutoclicker;
        private Label lblUpgradeCost;
        private Label lblUpgradeCount;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblCookies = new Label();
            btnUpgradeClickpower = new Button();
            btnAutoclicker = new Button();
            lblUpgradeCost = new Label();
            lblUpgradeCount = new Label();
            btnCookie = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblCookies
            // 
            lblCookies.BackColor = Color.Transparent;
            lblCookies.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            lblCookies.ForeColor = Color.White;
            lblCookies.Location = new Point(110, 18);
            lblCookies.Name = "lblCookies";
            lblCookies.Size = new Size(420, 83);
            lblCookies.TabIndex = 1;
            lblCookies.Text = "Cookies: 0";
            lblCookies.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUpgradeClickpower
            // 
            btnUpgradeClickpower.BackColor = Color.Transparent;
            btnUpgradeClickpower.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold);
            btnUpgradeClickpower.Location = new Point(370, 176);
            btnUpgradeClickpower.Name = "btnUpgradeClickpower";
            btnUpgradeClickpower.Size = new Size(160, 70);
            btnUpgradeClickpower.TabIndex = 2;
            btnUpgradeClickpower.Text = "Click Power";
            btnUpgradeClickpower.UseVisualStyleBackColor = false;
            btnUpgradeClickpower.Click += btnUpgradeClickpower_Click;
            // 
            // btnAutoclicker
            // 
            btnAutoclicker.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold);
            btnAutoclicker.Location = new Point(370, 252);
            btnAutoclicker.Name = "btnAutoclicker";
            btnAutoclicker.Size = new Size(160, 70);
            btnAutoclicker.TabIndex = 3;
            btnAutoclicker.Text = "AutoClicker";
            btnAutoclicker.UseVisualStyleBackColor = true;
            btnAutoclicker.Click += btnAutoclicker_Click;
            // 
            // lblUpgradeCost
            // 
            lblUpgradeCost.BackColor = Color.Transparent;
            lblUpgradeCost.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            lblUpgradeCost.ForeColor = Color.White;
            lblUpgradeCost.Location = new Point(12, 78);
            lblUpgradeCost.Name = "lblUpgradeCost";
            lblUpgradeCost.Size = new Size(576, 30);
            lblUpgradeCost.TabIndex = 5;
            lblUpgradeCost.Text = "ClickpowerCost: 100 | AutoclickerCost: 500 | RebirthCost: 1500000";
            lblUpgradeCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUpgradeCount
            // 
            lblUpgradeCount.BackColor = Color.Transparent;
            lblUpgradeCount.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            lblUpgradeCount.ForeColor = Color.White;
            lblUpgradeCount.Location = new Point(29, 108);
            lblUpgradeCount.Name = "lblUpgradeCount";
            lblUpgradeCount.Size = new Size(559, 22);
            lblUpgradeCount.TabIndex = 6;
            lblUpgradeCount.Text = "Clickpower lvl: 0 | Autoclicker lvl: 0 | Rebirths: 0";
            lblUpgradeCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCookie
            // 
            btnCookie.BackColor = Color.Transparent;
            btnCookie.BackgroundImageLayout = ImageLayout.Stretch;
            btnCookie.FlatStyle = FlatStyle.Popup;
            btnCookie.Image = (Image)resources.GetObject("btnCookie.Image");
            btnCookie.Location = new Point(87, 156);
            btnCookie.Name = "btnCookie";
            btnCookie.Size = new Size(246, 246);
            btnCookie.TabIndex = 0;
            btnCookie.UseVisualStyleBackColor = false;
            btnCookie.Click += btnCookie_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold);
            button2.Location = new Point(370, 328);
            button2.Name = "button2";
            button2.Size = new Size(160, 75);
            button2.TabIndex = 8;
            button2.Text = "Rebirth";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            BackColor = Color.BurlyWood;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(591, 450);
            Controls.Add(button2);
            Controls.Add(lblUpgradeCount);
            Controls.Add(lblUpgradeCost);
            Controls.Add(btnAutoclicker);
            Controls.Add(btnUpgradeClickpower);
            Controls.Add(btnCookie);
            Controls.Add(lblCookies);
            Name = "Form1";
            Text = "Cookie Clicker";
            ResumeLayout(false);
        }
        private Button btnCookie;
        private Button button2;
    }
}
