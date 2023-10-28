using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamPlayers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam oneDayTeam = new OneDayTeam();

            while(true)
            {
                Console.WriteLine("Enter choice:");
                Console.WriteLine("1.Add player");
                Console.WriteLine("2.Remove player by Id");
                Console.WriteLine("3.Get player by Id");
                Console.WriteLine("4.Get player by Name ");
                Console.WriteLine("5.Get All players");
                Console.WriteLine("6.Exit");

                int choice;
                if(int.TryParse(Console.ReadLine(),out choice))
                {
                    switch(choice)
                    {
                        case 1:
                            Console.Write("Enter player Id:");
                            int playerId = int.Parse(Console.ReadLine());
                            Console.Write("Enter player Name:");
                            string playerName = Console.ReadLine();
                            Console.Write("Enter Player Age:");
                            int playerAge = int.Parse(Console.ReadLine());

                            Player newPlayer = new Player
                            {
                                PlayerId = playerId,
                                PlayerName = playerName,
                                PlayerAge = playerId
                            };
                            oneDayTeam.Add(newPlayer);
                            Console.WriteLine("Player added to team.");
                            break;
                        case 2:
                            Console.Write("Enter player Id to Remove:");
                            int idToRemove = int.Parse(Console.ReadLine());
                            oneDayTeam.Remove(idToRemove);
                            break;
                        case 3:
                            Console.WriteLine("Enter player Id to Get:");
                            int idToGet = int.Parse(Console.ReadLine());
                            Player playerById = oneDayTeam.GetPlayerById(idToGet);
                            if(playerById != null)
                            {
                                Console.WriteLine($"Player Id: {playerById.PlayerId},Name:{playerById.PlayerName},Age:{playerById.PlayerAge}");
                            }
                            else
                            {
                                Console.WriteLine("player not found.");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Enter player Name to get:");
                            string nameToGet = Console.ReadLine();
                            Player playerByName = oneDayTeam.GetPlayerByName(nameToGet);
                            if(playerByName != null)
                            {
                                Console.WriteLine($"Player Id: {playerByName.PlayerId},Name:{playerByName.PlayerName},Age:{playerByName.PlayerName}");
                            }
                            else
                            {
                                Console.WriteLine("players not found");
                            }
                            break;
                        case 5:
                            var allPlayers = oneDayTeam.GetAllPlayer();
                            foreach (var player in allPlayers)
                            {
                                Console.WriteLine($"Player Id:{player.PlayerId}, Name:{player.PlayerName},Age:{player.PlayerAge}");
                            }
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }

        }
    }
}
