
namespace BoatRentingDesktopApplication
{
    partial class ItemFormEditItemPage
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudItemCost = new System.Windows.Forms.NumericUpDown();
            this.nudItemDeposit = new System.Windows.Forms.NumericUpDown();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbxItemDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxItemName = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemDeposit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudItemCost);
            this.groupBox2.Controls.Add(this.nudItemDeposit);
            this.groupBox2.Controls.Add(this.btnRemoveItem);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnEditItem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rtbxItemDescription);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbxItemName);
            this.groupBox2.Location = new System.Drawing.Point(289, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 272);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Item";
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
            this.nudItemCost.TabIndex = 17;
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
            this.nudItemDeposit.TabIndex = 18;
            this.nudItemDeposit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(6, 232);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(85, 34);
            this.btnRemoveItem.TabIndex = 12;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
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
            // btnEditItem
            // 
            this.btnEditItem.Location = new System.Drawing.Point(140, 232);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(76, 34);
            this.btnEditItem.TabIndex = 11;
            this.btnEditItem.Text = "Edit Item";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
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
            // rtbxItemDescription
            // 
            this.rtbxItemDescription.Location = new System.Drawing.Point(79, 134);
            this.rtbxItemDescription.Name = "rtbxItemDescription";
            this.rtbxItemDescription.Size = new System.Drawing.Size(127, 74);
            this.rtbxItemDescription.TabIndex = 10;
            this.rtbxItemDescription.Text = "";
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
            // tbxItemName
            // 
            this.tbxItemName.Location = new System.Drawing.Point(79, 16);
            this.tbxItemName.Name = "tbxItemName";
            this.tbxItemName.ReadOnly = true;
            this.tbxItemName.Size = new System.Drawing.Size(127, 23);
            this.tbxItemName.TabIndex = 7;
            // 
            // ItemFormEditItemPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Name = "ItemFormEditItemPage";
            this.Text = "ItemFormEditItemPage";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemDeposit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbxItemDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxItemName;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.NumericUpDown nudItemCost;
        private System.Windows.Forms.NumericUpDown nudItemDeposit;
    }
}