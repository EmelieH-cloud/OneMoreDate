using OneMoreDate.Models;

namespace OneMoreDate.Managers
{
    public static class PlayerManager
    {
        public static List<Player> Players { get; set; } = new();
        private static bool CheckMarriageStatus(int index)
        {
            Player PotentiallyMarriedPlayer = Players[index];
            if (PotentiallyMarriedPlayer.IsMarried)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void AddActivePlayers(List<string> players)
        {
            foreach (string player in players)
            {
                Player playerObj = new Player
                {
                    Name = player,
                    HasCard = false,
                    MaxHandSize = 10
                };

                Players.Add(playerObj);
            }

        }
    }
}
