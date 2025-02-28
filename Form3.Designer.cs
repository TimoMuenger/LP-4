namespace CookieClicker
{
    partial class FormUpgrade
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnUpgrade1;
        private System.Windows.Forms.Label lblUpgrade1;
        private System.Windows.Forms.Button btnUpgrade2;
        private System.Windows.Forms.Label lblUpgrade2;
        private System.Windows.Forms.Button btnUpgrade3;
        private System.Windows.Forms.Label lblUpgrade3;

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
            this.btnUpgrade1 = new System.Windows.Forms.Button();
            this.lblUpgrade1 = new System.Windows.Forms.Label();
            this.btnUpgrade2 = new System.Windows.Forms.Button();
            this.lblUpgrade2 = new System.Windows.Forms.Label();
            this.btnUpgrade3 = new System.Windows.Forms.Button();
            this.lblUpgrade3 = new System.Windows.Forms.Label();
            this.SuspendLayout();


            this.lblUpgrade1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblUpgrade1.Location = new System.Drawing.Point(20, 20);
            this.lblUpgrade1.Size = new System.Drawing.Size(250, 30);
            this.lblUpgrade1.Text = "Upgrade 1: 2 Cookies/Klick (10 Cookies)";

            this.btnUpgrade1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpgrade1.BackColor = System.Drawing.Color.LightGreen;
            this.btnUpgrade1.Location = new System.Drawing.Point(280, 20);
            this.btnUpgrade1.Size = new System.Drawing.Size(100, 30);
            this.btnUpgrade1.Text = "Kaufen";
            this.btnUpgrade1.UseVisualStyleBackColor = false;
            this.btnUpgrade1.Click += new System.EventHandler(this.btnUpgrade1_Click);


            this.lblUpgrade2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblUpgrade2.Location = new System.Drawing.Point(20, 60);
            this.lblUpgrade2.Size = new System.Drawing.Size(250, 30);
            this.lblUpgrade2.Text = "Upgrade 2: 4 Cookies/Klick (50 Cookies)";

            this.btnUpgrade2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpgrade2.BackColor = System.Drawing.Color.Orange;
            this.btnUpgrade2.Location = new System.Drawing.Point(280, 60);
            this.btnUpgrade2.Size = new System.Drawing.Size(100, 30);
            this.btnUpgrade2.Text = "Kaufen";
            this.btnUpgrade2.UseVisualStyleBackColor = false;
            this.btnUpgrade2.Click += new System.EventHandler(this.btnUpgrade2_Click);

            this.lblUpgrade3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblUpgrade3.Location = new System.Drawing.Point(20, 100);
            this.lblUpgrade3.Size = new System.Drawing.Size(250, 30);
            this.lblUpgrade3.Text = "Upgrade 3: 10 Cookies/Klick (200 Cookies)";

            this.btnUpgrade3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpgrade3.BackColor = System.Drawing.Color.Red;
            this.btnUpgrade3.Location = new System.Drawing.Point(280, 100);
            this.btnUpgrade3.Size = new System.Drawing.Size(100, 30);
            this.btnUpgrade3.Text = "Kaufen";
            this.btnUpgrade3.UseVisualStyleBackColor = false;
            this.btnUpgrade3.Click += new System.EventHandler(this.btnUpgrade3_Click);


            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.lblUpgrade1);
            this.Controls.Add(this.btnUpgrade1);
            this.Controls.Add(this.lblUpgrade2);
            this.Controls.Add(this.btnUpgrade2);
            this.Controls.Add(this.lblUpgrade3);
            this.Controls.Add(this.btnUpgrade3);
            this.Text = "Upgrade Shop";
            this.ResumeLayout(false);
        }
    }
}
