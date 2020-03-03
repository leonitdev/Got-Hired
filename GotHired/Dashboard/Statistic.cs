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

namespace GotHired
{
    public partial class Statistic : UserControl
    {
        public Statistic()
        {
            InitializeComponent();
          
            lblBusinessNum.Text = BusinessService.GetBusinessNum().ToString();
            lbJobSeekerNum.Text = JobSeekerService.GetJobSeekerNum().ToString();
            lblOfferNum.Text = JobOfferService.GetOfferNum().ToString();
        }
    }
}
