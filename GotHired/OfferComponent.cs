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
using GotHired.Services;



namespace GotHired.Entities.Businesses
{
    public partial class OfferComponent : UserControl
    {
        public OfferComponent(JobOffer offer)
        {
            InitializeComponent();

            lblId.Text = offer.Id.ToString();
            lblBusinessName.Text = offer.Business.Name;
            lblTitleJob.Text = offer.Title;
            lblDescription.Text = offer.Description;
            lblCategory.Text = "Category: "+offer.Category.Name;
            lblAddress.Text = offer.Address.City + " - " + offer.Address.Street + " -  No: " + offer.Address.PostalCode;
            if (JobOfferService.GetOfferById(Convert.ToInt32(lblId.Text)).Promoted)
            {
                btnPromote.BackColor = Color.White;
                btnPromote.ForeColor = Color.Black;
                JobOfferService.GetOfferById(Convert.ToInt32(lblId.Text)).Promoted = false;
            }
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            if (JobOfferService.GetOfferById(Convert.ToInt32(lblId.Text)).Promoted)
            {
                btnPromote.BackColor = Color.White;
                btnPromote.ForeColor = Color.Black;
                JobOfferService.GetOfferById(Convert.ToInt32(lblId.Text)).Promoted = false;
            }
            else
            {
                JobOfferService.GetOfferById(Convert.ToInt32(lblId.Text)).Promoted = true;
                btnPromote.BackColor = Color.DarkSlateGray;
                btnPromote.ForeColor = Color.White;
                MessageBox.Show("Promoted");
            }
          
           // item.Promoted = true;
        }

        private void lblBusinessName_Click(object sender, EventArgs e)
        {

        }
    }
}
