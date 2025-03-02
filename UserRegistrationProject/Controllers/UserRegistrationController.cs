using BusinessLayer_.Service;
using Microsoft.AspNetCore.Mvc;
using Model_Layer.DTO;

namespace UserRegistrationProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        private readonly UserRegistrationBL _userRegistrationBL;
        private readonly ILogger<UserRegistrationController> _logger;
       
        //  Inject UserRegistrationBL via Dependency Injection
        public UserRegistrationController(UserRegistrationBL userRegistrationBL,ILogger<UserRegistrationController> logger)
        {
            _userRegistrationBL = userRegistrationBL;
            _logger = logger;

        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                _logger.LogInformation("Get API Called");
                return Ok("User Registration API");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Get API");
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpPost]
        public IActionResult RegisterUser([FromBody]RegisterUserDTO registerUserDTO)
        {
            var response = new ResponseModel<string>();
            try
            {
                _logger.LogInformation("RegisterUser API Called for User: {UserName}", registerUserDTO.UserName);
                response.success = true;
                response.message = _userRegistrationBL.RegisterUser(registerUserDTO); ;
                response.data = registerUserDTO.UserName;
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in RegistrationUser API");
                response.success = false;
                response.message = "An error occurred while processing your request.";
                return StatusCode(500, response);
            }
        }
    }
}
