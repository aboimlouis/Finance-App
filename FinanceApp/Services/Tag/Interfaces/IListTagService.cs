using FinanceApp.Domain.DTOs.Tag;

namespace FinanceApp.Services.Tag.Interfaces
{
    public interface IListTagService
    {
        public Task<List<TagDTO>> ListTag();
    }
}
