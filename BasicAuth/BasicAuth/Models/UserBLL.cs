using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuth.Models
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
                Password = "123456"
            });
            userList.Add(new User()
            {
                ID = 2,
                UserName = "Abir",
                Password = "abcdef"
            });

            return userList;
        }
        
        
        
    }
}