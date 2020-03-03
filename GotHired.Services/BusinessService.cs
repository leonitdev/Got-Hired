using GotHired.Entities.Businesses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GotHired.Persistance;
using GotHired.Entities;

namespace GotHired.Services
{
    public class BusinessService
    {
        //Register Business
        public static void RegisterBusiness(Business b1)
        {
            DbContext.Businesses.Add(b1);
        }

        //search by Business Name
        public static Business SearchByBusinessName(string name)
        {
            foreach (var item in DbContext.Businesses)
            {
                if (item.Name == name)
                   return item;

            }
            return null;
        }


        //Check if this businessName exists
        public static bool DoesThisNameExist(string name)
        {
            foreach (var item in DbContext.Businesses)
            {
                if (item.Username == name)
                    return true;
            }
            return false;
        }

        //get Business num
        public static int GetBusinessNum()
        {
            return DbContext.Businesses.Count;
        }

        //------------------------------------------------------------------
        //Part 2
        public static void ViewProfile(ProfileViewer p1)
        {
            DbContext.ProfileViewers.Add(p1);
        }

    }
}
