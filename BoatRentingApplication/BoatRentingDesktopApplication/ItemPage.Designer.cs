
namespace BoatRentingDesktopApplication
{
    partial class ItemPage
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
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dgvItemPage = new System.Windows.Forms.DataGridView();
            this.btnViewItem = new System.Windows.Forms.Button();
            this.btnViewInventory = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemPage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(615, 358);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(86, 36);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // dgvItemPage
            // 
            this.dgvItemPage.AllowUserToAddRows = false;
            this.dgvItemPage.AllowUserToDeleteRows = false;
            this.dgvItemPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemPage.Location = new System.Drawing.Point(99, 96);
            this.dgvItemPage.Name = "dgvItemPage";
            this.dgvItemPage.ReadOnly = true;
            this.dgvItemPage.RowTemplate.Height = 25;
            this.dgvItemPage.Size = new System.Drawing.Size(487, 298);
            this.dgvItemPage.TabIndex = 2;
            // 
            // btnViewItem
            // 
            this.btnViewItem.Location = new System.Drawing.Point(99, 42);
            this.btnViewItem.Name = "btnViewItem";
            this.btnViewItem.Size = new System.Drawing.Size(86, 36);
            this.btnViewItem.TabIndex = 4;
            this.btnViewItem.Text = "View Item";
            this.btnViewItem.UseVisualStyleBackColor = true;
            this.btnViewItem.Click += new System.EventHandler(this.btnViewItem_Click);
            // 
            // btnViewInventory
            // 
            this.btnViewInventory.Location = new System.Drawing.Point(213, 42);
            this.btnViewInventory.Name = "btnViewInventory";
            this.btnViewInventory.Size = new System.Drawing.Size(95, 36);
            this.btnViewInventory.TabIndex = 5;
            this.btnViewInventory.Text = "View Inventory";
            this.btnViewInventory.UseVisualStyleBackColor = true;
            this.btnViewInventory.Click += new System.EventHandler(this.btnViewInventory_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Location = new System.Drawing.Point(615, 316);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(86, 36);
            this.btnEditItem.TabIndex = 6;
            this.btnEditItem.Text = "Edit Item";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // ItemPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditItem);
            this.Controls.Add(this.btnViewInventory);
            this.Controls.Add(this.btnViewItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.dgvItemPage);
            this.Name = "ItemPage";
            this.Text = "ItemPage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView dgvItemPage;
        private System.Windows.Forms.Button btnViewItem;
        private System.Windows.Forms.Button btnViewInventory;
        private System.Windows.Forms.Button btnEditItem;
    }
}