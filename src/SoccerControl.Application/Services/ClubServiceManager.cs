using SoccerControl.Domain.Adapters;
using SoccerControl.Domain.Intities;
using SoccerControl.Domain.Services;

namespace SoccerControl.Application.Services
{
    public class ClubServiceManager : IClubService
    {
        private readonly IEmailAdapter _emailAdapter;
        private readonly IClubRepository _clubRepository;

        public ClubServiceManager(
            IEmailAdapter emailAdapter, 
            IClubRepository clubRepository
            )
        {
            _emailAdapter = emailAdapter;
            _clubRepository = clubRepository;
        }

        public async Task<IEnumerable<Club>> RecoverAllClubs()
        {
            var clubs = await _clubRepository.GetAll();
            return clubs;
        }

        public async Task<int> RegisterAClub(Club club)
        {
            var id = await _clubRepository.Insert(club);
            _= _emailAdapter.SendEmail("","","","");
            return id;
        }
    }
}
