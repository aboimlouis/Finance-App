using FinanceApp.Domain.DTOs.Group;

namespace FinanceApp.Services.Group.Interfaces
{
    public interface IPostGroupService
    {
        public Task PostGroup(PostGroupDTO group);
    }
}
