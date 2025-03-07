namespace CookieClicker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCookie;
        private System.Windows.Forms.Label lblCookies;

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
            btnCookie = new Button();
            lblCookies = new Label();
            btnUpgradeClickpower = new Button();
            SuspendLayout();
            // 
            // btnCookie
            // 
            btnCookie.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCookie.Location = new Point(100, 100);
            btnCookie.Name = "btnCookie";
            btnCookie.Size = new Size(150, 150);
            btnCookie.TabIndex = 0;
            btnCookie.Text = "Cookie";
            btnCookie.UseVisualStyleBackColor = true;
            btnCookie.Click += btnCookie_Click;
            // 
            // lblCookies
            // 
            lblCookies.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCookies.Location = new Point(100, 50);
            lblCookies.Name = "lblCookies";
            lblCookies.Size = new Size(288, 40);
            lblCookies.TabIndex = 1;
            lblCookies.Text = "Cookies: 0";
            // 
            // btnUpgradeClickpower
            // 
            btnUpgradeClickpower.Location = new Point(372, 100);
            btnUpgradeClickpower.Name = "btnUpgradeClickpower";
            btnUpgradeClickpower.Size = new Size(201, 66);
            btnUpgradeClickpower.TabIndex = 2;
            btnUpgradeClickpower.Text = "Upgrade Clickpower";
            btnUpgradeClickpower.UseVisualStyleBackColor = true;
            btnUpgradeClickpower.Click += button1_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(585, 400);
            Controls.Add(btnUpgradeClickpower);
            Controls.Add(btnCookie);
            Controls.Add(lblCookies);
            Name = "Form1";
            Text = "Cookie Clicker";
            ResumeLayout(false);
        }

        private Button btnUpgradeClickpower;
    }
}
