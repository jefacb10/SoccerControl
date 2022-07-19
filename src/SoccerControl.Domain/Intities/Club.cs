namespace SoccerControl.Domain.Intities
{
    public class Club
    {
        public int ClubId { get; set; }
        public string? ClubName { get; set; }

        public string? Localization { get; set; }

        public Club(int clubId, string clubName, string localization)
        {
            ClubId = clubId;
            ClubName = clubName;
            Localization = localization;
        }


    }
}
