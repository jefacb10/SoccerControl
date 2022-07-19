using SoccerControl.Domain.Intities;

namespace SoccerControl.Domain.Services
{
    public interface IClubService
    {
        Task<IEnumerable<Club>> RecoverAllClubs();

        Task<int> RegisterAClub(Club club);
    }
}
