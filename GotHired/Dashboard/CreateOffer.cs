using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GotHired.Entities.Businesses;
using GotHired.Services;
using GotHired.Dashboard;

namespace GotHired.Dashboard
{
    public partial class CreateOffer : UserControl
    {
        public CreateOffer()
        {
            InitializeComponent();
        }

        private void CreateOffer_Load(object sender, EventArgs e)
        {

        }

        private void btnShareOffer_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Share_Click(object sender, EventArgs e)
        {

            //qitu u met me ndreq business mos me lan null 
            Address a1 = new Address(cmbCity.SelectedItem.ToString(), txtStreet.Text, 10000);
            JobOfferService.AddOffer(new JobOffer(txtTitleOffer.Text, txtOfferDescription.Text,
                new Business(LoggedData.LoggedBusiness.BusinessType, LoggedData.LoggedBusiness.BusinessCategory, LoggedData.LoggedBusiness.Name, "password", "password"), a1,
                new Category(cmbCategory.SelectedItem.ToString())));
            MessageBox.Show("You Shared an Offer succesfuly");
        }
    }
}
