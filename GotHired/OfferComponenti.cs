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
using GotHired.Entities.JobSeekers;



namespace GotHired.Entities.Businesses
{
    public partial class OfferComponenti : UserControl
    {
        public OfferComponenti(JobOffer offer)
        {
            InitializeComponent();

            lblId.Text = offer.Id.ToString();
            lblBusinessName.Text = offer.Business.Name;
            lblTitleJob.Text = offer.Title;
            lblDescription.Text = offer.Description;
            lblCategory.Text = "Category: "+offer.Category.Name;
            lblAddress.Text = offer.Address.City + " - " + offer.Address.Street + " -  No: " + offer.Address.PostalCode;
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {

        }

        private void lblBusinessName_Click(object sender, EventArgs e)
        {

        }
    }
}
