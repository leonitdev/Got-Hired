using GotHired.Entities.JobSeekers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GotHired.JobSeekerSIde
{
    public partial class ProfileJobSeeker : Form
    {
        public ProfileJobSeeker(JobSeeker j1)
        {
            InitializeComponent();
            lblAge.Text = "Age: " + j1.Age;
            lblCity.Text = "City: " + j1.City;
            lblLastName.Text = "Gender: "+j1.Gender;
            lblName.Text = "Name: " + j1.Name;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
