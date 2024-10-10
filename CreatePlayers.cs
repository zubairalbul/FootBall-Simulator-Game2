using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Simulator_Game2
{
    public class CreatePlayers : IPlayerGenerator
    {
        private Random random = new Random();
        private readonly List<string> PlayerNames = new List<string>()
        {
        "Ahmed", "Omar", "Hassan", "Ali", "Mohammed", "Youssef", "Mahmoud", "Khaled", "Ibrahim", "Said",
        "Ziad", "Tariq", "Fahad", "Musa", "Salim", "Rami", "Samir", "Jamil", "Nasser", "Mustafa"
        };
        // Create a player with a random name, a given position, and a random skill level
        public IPlayer CreatePlayer(string position)
        {
            string name = PlayerNames[random.Next(PlayerNames.Count)]; // Randomly pick a name
            int skill = random.Next(1, 101); // Random skill between 1 and 100
            return new Players(name, position, skill);
        }
    }
    // Class to handle the flow of the soccer match


}

