
namespace BoatRentingDesktopApplication
{
    partial class CouponFormEditPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRemoveCoupon = new System.Windows.Forms.Button();
            this.btnEditCoupon = new System.Windows.Forms.Button();
            this.grpbxExclusiveCoupon = new System.Windows.Forms.GroupBox();
            this.nudCustomerID = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.grpbxLimitedCoupon = new System.Windows.Forms.GroupBox();
            this.nudRemainingUses = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudTotalUses = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.grpbxTimeCoupon = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCouponType = new System.Windows.Forms.ComboBox();
            this.tbxDiscount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCouponCode = new System.Windows.Forms.TextBox();
            this.grpbxExclusiveCoupon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomerID)).BeginInit();
            this.grpbxLimitedCoupon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemainingUses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalUses)).BeginInit();
            this.grpbxTimeCoupon.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemoveCoupon
            // 
            this.btnRemoveCoupon.Location = new System.Drawing.Point(182, 355);
            this.btnRemoveCoupon.Name = "btnRemoveCoupon";
            this.btnRemoveCoupon.Size = new System.Drawing.Size(104, 30);
            this.btnRemoveCoupon.TabIndex = 26;
            this.btnRemoveCoupon.Text = "Remove Coupon";
            this.btnRemoveCoupon.UseVisualStyleBackColor = true;
            this.btnRemoveCoupon.Click += new System.EventHandler(this.btnRemoveCoupon_Click);
            // 
            // btnEditCoupon
            // 
            this.btnEditCoupon.Location = new System.Drawing.Point(500, 355);
            this.btnEditCoupon.Name = "btnEditCoupon";
            this.btnEditCoupon.Size = new System.Drawing.Size(88, 30);
            this.btnEditCoupon.TabIndex = 25;
            this.btnEditCoupon.Text = "Edit Coupon";
            this.btnEditCoupon.UseVisualStyleBackColor = true;
            this.btnEditCoupon.Click += new System.EventHandler(this.btnEditCoupon_Click);
            // 
            // grpbxExclusiveCoupon
            // 
            this.grpbxExclusiveCoupon.Controls.Add(this.nudCustomerID);
            this.grpbxExclusiveCoupon.Controls.Add(this.label6);
            this.grpbxExclusiveCoupon.Location = new System.Drawing.Point(578, 221);
            this.grpbxExclusiveCoupon.Name = "grpbxExclusiveCoupon";
            this.grpbxExclusiveCoupon.Size = new System.Drawing.Size(196, 86);
            this.grpbxExclusiveCoupon.TabIndex = 23;
            this.grpbxExclusiveCoupon.TabStop = false;
            this.grpbxExclusiveCoupon.Text = "Exclusive Coupon";
            // 
            // nudCustomerID
            // 
            this.nudCustomerID.Location = new System.Drawing.Point(82, 28);
            this.nudCustomerID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCustomerID.Name = "nudCustomerID";
            this.nudCustomerID.Size = new System.Drawing.Size(99, 23);
            this.nudCustomerID.TabIndex = 9;
            this.nudCustomerID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Customer ID";
            // 
            // grpbxLimitedCoupon
            // 
            this.grpbxLimitedCoupon.Controls.Add(this.nudRemainingUses);
            this.grpbxLimitedCoupon.Controls.Add(this.label7);
            this.grpbxLimitedCoupon.Controls.Add(this.nudTotalUses);
            this.grpbxLimitedCoupon.Controls.Add(this.label5);
            this.grpbxLimitedCoupon.Location = new System.Drawing.Point(298, 221);
            this.grpbxLimitedCoupon.Name = "grpbxLimitedCoupon";
            this.grpbxLimitedCoupon.Size = new System.Drawing.Size(204, 92);
            this.grpbxLimitedCoupon.TabIndex = 22;
            this.grpbxLimitedCoupon.TabStop = false;
            this.grpbxLimitedCoupon.Text = "Limited Coupon";
            // 
            // nudRemainingUses
            // 
            this.nudRemainingUses.Location = new System.Drawing.Point(94, 57);
            this.nudRemainingUses.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRemainingUses.Name = "nudRemainingUses";
            this.nudRemainingUses.Size = new System.Drawing.Size(99, 23);
            this.nudRemainingUses.TabIndex = 10;
            this.nudRemainingUses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Remaining Uses";
            // 
            // nudTotalUses
            // 
            this.nudTotalUses.Location = new System.Drawing.Point(94, 28);
            this.nudTotalUses.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTotalUses.Name = "nudTotalUses";
            this.nudTotalUses.Size = new System.Drawing.Size(99, 23);
            this.nudTotalUses.TabIndex = 8;
            this.nudTotalUses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Uses";
            // 
            // grpbxTimeCoupon
            // 
            this.grpbxTimeCoupon.Controls.Add(this.dtpEndDate);
            this.grpbxTimeCoupon.Controls.Add(this.label4);
            this.grpbxTimeCoupon.Location = new System.Drawing.Point(26, 221);
            this.grpbxTimeCoupon.Name = "grpbxTimeCoupon";
            this.grpbxTimeCoupon.Size = new System.Drawing.Size(222, 86);
            this.grpbxTimeCoupon.TabIndex = 21;
            this.grpbxTimeCoupon.TabStop = false;
            this.grpbxTimeCoupon.Text = "Time Coupon";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(63, 30);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(137, 23);
            this.dtpEndDate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "EndDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Type";
            // 
            // cbxCouponType
            // 
            this.cbxCouponType.FormattingEnabled = true;
            this.cbxCouponType.Location = new System.Drawing.Point(347, 149);
            this.cbxCouponType.Name = "cbxCouponType";
            this.cbxCouponType.Size = new System.Drawing.Size(134, 23);
            this.cbxCouponType.TabIndex = 19;
            // 
            // tbxDiscount
            // 
            this.tbxDiscount.Location = new System.Drawing.Point(347, 104);
            this.tbxDiscount.Name = "tbxDiscount";
            this.tbxDiscount.Size = new System.Drawing.Size(134, 23);
            this.tbxDiscount.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Discount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Code";
            // 
            // tbxCouponCode
            // 
            this.tbxCouponCode.Location = new System.Drawing.Point(347, 66);
            this.tbxCouponCode.Name = "tbxCouponCode";
            this.tbxCouponCode.ReadOnly = true;
            this.tbxCouponCode.Size = new System.Drawing.Size(134, 23);
            this.tbxCouponCode.TabIndex = 15;
            // 
            // CouponFormEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveCoupon);
            this.Controls.Add(this.btnEditCoupon);
            this.Controls.Add(this.grpbxExclusiveCoupon);
            this.Controls.Add(this.grpbxLimitedCoupon);
            this.Controls.Add(this.grpbxTimeCoupon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxCouponType);
            this.Controls.Add(this.tbxDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxCouponCode);
            this.Name = "CouponFormEditPage";
            this.Text = "CouponFormEditPage";
            this.grpbxExclusiveCoupon.ResumeLayout(false);
            this.grpbxExclusiveCoupon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomerID)).EndInit();
            this.grpbxLimitedCoupon.ResumeLayout(false);
            this.grpbxLimitedCoupon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemainingUses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalUses)).EndInit();
            this.grpbxTimeCoupon.ResumeLayout(false);
            this.grpbxTimeCoupon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveCoupon;
        private System.Windows.Forms.Button btnEditCoupon;
        private System.Windows.Forms.GroupBox grpbxExclusiveCoupon;
        private System.Windows.Forms.NumericUpDown nudCustomerID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpbxLimitedCoupon;
        private System.Windows.Forms.NumericUpDown nudTotalUses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpbxTimeCoupon;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCouponType;
        private System.Windows.Forms.TextBox tbxDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCouponCode;
        private System.Windows.Forms.NumericUpDown nudRemainingUses;
        private System.Windows.Forms.Label label7;
    }
}