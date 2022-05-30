using FinanceApp.Domain.Models;

namespace FinanceApp.Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public Task<List<UserModel>> GetCompleteUser();
    }
}
