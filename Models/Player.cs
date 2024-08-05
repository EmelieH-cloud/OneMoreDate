namespace OneMoreDate.Models
{
    public class Player
    {
        public string Name { get; set; }
        public List<PlayerCard> Hand { get; set; } = new();
        public bool HasCard { get; set; }


        public bool IsTurn { get; set; }
    }

}
