using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;

namespace BusinessLayer.Interface
{
    public interface IReviewBL
    {
       Task<EmployeeDTO> RegistrationBL(EmployeeDTO registerDTO);
      
       Task<EmployeeDTO> UpdateEmployeeBL(int id, EmployeeDTO empDTO); // New method 

    }
}
