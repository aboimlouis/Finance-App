using AutoMapper;
using FinanceApp.Data.Repositories.Interfaces;
using FinanceApp.Domain.DTOs.Group;
using FinanceApp.Domain.DTOs.User.Responses;
using FinanceApp.Domain.Models;
using FinanceApp.Services.Group.Interfaces;

namespace FinanceApp.Services.Implementations
{
    public class ListGroupService : IListGroupService
    {
        private IGroupRepository _groupRepository { get; set; }
        private IMapper _mapper { get; set; }
        public ListGroupService(IGroupRepository groupRepository, IMapper mapper)
        {
            _groupRepository = groupRepository;
            _mapper = mapper;
        }

        public async Task<List<GroupDTO>> ListGroup()
        {
            return _mapper.Map<List<GroupModel>, List<GroupDTO>>(await _groupRepository.ListGroups());
        }
    }
}
