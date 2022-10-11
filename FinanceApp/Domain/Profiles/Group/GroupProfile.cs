using AutoMapper;
using FinanceApp.Domain.DTOs.Group;
using FinanceApp.Domain.Models;

namespace FinanceApp.Domain.Profiles.Group
{
    public class GroupProfile : Profile
    {
        public GroupProfile()
        {
            CreateMap<GroupModel, GroupDTO>();
            CreateMap<PostGroupDTO, GroupModel>();
        }
    }
}
