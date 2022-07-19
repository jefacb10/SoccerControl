using SoccerControl.Domain.Adapters;
using SoccerControl.Domain.Intities;

namespace SoccerControl.Infra.DataBase.InMemory.Repositories
{
    internal class ClubRepository : IClubRepository
    {
        public List<Club> Clubs { get; set; } = new List<Club>();
        public async Task<IEnumerable<Club>> GetAll()
        {
            
            var corinthians = new Club(1, "Corinthians", "SP");
            var saoPaulo = new Club(2, "São Paulo", "SP");
            var palmeiras = new Club(3, "Palmeiras", "SP");

            Clubs.Add(corinthians);
            Clubs.Add(saoPaulo);
            Clubs.Add(palmeiras);

            return Clubs.AsEnumerable();

        }

        public async Task<int> Insert(Club club)
        {
            var id = club.ClubId;
            Clubs.Add(club);

            return id;
        }
    }
}
