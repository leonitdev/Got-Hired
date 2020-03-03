using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLib;


namespace GotHired.Entities
{
    public abstract class User:Person
    {
        public User(string name,  string username, string password, string address) : base(name, null,null)
        {
            //Name = name;
            Username = username;
            Password = password;
        }

       // public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual string GetInfo()
        {
            return $"Name";
        }


    }
}
