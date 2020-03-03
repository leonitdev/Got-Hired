using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GotHired.Entities;
using GotHired.Entities.Businesses;
using GotHired.Entities.JobSeekers;

namespace GotHired.Persistance
{
    public static class DbContext
    {

        //Businesses List
        public static List<Business> Businesses { get; set; } = new List<Business>();

        //JobSeekers List
        public static List<JobSeeker> JobSeekers { get; set; } = new List<JobSeeker>();

        //Offers list
        public static List<JobOffer> Offers { get; set; } = new List<JobOffer>();

        //Applications List
        public static List<Application_> Applications = new List<Application_>();

        //Users That click Offers List
        public static List<UserClickedOffer> UsersThatClickedOffers = new List<UserClickedOffer>();

        //Profile Viewers List
        public static List<ProfileViewer> ProfileViewers = new List<ProfileViewer>();



    }
}
