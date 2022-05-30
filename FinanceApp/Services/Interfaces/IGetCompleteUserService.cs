using FinanceApp.Domain.DTOs.User.Responses;

namespace FinanceApp.Services.Interfaces
{
    public interface IGetCompleteUserService
    {
        public Task<List<CompleteUserDTO>> GetCompleteUser();
    }
}
