using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;

namespace RepositoryLayer.Interface
{
    public interface IReviewRL
    {
        Task<EmployeeDTO> RegisterEmployee(EmployeeDTO empDTO);
        Task<EmployeeDTO> UpdateEmployeeRL(int id, EmployeeDTO empDTO);
    }
}
