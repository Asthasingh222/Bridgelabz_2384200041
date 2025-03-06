using BusinessLayer.Interface;
using ModelLayer.DTO;
using RepositoryLayer.Interface;

public class ReviewBL : IReviewBL
{
    private readonly IReviewRL reviewRL;

    public ReviewBL(IReviewRL reviewRL)
    {
        this.reviewRL = reviewRL;
    }

    public async Task<EmployeeDTO> RegistrationBL(EmployeeDTO empDTO)
    {
        return await reviewRL.RegisterEmployee(empDTO);
    }

    public async Task<EmployeeDTO> UpdateEmployeeBL(int id, EmployeeDTO empDTO)
    {
        return await reviewRL.UpdateEmployeeRL(id, empDTO);
    }
}
