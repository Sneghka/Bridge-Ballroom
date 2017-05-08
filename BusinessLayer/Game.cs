using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Game
    {
        public int TotalScore { get; set; }
        public string PlayingUsers { get; set; }
        public int Points { get; set; }
        public string ContractName { get; set; }
        public int TricksNumber { get; set; }
        public DateTime Date { get; set; }
        public string GameId { get; set; }

    }
}
