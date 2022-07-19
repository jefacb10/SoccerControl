using SoccerControl.Domain.Intities;

namespace SoccerControl.Domain.Adapters
{
    public interface IClubRepository
    {
        Task<IEnumerable<Club>> GetAll();

        Task<int> Insert(Club club);
    }
}
