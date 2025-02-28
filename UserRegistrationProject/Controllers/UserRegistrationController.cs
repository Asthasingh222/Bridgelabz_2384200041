using BusinessLayer_.Service;
using Microsoft.AspNetCore.Mvc;

namespace UserRegistrationProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        private readonly UserRegistrationBL _userRegistrationBL;

        //  Inject UserRegistrationBL via Dependency Injection
        public UserRegistrationController(UserRegistrationBL userRegistrationBL)
        {
            _userRegistrationBL = userRegistrationBL;
        }

        [HttpGet]
        public string Get()
        {
            string username = "root";
            string password = "root";

            string result = _userRegistrationBL.Registration(username, password);

            return result; //  Return proper HTTP response
        }
    }
}
