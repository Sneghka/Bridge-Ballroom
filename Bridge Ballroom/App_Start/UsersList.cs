using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bridge_Ballroom.Models;

namespace Bridge_Ballroom.App_Start
{
    public  class UsersList
    {
        public List<UserModels> ListOfUser { get; set; } = new List<UserModels>();
       
        public bool IsUserExist(string userName)
        {
            return ListOfUser.Any(user => user.Name == userName);
        }
    }
}