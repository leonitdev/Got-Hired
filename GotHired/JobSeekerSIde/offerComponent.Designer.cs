namespace GotHired.JobSeekerSIde
{
    partial class offerComponent
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitleJob = new System.Windows.Forms.Label();
            this.btnJobApply = new System.Windows.Forms.Button();
            this.btnMssg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Metropolis Thin", 10F);
            this.lblCategory.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCategory.Location = new System.Drawing.Point(394, 144);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(43, 14);
            this.lblCategory.TabIndex = 15;
            this.lblCategory.Text = "label1";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Metropolis Thin", 10F);
            this.lblAddress.ForeColor = System.Drawing.Color.Teal;
            this.lblAddress.Location = new System.Drawing.Point(36, 129);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 14);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Address:";
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBusinessName.Font = new System.Drawing.Font("Malgun Gothic", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblBusinessName.ForeColor = System.Drawing.Color.Navy;
            this.lblBusinessName.Location = new System.Drawing.Point(580, 14);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(51, 20);
            this.lblBusinessName.TabIndex = 13;
            this.lblBusinessName.Text = "label1";
            this.lblBusinessName.Click += new System.EventHandler(this.lblBusinessName_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Metropolis Thin", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblDescription.Location = new System.Drawing.Point(36, 83);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(43, 14);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "label1";
            // 
            // lblTitleJob
            // 
            this.lblTitleJob.AutoSize = true;
            this.lblTitleJob.Font = new System.Drawing.Font("Metropolis Medium", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitleJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitleJob.Location = new System.Drawing.Point(35, 37);
            this.lblTitleJob.Name = "lblTitleJob";
            this.lblTitleJob.Size = new System.Drawing.Size(63, 19);
            this.lblTitleJob.TabIndex = 11;
            this.lblTitleJob.Text = "label1";
            // 
            // btnJobApply
            // 
            this.btnJobApply.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnJobApply.Font = new System.Drawing.Font("Metropolis Thin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobApply.ForeColor = System.Drawing.Color.White;
            this.btnJobApply.Location = new System.Drawing.Point(38, 165);
            this.btnJobApply.Name = "btnJobApply";
            this.btnJobApply.Size = new System.Drawing.Size(201, 49);
            this.btnJobApply.TabIndex = 16;
            this.btnJobApply.Text = "Apply";
            this.btnJobApply.UseVisualStyleBackColor = false;
            this.btnJobApply.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMssg
            // 
            this.btnMssg.BackColor = System.Drawing.Color.Transparent;
            this.btnMssg.Font = new System.Drawing.Font("Malgun Gothic", 11.25F);
            this.btnMssg.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnMssg.Location = new System.Drawing.Point(584, 202);
            this.btnMssg.Name = "btnMssg";
            this.btnMssg.Size = new System.Drawing.Size(82, 32);
            this.btnMssg.TabIndex = 17;
            this.btnMssg.Text = "Save";
            this.btnMssg.UseVisualStyleBackColor = false;
            this.btnMssg.Click += new System.EventHandler(this.btnMssg_Click_1);
            // 
            // offerComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnMssg);
            this.Controls.Add(this.btnJobApply);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblBusinessName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitleJob);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.Name = "offerComponent";
            this.Size = new System.Drawing.Size(687, 247);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitleJob;
        private System.Windows.Forms.Button btnJobApply;
        private System.Windows.Forms.Button btnMssg;
    }
}
