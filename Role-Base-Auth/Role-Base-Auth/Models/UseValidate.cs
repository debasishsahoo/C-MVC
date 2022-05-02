using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Role_Base_Auth.Models
{
    public class UseValidate
    {
        //This method is used to Check the User Credentials
        public static bool Login(string username, string password)
        {
            UserBLL userBLL = new UserBLL();

            List<User> users = userBLL.GetUsers();

            return users.Any(user => user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase) && user.Password == password);
        }
        //This method is used to Check the User Details
        public static User GetUserDetails(string username, string password)
        {
            UserBLL userBLL = new UserBLL();

            return userBLL.GetUsers().FirstOrDefault(e => e.UserName.Equals(username, StringComparison.OrdinalIgnoreCase) && e.Password == password);
        }
    }
}