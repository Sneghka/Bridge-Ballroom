using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bridge_Ballroom.Models;

namespace Bridge_Ballroom.App_Start
{
    public static class UsersList
    {
        public static List<UserModels> ListOfUser { get; set; } = new List<UserModels>();
       
        public static bool IsUserExist(string userName)
        {
            return ListOfUser.Any(user => user.Name == userName);
        }
    }
}