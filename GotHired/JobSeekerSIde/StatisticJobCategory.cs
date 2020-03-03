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
namespace GotHired.JobSeekerSIde
{
    public partial class StatisticJobCategory : UserControl
    {
        public StatisticJobCategory()
        {
            InitializeComponent();
            lblConstructionNumIndustry.Text = JobOfferService.GetJobBsyCategory("Construction").ToString();
            lblEnergyNumIndustry.Text = JobOfferService.GetJobBsyCategory("Energy").ToString();
            lblFinanceNumIndustry.Text = JobOfferService.GetJobBsyCategory("Finance").ToString();
            lblHealthNumIndustry.Text = JobOfferService.GetJobBsyCategory("Health").ToString();
            lblHospitalityNumIndustry.Text = JobOfferService.GetJobBsyCategory("Hospitality").ToString();
            lblMediaNumIndustry.Text = JobOfferService.GetJobBsyCategory("Media").ToString();
            lblTechNumIndustry.Text = JobOfferService.GetJobBsyCategory("Technology").ToString();


            /// part cities
            /// ë
            /// 
            lblPejaJobsNum.Text = JobOfferService.GetJobBsyCity("Pejë").ToString();
            lblPodujevaJobsNum.Text = JobOfferService.GetJobBsyCity("Podujevë").ToString();
            lblPrizrenJobsNum.Text = JobOfferService.GetJobBsyCity("Prizren").ToString();
            lblMitrovicaJobsNum.Text = JobOfferService.GetJobBsyCity("Mitrovicë").ToString();
            lblFerizajJobsNum.Text = JobOfferService.GetJobBsyCity("Ferizajë").ToString();
            lblGJakovaJobsNum.Text = JobOfferService.GetJobBsyCity("Gjakovë").ToString();
            lblPrishtinaJobsNum.Text = JobOfferService.GetJobBsyCity("Prishtinë").ToString();


        }

        private void StatisticJobCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
