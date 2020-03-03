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

namespace GotHired.Registers
{
    public partial class BusinessRegister : Form
    {
        public BusinessRegister()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            JobSeekerRegister jb = new JobSeekerRegister();
          //  this.Close();
            jb.Show();
        }

        private void btnRegisterBusiness_Click(object sender, EventArgs e)
        {
            if (BusinessService.DoesThisNameExist(txtBusinessName.Text) || JobSeekerService.DoesThisNameExist(txtBusinessName.Text))
            {
                MessageBox.Show("This Name is already taken.", "Warning");
            }
            else
            {
                var business = new Business(new BusinessType(cmbCategory.SelectedItem.ToString()),
                    new Category(cmbTypeBusiness.SelectedItem.ToString()),
                    txtBusinessName.Text, txtUsername.Text,
                    txtBusinessPassword.Text);

                    LoggedData.LoggedBusiness = business;

                    BusinessService.RegisterBusiness(business);
                    Home h1 = new Home();

                //   MessageBox.Show(LoggedData.LoggedBusiness.Name);
               // this.Close();
                h1.Show();
                  
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbTypeBusiness_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBusinessPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBusinessName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
