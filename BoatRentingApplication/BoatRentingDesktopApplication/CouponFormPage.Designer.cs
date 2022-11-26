
namespace BoatRentingDesktopApplication
{
    partial class CouponFormPage
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
            this.tbxCouponCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDiscount = new System.Windows.Forms.TextBox();
            this.cbxCouponType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpbxTimeCoupon = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.grpbxLimitedCoupon = new System.Windows.Forms.GroupBox();
            this.nudTotalUses = new System.Windows.Forms.NumericUpDown();
            this.grpbxExclusiveCoupon = new System.Windows.Forms.GroupBox();
            this.nudCustomerID = new System.Windows.Forms.NumericUpDown();
            this.btnAddCoupon = new System.Windows.Forms.Button();
            this.grpbxTimeCoupon.SuspendLayout();
            this.grpbxLimitedCoupon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalUses)).BeginInit();
            this.grpbxExclusiveCoupon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomerID)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxCouponCode
            // 
            this.tbxCouponCode.Location = new System.Drawing.Point(344, 88);
            this.tbxCouponCode.Name = "tbxCouponCode";
            this.tbxCouponCode.Size = new System.Drawing.Size(134, 23);
            this.tbxCouponCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Discount";
            // 
            // tbxDiscount
            // 
            this.tbxDiscount.Location = new System.Drawing.Point(344, 126);
            this.tbxDiscount.Name = "tbxDiscount";
            this.tbxDiscount.Size = new System.Drawing.Size(134, 23);
            this.tbxDiscount.TabIndex = 3;
            // 
            // cbxCouponType
            // 
            this.cbxCouponType.FormattingEnabled = true;
            this.cbxCouponType.Location = new System.Drawing.Point(344, 171);
            this.cbxCouponType.Name = "cbxCouponType";
            this.cbxCouponType.Size = new System.Drawing.Size(134, 23);
            this.cbxCouponType.TabIndex = 4;
            this.cbxCouponType.SelectedIndexChanged += new System.EventHandler(this.cbxCouponType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Uses";
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
            // grpbxTimeCoupon
            // 
            this.grpbxTimeCoupon.Controls.Add(this.dtpEndDate);
            this.grpbxTimeCoupon.Controls.Add(this.label4);
            this.grpbxTimeCoupon.Location = new System.Drawing.Point(23, 243);
            this.grpbxTimeCoupon.Name = "grpbxTimeCoupon";
            this.grpbxTimeCoupon.Size = new System.Drawing.Size(222, 86);
            this.grpbxTimeCoupon.TabIndex = 9;
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
            // grpbxLimitedCoupon
            // 
            this.grpbxLimitedCoupon.Controls.Add(this.nudTotalUses);
            this.grpbxLimitedCoupon.Controls.Add(this.label5);
            this.grpbxLimitedCoupon.Location = new System.Drawing.Point(308, 243);
            this.grpbxLimitedCoupon.Name = "grpbxLimitedCoupon";
            this.grpbxLimitedCoupon.Size = new System.Drawing.Size(191, 86);
            this.grpbxLimitedCoupon.TabIndex = 10;
            this.grpbxLimitedCoupon.TabStop = false;
            this.grpbxLimitedCoupon.Text = "Limited Coupon";
            // 
            // nudTotalUses
            // 
            this.nudTotalUses.Location = new System.Drawing.Point(71, 28);
            this.nudTotalUses.Minimum = new decimal(new int[] {
            1,
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
            // grpbxExclusiveCoupon
            // 
            this.grpbxExclusiveCoupon.Controls.Add(this.nudCustomerID);
            this.grpbxExclusiveCoupon.Controls.Add(this.label6);
            this.grpbxExclusiveCoupon.Location = new System.Drawing.Point(575, 243);
            this.grpbxExclusiveCoupon.Name = "grpbxExclusiveCoupon";
            this.grpbxExclusiveCoupon.Size = new System.Drawing.Size(196, 86);
            this.grpbxExclusiveCoupon.TabIndex = 11;
            this.grpbxExclusiveCoupon.TabStop = false;
            this.grpbxExclusiveCoupon.Text = "Exclusive Coupon";
            // 
            // nudCustomerID
            // 
            this.nudCustomerID.Location = new System.Drawing.Point(82, 28);
            this.nudCustomerID.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
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
            // btnAddCoupon
            // 
            this.btnAddCoupon.Location = new System.Drawing.Point(365, 377);
            this.btnAddCoupon.Name = "btnAddCoupon";
            this.btnAddCoupon.Size = new System.Drawing.Size(88, 30);
            this.btnAddCoupon.TabIndex = 12;
            this.btnAddCoupon.Text = "Add Coupon";
            this.btnAddCoupon.UseVisualStyleBackColor = true;
            this.btnAddCoupon.Click += new System.EventHandler(this.btnAddCoupon_Click);
            // 
            // CouponFormPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddCoupon);
            this.Controls.Add(this.grpbxExclusiveCoupon);
            this.Controls.Add(this.grpbxLimitedCoupon);
            this.Controls.Add(this.grpbxTimeCoupon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxCouponType);
            this.Controls.Add(this.tbxDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxCouponCode);
            this.Name = "CouponFormPage";
            this.Text = "CouponFormPage";
            this.grpbxTimeCoupon.ResumeLayout(false);
            this.grpbxTimeCoupon.PerformLayout();
            this.grpbxLimitedCoupon.ResumeLayout(false);
            this.grpbxLimitedCoupon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalUses)).EndInit();
            this.grpbxExclusiveCoupon.ResumeLayout(false);
            this.grpbxExclusiveCoupon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomerID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxCouponCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDiscount;
        private System.Windows.Forms.ComboBox cbxCouponType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpbxTimeCoupon;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.GroupBox grpbxLimitedCoupon;
        private System.Windows.Forms.NumericUpDown nudTotalUses;
        private System.Windows.Forms.GroupBox grpbxExclusiveCoupon;
        private System.Windows.Forms.NumericUpDown nudCustomerID;
        private System.Windows.Forms.Button btnAddCoupon;
    }
}