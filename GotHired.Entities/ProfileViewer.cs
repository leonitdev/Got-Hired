using GotHired.Entities.Businesses;
using GotHired.Entities.JobSeekers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotHired.Entities
{
    public class ProfileViewer
    {
        public ProfileViewer(Business business, JobSeeker jobSeeker)
        {
            Business = business;
            JobSeeker = jobSeeker;
        }

        public Business Business { get; set; }
        public JobSeeker JobSeeker { get; set; }
    }
}
