using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoyalEMS_MVC.Models
{
    public class AppUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class LoginModel
    {
        public static List<AppUser> UserList;
        static LoginModel()
        {
            UserList = new List<AppUser>()
            {
                new AppUser(){UserName="sa",Password="sa12345"},
                new AppUser(){UserName="admin",Password="admin12345"},
                new AppUser(){UserName="fa",Password="fa12345"},
                new AppUser(){UserName="br",Password="br12345"},
            };
        }

        public static bool IsValid(AppUser user)
        {
           var data = UserList.FirstOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);

            if (data != null)
                return true;
            return false;
        }
    }
}