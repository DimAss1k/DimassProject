using piris.DomainService.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace piris.DomainService
{
    public class AuthService : IAuthService
    {
        private static DatabaseService _databaseService = new
        DatabaseService();
        public bool UserAuth(UserRegistration userObj)
        {
            var res =
   _databaseService.GetUserByUserName(userObj.UserName);
            if (res == null)
            {
                return false;
            }
            if (userObj.Password == res.userPassword)
            {
                return true;
            }
            return true;
        }
        public bool UserRegistration(UserRegistration userObj)
        {
            store_users dbUser = new store_users();
            dbUser.userName = userObj.UserName;
            dbUser.userPassword = userObj.Password;
            var res = _databaseService.CreateUser(dbUser);
            return res;
        }
    }
}
