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
        ResponseModel<string> response;

        //  Inject UserRegistrationBL via Dependency Injection
        public UserRegistrationController(UserRegistrationBL userRegistrationBL)
        {
            _userRegistrationBL = userRegistrationBL;
        }

        [HttpGet]
        public string Get()
        {
           
            return "User Registration API"; //  Return proper HTTP response
        }
        [HttpPost]
        public IActionResult RegisterUser(RegisterUserDTO registerUserDTO)
        {
            try
            {
                var response = new ResponseModel<string>();
                string msg = _userRegistrationBL.RegisterUser(registerUserDTO);
                response.success = true;
                response.message = msg;
                response.data = registerUserDTO.UserName;
                return Ok(response);
            }
            catch (Exception ex)
            {
                response = new ResponseModel<string>();
                response.success = false;
                response.message = ex.Message;
                return BadRequest(response);
            }
        }
    }
}
