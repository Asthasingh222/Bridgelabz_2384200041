using BusinessLayer.Interface;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTO;
using System.Threading.Tasks;

namespace Review.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewBL reviewBL;

        public ReviewController(IReviewBL review)
        {
            reviewBL = review;
        }

        /// <summary>
        /// Post method to Register User
        /// </summary>
        [HttpPost("register")]
        public async Task<IActionResult> RegisterEmployee([FromBody] EmployeeDTO employeeDTO)
        {
            var result = await reviewBL.RegistrationBL(employeeDTO);
            return Created("User Created", new ResponseModel<EmployeeDTO>
            {
                Success = true,
                Message = "Registration Successful",
                data = result
            });
        }

        /// <summary>
        /// Patch method to update employee details (excluding email)
        /// </summary>
        [HttpPatch("update/{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, [FromBody] EmployeeDTO empModel)
        {
            var result = await reviewBL.UpdateEmployeeBL(id, empModel);
            if (result == null)
            {
                return NotFound(new ResponseModel<string>
                {
                    Success = false,
                    Message = "Employee not found",
                    data = ""
                });
            }

            return Ok(new ResponseModel<EmployeeDTO>
            {
                Success = true,
                Message = "Employee details updated successfully",
                data = result
            });
        }
    }
}
