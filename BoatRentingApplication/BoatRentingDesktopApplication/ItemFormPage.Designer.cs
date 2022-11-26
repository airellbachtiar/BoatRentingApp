
namespace BoatRentingDesktopApplication
{
    partial class ItemFormPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chbxIsBoat = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudBoatCapacity = new System.Windows.Forms.NumericUpDown();
            this.tbxItemName = new System.Windows.Forms.TextBox();
            this.rtbxItemDescription = new System.Windows.Forms.RichTextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudItemCost = new System.Windows.Forms.NumericUpDown();
            this.nudItemDeposit = new System.Windows.Forms.NumericUpDown();
            this.chbxIsBoatItem = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudInventoryAmount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddInventory = new System.Windows.Forms.Button();
            this.cbxItemList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoatCapacity)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemDeposit)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInventoryAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Deposit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Capacity";
            // 
            // chbxIsBoat
            // 
            this.chbxIsBoat.AutoSize = true;
            this.chbxIsBoat.Enabled = false;
            this.chbxIsBoat.Location = new System.Drawing.Point(82, 96);
            this.chbxIsBoat.Name = "chbxIsBoat";
            this.chbxIsBoat.Size = new System.Drawing.Size(50, 19);
            this.chbxIsBoat.TabIndex = 5;
            this.chbxIsBoat.Text = "Boat";
            this.chbxIsBoat.UseVisualStyleBackColor = true;
            this.chbxIsBoat.CheckedChanged += new System.EventHandler(this.chbxIsBoat_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudBoatCapacity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(0, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 68);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boat Information";
            // 
            // nudBoatCapacity
            // 
            this.nudBoatCapacity.Location = new System.Drawing.Point(82, 30);
            this.nudBoatCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBoatCapacity.Name = "nudBoatCapacity";
            this.nudBoatCapacity.Size = new System.Drawing.Size(127, 23);
            this.nudBoatCapacity.TabIndex = 15;
            this.nudBoatCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbxItemName
            // 
            this.tbxItemName.Location = new System.Drawing.Point(79, 16);
            this.tbxItemName.Name = "tbxItemName";
            this.tbxItemName.Size = new System.Drawing.Size(127, 23);
            this.tbxItemName.TabIndex = 7;
            // 
            // rtbxItemDescription
            // 
            this.rtbxItemDescription.Location = new System.Drawing.Point(79, 134);
            this.rtbxItemDescription.Name = "rtbxItemDescription";
            this.rtbxItemDescription.Size = new System.Drawing.Size(127, 74);
            this.rtbxItemDescription.TabIndex = 10;
            this.rtbxItemDescription.Text = "";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(130, 224);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(76, 34);
            this.btnAddItem.TabIndex = 11;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudItemCost);
            this.groupBox2.Controls.Add(this.nudItemDeposit);
            this.groupBox2.Controls.Add(this.chbxIsBoatItem);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnAddItem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rtbxItemDescription);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbxItemName);
            this.groupBox2.Location = new System.Drawing.Point(106, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 272);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Item";
            // 
            // nudItemCost
            // 
            this.nudItemCost.DecimalPlaces = 2;
            this.nudItemCost.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudItemCost.Location = new System.Drawing.Point(79, 55);
            this.nudItemCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudItemCost.Name = "nudItemCost";
            this.nudItemCost.Size = new System.Drawing.Size(127, 23);
            this.nudItemCost.TabIndex = 15;
            this.nudItemCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudItemDeposit
            // 
            this.nudItemDeposit.DecimalPlaces = 2;
            this.nudItemDeposit.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudItemDeposit.Location = new System.Drawing.Point(79, 93);
            this.nudItemDeposit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudItemDeposit.Name = "nudItemDeposit";
            this.nudItemDeposit.Size = new System.Drawing.Size(127, 23);
            this.nudItemDeposit.TabIndex = 16;
            this.nudItemDeposit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chbxIsBoatItem
            // 
            this.chbxIsBoatItem.AutoSize = true;
            this.chbxIsBoatItem.Location = new System.Drawing.Point(6, 214);
            this.chbxIsBoatItem.Name = "chbxIsBoatItem";
            this.chbxIsBoatItem.Size = new System.Drawing.Size(77, 19);
            this.chbxIsBoatItem.TabIndex = 12;
            this.chbxIsBoatItem.Text = "Boat Item";
            this.chbxIsBoatItem.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudInventoryAmount);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.chbxIsBoat);
            this.groupBox3.Controls.Add(this.btnAddInventory);
            this.groupBox3.Controls.Add(this.cbxItemList);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(470, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 246);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Inventory";
            // 
            // nudInventoryAmount
            // 
            this.nudInventoryAmount.Location = new System.Drawing.Point(82, 60);
            this.nudInventoryAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInventoryAmount.Name = "nudInventoryAmount";
            this.nudInventoryAmount.Size = new System.Drawing.Size(127, 23);
            this.nudInventoryAmount.TabIndex = 14;
            this.nudInventoryAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Amount";
            // 
            // btnAddInventory
            // 
            this.btnAddInventory.Location = new System.Drawing.Point(133, 195);
            this.btnAddInventory.Name = "btnAddInventory";
            this.btnAddInventory.Size = new System.Drawing.Size(76, 42);
            this.btnAddInventory.TabIndex = 12;
            this.btnAddInventory.Text = "Add Inventory";
            this.btnAddInventory.UseVisualStyleBackColor = true;
            this.btnAddInventory.Click += new System.EventHandler(this.btnAddInventory_Click);
            // 
            // cbxItemList
            // 
            this.cbxItemList.FormattingEnabled = true;
            this.cbxItemList.Location = new System.Drawing.Point(82, 19);
            this.cbxItemList.Name = "cbxItemList";
            this.cbxItemList.Size = new System.Drawing.Size(127, 23);
            this.cbxItemList.TabIndex = 9;
            this.cbxItemList.SelectedIndexChanged += new System.EventHandler(this.cbxItemList_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Item";
            // 
            // ItemFormPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "ItemFormPage";
            this.Text = "ItemFormPage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoatCapacity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemDeposit)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInventoryAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbxIsBoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxItemName;
        private System.Windows.Forms.RichTextBox rtbxItemDescription;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddInventory;
        private System.Windows.Forms.ComboBox cbxItemList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudBoatCapacity;
        private System.Windows.Forms.NumericUpDown nudInventoryAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chbxIsBoatItem;
        private System.Windows.Forms.NumericUpDown nudItemCost;
        private System.Windows.Forms.NumericUpDown nudItemDeposit;
    }
}