using GotHired.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GotHired.Dashboard
{
    public partial class BusinessProfileViewer : Form
    {
        public BusinessProfileViewer()
        {
            InitializeComponent();
            var list = ViewerService.GetMyProfileViewers(LoggedData.LoggedBusiness.Name);
            foreach (var item in list)
            {
                flowLayoutPanel1.Controls.Add(new ProfileViewerComponent(item));
            }
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
