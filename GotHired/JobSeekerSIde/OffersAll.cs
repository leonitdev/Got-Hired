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

namespace GotHired.JobSeekerSIde
{
    public partial class OffersAll : UserControl
    {
        public OffersAll()
        {
            InitializeComponent();
            foreach (var item in JobOfferService.GetOffersByBusinessName(LoggedData.LoggedBusiness.Name))
            {
                flowLayoutPanel1.Controls.Add(new offerComponent(item));
            }
            flowLayoutPanel1.Refresh();
        }
    }
}
