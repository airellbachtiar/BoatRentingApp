
namespace BoatRentingDesktopApplication
{
    partial class CouponPage
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
            this.dgvCouponList = new System.Windows.Forms.DataGridView();
            this.btnAddCoupon = new System.Windows.Forms.Button();
            this.btnEditCoupon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCouponList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCouponList
            // 
            this.dgvCouponList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCouponList.Location = new System.Drawing.Point(103, 60);
            this.dgvCouponList.Name = "dgvCouponList";
            this.dgvCouponList.ReadOnly = true;
            this.dgvCouponList.RowTemplate.Height = 25;
            this.dgvCouponList.Size = new System.Drawing.Size(487, 338);
            this.dgvCouponList.TabIndex = 0;
            // 
            // btnAddCoupon
            // 
            this.btnAddCoupon.Location = new System.Drawing.Point(619, 362);
            this.btnAddCoupon.Name = "btnAddCoupon";
            this.btnAddCoupon.Size = new System.Drawing.Size(86, 36);
            this.btnAddCoupon.TabIndex = 1;
            this.btnAddCoupon.Text = "Add Coupon";
            this.btnAddCoupon.UseVisualStyleBackColor = true;
            this.btnAddCoupon.Click += new System.EventHandler(this.btnAddCoupon_Click);
            // 
            // btnEditCoupon
            // 
            this.btnEditCoupon.Location = new System.Drawing.Point(619, 320);
            this.btnEditCoupon.Name = "btnEditCoupon";
            this.btnEditCoupon.Size = new System.Drawing.Size(86, 36);
            this.btnEditCoupon.TabIndex = 2;
            this.btnEditCoupon.Text = "Edit Coupon";
            this.btnEditCoupon.UseVisualStyleBackColor = true;
            this.btnEditCoupon.Click += new System.EventHandler(this.btnEditCoupon_Click);
            // 
            // CouponPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditCoupon);
            this.Controls.Add(this.btnAddCoupon);
            this.Controls.Add(this.dgvCouponList);
            this.Name = "CouponPage";
            this.Text = "CouponPage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCouponList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCouponList;
        private System.Windows.Forms.Button btnAddCoupon;
        private System.Windows.Forms.Button btnEditCoupon;
    }
}