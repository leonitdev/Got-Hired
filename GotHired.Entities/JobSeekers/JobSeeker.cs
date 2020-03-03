using GotHired.Entities.Businesses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using PersonLib;

namespace GotHired.Entities.JobSeekers
{
    public class JobSeeker:User
    {
        public static int _id { get; set; } = 0;

        public JobSeeker(string gender,string lastName, string city, string name, int age, string username, string password) : base(name, username, password,null)
        {
            Gender = gender;
            //LastName = lastName;
            City = city;
            Age = age;
        }

        public override string GetInfo()
        {
            return $"Name: {Name} , Surname:{LastName} - {Gender} \nCity:{City} - Age:{Age}";
        }


        new public int  Id { get; set; }
      // public string LastName { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

    }
}
