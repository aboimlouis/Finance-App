using AutoMapper;
using FinanceApp.Data.Repositories.Interfaces;
using FinanceApp.Domain.DTOs.Tag;
using FinanceApp.Domain.Models;
using FinanceApp.Services.Tag.Interfaces;

namespace FinanceApp.Services.Tag.Implementations
{
    public class ListTagService : IListTagService
    {
        private ITagRepository _TagRepository { get; set; }
        private IMapper _mapper { get; set; }
        public ListTagService(ITagRepository TagRepository, IMapper mapper)
        {
            _TagRepository = TagRepository;
            _mapper = mapper;
        }

        public async Task<List<TagDTO>> ListTag()
        {
            return _mapper.Map<List<TagModel>, List<TagDTO>>(await _TagRepository.ListTags());
        }
    }
}
