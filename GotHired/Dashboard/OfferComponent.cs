using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GotHired.Dashboard;
using GotHired.Entities.Businesses;
using GotHired.Entities.JobSeekers;
using GotHired.Services;

namespace GotHired.UI
{
    public partial class OfferComponent : UserControl
    {

        private readonly Home _home;
        public OfferComponent(JobOffer offer)
        {
            InitializeComponent();
            lblId.Text = offer.Id.ToString();
            lblBusinessName.Text = offer.Business.Name;
            lblTitleJob.Text = offer.Title;
            lblDescription.Text = offer.Description;
            lblCategory.Text = "Category: "+offer.Category.Name;
            lblAddress.Text = offer.Address.City + " - " + offer.Address.Street + " -  No: " + offer.Address.PostalCode;
        }
        public OfferComponent(JobOffer offer, Home home):this(offer)
        {
            _home = home;
            
        }
        private void OfferComponent_Load(object sender, EventArgs e)
        {

        }

        private void btnShowStatistic_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblId.ToString());
            MessageBox.Show("Users that clicked on this "+JobOfferService.GetClickedUsersInOfferByOfferId(id).ToString());
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
        }

        private void lblStatisticLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int id = Convert.ToInt32(lblId.Text);
           // _home.Controls.Clear();

            string users = JobOfferService.GetClickedUsersInOfferByOfferId(id).Count.ToString();
          //  MessageBox.Show("Numri i klikimeve apo vjen sakt " + JobOfferService.GetClickedUsersInOfferByOfferId(id).Count);
            //foreach (var item in JobOfferService.GetClickedUsersInOfferByOfferId(id))
            //{
            //    users += item.Name + " " + item.LastName + "\n";
            //}

            MessageBox.Show("Users that checked your Offers are:\n "+users);
            //OfferStatistic o1 = new OfferStatistic(id);
            //o1.Show();
         //   MessageBox.Show("Users that clicked on this " + JobOfferService.GetClickedUsersInOfferByOfferId(id).ToString());
        }

        private void lblBusinessName_Click(object sender, EventArgs e)
        {

        }
    }
}
