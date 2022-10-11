using FinanceApp.Domain.Models;

namespace FinanceApp.Data.Repositories.Interfaces
{
    public interface ITagRepository
    {
        public Task<List<TagModel>> ListTags();
        public Task CreateTag(TagModel group);
    }
}
