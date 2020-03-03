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
using GotHired.Entities;
using GotHired.Services;

namespace GotHired.Dashboard
{
   
    public partial class ProfileViewerComponent : UserControl
    {
      

        public ProfileViewerComponent(ProfileViewer p1)
        {
            InitializeComponent();
            lblFullName.Text = p1.JobSeeker.Name + " " + p1.JobSeeker.LastName;
            lblProfession.Text = p1.JobSeeker.City;
        }
    }
}
