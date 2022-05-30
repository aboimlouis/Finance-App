using AutoMapper;
using FinanceApp.Domain.DTOs.User.Responses;
using FinanceApp.Domain.Models;

namespace FinanceApp.Domain.Profiles.User
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserModel, CompleteUserDTO>();
        }
    }
}
