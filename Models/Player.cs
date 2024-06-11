namespace OneMoreDate.Models
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; } = new();
        public bool HasCard { get; set; }
        public int MaxHandSize { get; set; }
        public bool LivesTogether { get; set; } = false;
        public bool IsMarried { get; set; } = false;
        public bool IsTurn { get; set; }
    }

}
