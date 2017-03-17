using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bridge_Ballroom.Models
{
    public class GamesSet
    {
        public string Status { get; set; }
        public List<GameModels> Games { get; set; } = new List<GameModels>();
        public DateTime LastGameDate => (from game in Games select game.Date).Max();
        public List<string> UsersName { get; set; }
        public int TotalScore { get; set; }
        public string GamesSetId { get; set; }
    }
}