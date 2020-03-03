using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotHired.Entities.Businesses
{
    public class Category
    {
        private static int _id { get; set; }
        public Category(string name)
        {
            Id = ++_id;
            Name = name;
        }

        private static int Id { get; set; }
        public string Name { get; set; }
    }
}
