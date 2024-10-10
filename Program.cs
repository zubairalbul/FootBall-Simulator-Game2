namespace FootBall_Simulator_Game2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input team names
            Console.Write("Enter name for Team 1: ");
            ITeam team1 = new Team(Console.ReadLine(), new CreatePlayers());
            Console.Write("Enter name for Team 2: ");
            ITeam team2 = new Team(Console.ReadLine(), new CreatePlayers());
            // Start the game with the two teams
            MatchFlow game = new MatchFlow(team1, team2);
            game.Matchstart();
        }
    }
}
