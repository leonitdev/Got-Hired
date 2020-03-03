using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GotHired.Entities.JobSeekers;
using GotHired.Services;

namespace GotHired.Dashboard
{
    public partial class JobApplicationComponent : UserControl
    {
        int applicationId = 0; 
        public JobApplicationComponent(Application_ a1)
        {

            InitializeComponent();

            lblApplicationId.Text = applicationId.ToString();
            lblJobOfferName.Text = a1.JobOffer.Title;
            lbljobOfferDescription.Text = a1.JobOffer.Description;
            lblJobOfferCategory.Text = a1.JobOffer.Category.Name;
            //
            lblJobSeekerName.Text = "Job Seeker: " + a1.JobSeeker.Name + " " + a1.JobSeeker.LastName;
            lblStatusApplication.Text = "Status: "+a1.Status.ToString();
            lblGenderJobSeeker.Text = "Gender: "+a1.JobSeeker.Gender.ToString();


        }

        private void JobApplicationComponent_Load(object sender, EventArgs e)
        {

        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            ApplicationService.GetApplicationById(Convert.ToInt32(lblApplicationId.Text)).Status = "Hired";
            if(ApplicationService.GetApplicationById(Convert.ToInt32(lblApplicationId.Text)).Status == "Hired")
            {
                btnHire.BackColor = Color.White;
                btnHire.ForeColor = Color.Black;
            }
          

        }

        private void btnRefuse_Click(object sender, EventArgs e)
        {
            ApplicationService.GetApplicationById(Convert.ToInt32(lblApplicationId.Text)).Status="Refused";
            if (ApplicationService.GetApplicationById(Convert.ToInt32(lblApplicationId.Text)).Status == "Refused")
            {
                btnHire.BackColor = Color.White;
                btnHire.ForeColor = Color.Black;
            }
        }
    }
}
