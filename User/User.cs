using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Course_Registration_System.User
{
    internal class User
    {
        private string Name { get; set; }
        private string Email { get; set; }

        //constructor
        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public void SetName(string name) { Name = name; }
        public string GetName() => Name;

        public string GetEmail() => Email;
    }

    
}
