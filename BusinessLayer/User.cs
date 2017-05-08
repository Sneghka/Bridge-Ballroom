using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string UserId { get; set; }
        public List<GameSet> SetsList { get; set; } = new List<GameSet>();

    }
}
