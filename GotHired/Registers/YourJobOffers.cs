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
using GotHired.UI;

namespace GotHired.Registers
{
    public partial class YourJobOffers : UserControl
    {

        
       
        public YourJobOffers()
        {
            InitializeComponent();

            //
            //var offer = new JobOffer("title", "Helo world",new Business("Interex",null,new Category("Category"),null)
            //    , new Address("Prishtina", "hello", 1000),new Category("Category name"));
          //  MessageBox.Show(LoggedData.LoggedBusiness.Name);

            foreach (var item in JobOfferService.GetOffersByBusinessName(LoggedData.LoggedBusiness.Name))
            {
                flowLayoutPanel1.Controls.Add(new OfferComponent(item));
            }
            flowLayoutPanel1.Refresh();



        }



        private void YourJobOffers_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
