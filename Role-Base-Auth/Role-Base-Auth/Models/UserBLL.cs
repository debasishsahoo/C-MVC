using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Role_Base_Auth.Models
{
	public class UserBLL
	{
        public List<User> GetUsers()
        {
            List<User> userList = new List<User>();
            userList.Add(new User()
            {
                ID = 1,
                UserName = "Mir",
                Password = "123456",
                Role="Admin",
                Email="admin@a.com"
            });
            userList.Add(new User()
            {
                ID = 2,
                UserName = "Abir",
                Password = "abcdef",
                Role = "Admin,Superadmin",
                Email = "bothUser@a.com"
            });
            userList.Add(new User()
            {
                ID = 3,
                UserName = "Poly",
                Password = "123abc",
                Role = "Superadmin",
                Email = "superadmin@a.com"
            });

            return userList;
        }
    }
}