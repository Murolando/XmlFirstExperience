using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_Experience
{
    [Serializable]
    public class Users
    {
        public List<User> UsersList { get; set; } = new List<User>();
      
    }
    [Serializable]
    public class User
    {
        public string user_name { get; set; }
        public int user_age { get; set; }
        public int user_sex { get; set; }

        public User() { }
        public User(string user_name, int user_sex, int user_age)
        {
            this.user_name = user_name;
            this.user_age = user_age;
            this.user_sex = user_sex;
        }
    }

}
