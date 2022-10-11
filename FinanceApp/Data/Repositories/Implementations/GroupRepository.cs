using FinanceApp.Data;
using FinanceApp.Data.Repositories.Interfaces;
using FinanceApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Data.Repositories.Implementations
{
    public class GroupRepository : IGroupRepository
    {
        private Context _context { get; set; }
        public GroupRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<GroupModel>> ListGroups()
        {
            return 
                await 
                _context.Group
                .Where(l => l.UserId == 0)
                .ToListAsync();
        }

        public async Task CreateGroup(GroupModel group)
        {
            await _context.AddAsync(group);
            await _context.SaveChangesAsync();
        }
    }
}
