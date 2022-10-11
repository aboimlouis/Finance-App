using AutoMapper;
using FinanceApp.Domain.DTOs.Tag;
using FinanceApp.Domain.Models;

namespace FinanceApp.Domain.Profiles.Tag
{
    public class TagProfile : Profile
    {
        public TagProfile()
        {
            CreateMap<TagModel, TagDTO>();
            CreateMap<PostTagDTO, TagModel>();
        }
    }
}
