using GotHired.Entities.Businesses;
using GotHired.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GotHired
{
    public partial class BusinessProfile : Form
    {
        public BusinessProfile(Business b1,int offers)
        {

            InitializeComponent();
            lblBusinessName.Text= b1.Name;
            lblBusinessCategory.Text = b1.BusinessCategory.Name;
            lblOffersShared.Text = offers.ToString();
            lblBusinessType.Text = b1.BusinessType.Type;
            lblTechOffers.Text = JobOfferService.GetJobBsyCategoryAndBusinessName("Technology", b1.Name).ToString();
            MessageBox.Show(LoggedData.LoggedJobSeeker.City + " " + b1.Name);
            lblCityOffersNum.Text = JobOfferService.GetOffersByCityAndBusinessName(b1.Name, LoggedData.LoggedJobSeeker.City).Count.ToString();
           
        }

        private void BusinessProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void businessPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ViewerService.ProfileViwerNum().ToString());
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
