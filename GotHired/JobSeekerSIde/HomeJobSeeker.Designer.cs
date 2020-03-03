namespace GotHired.JobSeekerSIde
{
    partial class HomeJobSeeker
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHomeJobSeeker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.parentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.statisticJobCategory2 = new GotHired.JobSeekerSIde.StatisticJobCategory();
            this.panel1.SuspendLayout();
            this.parentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnHomeJobSeeker);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 70);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Metropolis Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(130)))));
            this.btnLogout.Location = new System.Drawing.Point(852, 18);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 50);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.White;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Metropolis Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(130)))));
            this.btnFilter.Location = new System.Drawing.Point(656, 18);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(190, 50);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "MY PROFILE";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(59)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(548, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 3);
            this.panel2.TabIndex = 2;
            // 
            // btnHomeJobSeeker
            // 
            this.btnHomeJobSeeker.BackColor = System.Drawing.Color.White;
            this.btnHomeJobSeeker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomeJobSeeker.FlatAppearance.BorderSize = 0;
            this.btnHomeJobSeeker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeJobSeeker.Font = new System.Drawing.Font("Metropolis Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeJobSeeker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(130)))));
            this.btnHomeJobSeeker.Location = new System.Drawing.Point(548, 18);
            this.btnHomeJobSeeker.Name = "btnHomeJobSeeker";
            this.btnHomeJobSeeker.Size = new System.Drawing.Size(100, 50);
            this.btnHomeJobSeeker.TabIndex = 1;
            this.btnHomeJobSeeker.Text = "HOME";
            this.btnHomeJobSeeker.UseVisualStyleBackColor = false;
            this.btnHomeJobSeeker.Click += new System.EventHandler(this.btnHomeJobSeeker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(41, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Got Hired";
            // 
            // parentPanel
            // 
            this.parentPanel.AutoScroll = true;
            this.parentPanel.Controls.Add(this.label2);
            this.parentPanel.Location = new System.Drawing.Point(282, 67);
            this.parentPanel.Name = "parentPanel";
            this.parentPanel.Padding = new System.Windows.Forms.Padding(20, 30, 0, 50);
            this.parentPanel.Size = new System.Drawing.Size(791, 536);
            this.parentPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(23, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 47);
            this.label2.TabIndex = 0;
            this.label2.Text = "Find your dream job...\r\n";
            // 
            // statisticJobCategory2
            // 
            this.statisticJobCategory2.BackColor = System.Drawing.Color.Gainsboro;
            this.statisticJobCategory2.Location = new System.Drawing.Point(1, 66);
            this.statisticJobCategory2.Name = "statisticJobCategory2";
            this.statisticJobCategory2.Size = new System.Drawing.Size(279, 623);
            this.statisticJobCategory2.TabIndex = 2;
            // 
            // HomeJobSeeker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1080, 700);
            this.Controls.Add(this.parentPanel);
            this.Controls.Add(this.statisticJobCategory2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeJobSeeker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.parentPanel.ResumeLayout(false);
            this.parentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHomeJobSeeker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private StatisticJobCategory statisticJobCategory2;
        private System.Windows.Forms.FlowLayoutPanel parentPanel;
        private System.Windows.Forms.Label label2;
    }
}