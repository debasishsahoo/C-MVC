using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuth.Models
{
    public class UserValidator
    {
        public static bool Login(string username,string password)
        {
            UserBLL userBLL = new UserBLL(); 

            List<User> users=userBLL.GetUsers();

            return users.Any(user=>user.UserName.Equals(username,StringComparison.OrdinalIgnoreCase)&& user.Password==password);
        }
    }
}