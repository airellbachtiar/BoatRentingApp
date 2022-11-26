
namespace BoatRentingDesktopApplication
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.pnlPage = new System.Windows.Forms.Panel();
            this.btnItemPage = new System.Windows.Forms.Button();
            this.btnReservationPage = new System.Windows.Forms.Button();
            this.btnCouponPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(750, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(78, 38);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(750, 56);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(78, 38);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(666, 35);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(78, 38);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // pnlPage
            // 
            this.pnlPage.Location = new System.Drawing.Point(12, 115);
            this.pnlPage.Name = "pnlPage";
            this.pnlPage.Size = new System.Drawing.Size(816, 489);
            this.pnlPage.TabIndex = 3;
            // 
            // btnItemPage
            // 
            this.btnItemPage.Location = new System.Drawing.Point(118, 35);
            this.btnItemPage.Name = "btnItemPage";
            this.btnItemPage.Size = new System.Drawing.Size(78, 38);
            this.btnItemPage.TabIndex = 4;
            this.btnItemPage.Text = "Items";
            this.btnItemPage.UseVisualStyleBackColor = true;
            this.btnItemPage.Click += new System.EventHandler(this.btnItemPage_Click);
            // 
            // btnReservationPage
            // 
            this.btnReservationPage.Location = new System.Drawing.Point(254, 35);
            this.btnReservationPage.Name = "btnReservationPage";
            this.btnReservationPage.Size = new System.Drawing.Size(83, 38);
            this.btnReservationPage.TabIndex = 5;
            this.btnReservationPage.Text = "Reservations";
            this.btnReservationPage.UseVisualStyleBackColor = true;
            this.btnReservationPage.Click += new System.EventHandler(this.btnReservationPage_Click);
            // 
            // btnCouponPage
            // 
            this.btnCouponPage.Location = new System.Drawing.Point(394, 35);
            this.btnCouponPage.Name = "btnCouponPage";
            this.btnCouponPage.Size = new System.Drawing.Size(78, 38);
            this.btnCouponPage.TabIndex = 6;
            this.btnCouponPage.Text = "Coupons";
            this.btnCouponPage.UseVisualStyleBackColor = true;
            this.btnCouponPage.Click += new System.EventHandler(this.btnCouponPage_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 621);
            this.Controls.Add(this.btnCouponPage);
            this.Controls.Add(this.btnReservationPage);
            this.Controls.Add(this.btnItemPage);
            this.Controls.Add(this.pnlPage);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnLogout);
            this.Name = "HomePage";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel pnlPage;
        private System.Windows.Forms.Button btnItemPage;
        private System.Windows.Forms.Button btnReservationPage;
        private System.Windows.Forms.Button btnCouponPage;
    }
}

