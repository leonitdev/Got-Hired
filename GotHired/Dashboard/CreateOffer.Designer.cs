namespace GotHired.Dashboard
{
    partial class CreateOffer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Share = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtOfferDescription = new System.Windows.Forms.TextBox();
            this.txtTitleOffer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Share);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblStreet);
            this.panel1.Controls.Add(this.cmbCity);
            this.panel1.Controls.Add(this.txtPostalCode);
            this.panel1.Controls.Add(this.txtStreet);
            this.panel1.Controls.Add(this.txtOfferDescription);
            this.panel1.Controls.Add(this.txtTitleOffer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 573);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Share
            // 
            this.Share.BackColor = System.Drawing.Color.DarkCyan;
            this.Share.Font = new System.Drawing.Font("Metropolis Thin", 15.25F);
            this.Share.ForeColor = System.Drawing.Color.White;
            this.Share.Location = new System.Drawing.Point(80, 480);
            this.Share.Name = "Share";
            this.Share.Size = new System.Drawing.Size(159, 51);
            this.Share.TabIndex = 46;
            this.Share.Text = "Share";
            this.Share.UseVisualStyleBackColor = false;
            this.Share.Click += new System.EventHandler(this.Share_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCategory.Font = new System.Drawing.Font("Metropolis Thin", 17.25F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Technology",
            "Health",
            "Energy",
            "Media",
            "Hospitality",
            "Construction",
            " Finance"});
            this.cmbCategory.Location = new System.Drawing.Point(80, 426);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(411, 31);
            this.cmbCategory.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Metropolis Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(363, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Postal No.";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Metropolis Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(82, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "Category";
            // 
            // lblStreet
            // 
            this.lblStreet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Metropolis Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStreet.Location = new System.Drawing.Point(80, 336);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(49, 15);
            this.lblStreet.TabIndex = 43;
            this.lblStreet.Text = "Street";
            // 
            // cmbCity
            // 
            this.cmbCity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCity.Font = new System.Drawing.Font("Metropolis Thin", 16.25F);
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "Prishtinë",
            "Pejë",
            "Podujevë",
            "Prizren",
            "Mitrovicë",
            "Ferizajë",
            "Gjakovë"});
            this.cmbCity.Location = new System.Drawing.Point(80, 282);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(280, 30);
            this.cmbCity.TabIndex = 42;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPostalCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostalCode.Font = new System.Drawing.Font("Metropolis Thin", 17.25F);
            this.txtPostalCode.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPostalCode.Location = new System.Drawing.Point(367, 282);
            this.txtPostalCode.MaxLength = 10;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(124, 30);
            this.txtPostalCode.TabIndex = 41;
            // 
            // txtStreet
            // 
            this.txtStreet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStreet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStreet.Font = new System.Drawing.Font("Metropolis Thin", 17.25F);
            this.txtStreet.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtStreet.Location = new System.Drawing.Point(80, 354);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(411, 30);
            this.txtStreet.TabIndex = 40;
            // 
            // txtOfferDescription
            // 
            this.txtOfferDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOfferDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOfferDescription.Font = new System.Drawing.Font("Metropolis Thin", 14.25F);
            this.txtOfferDescription.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtOfferDescription.Location = new System.Drawing.Point(80, 197);
            this.txtOfferDescription.Multiline = true;
            this.txtOfferDescription.Name = "txtOfferDescription";
            this.txtOfferDescription.Size = new System.Drawing.Size(414, 56);
            this.txtOfferDescription.TabIndex = 36;
            // 
            // txtTitleOffer
            // 
            this.txtTitleOffer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitleOffer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTitleOffer.Font = new System.Drawing.Font("Metropolis Thin", 17.25F);
            this.txtTitleOffer.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTitleOffer.Location = new System.Drawing.Point(80, 139);
            this.txtTitleOffer.Name = "txtTitleOffer";
            this.txtTitleOffer.Size = new System.Drawing.Size(411, 30);
            this.txtTitleOffer.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Metropolis Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(80, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Metropolis Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(82, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Metropolis Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(80, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Metropolis Medium", 27.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(123, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 37);
            this.label1.TabIndex = 31;
            this.label1.Text = "Share an Offer !";
            // 
            // CreateOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CreateOffer";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(608, 603);
            this.Load += new System.EventHandler(this.CreateOffer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Share;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtOfferDescription;
        private System.Windows.Forms.TextBox txtTitleOffer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}
