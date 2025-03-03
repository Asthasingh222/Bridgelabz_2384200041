using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Service;
using ModelLayer.DTO;
using BusinessLayer.Interface;
using Microsoft.Extensions.Logging;
using NLog;
namespace HelloApp.Controllers
{
    [ApiController]
    [Route("[controller]")] // Address provider
    public class HelloAppController : ControllerBase
    {
        private readonly IRegisterHelloBL registerHelloBL;
        private readonly ILogger<HelloAppController> logger;
        private ResponseModel<string> response;

        public HelloAppController(IRegisterHelloBL registerHelloBL, ILogger<HelloAppController> logger)
        {
            this.registerHelloBL = registerHelloBL;
            this.logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            logger.LogInformation("Executing Get method");
            return registerHelloBL.Registration("Value from Controller");
        }

        [HttpPost]
        public IActionResult LoginUser(LoginDTO loginDTO)
        {
            response = new ResponseModel<string>();

            try
            {
                logger.LogInformation("User login attempt with email: {email}", loginDTO.Email);

                bool result = registerHelloBL.LoginUser(loginDTO);
                if (result)
                {
                    logger.LogInformation("Login successful for email: {email}", loginDTO.Email);
                    response.Success = true;
                    response.Message = "Login successful";
                    response.data = loginDTO.Username;
                    return Ok(response);
                }

                logger.LogWarning("Login failed: Invalid email or password for email: {email}", loginDTO.Email);
                response.Success = false;
                response.Message = "Invalid email or password";
                return Unauthorized(response);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error during login for email: {email}", loginDTO.Email);
                return BadRequest(new { Success = false, Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("register")]
        public IActionResult RegisterUser(RegisterDTO registerDTO)
        {
            try
            {
                logger.LogInformation("User registration attempt with email: {email}", registerDTO.Email);

                var result = registerHelloBL.RegistrationBL(registerDTO);
                response = new ResponseModel<string>
                {
                    Success = true,
                    Message = "Registration Successful",
                    data = ""
                };

                logger.LogInformation("User registered successfully with email: {email}", registerDTO.Email);
                return Created("User Created", result);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error during user registration for email: {email}", registerDTO.Email);
                return BadRequest(new { Success = false, Message = ex.Message });
            }
        }
    }
}
