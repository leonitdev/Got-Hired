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
    public partial class filteredData : UserControl
    {
        public filteredData()
        {
            InitializeComponent();
          
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (var item in JobOfferService.GetOffersByBusinessJobOfferDate
                (txtCompanyName.Text.ToLower(),txtJobName.Text.ToLower(),txtDateTime.ToString()))
            {
                flowLayoutPanel1.Controls.Add(new offerComponent(item));
            }
        }
    }
}
