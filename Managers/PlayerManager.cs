using OneMoreDate.Models;

namespace OneMoreDate.Managers
{
    public static class PlayerManager
    {
        public static List<Player> Players { get; set; } = new();
   
        public static int PlayerCount { get; set; }

      

  

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

        public static void ClearAllPlayerHands()
        {
            for(int i = 0; i<Players.Count; i++)
            {
                if (Players[i].Hand.Count > 0)
                {
                    Players[i].Hand.Clear();
                }
            }
        }
    }
}
