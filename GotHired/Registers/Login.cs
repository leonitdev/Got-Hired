using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GotHired.Dashboard;
using GotHired.Services;
using GotHired.Registers;
using GotHired.JobSeekerSIde;

namespace GotHired.Registers
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblCreateJobSeekerAcc_Click(object sender, EventArgs e)
        {
            this.Close();
            JobSeekerRegister j1 = new JobSeekerRegister();
            j1.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           // LoggedData.LoggedJobSeeker = null;

            bool Exists = JobSeekerService.DoesThisNameExist(txtUsername.Text);
            if (Exists)
            {
                //MessageBox.Show("Go to joobSeker web");

                //Initialzing object
                var user = JobSeekerService.GetByUsername(txtUsername.Text);
                LoggedData.LoggedJobSeeker.Username = txtUsername.Text;
                LoggedData.LoggedJobSeeker.Name = user.Name;
                LoggedData.LoggedJobSeeker.Password = user.Password;
                LoggedData.LoggedJobSeeker.LastName = user.LastName;
                LoggedData.LoggedJobSeeker.Id = user.Id;


                this.Close();
                HomeJobSeeker h = new HomeJobSeeker();
                h.Show();
            }
            else if (BusinessService.DoesThisNameExist(txtUsername.Text))
            {
                LoggedData.LoggedBusiness.Username = txtUsername.Text;
                Home h1 = new Home();
                h1.Show();
            }

        }

        private void lblBusinessCreate_Click(object sender, EventArgs e)
        {
            this.Close();
            BusinessRegister b1 = new BusinessRegister();
            b1.Show();
        }
    }
}
