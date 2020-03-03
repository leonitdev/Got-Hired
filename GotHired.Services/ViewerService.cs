using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GotHired.Entities;
using GotHired.Entities.Businesses;
using GotHired.Entities.JobSeekers;
using GotHired.Persistance;

namespace GotHired.Services
{
    public class ViewerService
    {
        // add profile viwer
        public static void AddProfileViewer( ProfileViewer p1)
        {
            DbContext.ProfileViewers.Add(p1);
        }

        // get profile viwer num
        public static int ProfileViwerNum()
        {
            return DbContext.ProfileViewers.Count;
        }


        //get my profile viewers
        public static List<ProfileViewer> GetMyProfileViewers(string name)
        {
            
            List<ProfileViewer> found = new List<ProfileViewer>();
            foreach (var item in DbContext.ProfileViewers)
            {
                if (item.Business.Name == name)
                {
                    found.Add(item);
                }
            }
            return found;
        }

    }
}
