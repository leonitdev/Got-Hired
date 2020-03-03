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
using GotHired.Dashboard;

namespace GotHired.JobSeekerSIde
{
    public partial class AllOffers : UserControl
    {
        public AllOffers()
        {
            InitializeComponent();
            foreach (var item in JobOfferService.GetAllOffers())
            {
                flowLayoutPanel1.Controls.Add(new offerComponent(item,this));
            }
            flowLayoutPanel1.Refresh();
        }
    }
}
