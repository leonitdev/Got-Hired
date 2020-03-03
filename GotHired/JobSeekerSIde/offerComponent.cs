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
using GotHired.Entities.JobSeekers;

namespace GotHired.JobSeekerSIde
{
    public partial class offerComponent : UserControl
    {
        JobOffer offerGlobal = null;
        AllOffers _parent;
        public offerComponent(JobOffer offer)
        {
            offerGlobal = offer;
            
            InitializeComponent();

            lblBusinessName.Text = offer.Business.Name;
            lblTitleJob.Text = offer.Title;
            lblDescription.Text = offer.Description;
            lblCategory.Text = "Category: " + offer.Category.Name;
            lblAddress.Text = offer.Address.City + " - " + offer.Address.Street + " -  No: " + offer.Address.PostalCode;
        }

        public offerComponent(JobOffer offer, AllOffers parent):this(offer)
        {
            _parent = parent;

        }

        private void lblBusinessName_Click(object sender, EventArgs e, HomeJobSeeker h1)
        {
            var business = BusinessService.SearchByBusinessName(lblBusinessName.Text);
            MessageBox.Show("hello world ");
            h1.Parent.Controls.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            var user = JobSeekerService.GetById(LoggedData.LoggedJobSeeker.Id);
            // var offer = JobOfferService.GetOffersByBusinessName(lblBusinessName.Text);
            // var thisApplication = new Application_(offerGlobal, user);

            var application = ApplicationService.GetApplicationById(offerGlobal.Id);
         
            if(btnJobApply.BackColor == Color.DarkSlateGray)
            {

               // thisApplication.Status = "Applied";
                ApplicationService.Apply(offerGlobal, user,"Applied");

                MessageBox.Show("You applied succesfully");
                btnJobApply.BackColor = Color.WhiteSmoke;
                btnJobApply.ForeColor = Color.Black;
                btnJobApply.Text = "Undo Application";
            }
            else if(btnJobApply.BackColor == Color.WhiteSmoke) 
            {
                //     thisApplication.Status = "Neutral";
                //  MessageBox.Show(ApplicationService.GetLastApplication().ToString());

                btnJobApply.BackColor = Color.DarkSlateGray;
                btnJobApply.ForeColor = Color.White;
                btnJobApply.Text = "Apply";
                 ApplicationService.GetLastApplication().Status="Neutral";
                ApplicationService.GetApplicationById(offerGlobal.Id);
                var last = ApplicationService.GetLastApplication();
                ApplicationService.DeleteApplication(last.Id);
            }

        }

      

        private void btnMssg_Click_1(object sender, EventArgs e)
        {
           // MessageBox.Show(offerGlobal.Id.ToString());
            //   h1.Parent.Controls.Clear();
            JobOfferService.CheckOffer(offerGlobal.Id);
        }

        private void lblBusinessName_Click(object sender, EventArgs e)
        {
            //profile viwer added
            ViewerService.AddProfileViewer(new Entities.ProfileViewer(offerGlobal.Business, LoggedData.LoggedJobSeeker));


            var business= BusinessService.SearchByBusinessName(offerGlobal.Business.Name);
            int offersNum = JobOfferService.GetOffersByBusinessName(offerGlobal.Business.Name).Count;
           // MessageBox.Show(business.Name);
            BusinessProfile b1 = new BusinessProfile(business,offersNum);
            b1.Show();
      
        }
    }
}
