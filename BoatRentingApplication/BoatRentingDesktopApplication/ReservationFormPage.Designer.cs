
namespace BoatRentingDesktopApplication
{
    partial class ReservationFormPage
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
            this.grpbxRentedItems = new System.Windows.Forms.GroupBox();
            this.dgvRentedItems = new System.Windows.Forms.DataGridView();
            this.grpbxEditReservation = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.nudTotalDeposit = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.btnCheckDiscount = new System.Windows.Forms.Button();
            this.tbxDiscount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.nudActualPrice = new System.Windows.Forms.NumericUpDown();
            this.nudDamagePrice = new System.Windows.Forms.NumericUpDown();
            this.tbxCoupon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nudTotalPrice = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDateCreated = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxLocation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxReferenceNumber = new System.Windows.Forms.TextBox();
            this.tbxUserID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudHouseNumber = new System.Windows.Forms.NumericUpDown();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxZipcode = new System.Windows.Forms.TextBox();
            this.tbxStreetName = new System.Windows.Forms.TextBox();
            this.btnSaveReservation = new System.Windows.Forms.Button();
            this.btnRemoveReservation = new System.Windows.Forms.Button();
            this.grpbxRentedItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedItems)).BeginInit();
            this.grpbxEditReservation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudActualPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDamagePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalPrice)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHouseNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxRentedItems
            // 
            this.grpbxRentedItems.Controls.Add(this.dgvRentedItems);
            this.grpbxRentedItems.Location = new System.Drawing.Point(12, 12);
            this.grpbxRentedItems.Name = "grpbxRentedItems";
            this.grpbxRentedItems.Size = new System.Drawing.Size(408, 211);
            this.grpbxRentedItems.TabIndex = 16;
            this.grpbxRentedItems.TabStop = false;
            this.grpbxRentedItems.Text = "Rented Items";
            // 
            // dgvRentedItems
            // 
            this.dgvRentedItems.AllowUserToAddRows = false;
            this.dgvRentedItems.AllowUserToDeleteRows = false;
            this.dgvRentedItems.AllowUserToOrderColumns = true;
            this.dgvRentedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentedItems.Location = new System.Drawing.Point(17, 24);
            this.dgvRentedItems.Name = "dgvRentedItems";
            this.dgvRentedItems.ReadOnly = true;
            this.dgvRentedItems.RowTemplate.Height = 25;
            this.dgvRentedItems.Size = new System.Drawing.Size(372, 165);
            this.dgvRentedItems.TabIndex = 0;
            // 
            // grpbxEditReservation
            // 
            this.grpbxEditReservation.Controls.Add(this.groupBox2);
            this.grpbxEditReservation.Controls.Add(this.groupBox1);
            this.grpbxEditReservation.Location = new System.Drawing.Point(456, 12);
            this.grpbxEditReservation.Name = "grpbxEditReservation";
            this.grpbxEditReservation.Size = new System.Drawing.Size(311, 435);
            this.grpbxEditReservation.TabIndex = 17;
            this.grpbxEditReservation.TabStop = false;
            this.grpbxEditReservation.Text = "Edit Reservation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxStatus);
            this.groupBox2.Controls.Add(this.nudTotalDeposit);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.btnCheckDiscount);
            this.groupBox2.Controls.Add(this.tbxDiscount);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.nudActualPrice);
            this.groupBox2.Controls.Add(this.nudDamagePrice);
            this.groupBox2.Controls.Add(this.tbxCoupon);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.nudTotalPrice);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(6, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 217);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Misc.";
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(94, 16);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(135, 23);
            this.cbxStatus.TabIndex = 26;
            // 
            // nudTotalDeposit
            // 
            this.nudTotalDeposit.DecimalPlaces = 2;
            this.nudTotalDeposit.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTotalDeposit.Location = new System.Drawing.Point(94, 73);
            this.nudTotalDeposit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTotalDeposit.Name = "nudTotalDeposit";
            this.nudTotalDeposit.ReadOnly = true;
            this.nudTotalDeposit.Size = new System.Drawing.Size(100, 23);
            this.nudTotalDeposit.TabIndex = 25;
            this.nudTotalDeposit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 15);
            this.label18.TabIndex = 24;
            this.label18.Text = "Total Deposit";
            // 
            // btnCheckDiscount
            // 
            this.btnCheckDiscount.Location = new System.Drawing.Point(211, 175);
            this.btnCheckDiscount.Name = "btnCheckDiscount";
            this.btnCheckDiscount.Size = new System.Drawing.Size(59, 23);
            this.btnCheckDiscount.TabIndex = 23;
            this.btnCheckDiscount.Text = "Check";
            this.btnCheckDiscount.UseVisualStyleBackColor = true;
            this.btnCheckDiscount.Click += new System.EventHandler(this.btnCheckDiscount_Click);
            // 
            // tbxDiscount
            // 
            this.tbxDiscount.Location = new System.Drawing.Point(94, 189);
            this.tbxDiscount.Name = "tbxDiscount";
            this.tbxDiscount.ReadOnly = true;
            this.tbxDiscount.Size = new System.Drawing.Size(100, 23);
            this.tbxDiscount.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 192);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 15);
            this.label17.TabIndex = 21;
            this.label17.Text = "Discount";
            // 
            // nudActualPrice
            // 
            this.nudActualPrice.DecimalPlaces = 2;
            this.nudActualPrice.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudActualPrice.Location = new System.Drawing.Point(94, 131);
            this.nudActualPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudActualPrice.Name = "nudActualPrice";
            this.nudActualPrice.ReadOnly = true;
            this.nudActualPrice.Size = new System.Drawing.Size(100, 23);
            this.nudActualPrice.TabIndex = 20;
            this.nudActualPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDamagePrice
            // 
            this.nudDamagePrice.DecimalPlaces = 2;
            this.nudDamagePrice.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDamagePrice.Location = new System.Drawing.Point(94, 99);
            this.nudDamagePrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDamagePrice.Name = "nudDamagePrice";
            this.nudDamagePrice.Size = new System.Drawing.Size(100, 23);
            this.nudDamagePrice.TabIndex = 19;
            this.nudDamagePrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbxCoupon
            // 
            this.tbxCoupon.Location = new System.Drawing.Point(94, 160);
            this.tbxCoupon.Name = "tbxCoupon";
            this.tbxCoupon.Size = new System.Drawing.Size(100, 23);
            this.tbxCoupon.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Coupon";
            // 
            // nudTotalPrice
            // 
            this.nudTotalPrice.DecimalPlaces = 2;
            this.nudTotalPrice.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTotalPrice.Location = new System.Drawing.Point(94, 45);
            this.nudTotalPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTotalPrice.Name = "nudTotalPrice";
            this.nudTotalPrice.ReadOnly = true;
            this.nudTotalPrice.Size = new System.Drawing.Size(100, 23);
            this.nudTotalPrice.TabIndex = 18;
            this.nudTotalPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "Status";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 15);
            this.label14.TabIndex = 13;
            this.label14.Text = "Total Price";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 15);
            this.label15.TabIndex = 14;
            this.label15.Text = "Damage Price";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 133);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 15);
            this.label16.TabIndex = 15;
            this.label16.Text = "Actual Price";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.nudDuration);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpDateCreated);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbxLocation);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbxReferenceNumber);
            this.groupBox1.Controls.Add(this.tbxUserID);
            this.groupBox1.Location = new System.Drawing.Point(6, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 189);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Info";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "User ID";
            // 
            // nudDuration
            // 
            this.nudDuration.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDuration.Location = new System.Drawing.Point(129, 130);
            this.nudDuration.Maximum = new decimal(new int[] {
            336,
            0,
            0,
            0});
            this.nudDuration.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(100, 23);
            this.nudDuration.TabIndex = 22;
            this.nudDuration.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reference Number";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(128, 99);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(142, 23);
            this.dtpStartDate.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Start Date";
            // 
            // dtpDateCreated
            // 
            this.dtpDateCreated.Enabled = false;
            this.dtpDateCreated.Location = new System.Drawing.Point(128, 74);
            this.dtpDateCreated.Name = "dtpDateCreated";
            this.dtpDateCreated.Size = new System.Drawing.Size(142, 23);
            this.dtpDateCreated.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date Created";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Location";
            // 
            // tbxLocation
            // 
            this.tbxLocation.Location = new System.Drawing.Point(129, 155);
            this.tbxLocation.Name = "tbxLocation";
            this.tbxLocation.Size = new System.Drawing.Size(100, 23);
            this.tbxLocation.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Duration";
            // 
            // tbxReferenceNumber
            // 
            this.tbxReferenceNumber.Location = new System.Drawing.Point(129, 45);
            this.tbxReferenceNumber.Name = "tbxReferenceNumber";
            this.tbxReferenceNumber.ReadOnly = true;
            this.tbxReferenceNumber.Size = new System.Drawing.Size(100, 23);
            this.tbxReferenceNumber.TabIndex = 17;
            // 
            // tbxUserID
            // 
            this.tbxUserID.Location = new System.Drawing.Point(129, 16);
            this.tbxUserID.Name = "tbxUserID";
            this.tbxUserID.ReadOnly = true;
            this.tbxUserID.Size = new System.Drawing.Size(100, 23);
            this.tbxUserID.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "House Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zipcode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Street Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone Number";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudHouseNumber);
            this.groupBox3.Controls.Add(this.tbxPhoneNumber);
            this.groupBox3.Controls.Add(this.tbxCity);
            this.groupBox3.Controls.Add(this.tbxZipcode);
            this.groupBox3.Controls.Add(this.tbxStreetName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 167);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contact";
            // 
            // nudHouseNumber
            // 
            this.nudHouseNumber.Location = new System.Drawing.Point(105, 78);
            this.nudHouseNumber.Name = "nudHouseNumber";
            this.nudHouseNumber.Size = new System.Drawing.Size(153, 23);
            this.nudHouseNumber.TabIndex = 21;
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(105, 136);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(153, 23);
            this.tbxPhoneNumber.TabIndex = 20;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(105, 107);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(153, 23);
            this.tbxCity.TabIndex = 19;
            // 
            // tbxZipcode
            // 
            this.tbxZipcode.Location = new System.Drawing.Point(105, 49);
            this.tbxZipcode.Name = "tbxZipcode";
            this.tbxZipcode.Size = new System.Drawing.Size(153, 23);
            this.tbxZipcode.TabIndex = 18;
            // 
            // tbxStreetName
            // 
            this.tbxStreetName.Location = new System.Drawing.Point(105, 20);
            this.tbxStreetName.Name = "tbxStreetName";
            this.tbxStreetName.Size = new System.Drawing.Size(153, 23);
            this.tbxStreetName.TabIndex = 17;
            // 
            // btnSaveReservation
            // 
            this.btnSaveReservation.Location = new System.Drawing.Point(201, 409);
            this.btnSaveReservation.Name = "btnSaveReservation";
            this.btnSaveReservation.Size = new System.Drawing.Size(75, 36);
            this.btnSaveReservation.TabIndex = 19;
            this.btnSaveReservation.Text = "Save";
            this.btnSaveReservation.UseVisualStyleBackColor = true;
            this.btnSaveReservation.Click += new System.EventHandler(this.btnSaveReservation_Click);
            // 
            // btnRemoveReservation
            // 
            this.btnRemoveReservation.Location = new System.Drawing.Point(12, 409);
            this.btnRemoveReservation.Name = "btnRemoveReservation";
            this.btnRemoveReservation.Size = new System.Drawing.Size(75, 36);
            this.btnRemoveReservation.TabIndex = 20;
            this.btnRemoveReservation.Text = "Remove";
            this.btnRemoveReservation.UseVisualStyleBackColor = true;
            this.btnRemoveReservation.Click += new System.EventHandler(this.btnRemoveReservation_Click);
            // 
            // ReservationFormPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveReservation);
            this.Controls.Add(this.btnSaveReservation);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpbxEditReservation);
            this.Controls.Add(this.grpbxRentedItems);
            this.Name = "ReservationFormPage";
            this.Text = "ReservationFormPage";
            this.grpbxRentedItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedItems)).EndInit();
            this.grpbxEditReservation.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudActualPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDamagePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalPrice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHouseNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxRentedItems;
        private System.Windows.Forms.DataGridView dgvRentedItems;
        private System.Windows.Forms.GroupBox grpbxEditReservation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpDateCreated;
        private System.Windows.Forms.TextBox tbxLocation;
        private System.Windows.Forms.TextBox tbxReferenceNumber;
        private System.Windows.Forms.TextBox tbxUserID;
        private System.Windows.Forms.TextBox tbxCoupon;
        private System.Windows.Forms.Button btnCheckDiscount;
        private System.Windows.Forms.TextBox tbxDiscount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nudActualPrice;
        private System.Windows.Forms.NumericUpDown nudDamagePrice;
        private System.Windows.Forms.NumericUpDown nudTotalPrice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudHouseNumber;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxZipcode;
        private System.Windows.Forms.TextBox tbxStreetName;
        private System.Windows.Forms.Button btnSaveReservation;
        private System.Windows.Forms.Button btnRemoveReservation;
        private System.Windows.Forms.NumericUpDown nudTotalDeposit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbxStatus;
    }
}