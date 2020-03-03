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
    public class JobOfferService
    {
        public static void AddOffer(JobOffer o1)
        {
            DbContext.Offers.Add(o1); // e kem shti ni offert nga biznesi me Id  te caktuar
        }

        // show job offers
        public static List<JobOffer> GetAllOffers()
        {
            return DbContext.Offers;
        }

        //Get offerBy Id
        public static JobOffer GetOfferById(int id)
        {
            foreach (var item in DbContext.Offers)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        //search by job name
        public static List<JobOffer> SearchByJobName(string title)
        {
            List<JobOffer> foundJobs = new List<JobOffer>();
            foreach (var item in DbContext.Offers)
            {
                if (item.Title == title)
                    foundJobs.Add(item);
            }
            return foundJobs;
        }

        public static List<JobOffer> GetOffersByCityAndBusinessName(string title,string city)
        {
            List<JobOffer> foundJobs = new List<JobOffer>();
            foreach (var item in GetOffersByBusinessName(title))
            {
                if (item.Address.City == city)
                    foundJobs.Add(item);
            }
            return foundJobs;
        }

        //getOfferNum
        public static int GetOfferNum()
        {
            return DbContext.Offers.Count;
        }

        //getJobByCategory only for one business
        public static int GetJobBsyCategory(string category)
        {
            List<JobOffer> categoryJob = new List<JobOffer>();
            foreach (var item in DbContext.Offers)
            {
                if (item.Category.Name.ToLower() == category.ToLower())
                    categoryJob.Add(item);
            }
            return categoryJob.Count;
        }

        //getJobByCategory only for one business
        public static int GetJobBsyCategoryAndBusinessName(string category,string businessName)
        {
            List<JobOffer> categoryJob = new List<JobOffer>();
            foreach (var item in DbContext.Offers)
            {
                if (item.Category.Name.ToLower() == category.ToLower() && item.Business.Name.ToLower() == businessName.ToLower())
                    categoryJob.Add(item);
            }
            return categoryJob.Count;
        }

        //getJobBsyCity
        public static int GetJobBsyCity(string city)
        {
            List<JobOffer> categoryJob = new List<JobOffer>();
            foreach (var item in DbContext.Offers)
            {
                if (item.Address.City.ToLower() == city.ToLower())
                    categoryJob.Add(item);
            }
            return categoryJob.Count;
        }

        //GetOffersByBusinessName
        public static List<JobOffer> GetOffersByBusinessName(string name)
        {
            List<JobOffer> offers = new List<JobOffer>();
            foreach (var item in DbContext.Offers)
            {
                if (item.Business.Name.ToLower() == name.ToLower())
                    offers.Add(item);
            }
            return offers;
        }


        //GetOffers by Business, JobOffer and Date Share 
        public static List<JobOffer> GetOffersByBusinessJobOfferDate(string businessName,string JobTitle ,string date)
        {
            List<JobOffer> offers = new List<JobOffer>();
            foreach (var item in DbContext.Offers)
            {
                if (item.Business.Name.ToLower() == businessName.ToLower() && item.Title==JobTitle && item.DateCreated.ToShortDateString()==date)
                    offers.Add(item);
            }
            return offers;
        }

        ///part 2 
        ////.
        //CheckOffer 

        public static void CheckOffer(int id) // Ofert that is clicked will be added here
        {
            DbContext.UsersThatClickedOffers.Add(new UserClickedOffer(GetOfferById(id),LoggedData.LoggedJobSeeker));
        }


        //GetOffersClickedUsers
        public static List<UserClickedOffer> GetClickedUsersInOffer()
        {
            return DbContext.UsersThatClickedOffers;
        }

        //getByCity
        public static List<JobSeeker> GetClickedUsersInOfferByOfferId(int id)
        {
            List<JobSeeker> temp = new List<JobSeeker>();
            foreach (var item in DbContext.UsersThatClickedOffers)
            {
                if (item.JobOffer.Id == id)
                    temp.Add(item.JobSeeker);
            }
            return temp;
        }
        //getByCity
        public static List<JobSeeker> GetClickedUsersInOffer(string city)
        {
            List<JobSeeker> temp = new List<JobSeeker>();
            foreach (var item in DbContext.UsersThatClickedOffers)
            {
                if (item.JobSeeker.City.ToLower() == city.ToLower())
                     temp.Add(item.JobSeeker);
            }
            return temp;
        }

        //getByAge
        public static List<JobSeeker> GetClickedUsersInOffer(int startAge, int endAge)
        {
            List<JobSeeker> temp = new List<JobSeeker>();
            foreach (var item in DbContext.UsersThatClickedOffers)
            {
                if (item.JobSeeker.Age >= startAge && item.JobSeeker.Age <= endAge)
                    temp.Add(item.JobSeeker);
            }
            return temp;
        }

        //getByBusinessCategory
        public static List<JobSeeker> GetClickedUsersInOffer(string category,int i=0)
        {
            List<JobSeeker> temp = new List<JobSeeker>();
            foreach (var item in DbContext.UsersThatClickedOffers)
            {
                if (item.JobOffer.Category.Name == category)
                {
                    temp.Add(item.JobSeeker);
                }
            }
            return temp;
        }

        ////
        ///


    }
}
