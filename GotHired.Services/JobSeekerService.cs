using GotHired.Entities;
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
    public class JobSeekerService
    {
        public static void RegisterJobSeeker(JobSeeker j1)
        {
            DbContext.JobSeekers.Add(j1);
        }

        //check if user exists

        public static bool DoesThisNameExist(string name)
        {
            foreach (var item in DbContext.JobSeekers)
            {
                if (item.Username == name)
                    return true;
            }
            return false;
        }

        //get Job Seeker num
        public static int GetJobSeekerNum()
        {
            return DbContext.JobSeekers.Count;
        }

        //get user by id
        public static JobSeeker GetById(int id)
        {
            foreach (var item in DbContext.JobSeekers)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }
        // get by username
        public static JobSeeker GetByUsername(string username)
        {
            foreach (var item in DbContext.JobSeekers)
            {
                if (item.Username == username)
                    return item;
            }
            return null;
        }
        ////////////////
        ////Part 2
        ///
        public static List<ProfileViewer> GetAllProfileViewers()
        {
            return DbContext.ProfileViewers; 
        }

        //GetProfileViewer by gender
        public static List<JobSeeker> GetMyProfileViewers(string businessCategory)
        {
            List<JobSeeker> temp = new List<JobSeeker>();
            foreach (var item in DbContext.ProfileViewers)
            {
                if (item.Business.BusinessCategory.Name.ToLower() == businessCategory.ToLower())
                    temp.Add(item.JobSeeker);
            }
            return temp;
        }

        //
        public static List<JobSeeker> GetMyProfileViewers(string gender,int age)
        {
            List<JobSeeker> temp = new List<JobSeeker>();
            foreach (var item in DbContext.ProfileViewers)
            {
                if (item.JobSeeker.Gender.ToLower() == gender.ToLower() && item.JobSeeker.Age>=age)
                    temp.Add(item.JobSeeker);
            }
            return temp;
        }
    }
}
