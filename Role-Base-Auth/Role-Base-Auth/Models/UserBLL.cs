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
                //Base64Encode->TWlyOjEyMzQ1Ng==     //Mir:123456
                ID = 1,
                UserName = "Mir",
                Password = "123456",
                Roles="Admin",
                Email="admin@a.com"
            });
            userList.Add(new User()
            {
                //Base64Encode->QWJpcjphYmNkZWY=    //Abir:abcdef
                ID = 2,
                UserName = "Abir",
                Password = "abcdef",
                Roles = "Admin,Superadmin",
                Email = "bothUser@a.com"
            });
            userList.Add(new User()
            {
                //Base64Encode->UG9seToxMjNhYmM=    //Poly:123abc
                ID = 3,
                UserName = "Poly",
                Password = "123abc",
                Roles = "Superadmin",
                Email = "superadmin@a.com"
            });

            return userList;
        }
    }
}