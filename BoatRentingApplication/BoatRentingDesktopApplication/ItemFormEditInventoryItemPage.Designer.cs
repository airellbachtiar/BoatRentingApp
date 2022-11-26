
namespace BoatRentingDesktopApplication
{
    partial class ItemFormEditInventoryItemPage
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEditInventory = new System.Windows.Forms.Button();
            this.btnRemoveInventory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudBoatCapacity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.chbxIsBoat = new System.Windows.Forms.CheckBox();
            this.cbxItemList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpbxMaintenanceRecord = new System.Windows.Forms.GroupBox();
            this.btnEditMaintenanceRecord = new System.Windows.Forms.Button();
            this.btnAddMaintenanceRecord = new System.Windows.Forms.Button();
            this.dgvMaintenanceRecords = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoatCapacity)).BeginInit();
            this.grpbxMaintenanceRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEditInventory);
            this.groupBox3.Controls.Add(this.btnRemoveInventory);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.chbxIsBoat);
            this.groupBox3.Controls.Add(this.cbxItemList);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(64, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 246);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit Inventory";
            // 
            // btnEditInventory
            // 
            this.btnEditInventory.Location = new System.Drawing.Point(140, 198);
            this.btnEditInventory.Name = "btnEditInventory";
            this.btnEditInventory.Size = new System.Drawing.Size(76, 42);
            this.btnEditInventory.TabIndex = 15;
            this.btnEditInventory.Text = "Edit Inventory";
            this.btnEditInventory.UseVisualStyleBackColor = true;
            this.btnEditInventory.Click += new System.EventHandler(this.btnEditInventory_Click);
            // 
            // btnRemoveInventory
            // 
            this.btnRemoveInventory.Location = new System.Drawing.Point(6, 198);
            this.btnRemoveInventory.Name = "btnRemoveInventory";
            this.btnRemoveInventory.Size = new System.Drawing.Size(76, 42);
            this.btnRemoveInventory.TabIndex = 15;
            this.btnRemoveInventory.Text = "Remove Inventory";
            this.btnRemoveInventory.UseVisualStyleBackColor = true;
            this.btnRemoveInventory.Click += new System.EventHandler(this.btnRemoveInventory_Click);
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
            this.nudBoatCapacity.Name = "nudBoatCapacity";
            this.nudBoatCapacity.Size = new System.Drawing.Size(127, 23);
            this.nudBoatCapacity.TabIndex = 15;
            this.nudBoatCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.chbxIsBoat.Location = new System.Drawing.Point(82, 96);
            this.chbxIsBoat.Name = "chbxIsBoat";
            this.chbxIsBoat.Size = new System.Drawing.Size(50, 19);
            this.chbxIsBoat.TabIndex = 5;
            this.chbxIsBoat.Text = "Boat";
            this.chbxIsBoat.UseVisualStyleBackColor = true;
            // 
            // cbxItemList
            // 
            this.cbxItemList.FormattingEnabled = true;
            this.cbxItemList.Location = new System.Drawing.Point(82, 40);
            this.cbxItemList.Name = "cbxItemList";
            this.cbxItemList.Size = new System.Drawing.Size(127, 23);
            this.cbxItemList.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Item";
            // 
            // grpbxMaintenanceRecord
            // 
            this.grpbxMaintenanceRecord.Controls.Add(this.btnEditMaintenanceRecord);
            this.grpbxMaintenanceRecord.Controls.Add(this.btnAddMaintenanceRecord);
            this.grpbxMaintenanceRecord.Controls.Add(this.dgvMaintenanceRecords);
            this.grpbxMaintenanceRecord.Location = new System.Drawing.Point(334, 85);
            this.grpbxMaintenanceRecord.Name = "grpbxMaintenanceRecord";
            this.grpbxMaintenanceRecord.Size = new System.Drawing.Size(408, 240);
            this.grpbxMaintenanceRecord.TabIndex = 15;
            this.grpbxMaintenanceRecord.TabStop = false;
            this.grpbxMaintenanceRecord.Text = "Maintenance Record";
            // 
            // btnEditMaintenanceRecord
            // 
            this.btnEditMaintenanceRecord.Location = new System.Drawing.Point(17, 195);
            this.btnEditMaintenanceRecord.Name = "btnEditMaintenanceRecord";
            this.btnEditMaintenanceRecord.Size = new System.Drawing.Size(112, 42);
            this.btnEditMaintenanceRecord.TabIndex = 17;
            this.btnEditMaintenanceRecord.Text = "Edit Maintenance Record";
            this.btnEditMaintenanceRecord.UseVisualStyleBackColor = true;
            this.btnEditMaintenanceRecord.Click += new System.EventHandler(this.btnEditMaintenanceRecord_Click);
            // 
            // btnAddMaintenanceRecord
            // 
            this.btnAddMaintenanceRecord.Location = new System.Drawing.Point(277, 192);
            this.btnAddMaintenanceRecord.Name = "btnAddMaintenanceRecord";
            this.btnAddMaintenanceRecord.Size = new System.Drawing.Size(112, 42);
            this.btnAddMaintenanceRecord.TabIndex = 16;
            this.btnAddMaintenanceRecord.Text = "Add Maintenance Record";
            this.btnAddMaintenanceRecord.UseVisualStyleBackColor = true;
            this.btnAddMaintenanceRecord.Click += new System.EventHandler(this.btnAddMaintenanceRecord_Click);
            // 
            // dgvMaintenanceRecords
            // 
            this.dgvMaintenanceRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenanceRecords.Location = new System.Drawing.Point(17, 24);
            this.dgvMaintenanceRecords.Name = "dgvMaintenanceRecords";
            this.dgvMaintenanceRecords.ReadOnly = true;
            this.dgvMaintenanceRecords.RowTemplate.Height = 25;
            this.dgvMaintenanceRecords.Size = new System.Drawing.Size(372, 165);
            this.dgvMaintenanceRecords.TabIndex = 0;
            // 
            // ItemFormEditInventoryItemPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpbxMaintenanceRecord);
            this.Controls.Add(this.groupBox3);
            this.Name = "ItemFormEditInventoryItemPage";
            this.Text = "ItemFormEditInventoryItemPage";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoatCapacity)).EndInit();
            this.grpbxMaintenanceRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudBoatCapacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbxIsBoat;
        private System.Windows.Forms.ComboBox cbxItemList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditInventory;
        private System.Windows.Forms.Button btnRemoveInventory;
        private System.Windows.Forms.GroupBox grpbxMaintenanceRecord;
        private System.Windows.Forms.Button btnEditMaintenanceRecord;
        private System.Windows.Forms.Button btnAddMaintenanceRecord;
        private System.Windows.Forms.DataGridView dgvMaintenanceRecords;
    }
}