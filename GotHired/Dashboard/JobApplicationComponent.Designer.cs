namespace GotHired.Dashboard
{
    partial class JobApplicationComponent
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
            this.lblJobOfferName = new System.Windows.Forms.Label();
            this.lbljobOfferDescription = new System.Windows.Forms.Label();
            this.lblJobOfferCategory = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblJobSeekerName = new System.Windows.Forms.Label();
            this.lblGenderJobSeeker = new System.Windows.Forms.Label();
            this.lblStatusApplication = new System.Windows.Forms.Label();
            this.btnHire = new System.Windows.Forms.Button();
            this.btnRefuse = new System.Windows.Forms.Button();
            this.lblApplicationId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblJobOfferName
            // 
            this.lblJobOfferName.AutoSize = true;
            this.lblJobOfferName.Font = new System.Drawing.Font("Metropolis Thin", 15.25F);
            this.lblJobOfferName.Location = new System.Drawing.Point(52, 61);
            this.lblJobOfferName.Name = "lblJobOfferName";
            this.lblJobOfferName.Size = new System.Drawing.Size(67, 21);
            this.lblJobOfferName.TabIndex = 1;
            this.lblJobOfferName.Text = "label2";
            // 
            // lbljobOfferDescription
            // 
            this.lbljobOfferDescription.AutoSize = true;
            this.lbljobOfferDescription.Location = new System.Drawing.Point(54, 107);
            this.lbljobOfferDescription.Name = "lbljobOfferDescription";
            this.lbljobOfferDescription.Size = new System.Drawing.Size(35, 11);
            this.lbljobOfferDescription.TabIndex = 2;
            this.lbljobOfferDescription.Text = "label2";
            // 
            // lblJobOfferCategory
            // 
            this.lblJobOfferCategory.AutoSize = true;
            this.lblJobOfferCategory.Location = new System.Drawing.Point(54, 156);
            this.lblJobOfferCategory.Name = "lblJobOfferCategory";
            this.lblJobOfferCategory.Size = new System.Drawing.Size(35, 11);
            this.lblJobOfferCategory.TabIndex = 3;
            this.lblJobOfferCategory.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(43, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 10);
            this.panel1.TabIndex = 4;
            // 
            // lblJobSeekerName
            // 
            this.lblJobSeekerName.AutoSize = true;
            this.lblJobSeekerName.Font = new System.Drawing.Font("Metropolis Thin", 15.25F);
            this.lblJobSeekerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblJobSeekerName.Location = new System.Drawing.Point(52, 215);
            this.lblJobSeekerName.Name = "lblJobSeekerName";
            this.lblJobSeekerName.Size = new System.Drawing.Size(67, 21);
            this.lblJobSeekerName.TabIndex = 6;
            this.lblJobSeekerName.Text = "label3";
            // 
            // lblGenderJobSeeker
            // 
            this.lblGenderJobSeeker.AutoSize = true;
            this.lblGenderJobSeeker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGenderJobSeeker.Location = new System.Drawing.Point(54, 264);
            this.lblGenderJobSeeker.Name = "lblGenderJobSeeker";
            this.lblGenderJobSeeker.Size = new System.Drawing.Size(35, 11);
            this.lblGenderJobSeeker.TabIndex = 7;
            this.lblGenderJobSeeker.Text = "label2";
            // 
            // lblStatusApplication
            // 
            this.lblStatusApplication.AutoSize = true;
            this.lblStatusApplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatusApplication.Location = new System.Drawing.Point(54, 309);
            this.lblStatusApplication.Name = "lblStatusApplication";
            this.lblStatusApplication.Size = new System.Drawing.Size(35, 11);
            this.lblStatusApplication.TabIndex = 8;
            this.lblStatusApplication.Text = "label2";
            // 
            // btnHire
            // 
            this.btnHire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHire.Font = new System.Drawing.Font("Metropolis Thin", 12.25F);
            this.btnHire.ForeColor = System.Drawing.Color.White;
            this.btnHire.Location = new System.Drawing.Point(53, 339);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(140, 41);
            this.btnHire.TabIndex = 9;
            this.btnHire.Text = "Hire";
            this.btnHire.UseVisualStyleBackColor = false;
            this.btnHire.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // btnRefuse
            // 
            this.btnRefuse.BackColor = System.Drawing.Color.Maroon;
            this.btnRefuse.Font = new System.Drawing.Font("Metropolis Thin", 12.25F);
            this.btnRefuse.ForeColor = System.Drawing.Color.White;
            this.btnRefuse.Location = new System.Drawing.Point(213, 339);
            this.btnRefuse.Name = "btnRefuse";
            this.btnRefuse.Size = new System.Drawing.Size(140, 41);
            this.btnRefuse.TabIndex = 10;
            this.btnRefuse.Text = "Refuse";
            this.btnRefuse.UseVisualStyleBackColor = false;
            this.btnRefuse.Click += new System.EventHandler(this.btnRefuse_Click);
            // 
            // lblApplicationId
            // 
            this.lblApplicationId.AutoSize = true;
            this.lblApplicationId.Location = new System.Drawing.Point(13, 19);
            this.lblApplicationId.Name = "lblApplicationId";
            this.lblApplicationId.Size = new System.Drawing.Size(35, 11);
            this.lblApplicationId.TabIndex = 12;
            this.lblApplicationId.Text = "label3";
            // 
            // JobApplicationComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblApplicationId);
            this.Controls.Add(this.btnRefuse);
            this.Controls.Add(this.btnHire);
            this.Controls.Add(this.lblStatusApplication);
            this.Controls.Add(this.lblGenderJobSeeker);
            this.Controls.Add(this.lblJobSeekerName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblJobOfferCategory);
            this.Controls.Add(this.lbljobOfferDescription);
            this.Controls.Add(this.lblJobOfferName);
            this.Font = new System.Drawing.Font("Metropolis Thin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "JobApplicationComponent";
            this.Size = new System.Drawing.Size(477, 427);
            this.Load += new System.EventHandler(this.JobApplicationComponent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJobOfferName;
        private System.Windows.Forms.Label lbljobOfferDescription;
        private System.Windows.Forms.Label lblJobOfferCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblJobSeekerName;
        private System.Windows.Forms.Label lblGenderJobSeeker;
        private System.Windows.Forms.Label lblStatusApplication;
        private System.Windows.Forms.Button btnHire;
        private System.Windows.Forms.Button btnRefuse;
        private System.Windows.Forms.Label lblApplicationId;
    }
}
