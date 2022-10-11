using FinanceApp.Domain.Models;

namespace FinanceApp.Data.Repositories.Interfaces
{
    public interface IGroupRepository
    {
        public Task<List<GroupModel>> ListGroups();
        public Task CreateGroup(GroupModel group);
    }
}
