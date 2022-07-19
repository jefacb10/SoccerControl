using Microsoft.AspNetCore.Mvc;
using SoccerControl.Domain.Intities;
using SoccerControl.Domain.Services;

namespace SoccerControl.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClubController : ControllerBase
    {
        
        private readonly ILogger<ClubController> _logger;
        private readonly IClubService _clubService;

        public ClubController(
            ILogger<ClubController> logger,
            IClubService clubService)
        {
            _logger = logger;
            _clubService = clubService;
        }

        [HttpGet]
        public async Task<IActionResult> RecoverAll()
        {
            var clubs = await _clubService.RecoverAllClubs();
            return Ok(clubs);
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] Club club)
        {
            var id = await _clubService.RegisterAClub(club);
            return Ok(id);
        }
    }
}