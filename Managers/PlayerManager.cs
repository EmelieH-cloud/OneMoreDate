using OneMoreDate.Models;

namespace OneMoreDate.Managers
{
    public static class PlayerManager
    {
        public static List<Player> Players { get; set; } = new();
        public static Player ActivePlayer { get; set; } = new Player();
        public static int PlayerCount { get; set; }

        private static bool CheckMarriageStatus(int index)
        {
            Player potentiallyMarriedPlayer = Players[index];
            return potentiallyMarriedPlayer.IsMarried;
        }

        public static void SetActivePlayer(Player player)
        {
            ActivePlayer = player;
        }

        public static Player GetActivePlayer()
        {
            return ActivePlayer ?? new Player();
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

            PlayerCount = Players.Count;
        }
    }
}
