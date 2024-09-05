namespace clashclash.Models
{
    public class CardModel
    {
        public string Name { get; set; } = string.Empty;
        public int Id { get; set; } = 0;
        public int maxlevel { get; set; } = 0;
        public int maxevolutionlevel { get; set; } = 0;
        public int elixircost{ get; set; } = 0;
        public string Medium { get; set; } = string.Empty;
        public string Rarity { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string LaunchDate { get; set; } = string.Empty;
    }
}
