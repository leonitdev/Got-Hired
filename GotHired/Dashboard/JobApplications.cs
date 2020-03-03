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
using GotHired.Entities.Businesses;
using GotHired.Services;


namespace GotHired.Dashboard
{
    public partial class JobApplications : UserControl
    {
        public JobApplications()
        {
            //var application = new Application_(new JobOffer("TITUILLI I PUNES", "asdasd", null,null,new Category("tech")),
            //    new JobSeeker("lEONIT", "KULETA","male", "male"));
            InitializeComponent();
            
            foreach (var item in ApplicationService.GetApplicationByBusinessName(LoggedData.LoggedBusiness.Name.ToLower()))
            {
                flowLayoutPanel1.Controls.Add(new JobApplicationComponent(item));
            }
            flowLayoutPanel1.Refresh();

        }
    }
}
