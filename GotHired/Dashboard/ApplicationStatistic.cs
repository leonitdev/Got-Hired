using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GotHired.Services;
namespace GotHired.Dashboard
{
    public partial class ApplicationStatistic : UserControl
    {
        public ApplicationStatistic()
        {
            InitializeComponent();
            lblMyOffersShared.Text = JobOfferService.GetOffersByBusinessName(LoggedData.LoggedBusiness.Name).Count.ToString();
            lblTechnologyOffersJob.Text =JobOfferService.GetJobBsyCategoryAndBusinessName("Technology", LoggedData.LoggedBusiness.Name).ToString();
            lblPristinaOffers.Text = JobOfferService.GetJobBsyCity("Prishtinë").ToString();


            ////
            //Applications statistic
            lblApplicationsNum.Text = ApplicationService.GetApplicationByBusinessName(LoggedData.LoggedBusiness.Name).Count.ToString();
            lblMaleApplications.Text = ApplicationService.GetApplicationsByMale().ToString();
            lblRefusedApplications.Text = ApplicationService.ApplicationRefused(LoggedData.LoggedBusiness.Name).ToString();

            //female find
            int femaleCount = ApplicationService.GetApplicationByBusinessName(LoggedData.LoggedBusiness.Name).Count - ApplicationService.GetApplicationsByMale();
            lblFemalApplicants.Text = femaleCount.ToString();
                
        }
    }
}
