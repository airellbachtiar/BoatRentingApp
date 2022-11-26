
namespace BoatRentingDesktopApplication
{
    partial class ReservationPage
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
            this.dgvReservationList = new System.Windows.Forms.DataGridView();
            this.btnEditReservation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservationList
            // 
            this.dgvReservationList.AllowUserToAddRows = false;
            this.dgvReservationList.AllowUserToDeleteRows = false;
            this.dgvReservationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservationList.Location = new System.Drawing.Point(99, 56);
            this.dgvReservationList.Name = "dgvReservationList";
            this.dgvReservationList.RowTemplate.Height = 25;
            this.dgvReservationList.Size = new System.Drawing.Size(487, 338);
            this.dgvReservationList.TabIndex = 2;
            // 
            // btnEditReservation
            // 
            this.btnEditReservation.Location = new System.Drawing.Point(613, 347);
            this.btnEditReservation.Name = "btnEditReservation";
            this.btnEditReservation.Size = new System.Drawing.Size(86, 47);
            this.btnEditReservation.TabIndex = 3;
            this.btnEditReservation.Text = "Edit Reservation";
            this.btnEditReservation.UseVisualStyleBackColor = true;
            this.btnEditReservation.Click += new System.EventHandler(this.btnEditReservation_Click);
            // 
            // ReservationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditReservation);
            this.Controls.Add(this.dgvReservationList);
            this.Name = "ReservationPage";
            this.Text = "ReservationPage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservationList;
        private System.Windows.Forms.Button btnEditReservation;
    }
}