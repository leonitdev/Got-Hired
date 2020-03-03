using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GotHired.JobSeekerSIde;
using GotHired.Registers;
using GotHired.Dashboard;
using GotHired.UI;
using GotHired.Entities.Businesses;
using GotHired.Entities.JobSeekers;
using GotHired.Services;

namespace GotHired.JobSeekerSIde
{
    public partial class HomeJobSeeker : Form
    {
        public HomeJobSeeker()
        {
            InitializeComponent();
          

            List<JobOffer> offerList = JobOfferService.GetAllOffers();
            //render promoted offers
            foreach (var item in offerList)
            {
                if (item.Promoted)
                {
                    parentPanel.Controls.Add(new offerComponent(item));
                }

            }
            //render not prometed offers
            foreach (var item in offerList)
            {
                if (!item.Promoted)
                {
                    parentPanel.Controls.Add(new offerComponent(item));
                }
            }
            parentPanel.Refresh();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l1 = new Login();
            l1.Show();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            filteredData f1 = new filteredData();
            parentPanel.Controls.Clear();

            var JobSeeker = LoggedData.LoggedJobSeeker;
            JobSeeker j1 = new JobSeeker(LoggedData.LoggedJobSeeker.Gender,
                LoggedData.LoggedJobSeeker.LastName,LoggedData.LoggedJobSeeker.City,
                LoggedData.LoggedJobSeeker.Name,LoggedData.LoggedJobSeeker.Age,LoggedData.LoggedJobSeeker.Username,LoggedData.LoggedJobSeeker.Password);

            //MessageBox.Show(j1.GetInfo());
            ProfileJobSeeker p1 = new ProfileJobSeeker(j1);
            p1.Show();

            
            


            f1.Show();
            //parentPanel.Refresh();
        }

        private void btnHomeJobSeeker_Click(object sender, EventArgs e)
        {
            parentPanel.Controls.Clear();
            //OffersAll o1 = new OffersAll();
            //o1.Show();
        }
    }
}