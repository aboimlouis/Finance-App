using AutoMapper;
using FinanceApp.Data.Repositories.Interfaces;
using FinanceApp.Domain.DTOs.Group;
using FinanceApp.Domain.Models;
using FinanceApp.Services.Group.Interfaces;

namespace FinanceApp.Services.Implementations
{
    public class PostGroupService : IPostGroupService
    {
        private IGroupRepository _groupRepository { get; set; }
        private IMapper _mapper { get; set; }
        public PostGroupService(IGroupRepository groupRepository, IMapper mapper)
        {
            _groupRepository = groupRepository;
            _mapper = mapper;
        }

        public async Task PostGroup(PostGroupDTO group)
        {
            await _groupRepository.CreateGroup(_mapper.Map<PostGroupDTO, GroupModel>(group));
        }
    }
}
