using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class GameSet
    {
        public string Status { get; set; }
        public List<Game> Games { get; set; } = new List<Game>();
        public DateTime LastGameDate => (from game in Games select game.Date).Max();
        public List<string> UsersName { get; set; }
        public int TotalScore { get; set; }
        public string GamesSetId { get; set; }

    }
}
