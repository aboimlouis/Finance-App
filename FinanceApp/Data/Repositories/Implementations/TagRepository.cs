using FinanceApp.Data.Repositories.Interfaces;
using FinanceApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Data.Repositories.Implementations
{
    public class TagRepository : ITagRepository
    {
        private Context _context { get; set; }
        public TagRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<TagModel>> ListTags()
        {
            return
                await
                _context.Tag
                .Where(l => l.UserId == 0)
                .ToListAsync();
        }

        public async Task CreateTag(TagModel group)
        {
            await _context.AddAsync(group);
            await _context.SaveChangesAsync();
        }
    }
}
