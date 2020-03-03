namespace GotHired.Entities.Businesses
{
    partial class OfferComponent 
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitleJob = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleJob
            // 
            this.lblTitleJob.AutoSize = true;
            this.lblTitleJob.Font = new System.Drawing.Font("Metropolis Medium", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitleJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitleJob.Location = new System.Drawing.Point(41, 88);
            this.lblTitleJob.Name = "lblTitleJob";
            this.lblTitleJob.Size = new System.Drawing.Size(63, 19);
            this.lblTitleJob.TabIndex = 0;
            this.lblTitleJob.Text = "label1";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Metropolis Thin", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblDescription.Location = new System.Drawing.Point(41, 115);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(43, 14);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "label1";
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Font = new System.Drawing.Font("Metropolis Medium", 19F, System.Drawing.FontStyle.Bold);
            this.lblBusinessName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblBusinessName.Location = new System.Drawing.Point(41, 34);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(85, 26);
            this.lblBusinessName.TabIndex = 2;
            this.lblBusinessName.Text = "label1";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Metropolis Thin", 10F);
            this.lblAddress.ForeColor = System.Drawing.Color.Teal;
            this.lblAddress.Location = new System.Drawing.Point(43, 179);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 14);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Metropolis Thin", 10F);
            this.lblCategory.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCategory.Location = new System.Drawing.Point(416, 179);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(43, 14);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "label1";
            // 
            // OfferComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblBusinessName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitleJob);
            this.Font = new System.Drawing.Font("Metropolis Thin", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 23);
            this.Name = "OfferComponent";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(635, 229);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleJob;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCategory;
    }
}
