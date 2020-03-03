using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GotHired.Services;
using GotHired.Entities.Businesses;
using GotHired.Entities.JobSeekers;
using GotHired.Dashboard;
using GotHired.JobSeekerSIde;

namespace GotHired.Registers
{
    public partial class JobSeekerRegister : Form
    {
        public JobSeekerRegister()
        {
            InitializeComponent();
       
        }

        private void JobSeekerRegister_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBusinessCreate_Click(object sender, EventArgs e)
        {
            BusinessRegister b1 = new BusinessRegister();
      //      this.Close();
            b1.Show();
        }


        private void btnRegisterJobSeeker_Click(object sender, EventArgs e)
        {
            if (JobSeekerService.DoesThisNameExist(txtFirstName.Text) || BusinessService.DoesThisNameExist(txtFirstName.Text))
            {
                MessageBox.Show("This Name is already taken.", "Warning");
            }
            else
            {
                string gender = "asd";
                if (rdbMale.Checked) gender = "Male";
                else gender = "Female";
                var jobSeeker = new JobSeeker(gender,txtLastName.Text,cmbCities.SelectedItem.ToString(), txtFirstName.Text,Convert.ToInt32(txtAge.Text),txtUserName.Text, txtPasswordJobSeeker.Text);
                JobSeekerService.RegisterJobSeeker(jobSeeker);
                LoggedData.LoggedJobSeeker = jobSeeker;

                HomeJobSeeker h1 = new HomeJobSeeker();
           //     this.Close();
                h1.Show();
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAge.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtAge.Text = txtAge.Text.Remove(txtAge.Text.Length - 1);
            }
        }
    }
}
