using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GotHired.Entities.Businesses;
using GotHired.Entities.JobSeekers;
using GotHired.Registers;
using GotHired.Services;

namespace GotHired.Dashboard
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
            lblbusinessName.Text = LoggedData.LoggedBusiness.Username;
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }

        private void position(Button b)
        {
           // active.Location = new Point(b.Location.X - b.Width, b.Location.Y);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            parentPanel.Controls.Clear();
            YourJobOffers jobOffers = new YourJobOffers();
            Statistic s1 = new Statistic();
            parentPanel.Controls.Add(s1);
            parentPanel.Controls.Add(jobOffers);
        }

        private void btnShareOffer_Click(object sender, EventArgs e)
        {
            position(btnShareOffer);

            parentPanel.Controls.Clear();

            CreateOffer createOffer = new CreateOffer();
            createOffer.Location = new Point(10, 0);
            parentPanel.Controls.Add(createOffer);
          

        }

      

        private void parentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            parentPanel.Controls.Clear();
            JobApplications j1 = new JobApplications();
            parentPanel.Controls.Add(j1);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btnStatistic_Click_1(object sender, EventArgs e)
        {
            parentPanel.Controls.Clear();
            ApplicationStatistic a1 = new ApplicationStatistic();
            parentPanel.Controls.Add(a1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l1 = new Login();
            l1.Show();
        }

        private void lblProfileViewers_Click(object sender, EventArgs e)
        {
            BusinessProfileViewer b1 = new BusinessProfileViewer();
            b1.Show();
            //MessageBox.Show(ViewerService.GetMyProfileViewers(LoggedData.LoggedBusiness.Name).Count.ToString());
        }

        private void lblbusinessName_Click(object sender, EventArgs e)
        {
            var B = LoggedData.LoggedBusiness;
            Business b1 = new Business(B.BusinessType, B.BusinessCategory, B.Name, B.Username, B.Password);

            MessageBox.Show(b1.GetInfo());
        }
    }
}
