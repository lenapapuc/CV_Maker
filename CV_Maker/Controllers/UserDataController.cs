using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain;
using CV_Maker.Services.Interfaces;
using CV_Maker.Services.ServiceClasses;
using DtoLibrary;

namespace CV_Maker.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserDataController : ControllerBase
    {
        private readonly ILogger<UserDataController> _logger;
        private readonly IUserDataService _userDataService;

        public UserDataController(ILogger<UserDataController> logger, IUserDataService userDataService)
        {
            _logger = logger;
            _userDataService = userDataService;

        }

        [HttpPost]
        public async Task<IActionResult> AddUserData([FromBody] UserCreationDto user)
        {
            await _userDataService.AddUserAsync(user);
            return Ok();

        }
    }
}
