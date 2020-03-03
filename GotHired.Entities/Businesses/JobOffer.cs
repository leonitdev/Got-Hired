using GotHired.Entities.JobSeekers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotHired.Entities.Businesses
{
    public class JobOffer
    {
        private static int _id { get; set; }
        public JobOffer(string title, string description, Business business, Address address, Category category)
        {
            Id = ++_id;
            Title = title;
            Description = description;
            DateCreated = new DateTime();
            Address = address;
            Category = category;
            Business = business;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public Address Address { get; set; }
        public Category Category { get; set; }
        public Business Business { get; set; }
        public bool Promoted { get; set; } = false;

    }
}
