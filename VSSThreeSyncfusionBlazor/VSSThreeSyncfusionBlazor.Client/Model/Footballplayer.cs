namespace VSSThreeSyncfusionBlazor.Client.Model
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? NickName { get; set; }
        public string? Team { get; set; }
        public int Age { get; set; }
        public bool IsInjured { get; set; }
    }
}
