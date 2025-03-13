namespace CookieClicker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCookie;
        private System.Windows.Forms.Label lblCookies;
        private System.Windows.Forms.Button btnUpgradeClickpower;
        private System.Windows.Forms.Button btnAutoclicker;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCookie = new Button();
            lblCookies = new Label();
            btnUpgradeClickpower = new Button();
            btnAutoclicker = new Button();
            SuspendLayout();
            // 
            // btnCookie
            // 
            btnCookie.BackColor = Color.FromArgb(128, 64, 0);
            btnCookie.BackgroundImage = (Image)resources.GetObject("btnCookie.BackgroundImage");
            btnCookie.BackgroundImageLayout = ImageLayout.Zoom;
            btnCookie.Font = new Font("Comic Sans MS", 100F, FontStyle.Bold);
            btnCookie.Location = new Point(134, 120);
            btnCookie.Name = "btnCookie";
            btnCookie.Size = new Size(246, 246);
            btnCookie.TabIndex = 0;
            btnCookie.UseVisualStyleBackColor = false;
            btnCookie.Click += btnCookie_Click;
            // 
            // lblCookies
            // 
            lblCookies.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            lblCookies.ForeColor = Color.GhostWhite;
            lblCookies.Location = new Point(110, 42);
            lblCookies.Name = "lblCookies";
            lblCookies.Size = new Size(300, 50);
            lblCookies.TabIndex = 1;
            lblCookies.Text = "Cookies: 0";
            lblCookies.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUpgradeClickpower
            // 
            btnUpgradeClickpower.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            btnUpgradeClickpower.Location = new Point(420, 120);
            btnUpgradeClickpower.Name = "btnUpgradeClickpower";
            btnUpgradeClickpower.Size = new Size(160, 70);
            btnUpgradeClickpower.TabIndex = 2;
            btnUpgradeClickpower.Text = "Click Power";
            btnUpgradeClickpower.UseVisualStyleBackColor = true;
            btnUpgradeClickpower.Click += button1_Click;
            // 
            // btnAutoclicker
            // 
            btnAutoclicker.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            btnAutoclicker.Location = new Point(420, 210);
            btnAutoclicker.Name = "btnAutoclicker";
            btnAutoclicker.Size = new Size(160, 70);
            btnAutoclicker.TabIndex = 3;
            btnAutoclicker.Text = "AutoClicker";
            btnAutoclicker.UseVisualStyleBackColor = true;
            btnAutoclicker.Click += btnAutoclicker_Click;
            // 
            // Form1
            // 
            BackColor = Color.BurlyWood;
            ClientSize = new Size(600, 450);
            Controls.Add(btnAutoclicker);
            Controls.Add(btnUpgradeClickpower);
            Controls.Add(btnCookie);
            Controls.Add(lblCookies);
            Name = "Form1";
            Text = "Cookie Clicker";
            ResumeLayout(false);
        }
    }
}
