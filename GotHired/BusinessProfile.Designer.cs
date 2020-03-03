namespace GotHired
{
    partial class BusinessProfile
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
            System.Windows.Forms.Button btnClose;
            this.businessPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTechOffers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBusinessType = new System.Windows.Forms.Label();
            this.lblCityOffersNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOffersShared = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBusinessCategory = new System.Windows.Forms.Label();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            btnClose = new System.Windows.Forms.Button();
            this.businessPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.DarkSlateGray;
            btnClose.Font = new System.Drawing.Font("Malgun Gothic", 13.25F, System.Drawing.FontStyle.Bold);
            btnClose.ForeColor = System.Drawing.Color.Cornsilk;
            btnClose.Location = new System.Drawing.Point(212, 561);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(150, 48);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // businessPanel
            // 
            this.businessPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.businessPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.businessPanel.Controls.Add(this.panel1);
            this.businessPanel.Controls.Add(btnClose);
            this.businessPanel.Controls.Add(this.lblTechOffers);
            this.businessPanel.Controls.Add(this.label4);
            this.businessPanel.Controls.Add(this.lblBusinessType);
            this.businessPanel.Controls.Add(this.lblCityOffersNum);
            this.businessPanel.Controls.Add(this.label2);
            this.businessPanel.Controls.Add(this.label3);
            this.businessPanel.Controls.Add(this.lblOffersShared);
            this.businessPanel.Controls.Add(this.panel5);
            this.businessPanel.Controls.Add(this.panel3);
            this.businessPanel.Controls.Add(this.panel2);
            this.businessPanel.Controls.Add(this.lblBusinessCategory);
            this.businessPanel.Controls.Add(this.lblBusinessName);
            this.businessPanel.Controls.Add(this.pictureBox1);
            this.businessPanel.Location = new System.Drawing.Point(1, 0);
            this.businessPanel.Name = "businessPanel";
            this.businessPanel.Size = new System.Drawing.Size(572, 690);
            this.businessPanel.TabIndex = 1;
            this.businessPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.businessPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(6)))));
            this.panel1.Controls.Add(this.iconClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 67);
            this.panel1.TabIndex = 1;
            // 
            // iconClose
            // 
            this.iconClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconClose.Image = global::GotHired.Properties.Resources.close_icon_png_transparent_27;
            this.iconClose.Location = new System.Drawing.Point(498, 11);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(52, 50);
            this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconClose.TabIndex = 2;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 19.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(199, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Business Profile";
            // 
            // lblTechOffers
            // 
            this.lblTechOffers.AutoSize = true;
            this.lblTechOffers.Font = new System.Drawing.Font("Malgun Gothic", 19.75F, System.Drawing.FontStyle.Bold);
            this.lblTechOffers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTechOffers.Location = new System.Drawing.Point(436, 448);
            this.lblTechOffers.Name = "lblTechOffers";
            this.lblTechOffers.Size = new System.Drawing.Size(65, 37);
            this.lblTechOffers.TabIndex = 14;
            this.lblTechOffers.Text = "322";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(390, 416);
            this.label4.MaximumSize = new System.Drawing.Size(170, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Offers in tech";
            // 
            // lblBusinessType
            // 
            this.lblBusinessType.AutoSize = true;
            this.lblBusinessType.Font = new System.Drawing.Font("Malgun Gothic", 12.25F);
            this.lblBusinessType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBusinessType.Location = new System.Drawing.Point(340, 330);
            this.lblBusinessType.Name = "lblBusinessType";
            this.lblBusinessType.Size = new System.Drawing.Size(120, 23);
            this.lblBusinessType.TabIndex = 12;
            this.lblBusinessType.Text = "BusinessName";
            // 
            // lblCityOffersNum
            // 
            this.lblCityOffersNum.AutoSize = true;
            this.lblCityOffersNum.Font = new System.Drawing.Font("Malgun Gothic", 19.75F, System.Drawing.FontStyle.Bold);
            this.lblCityOffersNum.ForeColor = System.Drawing.Color.Maroon;
            this.lblCityOffersNum.Location = new System.Drawing.Point(255, 448);
            this.lblCityOffersNum.Name = "lblCityOffersNum";
            this.lblCityOffersNum.Size = new System.Drawing.Size(65, 37);
            this.lblCityOffersNum.TabIndex = 11;
            this.lblCityOffersNum.Text = "322";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(210, 416);
            this.label2.MaximumSize = new System.Drawing.Size(170, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Offers in your City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(62, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Offers shared";
            // 
            // lblOffersShared
            // 
            this.lblOffersShared.AutoSize = true;
            this.lblOffersShared.Font = new System.Drawing.Font("Malgun Gothic", 19.75F, System.Drawing.FontStyle.Bold);
            this.lblOffersShared.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblOffersShared.Location = new System.Drawing.Point(95, 448);
            this.lblOffersShared.Name = "lblOffersShared";
            this.lblOffersShared.Size = new System.Drawing.Size(65, 37);
            this.lblOffersShared.TabIndex = 8;
            this.lblOffersShared.Text = "322";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(369, 416);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 100);
            this.panel5.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(199, 416);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 100);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(24, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 2);
            this.panel2.TabIndex = 5;
            // 
            // lblBusinessCategory
            // 
            this.lblBusinessCategory.AutoSize = true;
            this.lblBusinessCategory.Font = new System.Drawing.Font("Malgun Gothic", 12.25F);
            this.lblBusinessCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBusinessCategory.Location = new System.Drawing.Point(130, 330);
            this.lblBusinessCategory.Name = "lblBusinessCategory";
            this.lblBusinessCategory.Size = new System.Drawing.Size(120, 23);
            this.lblBusinessCategory.TabIndex = 4;
            this.lblBusinessCategory.Text = "BusinessName";
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Font = new System.Drawing.Font("Malgun Gothic", 18.75F, System.Drawing.FontStyle.Bold);
            this.lblBusinessName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBusinessName.Location = new System.Drawing.Point(226, 286);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(189, 35);
            this.lblBusinessName.TabIndex = 3;
            this.lblBusinessName.Text = "BusinessName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GotHired.Properties.Resources.bProfile;
            this.pictureBox1.Location = new System.Drawing.Point(199, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BusinessProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(572, 720);
            this.Controls.Add(this.businessPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BusinessProfile";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusinessProfile";
            this.Load += new System.EventHandler(this.BusinessProfile_Load);
            this.businessPanel.ResumeLayout(false);
            this.businessPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel businessPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOffersShared;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBusinessCategory;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Label lblBusinessType;
        private System.Windows.Forms.Label lblCityOffersNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTechOffers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox iconClose;
        private System.Windows.Forms.Label label1;
    }
}