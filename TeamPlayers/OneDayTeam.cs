using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamPlayers
{
  
    public  class OneDayTeam : ITeam
    {
        private static List<Player> oneDayTeam = new List<Player>();
        private const int TeamCapacity = 11;

        

        public OneDayTeam()
        {
            oneDayTeam = new List<Player>(TeamCapacity);
        }
        public void Add(Player player)
        {
            if(oneDayTeam.Count < TeamCapacity)
            {
                oneDayTeam.Add(player);
                Console.WriteLine("player add to the team.");
            }
            else
            {
                Console.WriteLine("Team full");
            }
        }
        public void Remove(int PlayerId)
        {
            Player playerToRemove = oneDayTeam.FirstOrDefault(p => p.PlayerId == PlayerId);
            if(playerToRemove != null)
            {
                oneDayTeam.Remove(playerToRemove);
                Console.WriteLine("player Removed");
            }
            else
            {
                Console.WriteLine("player not found");
            }
        }
        public Player GetPlayerById(int PlayerId)
        {
            return oneDayTeam.FirstOrDefault(p => p.PlayerId == PlayerId);
        }
        public Player GetPlayerByName(string PlayerName)
        {
            return oneDayTeam.FirstOrDefault(p => p.PlayerName.Equals(PlayerName, StringComparison.OrdinalIgnoreCase));

        }
        public List<Player> GetAllPlayer()
        {
            return oneDayTeam;
        }



    }
}
