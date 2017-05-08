using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UsersList
    {
        public static List<User> ListOfUser { get; set; } = new List<User>();

        public static bool IsUserExist(string userName)
        {
            return ListOfUser.Any(user => user.Name == userName);
        }
    }
}
