using GotHired.Entities.Businesses;
using GotHired.Entities.JobSeekers;
using GotHired.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GotHired.Services
{
    public class ApplicationService
    {

        //Apply for this job
        public static void Apply(JobOffer jOffer, JobSeeker jSeeker,string status)
        {
            DbContext.Applications.Add(new Application_(jOffer, jSeeker,status));
        }


        //Delete your application
        public static void DeleteApplication(int id)
        {
            foreach (var item in DbContext.Applications)
            {
                if (item.Id == id)
                {
                    DbContext.Applications.Remove(item);
                    break;
                }

            }
        }

        //Get Last application
        public static Application_ GetLastApplication()
        {
            return DbContext.Applications[DbContext.Applications.Count - 1];
        }

        //Get Application by Id
        public static Application_ GetApplicationById(int id)
        {
            foreach (var item in DbContext.Applications)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        //Get Application by Business Name
        public static List<Application_> GetApplicationByBusinessName(string name)
        {
            List<Application_> Applications = new List<Application_>();
            foreach (var item in DbContext.Applications)
            {
                if (item.JobOffer.Business.Name == name)
                {
                    Applications.Add(item);
                }
            }
            return Applications;
        }

        //Get Applicatnts by Business Name and gender
        public static int GetApplicationsByMale()
        {
            List<Application_> Applications = new List<Application_>();
            foreach (var item in DbContext.Applications)
            {
                if (item.JobSeeker.Gender == "Male")
                {
                    Applications.Add(item);
                }
            }
            return Applications.Count;
        }

        //All male job seekers num
        public static int AllMaleJobSeekersNum()
        {
            List<JobSeeker> MaleFound = new List<JobSeeker>();
            foreach (var item in DbContext.Applications)
            {
                if (item.JobSeeker.Gender == "Male".ToLower())
                {
                    MaleFound.Add(item.JobSeeker);
                }
            }
            return MaleFound.Count;
        }

        //female job Seekers num.
        public static int AllFemaleJobSeekersNum()
        {
            return DbContext.Applications.Count - AllMaleJobSeekersNum();
        }


        //ALL  Refused Jobs
        public static int ApplicationRefused(string businessName)
        {
            List<Application_> RefusedApplied = new List<Application_>();
            foreach (var item in DbContext.Applications)
            {
                if (item.Status == "Refused".ToLower() && item.JobOffer.Business.Name.ToLower() == businessName.ToLower())
                {
                    RefusedApplied.Add(item);
                }
            }
            return RefusedApplied.Count;
        }

        //Applications to this business
        public static List<Application_> GetMyOfferApplications(Business b1)
        {
            List<Application_> Applications = new List<Application_>();
            foreach (var item in DbContext.Applications)
            {
                if (item.JobOffer.Business.Id == b1.Id)
                {
                    Applications.Add(item);
                }
            }
            return Applications;
        }

       

    }
}
