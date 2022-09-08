using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.Models
{
    class User
    {
        public string name;
        public string username;
        public string password;
        public string email;

        public User(string name, string username, string password, string email)
        {
            this.name = name;
            this.username = username;
            this.password = password;
            this.email = email;
        }
    }
}
