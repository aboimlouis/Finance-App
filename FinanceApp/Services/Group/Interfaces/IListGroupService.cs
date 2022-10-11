using FinanceApp.Domain.DTOs.Group;

namespace FinanceApp.Services.Group.Interfaces
{
    public interface IListGroupService
    {
        public Task<List<GroupDTO>> ListGroup();
    }
}
