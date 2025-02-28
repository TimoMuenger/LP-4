namespace CookieClicker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCookie;
        private System.Windows.Forms.Label lblCookies;
        private System.Windows.Forms.Button btnOpenUpgrade;

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
            btnOpenUpgrade = new Button();
            SuspendLayout();
            btnCookie.BackColor = Color.White;
            btnCookie.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCookie.ForeColor = Color.Black;
            btnCookie.Location = new Point(100, 107);
            btnCookie.Name = "btnCookie";
            btnCookie.Size = new Size(150, 150);
            btnCookie.TabIndex = 0;
            btnCookie.Text = "Cookie";
            btnCookie.UseVisualStyleBackColor = false;
            btnCookie.Click += btnCookie_Click;
            lblCookies.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCookies.Location = new Point(100, 45);
            lblCookies.Name = "lblCookies";
            lblCookies.Size = new Size(200, 40);
            lblCookies.TabIndex = 1;
            lblCookies.Text = "Cookies: 0";
            btnOpenUpgrade.BackColor = Color.LightBlue;
            btnOpenUpgrade.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            btnOpenUpgrade.Location = new Point(76, 274);
            btnOpenUpgrade.Name = "btnOpenUpgrade";
            btnOpenUpgrade.Size = new Size(200, 50);
            btnOpenUpgrade.TabIndex = 2;
            btnOpenUpgrade.Text = "Shop";
            btnOpenUpgrade.UseVisualStyleBackColor = false;
            btnOpenUpgrade.Click += btnOpenUpgrade_Click;
            ClientSize = new Size(400, 400);
            Controls.Add(btnCookie);
            Controls.Add(lblCookies);
            Controls.Add(btnOpenUpgrade);
            Name = "Form1";
            Text = "Cookie Clicker";
            ResumeLayout(false);
        }
    }
}
