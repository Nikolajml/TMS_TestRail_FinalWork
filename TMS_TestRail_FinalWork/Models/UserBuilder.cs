using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_TestRail_FinalWork.Models
{
    public class UserBuilder
    {
        private User user;

        public UserBuilder()
        {
            user = new User();
        }

        public UserBuilder SetUsername(string username)
        {
            user.Username = username;
            return this;
        }

        public UserBuilder SetPassword(string password)
        {
            user.Password = password;
            return this;
        }

        public UserBuilder SetEmail(string email)
        {
            user.Email = email;
            return this;
        }

        public User Build()
        {
            return user;
        }
    }
}
