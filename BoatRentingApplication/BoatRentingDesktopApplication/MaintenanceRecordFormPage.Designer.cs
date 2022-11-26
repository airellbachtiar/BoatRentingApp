
namespace BoatRentingDesktopApplication
{
    partial class MaintenanceRecordFormPage
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
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddMaintenanceRecord = new System.Windows.Forms.Button();
            this.btnEditMaintenanceRecord = new System.Windows.Forms.Button();
            this.btnRemoveMaintenanceRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(287, 121);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 23);
            this.dtpStartDate.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(287, 179);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 23);
            this.dtpEndDate.TabIndex = 1;
            // 
            // btnAddMaintenanceRecord
            // 
            this.btnAddMaintenanceRecord.Location = new System.Drawing.Point(469, 280);
            this.btnAddMaintenanceRecord.Name = "btnAddMaintenanceRecord";
            this.btnAddMaintenanceRecord.Size = new System.Drawing.Size(112, 42);
            this.btnAddMaintenanceRecord.TabIndex = 17;
            this.btnAddMaintenanceRecord.Text = "Add Maintenance Record";
            this.btnAddMaintenanceRecord.UseVisualStyleBackColor = true;
            this.btnAddMaintenanceRecord.Click += new System.EventHandler(this.btnAddMaintenanceRecord_Click);
            // 
            // btnEditMaintenanceRecord
            // 
            this.btnEditMaintenanceRecord.Location = new System.Drawing.Point(329, 280);
            this.btnEditMaintenanceRecord.Name = "btnEditMaintenanceRecord";
            this.btnEditMaintenanceRecord.Size = new System.Drawing.Size(112, 42);
            this.btnEditMaintenanceRecord.TabIndex = 18;
            this.btnEditMaintenanceRecord.Text = "Edit Maintenance Record";
            this.btnEditMaintenanceRecord.UseVisualStyleBackColor = true;
            this.btnEditMaintenanceRecord.Click += new System.EventHandler(this.btnEditMaintenanceRecord_Click);
            // 
            // btnRemoveMaintenanceRecord
            // 
            this.btnRemoveMaintenanceRecord.Location = new System.Drawing.Point(181, 280);
            this.btnRemoveMaintenanceRecord.Name = "btnRemoveMaintenanceRecord";
            this.btnRemoveMaintenanceRecord.Size = new System.Drawing.Size(126, 42);
            this.btnRemoveMaintenanceRecord.TabIndex = 19;
            this.btnRemoveMaintenanceRecord.Text = "Remove Maintenance Record";
            this.btnRemoveMaintenanceRecord.UseVisualStyleBackColor = true;
            this.btnRemoveMaintenanceRecord.Click += new System.EventHandler(this.btnRemoveMaintenanceRecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "End Date";
            // 
            // MaintenanceRecordFormPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveMaintenanceRecord);
            this.Controls.Add(this.btnEditMaintenanceRecord);
            this.Controls.Add(this.btnAddMaintenanceRecord);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Name = "MaintenanceRecordFormPage";
            this.Text = "MaintenanceRecordFormPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnAddMaintenanceRecord;
        private System.Windows.Forms.Button btnEditMaintenanceRecord;
        private System.Windows.Forms.Button btnRemoveMaintenanceRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}