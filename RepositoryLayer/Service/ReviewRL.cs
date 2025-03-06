using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using StackExchange.Redis;
using ModelLayer.DTO;
using RepositoryLayer.Interface;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;


namespace RepositoryLayer.Service
{
    public class ReviewRL : IReviewRL
    {
        private readonly ReviewContext _dbContext;
        private readonly IDatabase _redisDatabase;

        public ReviewRL(ReviewContext dbContext, IConnectionMultiplexer redis)
        {
            _dbContext = dbContext;
            _redisDatabase = redis.GetDatabase();
        }

        public async Task<EmployeeDTO> RegisterEmployee(EmployeeDTO newUser)
        {
            var existingEmployee = await _dbContext.Employees.FirstOrDefaultAsync(e => e.Email == newUser.Email);
            if (existingEmployee != null)
            {
                return new EmployeeDTO
                {
                    Id = existingEmployee.Id,
                    Name = existingEmployee.Name,
                    Department = existingEmployee.Department,
                    Email = existingEmployee.Email
                };
            }

            var empEntity = new EmployeeEntity
            {
                Name = newUser.Name,
                Email = newUser.Email,
                Department = newUser.Department
            };

            _dbContext.Employees.Add(empEntity);
            await _dbContext.SaveChangesAsync();

            var createdEmployee = new EmployeeDTO
            {
                Id = empEntity.Id,
                Name = empEntity.Name,
                Email = empEntity.Email,
                Department = empEntity.Department
            };

            // Store in Redis Cache
            await _redisDatabase.StringSetAsync($"employee:{createdEmployee.Id}", JsonConvert.SerializeObject(createdEmployee));

            return createdEmployee;
        }

        public async Task<EmployeeDTO> UpdateEmployeeRL(int id, EmployeeDTO empDTO)
        {
            var employee = await _dbContext.Employees.FirstOrDefaultAsync(e => e.Id == id);
            if (employee == null)
                return null;

            // Update only Name and Department (Not Email)
            employee.Name = empDTO.Name;
            employee.Department = empDTO.Department;

            _dbContext.Employees.Update(employee);
            await _dbContext.SaveChangesAsync();

            var updatedEmployee = new EmployeeDTO
            {
                Id = employee.Id,
                Name = employee.Name,
                Email = employee.Email,
                Department = employee.Department
            };

            // Update in Redis Cache
            await _redisDatabase.StringSetAsync($"employee:{id}", JsonConvert.SerializeObject(updatedEmployee));

            return updatedEmployee;
        }
    }
}
