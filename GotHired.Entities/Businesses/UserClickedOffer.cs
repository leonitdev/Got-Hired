using GotHired.Entities.JobSeekers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotHired.Entities.Businesses
{
    public class UserClickedOffer
    {
        public UserClickedOffer(JobOffer jobOffer, JobSeeker jobSeeker)
        {
            JobOffer = jobOffer;
            JobSeeker = jobSeeker;
        }

        public JobOffer JobOffer { get; set; }
        public JobSeeker JobSeeker { get; set; }
    }
}
