using FinanceApp.Domain.DTOs.Tag;

namespace FinanceApp.Services.Tag.Interfaces
{
    public interface IPostTagService
    {
        public Task PostTag(PostTagDTO group);
    }
}
