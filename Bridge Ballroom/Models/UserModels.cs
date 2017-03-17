using System.Collections.Generic;

namespace Bridge_Ballroom.Models
{
    public class UserModels
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string UserId { get; set; }
        public List<GamesSet> SetsList { get; set; } = new List<GamesSet>();

    }
}