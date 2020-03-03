namespace GotHired.Entities.Businesses
{
    partial class OfferComponenti 
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
            this.lblId = new System.Windows.Forms.Label();
            this.btnPromote = new System.Windows.Forms.Button();
            this.lblStatisticLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitleJob
            // 
            this.lblTitleJob.AutoSize = true;
            this.lblTitleJob.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitleJob.Location = new System.Drawing.Point(33, 36);
            this.lblTitleJob.Name = "lblTitleJob";
            this.lblTitleJob.Size = new System.Drawing.Size(70, 30);
            this.lblTitleJob.TabIndex = 0;
            this.lblTitleJob.Text = "label1";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Metropolis Thin", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblDescription.Location = new System.Drawing.Point(36, 81);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(43, 14);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "label1";
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Font = new System.Drawing.Font("Metropolis Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lblBusinessName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBusinessName.Location = new System.Drawing.Point(492, 5);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(53, 16);
            this.lblBusinessName.TabIndex = 2;
            this.lblBusinessName.Text = "label1";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Metropolis Thin", 10F);
            this.lblAddress.ForeColor = System.Drawing.Color.Teal;
            this.lblAddress.Location = new System.Drawing.Point(38, 145);
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
            this.lblCategory.Location = new System.Drawing.Point(419, 145);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(43, 14);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "label1";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(8, 5);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(33, 11);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "label1";
            // 
            // btnPromote
            // 
            this.btnPromote.Location = new System.Drawing.Point(38, 181);
            this.btnPromote.Name = "btnPromote";
            this.btnPromote.Size = new System.Drawing.Size(98, 30);
            this.btnPromote.TabIndex = 7;
            this.btnPromote.Text = "Promote";
            this.btnPromote.UseVisualStyleBackColor = true;
            this.btnPromote.Click += new System.EventHandler(this.btnPromote_Click);
            // 
            // lblStatisticLink
            // 
            this.lblStatisticLink.AutoSize = true;
            this.lblStatisticLink.Location = new System.Drawing.Point(493, 200);
            this.lblStatisticLink.Name = "lblStatisticLink";
            this.lblStatisticLink.Size = new System.Drawing.Size(82, 11);
            this.lblStatisticLink.TabIndex = 9;
            this.lblStatisticLink.TabStop = true;
            this.lblStatisticLink.Text = "Show Statistics";
            this.lblStatisticLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblStatisticLink_LinkClicked);
            // 
            // OfferComponenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblStatisticLink);
            this.Controls.Add(this.btnPromote);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblBusinessName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitleJob);
            this.Font = new System.Drawing.Font("Metropolis Thin", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 23);
            this.Name = "OfferComponenti";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(658, 240);
            this.Load += new System.EventHandler(this.OfferComponenti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleJob;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnPromote;
        private System.Windows.Forms.LinkLabel lblStatisticLink;
    }
}
