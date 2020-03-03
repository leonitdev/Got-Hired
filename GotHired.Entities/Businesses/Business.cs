using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotHired.Entities.Businesses
{
    public class Business:User
    {
        private static int _id = 0;

        public Business(BusinessType businessType, Category bsCategory, string name, string username, string password) : base( name, username, password,"address")
        {
            Id = ++_id;
            BusinessType = businessType;
            BusinessCategory = bsCategory;
        }

        public override string GetInfo()
        {
            return $"Business name: {Name}, Type {BusinessType.Type} - Category:{BusinessCategory.Name}";
        }

        new public int Id { get; set; }
        public BusinessType BusinessType { get; set; }
        public Category BusinessCategory { get; set; }
    }
}
