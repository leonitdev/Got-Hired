using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GotHired.Entities.JobSeekers;
using GotHired.Services;


namespace GotHired
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            JobSeekerService.RegisterJobSeeker(new JobSeeker("LEONIT", "kULETA",null, "123456",46, "Leonit","MALE"));

            MessageBox.Show(JobSeekerService.DoesThisNameExist("LEONIT").ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
