using AutoMapper;
using FinanceApp.Data.Repositories.Interfaces;
using FinanceApp.Domain.DTOs.Tag;
using FinanceApp.Domain.Models;
using FinanceApp.Services.Tag.Interfaces;

namespace FinanceApp.Services.Implementations
{
    public class PostTagService : IPostTagService
    {
        private ITagRepository _tagRepository { get; set; }
        private IMapper _mapper { get; set; }
        public PostTagService(ITagRepository tagRepository, IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }

        public async Task PostTag(PostTagDTO tag)
        {
            await _tagRepository.CreateTag(_mapper.Map<PostTagDTO, TagModel>(tag));
        }
    }
}
