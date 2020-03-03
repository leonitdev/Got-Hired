using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotHired.Entities.Businesses
{
    public class BusinessType
    {
        private static int _id { get; set; } = 0;

        public BusinessType(string type)
        {
            Id = ++_id;
            Type = type;
        }

        public int Id { get; set; }
        public string Type { get; set; }
    }
}
