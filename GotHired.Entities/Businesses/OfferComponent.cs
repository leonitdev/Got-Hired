using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GotHired.Entities.Businesses
{
    public partial class OfferComponent : UserControl
    {
        public OfferComponent(JobOffer offer)
        {
            InitializeComponent();

            lblBusinessName.Text = offer.Business.Name;
            lblTitleJob.Text = offer.Title;
            lblDescription.Text = offer.Description;
            lblCategory.Text = "Category: "+offer.Category.Name;
            lblAddress.Text = offer.Address.City + " - " + offer.Address.Street + " -  No: " + offer.Address.PostalCode;
        }
    }
}
