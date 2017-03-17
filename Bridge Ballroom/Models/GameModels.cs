using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bridge_Ballroom.Models
{
    public class GameModels
    {
        public int TotalScore { get; set; }
        public string PlayingUsers { get; set; }
        public int Points { get; set; }
        public string ContractName { get; set; }
        public int TricksNumber  { get; set; }
        public DateTime Date { get; set; }
        public string GameId { get; set; }
    }
}