namespace GotHired.UI
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
            this.lblStatisticLink = new System.Windows.Forms.LinkLabel();
            this.btnPromote = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitleJob = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatisticLink
            // 
            this.lblStatisticLink.AutoSize = true;
            this.lblStatisticLink.Location = new System.Drawing.Point(512, 210);
            this.lblStatisticLink.Name = "lblStatisticLink";
            this.lblStatisticLink.Size = new System.Drawing.Size(82, 11);
            this.lblStatisticLink.TabIndex = 17;
            this.lblStatisticLink.TabStop = true;
            this.lblStatisticLink.Text = "Show Statistics";
            this.lblStatisticLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblStatisticLink_LinkClicked);
            // 
            // btnPromote
            // 
            this.btnPromote.Location = new System.Drawing.Point(57, 191);
            this.btnPromote.Name = "btnPromote";
            this.btnPromote.Size = new System.Drawing.Size(98, 30);
            this.btnPromote.TabIndex = 16;
            this.btnPromote.Text = "Promote";
            this.btnPromote.UseVisualStyleBackColor = true;
            this.btnPromote.Click += new System.EventHandler(this.btnPromote_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(27, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(33, 11);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "label1";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Metropolis Thin", 10F);
            this.lblCategory.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCategory.Location = new System.Drawing.Point(438, 155);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(43, 14);
            this.lblCategory.TabIndex = 14;
            this.lblCategory.Text = "label1";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Metropolis Thin", 10F);
            this.lblAddress.ForeColor = System.Drawing.Color.Teal;
            this.lblAddress.Location = new System.Drawing.Point(57, 155);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 14);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address:";
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Font = new System.Drawing.Font("Metropolis Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lblBusinessName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBusinessName.Location = new System.Drawing.Point(511, 15);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(53, 16);
            this.lblBusinessName.TabIndex = 12;
            this.lblBusinessName.Text = "label1";
            this.lblBusinessName.Click += new System.EventHandler(this.lblBusinessName_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Metropolis Thin", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblDescription.Location = new System.Drawing.Point(55, 91);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(43, 14);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "label1";
            // 
            // lblTitleJob
            // 
            this.lblTitleJob.AutoSize = true;
            this.lblTitleJob.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitleJob.Location = new System.Drawing.Point(52, 46);
            this.lblTitleJob.Name = "lblTitleJob";
            this.lblTitleJob.Size = new System.Drawing.Size(70, 30);
            this.lblTitleJob.TabIndex = 10;
            this.lblTitleJob.Text = "label1";
            // 
            // OfferComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.Name = "OfferComponent";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(729, 256);
            this.Load += new System.EventHandler(this.OfferComponent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblStatisticLink;
        private System.Windows.Forms.Button btnPromote;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitleJob;
    }
}
