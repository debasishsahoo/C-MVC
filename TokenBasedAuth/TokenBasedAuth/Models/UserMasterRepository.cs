using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenBasedAuth.Models
{
    public class UserMasterRepository : IDisposable
    {
        UserModel context =new UserModel();

        public UserMaster ValidateUser(string username,string password)
        {
            return context.UserMasters.FirstOrDefault(user => user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase) && user.UserPassword == password);
        }

        public void Dispose()
        {
            context.Dispose();
        }

    }
}