using GotHired.Entities.Businesses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotHired.Entities.JobSeekers
{
    public class Application_
    {
        private static int _id { get; set; } = 0;

        public Application_(JobOffer offer, JobSeeker jobSeeker,string status)
        {
            Id = ++_id;
            JobOffer = offer;
            JobSeeker = jobSeeker;
            Status = status;
        }

        public int Id { get; private set; }
        public JobOffer JobOffer { get; set; }
        public JobSeeker JobSeeker { get; set; }
        public string Status { get; set; }
    }
}
