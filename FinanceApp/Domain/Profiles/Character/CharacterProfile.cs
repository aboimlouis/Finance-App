using AutoMapper;
using FinanceApp.Domain.DTOs.Character.Responses;
using FinanceApp.Domain.Models;

namespace FinanceApp.Domain.Profiles.Character
{
    public class CharacterProfile : Profile
    {
        public CharacterProfile()
        {
            CreateMap<CharacterModel, CharacterDTO>().ForMember(x => x.UserName, d => d.MapFrom(z => z.User.Name));
        }
    }
}
