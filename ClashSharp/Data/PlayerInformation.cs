using System.Collections.Generic;

namespace ClashSharp.Data
{
    public class PlayerInformation
    {
        public string Tag { get; set; }
        public string Name { get; set; }
        public int TownHallLevel { get; set; }
        public int ExpLevel { get; set; }
        public int Trophies { get; set; }
        public int BestTrophies { get; set; }
        public int WarStars { get; set; }
        public int AttackWins { get; set; }
        public int DefenseWins { get; set; }
        public string Role { get; set; }
        public int Donations { get; set; }
        public int DonationsReceived { get; set; }
        public PlayerClanInfomation Clan { get; set; }
        public League League { get; set; }
        public List<Achievement> Achievements { get; set; }
        public List<Troop> Troops { get; set; }
        public List<Hero> Heroes { get; set; }
        public List<Spell> Spells { get; set; }
    }
}
