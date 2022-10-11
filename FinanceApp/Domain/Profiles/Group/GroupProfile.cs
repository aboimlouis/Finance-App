using AutoMapper;
using FinanceApp.Domain.DTOs.Group;
using FinanceApp.Domain.DTOs.User.Responses;
using FinanceApp.Domain.Models;

namespace FinanceApp.Domain.Profiles.User
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
